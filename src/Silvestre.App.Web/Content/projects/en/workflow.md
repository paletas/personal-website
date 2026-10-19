---
title: "How I build with agents"
tagline: "A written plan, scenarios as the contract, and an independent check."
order: 0
kind: workflow
---

One person, many projects, and a set of agents kept on a short lead by a hub that holds the rules.

## Problem

I run several sizeable projects at once, and I am the only person. Agents can carry a lot of that load, but left alone they drift, repeat each other and touch things they should not. They also forget between sessions. I needed guardrails that live outside any single conversation, so that every session starts from the same rules and every change can be traced and reversed.

## What it does

Work flows through a fixed pipeline: learn, understand, plan, plan in batches, execute, verify. A stronger model does the thinking and writes the plan. A mid-tier model carries it out. Mechanical steps go to free models with very large context, served through a gateway I host myself, and free is always tried first. An independent agent then checks the result against the plan. The same hub runs the toil: scheduled patching, alerts and skills that refresh documentation. Several big projects move in parallel, each in its own space.

## How it's built

<figure class="diagram">
<svg viewBox="0 0 540 90" role="img" aria-label="Phase pipeline with model tiers: strong model plans, mid-tier executes, free models take mechanical steps, independent agent verifies">
<defs><marker id="m1" viewBox="0 0 10 10" refX="8" refY="5" markerWidth="7" markerHeight="7" orient="auto-start-reverse"><path d="M0 0L10 5L0 10z" class="mk"/></marker></defs>
<rect class="b" x="20" y="14" width="110" height="60" rx="10"/><text class="t" text-anchor="middle" x="75.0" y="40.0">Learn</text><text class="ts" text-anchor="middle" x="75.0" y="58.0">strong model</text>
<path class="ln" d="M130 44L150 44" marker-end="url(#m1)"/>
<rect class="b" x="150" y="14" width="110" height="60" rx="10"/><text class="t" text-anchor="middle" x="205.0" y="40.0">Plan</text><text class="ts" text-anchor="middle" x="205.0" y="58.0">strong model</text>
<path class="ln" d="M260 44L280 44" marker-end="url(#m1)"/>
<rect class="b" x="280" y="14" width="110" height="60" rx="10"/><text class="t" text-anchor="middle" x="335.0" y="40.0">Execute</text><text class="ts" text-anchor="middle" x="335.0" y="58.0">mid-tier, free first</text>
<path class="ln" d="M390 44L410 44" marker-end="url(#m1)"/>
<rect class="ba" x="410" y="14" width="110" height="60" rx="10"/><text class="t" text-anchor="middle" x="465.0" y="40.0">Verify</text><text class="ts" text-anchor="middle" x="465.0" y="58.0">independent agent</text>
</svg>
<figcaption>The expensive model plans, cheaper models build, and a separate agent checks</figcaption>
</figure>

The hub is a repository of its own. It holds the standing rules, the skills agents can invoke and a registry of every project. Each task gets a workspace: an isolated copy of the relevant repositories on its own branch, so the main checkouts are never edited directly and work reaches the world only through reviewed pull requests. Progress, plans and evidence for each task are written to files, so a new session picks up exactly where the last one stopped.

<figure class="diagram">
<svg viewBox="0 0 540 90" role="img" aria-label="Hub, workspaces and repositories linked in both directions">
<defs><marker id="m2" viewBox="0 0 10 10" refX="8" refY="5" markerWidth="7" markerHeight="7" orient="auto-start-reverse"><path d="M0 0L10 5L0 10z" class="mk"/></marker></defs>
<rect class="ba" x="20" y="14" width="140" height="60" rx="10"/><text class="t" text-anchor="middle" x="90.0" y="40.0">Hub</text><text class="ts" text-anchor="middle" x="90.0" y="58.0">rules, skills, registry</text>
<rect class="b" x="200" y="14" width="140" height="60" rx="10"/><text class="t" text-anchor="middle" x="270.0" y="40.0">Workspaces</text><text class="ts" text-anchor="middle" x="270.0" y="58.0">one per task</text>
<rect class="b" x="380" y="14" width="140" height="60" rx="10"/><text class="t" text-anchor="middle" x="450.0" y="40.0">Repos</text><text class="ts" text-anchor="middle" x="450.0" y="58.0">the projects themselves</text>
<path class="ln" d="M160 44L200 44" marker-start="url(#m2)" marker-end="url(#m2)"/><path class="ln" d="M340 44L380 44" marker-start="url(#m2)" marker-end="url(#m2)"/>
</svg>
<figcaption>Tasks never touch the main checkouts; the hub tracks every workspace</figcaption>
</figure>

## What's next

I want more of the routine work to run unattended, with the same guardrails, and more of the mechanical steps moved onto free models without losing quality. The thinking and the final judgement stay with me, in [the Learn → Validate loop](/ai) I follow on every project.
