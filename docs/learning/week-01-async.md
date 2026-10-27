# Week 1 – async/await

**Goal:** Forge fetches the latest videos from the Dwarfmasters YouTube channel – and you understand *exactly* what happens while it waits.

**Branch:** `feature/week-01-youtube-feed` (from `develop`)

---

## 1. Concepts – read first

Read these, then explain each point in your own words (2–3 sentences) in the pull request description:

1. **What is a `Task`?** What's the difference between `Task` and `Task<T>`?
2. **What does `await` actually do?** Why does it *not* block the thread?
3. **Why is `.Result` / `.Wait()` dangerous?**
4. **"Async all the way"** – why should async spread up the call chain?
5. **`CancellationToken`** – what is it for, and who cancels?
6. **Sequential vs. parallel:** what's the difference between `await a; await b;` and `await Task.WhenAll(a, b);`?
7. **Why avoid `async void`?**

Resources:
- [Asynchronous programming with async and await](https://learn.microsoft.com/dotnet/csharp/asynchronous-programming/)
- [Task asynchronous programming model](https://learn.microsoft.com/dotnet/csharp/asynchronous-programming/task-asynchronous-programming-model)

---

## 2. The task

> ⚠️ **No AI for steps 1–3.** Docs and Stack Overflow are fine. Struggling is part of the training.

### Step 1 – Find the channel ID
YouTube offers a free RSS feed per channel, no API key needed:
`https://www.youtube.com/feeds/videos.xml?channel_id=<CHANNEL_ID>`

Find the channel ID of `@dwarfmasters` (starts with `UC…`). Open the feed URL in your browser and look at the XML.

### Step 2 – Build `YouTubeFeedReader`
In `src/Modules/Forge.Content/`, create a class `YouTubeFeedReader` with:

```csharp
public Task<IReadOnlyList<Video>> GetLatestVideosAsync(int count, CancellationToken cancellationToken);
```

- Use `HttpClient` to download the feed.
- Parse it with `System.Xml.Linq` (`XDocument`).
- Map each `<entry>` to the existing `Video` record.
- For now, just create the `HttpClient` and hardcode the channel ID. It will feel wrong – good. We fix it properly in week 2.

<details>
<summary>Hint (only if stuck > 30 min)</summary>

The feed uses XML namespaces. You'll need:
- `XNamespace atom = "http://www.w3.org/2005/Atom";`
- `XNamespace yt = "http://www.youtube.com/xml/schemas/2015";` (for `yt:videoId`)
</details>

### Step 3 – Endpoint
In `Program.cs`, add `GET /content/videos?count=3` that returns the videos as JSON.
Pass the request's `CancellationToken` all the way down.

### Step 4 – The experiment (AI allowed from here)
Write a small endpoint `GET /content/experiment` that downloads the feed **3 times sequentially**, then **3 times with `Task.WhenAll`**, and returns both durations (use `Stopwatch`).
Write the result and your explanation in the PR description.

### Stretch goal – Twitch live status
Register an app at [dev.twitch.tv](https://dev.twitch.tv/console), get a token via the client-credentials flow, and call the Helix `streams` endpoint to check if `dwarfmastersx` is live.
You'll chain several awaits – and you'll meet your first **secret**. Do **not** commit it (see `.gitignore`).

---

## 3. Done when

- [ ] `GET /content/videos?count=3` returns the 3 newest Dwarfmasters videos
- [ ] Cancellation token is passed from endpoint to `HttpClient`
- [ ] No `.Result`, `.Wait()` or `async void` anywhere
- [ ] Experiment results + explanation in the PR description
- [ ] The 7 concept questions answered in your own words
- [ ] PR into `develop` opened, CI green
- [ ] Code review with Claude done → then the week-1 quiz
