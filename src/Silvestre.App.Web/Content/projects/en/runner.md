---
title: "Runner"
tagline: "A sandboxed runner for repeatable automation jobs."
order: 6
kind: project
---

A small controller that runs scheduled and on-demand agent jobs unattended, inside a sandbox, and tells me how they went.

## Problem

Agents are most useful when they work while I am not watching, and that is exactly when they are most worrying. A job that runs overnight needs a boundary around what it can touch, a way to keep secrets out of whatever it prints, and a record of what happened. Without those, unattended automation is either too risky to schedule or too opaque to trust, so I ended up running everything by hand and defeating the point.

## What it does

Each job runs under a named profile that describes what the agent may do and what it is given. Jobs can be launched on a schedule or whenever I ask. While a job runs, its output is scrubbed so credentials never reach logs or messages. When it finishes, I get a notification, and the outcome lands in a run history with basic telemetry, so I can see what ran, how long it took and whether it behaved.

## How it's built

It is a compact Python program with a command-line front end and a few focused modules: configuration, profiles, a small database for history, redaction, notifications and telemetry. The agent itself runs in a container image that is built and published by continuous integration, so the controller stays simple and the sandbox is reproducible. Where it is deployed, and the credentials it needs, are managed with the rest of my lab setup rather than in this project, and a unit test suite guards the controller.

<figure class="diagram">
<svg viewBox="0 0 540 90" role="img" aria-label="Runner flow: scheduler or command line, sandboxed run, redaction, notification and history">
<defs><marker id="m1" viewBox="0 0 10 10" refX="8" refY="5" markerWidth="7" markerHeight="7" orient="auto-start-reverse"><path d="M0 0L10 5L0 10z" class="mk"/></marker></defs>
<rect class="b" x="20" y="14" width="110" height="60" rx="10"/><text class="t" text-anchor="middle" x="75.0" y="40.0">Schedule / CLI</text><text class="ts" text-anchor="middle" x="75.0" y="58.0">start a job</text>
<path class="ln" d="M130 44L150 44" marker-end="url(#m1)"/>
<rect class="b" x="150" y="14" width="110" height="60" rx="10"/><text class="t" text-anchor="middle" x="205.0" y="40.0">Sandbox</text><text class="ts" text-anchor="middle" x="205.0" y="58.0">profile-selected run</text>
<path class="ln" d="M260 44L280 44" marker-end="url(#m1)"/>
<rect class="b" x="280" y="14" width="110" height="60" rx="10"/><text class="t" text-anchor="middle" x="335.0" y="40.0">Redaction</text><text class="ts" text-anchor="middle" x="335.0" y="58.0">secrets scrubbed</text>
<path class="ln" d="M390 44L410 44" marker-end="url(#m1)"/>
<rect class="ba" x="410" y="14" width="110" height="60" rx="10"/><text class="t" text-anchor="middle" x="465.0" y="40.0">Notify + history</text><text class="ts" text-anchor="middle" x="465.0" y="58.0">result and record</text>
</svg>
<figcaption>Every run is bounded, scrubbed and recorded</figcaption>
</figure>

## What's next

I want richer profiles for different kinds of work, better summaries in notifications, and more useful telemetry so I can spot jobs that are drifting or getting slower. The runner already does a share of the routine operations described in [how the lab is operated with agents](/projects/workflow), and the aim is to widen that carefully.
