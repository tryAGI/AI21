#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

# OpenAPI spec: https://api.ai21.com/openapi.json
install_autosdk_cli
rm -rf Generated
fetch_spec --fail --silent --show-error -L -o openapi.json https://api.ai21.com/openapi.json

autosdk generate openapi.json \
  --namespace AI21 \
  --clientClassName Ai21Client \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --base-url https://api.ai21.com/ \
  --security-scheme Http:Header:Bearer \
  --openapi-override '#/components/schemas/HTTPToolFunctionParameters/properties/additionalProperties=remove'

rm -rf ../../cli/AI21.CLI

autosdk cli-project openapi.json \
  --output ../../cli/AI21.CLI \
  --sdk-project ../../libs/AI21/AI21.csproj \
  --targetFramework net10.0 \
  --namespace AI21 \
  --clientClassName Ai21Client \
  --package-id AI21.CLI \
  --tool-command-name ai21 \
  --user-secrets-id AI21.CLI \
  --api-key-env-var AI21_API_KEY \
  --base-url-env-var AI21_BASE_URL \
  --cli-credential-file \
  --cli-keep-api-group \
  --exclude-deprecated-operations \
  --base-url https://api.ai21.com/ \
  --security-scheme Http:Header:Bearer
