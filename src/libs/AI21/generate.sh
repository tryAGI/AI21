dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://api.ai21.com/openapi.json
if ! command -v jq >/dev/null 2>&1; then
  echo "jq is required to patch the downloaded OpenAPI spec." >&2
  exit 1
fi

tmp_openapi="$(mktemp)"
jq '
  walk(
    if type == "object" and .name? == "request_start_time" and (.schema? | type == "object") then
      .schema.default = "1730898900272"
    else
      .
    end
  )
  | del(.components.schemas.HTTPToolFunctionParameters.properties.additionalProperties)
  | if .components.schemas.HTTPToolFunctionParameters.required? then
      .components.schemas.HTTPToolFunctionParameters.required |= map(select(. != "additionalProperties"))
    else
      .
    end
' openapi.yaml > "$tmp_openapi" && mv "$tmp_openapi" openapi.yaml

autosdk generate openapi.yaml \
  --namespace AI21 \
  --clientClassName Ai21Client \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --base-url https://api.ai21.com/ \
  --security-scheme Http:Header:Bearer
