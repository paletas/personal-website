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

The app covers the everyday finance loop and then goes further.

- **Public calculators.** Salary (gross to net under local rules), mortgage overpayment and refinancing comparisons work without an account, and they are the easy way in.
- **Tracking.** Accounts, transactions, categories, transfers between accounts and recurring income and expenses build a picture of what is coming and going.
- **Planning.** Budgets and sinking funds set money aside for known future costs: a sinking fund works out the monthly amount for an annual or half-yearly bill from the recurring expenses themselves.
- **Mortgages and net worth.** Mortgage accounts with projections, and a net-worth view that brings everything together.
- **Investments.** Holdings, buys and sells, stock splits, cost-basis lots and a capital-gains estimate, with prices and exchange rates pulled from several market-data sources that back each other up.
- **Taxes.** An annual tax return estimator that explains the result bracket by bracket and compares scenarios. Employment income is covered for 2025; other income categories are on the roadmap, and the design lets each country plug in its own rules.
- **Import.** Bulk import from generic files, plus converters that turn each bank's or broker's export into that same format, so every source goes through one validated pipeline. An optional bank sync can feed transactions in automatically.
- **Two languages.** Every user-facing text exists in Portuguese and English.

## How it's built

PlanAhead is a layered application on .NET 10. A server-rendered web client (Razor Pages with HTMX) talks only to a stateless REST API, never to the database directly. The API hands work to a layer of handlers that hold the business rules, independent of how a request arrives, and those handlers read and write PostgreSQL through a data layer. Keeping the rules in one transport-neutral layer means the same logic serves the web client and any future client. Aspire wires the pieces together for development and testing.

<figure class="diagram">
<svg viewBox="0 0 520 330" role="img" aria-label="Layers of PlanAhead: a web client calls an API, which calls handlers, which use storage; bank sync is an optional input to the handlers">
<defs><marker id="m1" viewBox="0 0 10 10" refX="8" refY="5" markerWidth="7" markerHeight="7" orient="auto-start-reverse"><path d="M0 0L10 5L0 10z" class="mk"/></marker></defs><rect class="b" x="20" y="14" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="120.0" y="38.0">Web client</text><text class="ts" text-anchor="middle" x="120.0" y="56.0">server-rendered pages</text><rect class="b" x="20" y="96" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="120.0" y="120.0">API</text><text class="ts" text-anchor="middle" x="120.0" y="138.0">stateless backend</text><rect class="b" x="20" y="178" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="120.0" y="202.0">Handlers</text><text class="ts" text-anchor="middle" x="120.0" y="220.0">business logic</text><rect class="b" x="20" y="260" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="120.0" y="284.0">Storage</text><text class="ts" text-anchor="middle" x="120.0" y="302.0">relational database</text><rect class="bd" x="300" y="178" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="400.0" y="202.0">Bank sync</text><text class="ts" text-anchor="middle" x="400.0" y="220.0">optional input</text><path class="ln" d="M120 66L120 94" marker-end="url(#m1)"/><path class="ln" d="M120 148L120 176" marker-end="url(#m1)"/><path class="ln" d="M120 230L120 258" marker-end="url(#m1)"/><path class="ln" d="M300 204L222 204" marker-end="url(#m1)"/>
</svg>
<figcaption>requests flow down the layers; bank sync is an optional input</figcaption>
</figure>

## Engineering choices

- **Lightweight CQRS, in-house.** Commands and queries go through a small mediator of our own instead of a third-party library, which keeps the pipeline simple and fully ours to change.
- **Results, not exceptions.** Expected failures such as a rule not being met come back as explicit operation results rather than thrown exceptions, so handlers read as a clear success-or-failure story.
- **Money is always decimal.** Every amount uses exact decimal arithmetic, never floating point.
- **Tenant isolation by default.** Every query is scoped to the signed-in user by global filters, and a test that signs in as two different users checks that one can never see the other's data.
- **HTMX first.** Small server-driven updates keep the pages fast without a heavy client-side framework.

## Testing

Browser-level end-to-end tests drive the real application on a fresh throwaway database, with the market-data boundary faked so results are repeatable. They assert computed values, not just that a page renders, and they have caught real product bugs. A feature is not considered done until its end-to-end coverage exists.

## How it has grown

PlanAhead started in 2024 as a hand-written project, before I was working with AI agents. Since then the way of working has shifted. Today the repository carries instructions for agents and a few project skills for repeatable jobs such as adding a bank importer. Every feature has a short design document explaining what it does and why; the agents read it before they start and update it after they finish. The architecture and the tests stay mine to set, and the agents work inside them. The pace shows it: most of the project's commits landed in 2026.
## What's next

The roadmap is mostly about depth rather than breadth: smarter categorisation of transactions, more flexible budget periods with alerts, richer reports, more income categories in the tax estimator, and stronger sign-in options. The longer view is support for other countries, each with its own tax framework.
