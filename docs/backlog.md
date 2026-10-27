# Forge Backlog

Everything Forge should do one day, grouped by module.
Learning weeks pull items from here. Status: 💡 idea · 📋 planned · 🔨 in progress · ✅ done

---

## Content – website & channels
| Status | Feature |
|---|---|
| 📋 | Detect new YouTube episodes and add them to `kampagne.json` on the website (via pull request) |
| 📋 | Twitch live status → "We're live" banner on dwarfmasters.de |
| 💡 | Weekly website health check: outdated events, stale texts (e.g. "Fotos folgen in Kürze"), missing photo folders, broken links → opens a fix PR |
| 💡 | Keep channel profiles consistent (name spelling "Dwarfmasters", About texts, links) – checklist report |

## Events
| Status | Feature |
|---|---|
| 📋 | Events database (replaces hand-edited `events.json` long term) |
| 📋 | **Ticket waitlist**: collect emails, notify everyone when ticket sales start |
| 💡 | GM planning: who leads which table, availability, reminders |
| 💡 | Google event markup (JSON-LD) generated automatically for every event |

## Social
| Status | Feature |
|---|---|
| 📋 | AI drafts Instagram captions for new events and episodes, in Deniz' style |
| 📋 | AI drafts GM intros in the fixed reel format |
| 💡 | Episode recaps from transcripts |
| 💡 | Weekly content plan suggestion |

## Clips – AI video pipeline
Goal: one stream recording in, ready-to-post short clips out. Replaces OpusClip long term.

| Status | Step |
|---|---|
| 💡 | Watch folder for new OBS recordings (or a VOD link) |
| 💡 | Extract audio with ffmpeg |
| 💡 | Transcribe with timestamps via **Groq Whisper** API |
| 💡 | AI picks the best moments by **story**, not volume (knows the heroes, running jokes, dramatic rolls) – avoids spoilers and moments players wouldn't want online |
| 💡 | Cut with ffmpeg: clean start/end points, merge setup + punchline, 9:16 vertical crop |
| 💡 | Burn in captions with correct names (Lunara, Gunther, Lindo Laut, …) |
| 💡 | Thumbnail/cover via **Canva** template autofill (title + still frame) |
| 💡 | Hook + caption per clip for Shorts, Reels and TikTok |
| 💡 | Approval step: "5 clips ready" → Deniz reviews → approve |
| 💡 | Publish/schedule (via OpusClip scheduler first; official platform APIs later – they require app verification for public posts) |

Interim until this exists: OpusClip for rough cuts + Claude fixes cut points and captions.

## Automation – the agent
| Status | Feature |
|---|---|
| 📋 | Scheduled background jobs (`BackgroundService`) |
| 💡 | AI agent with tool use: tools for events, content, inbox, clips – decides which to use |
| 💡 | Monday briefing: what's coming up this week (events, deadlines, Forge week) |
| 💡 | Notifications to Deniz when something needs approval |

Rule: **the agent prepares, a human approves.** No auto-posting, no auto-replies to customers, no money.

## Inbox
| Status | Feature |
|---|---|
| 💡 | Email overview across Dwarfmasters addresses |
| 💡 | AI sorts requests (GM applications, creator collabs, publisher/B2B, ticket questions) |
| 💡 | Reply drafts – sent only after approval |

## Campaign – Der Splitter des Ewigen
| Status | Feature |
|---|---|
| 💡 | Sessions, NPCs, locations, lore and heroes stored in one place |
| 💡 | Session prep and recap helper |
| 💡 | Sync with the Fandom wiki and the website |
| 💡 | Twitch channel point interactions logged into the story |

## Brand & design
| Status | Feature |
|---|---|
| 💡 | Canva integration: templates for event posters, GM intros, episode covers – autofilled |
| 💡 | One brand kit (colors, fonts, logo) used by all generated graphics |

## Finance
| Status | Feature |
|---|---|
| 💡 | Income/expense overview pulled from an accounting tool API (lexoffice/sevDesk) – **no own bookkeeping** (GoBD) |
| 💡 | Per-event profit report (tickets vs. venue, catering, insurance) |
| 💡 | Data prep for EÜR / tax advisor |

## Dashboard
| Status | Feature |
|---|---|
| 💡 | Blazor dashboard: approvals, upcoming events, clip queue, inbox, numbers |
