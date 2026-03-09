# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

C# SDK for the [AI21](https://ai21.com/) AI platform, auto-generated from the AI21 OpenAPI specification using [AutoSDK](https://github.com/HavenDV/AutoSDK). Published as a NuGet package under the `AI21` package name.

## Build Commands

```bash
# Build the solution
dotnet build AI21.sln

# Build for release (also produces NuGet package)
dotnet build AI21.sln -c Release

# Run integration tests (requires AI21_API_KEY env var)
dotnet test src/tests/AI21.IntegrationTests/AI21.IntegrationTests.csproj

# Regenerate SDK from OpenAPI spec
cd src/libs/AI21 && ./generate.sh
```

## Architecture

### Code Generation Pipeline

The SDK code is **entirely auto-generated** -- do not manually edit files in `src/libs/AI21/Generated/`.

1. `src/libs/AI21/openapi.yaml` -- the AI21 OpenAPI spec (fetched from `https://api.ai21.com/openapi.json`)
2. `src/helpers/FixOpenApiSpec/` -- converts OpenAPI 3.1 to 3.0 format for compatibility
3. `src/libs/AI21/generate.sh` -- orchestrates: download spec, fix spec, run AutoSDK CLI, output to `Generated/`
4. CI auto-updates the spec and creates PRs if changes are detected

### Project Layout

| Project | Purpose |
|---------|---------|
| `src/libs/AI21/` | Main SDK library (`Ai21Api`) |
| `src/tests/AI21.IntegrationTests/` | Integration tests against real AI21 API |
| `src/helpers/FixOpenApiSpec/` | OpenAPI spec fixer tool |
| `src/helpers/GenerateDocs/` | Documentation generator from integration tests |
| `src/helpers/TrimmingHelper/` | NativeAOT/trimming compatibility validator |

### Build Configuration

- **Target:** `net10.0` (single target)
- **Language:** C# preview with nullable reference types
- **Signing:** Strong-named assemblies via `src/key.snk`
- **Versioning:** Semantic versioning from git tags (`v` prefix) via MinVer
- **Analysis:** All .NET analyzers enabled, AOT/trimming compatibility enforced
- **Testing:** MSTest + FluentAssertions

### Key Conventions

- No hand-written extension files -- the SDK is purely generated code
- The client class is named `Ai21Api`
- The namespace is `AI21`

### CI/CD

- Uses shared workflows from `HavenDV/workflows` repo
- Dependabot updates NuGet packages weekly (auto-merged)
- Documentation deployed to GitHub Pages via MkDocs Material
