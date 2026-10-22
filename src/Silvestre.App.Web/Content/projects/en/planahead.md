---
title: "PlanAhead"
tagline: "A personal-finance planner for budgets, savings, taxes and investments."
order: 1
kind: project
---

PlanAhead is a personal finance planner for Portuguese users, built around the question of what the coming months should look like rather than only what was spent. It turns gross pay into net pay under local rules, tracks accounts, recurring items, budgets and sinking funds, and reports where things are heading. It is a layered .NET application, with the business rules kept apart from the web client.

<figure class="diagram">
<svg viewBox="0 0 520 330" role="img" aria-label="Layers of PlanAhead: a web client calls an API, which calls handlers, which use storage; bank sync is an optional input to the handlers">
<defs><marker id="m1" viewBox="0 0 10 10" refX="8" refY="5" markerWidth="7" markerHeight="7" orient="auto-start-reverse"><path d="M0 0L10 5L0 10z" class="mk"/></marker></defs><rect class="b" x="20" y="14" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="120.0" y="38.0">Web client</text><text class="ts" text-anchor="middle" x="120.0" y="56.0">server-rendered pages</text><rect class="b" x="20" y="96" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="120.0" y="120.0">API</text><text class="ts" text-anchor="middle" x="120.0" y="138.0">stateless backend</text><rect class="b" x="20" y="178" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="120.0" y="202.0">Handlers</text><text class="ts" text-anchor="middle" x="120.0" y="220.0">business logic</text><rect class="b" x="20" y="260" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="120.0" y="284.0">Storage</text><text class="ts" text-anchor="middle" x="120.0" y="302.0">relational database</text><rect class="bd" x="300" y="178" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="400.0" y="202.0">Bank sync</text><text class="ts" text-anchor="middle" x="400.0" y="220.0">optional input</text><path class="ln" d="M120 66L120 94" marker-end="url(#m1)"/><path class="ln" d="M120 148L120 176" marker-end="url(#m1)"/><path class="ln" d="M120 230L120 258" marker-end="url(#m1)"/><path class="ln" d="M300 204L222 204" marker-end="url(#m1)"/>
</svg>
<figcaption>requests flow down the layers; bank sync is an optional input</figcaption>
</figure>
