#!/bin/bash
# install node
# install openjdk
npx @openapitools/openapi-generator-cli generate -g csharp --additional-properties=library=unityWebRequest -i ../sol-general-api/sol/openapi.yaml -o ./Assets/Autogenerated/GeneralApi
