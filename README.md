# personal-website

The personal site of João Silvestre: ASP.NET Core 10 Razor Pages, Tailwind CSS, English and Portuguese, and no third-party requests.

Version 2.0.0.

## Requirements

- .NET 10 SDK (see `global.json`)
- Node 20+

## Build and run

```
cd src/Silvestre.App.Web
npm ci
npm run build:css
dotnet run -c Release --urls http://localhost:5080
```

## Tests and CI

```
dotnet build Silvestre.sln -c Release
```

The `pr-check` workflow builds the production image and runs a smoke test against the running site on every pull request.

## Content

Everything the site says lives in `src/Silvestre.App.Web/Content/`: `{en,pt}/site.json` and `{en,pt}/ai.md` per language, plus the shared `stack.json` and `writing/` posts.

## Docker

The container setup is in `build/docker`. The published image is `ghcr.io/paletas/personal-website`.
