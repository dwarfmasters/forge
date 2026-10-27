# ⚒️ Dwarfmasters Forge

The internal platform that runs the boring parts of [Dwarfmasters](https://dwarfmasters.de), so we can spend our time at the table instead of in spreadsheets.

Forge is also a **learning project**: every feature is built to master one core skill of modern .NET development.

## Architecture

Forge is a **modular monolith**: one deployable application, split into clearly separated modules.
No microservices – for a two-person company they would add complexity without benefit.

```
src/
  Forge.Host/            ASP.NET Core host – wires all modules together
  Modules/
    Forge.Content/       YouTube, Twitch, website updates
    Forge.Events/        (planned) events, ticket waitlist, GM planning
    Forge.Social/        (planned) AI drafts for Instagram, GM intros, recaps
    Forge.Campaign/      (planned) sessions, NPCs, lore, heroes, wiki sync
    Forge.Inbox/         (planned) email overview, AI triage and reply drafts
    Forge.Finance/       (planned) income/expense overview via accounting tool API
tests/
  Forge.Tests/
docs/
  learning/              One file per learning week
```

Each module owns its own code and data. Modules talk to each other only through public interfaces.

## Roadmap

### Phase 1 – Foundation (Nov – Dec 2026)

| Week | Skill | Feature |
|---|---|---|
| 1 | async/await | Fetch latest YouTube videos and Twitch live status |
| 2 | Dependency Injection & interfaces | Clean service structure, first Web API endpoints |
| 3 | Unit testing & mocking | Tests for everything, external services mocked |
| 4 | Git & CI | Feature branches, pull requests, CI runs tests on every push |
| 5 | SQL | Database for events and the ticket waitlist |
| 6 | System design | Design doc: ticket launch with 2,000 concurrent buyers |
| 7–8 | AI integration | AI drafts Instagram posts, GM intros and episode recaps |
| 9 | Deployment | Forge runs in the cloud and updates the website automatically |

### Phase 2 – Expansion (Jan – Mar 2027)
Campaign and Inbox modules.

### Phase 3 – Later
Finance (via lexoffice/sevDesk API – we do **not** build our own bookkeeping) and a Blazor dashboard.

## Learning rules

1. **Core logic is written by hand first, without AI.** AI may help afterwards – and its output gets reviewed critically.
2. Every week ends with a code review and a short quiz.
3. A week is done when its acceptance criteria in `docs/learning/` are met.

## Branches

| Branch | Purpose |
|---|---|
| `main` | Production. Always the latest working version. |
| `develop` | Integration branch for the next version. Feature branches start here. |
| `feature/<name>` | One branch per task, e.g. `feature/week-01-youtube-feed`. |

Flow: branch from `develop` → commit → pull request into `develop` → CI must be green → merge. Release: pull request `develop` → `main`.

Never commit directly to `main`.

## Getting started

Requires the [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0).

```bash
git clone https://github.com/dwarfmasters/forge.git
cd forge
dotnet build
dotnet test
dotnet run --project src/Forge.Host
```

Then open http://localhost:5080/health – you should see `Forge is burning 🔥`.
