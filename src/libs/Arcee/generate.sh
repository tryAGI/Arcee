#!/usr/bin/env bash
set -euo pipefail

# Hand-maintained OpenAPI spec based on Arcee AI API docs:
# https://docs.arcee.ai/api-reference/chat-completion

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace Arcee \
  --clientClassName ArceeClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
