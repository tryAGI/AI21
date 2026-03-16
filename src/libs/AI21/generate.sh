dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://api.ai21.com/openapi.json

autosdk generate openapi.yaml \
  --namespace AI21 \
  --clientClassName Ai21Client \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --base-url https://api.ai21.com/ \
  --security-scheme Http:Header:Bearer \
  --openapi-override '#/components/schemas/HTTPToolFunctionParameters/properties/additionalProperties=remove'
