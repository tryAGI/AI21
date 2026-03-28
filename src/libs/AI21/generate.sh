#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://api.ai21.com/openapi.json

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -L -o openapi.json https://api.ai21.com/openapi.json

autosdk generate openapi.json \
  --namespace AI21 \
  --clientClassName Ai21Client \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --base-url https://api.ai21.com/ \
  --security-scheme Http:Header:Bearer \
  --openapi-override '#/components/schemas/HTTPToolFunctionParameters/properties/additionalProperties=remove'
