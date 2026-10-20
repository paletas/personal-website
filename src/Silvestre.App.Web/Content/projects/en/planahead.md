---
title: "PlanAhead"
tagline: "A personal-finance planner for budgets, savings, taxes and investments."
order: 1
kind: project
---

Money tools usually look backwards: they record what was spent and leave the planning to a spreadsheet. PlanAhead starts from the other direction. It is a personal finance planner for Portuguese users, built around the question of what the coming months should look like, and tracking is there to feed that answer.

## Problem

Salaries in Portugal come with their own tax and contribution rules, and most budgeting apps either ignore them or force a manual workaround. I wanted one place that understands take-home pay, recurring commitments and long-term goals, so a plan made today still holds up a few months from now.

## What it does

The app covers the everyday finance loop. A salary calculator turns gross pay into net pay under local rules. Accounts, transactions and recurring items build up a picture of what is coming in and going out, and budgets and sinking funds set money aside for known future costs. Mortgage and asset tracking add the bigger, slower items, and reports pull everything into a view of where things are heading. Statements can be imported in bulk, and an optional bank sync can feed transactions in automatically.

## How it's built

PlanAhead is a layered .NET application. A server-rendered web client talks only to a stateless API, never to the database directly. The API hands work to a layer of handlers that hold the business rules, independent of how a request arrives, and those handlers read and write a relational database through a data layer. Keeping the rules in one transport-neutral layer means the same logic serves the web client and any future client. The pages favour small server-driven updates over heavy client-side code, and the whole solution is covered by browser-level end-to-end tests.

<figure class="diagram">
<svg viewBox="0 0 520 330" role="img" aria-label="Layers of PlanAhead: a web client calls an API, which calls handlers, which use storage; bank sync is an optional input to the handlers">
<defs><marker id="m1" viewBox="0 0 10 10" refX="8" refY="5" markerWidth="7" markerHeight="7" orient="auto-start-reverse"><path d="M0 0L10 5L0 10z" class="mk"/></marker></defs><rect class="b" x="20" y="14" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="120.0" y="38.0">Web client</text><text class="ts" text-anchor="middle" x="120.0" y="56.0">server-rendered pages</text><rect class="b" x="20" y="96" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="120.0" y="120.0">API</text><text class="ts" text-anchor="middle" x="120.0" y="138.0">stateless backend</text><rect class="b" x="20" y="178" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="120.0" y="202.0">Handlers</text><text class="ts" text-anchor="middle" x="120.0" y="220.0">business logic</text><rect class="b" x="20" y="260" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="120.0" y="284.0">Storage</text><text class="ts" text-anchor="middle" x="120.0" y="302.0">relational database</text><rect class="bd" x="300" y="178" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="400.0" y="202.0">Bank sync</text><text class="ts" text-anchor="middle" x="400.0" y="220.0">optional input</text><path class="ln" d="M120 66L120 94" marker-end="url(#m1)"/><path class="ln" d="M120 148L120 176" marker-end="url(#m1)"/><path class="ln" d="M120 230L120 258" marker-end="url(#m1)"/><path class="ln" d="M300 204L222 204" marker-end="url(#m1)"/>
</svg>
<figcaption>requests flow down the layers; bank sync is an optional input</figcaption>
</figure>

## What's next

The roadmap is mostly about depth rather than breadth: smarter categorisation of transactions, more flexible budget periods with alerts, richer reports, and stronger sign-in options. The longer view is support for other countries, each with its own tax framework.
