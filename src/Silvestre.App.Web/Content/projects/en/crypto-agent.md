---
title: "crypto-agent"
tagline: "A command-line tool for crypto tax reporting."
order: 7
kind: project
---

A calculator that turns a pile of transaction exports into the figures a Portuguese IRS crypto declaration needs.

## Problem

Crypto activity spread over several services leaves a messy trail: exports in different shapes, the same movement recorded twice, and entries that make no sense on their own. Tax rules then ask for precise cost-basis accounting across all of it. Spreadsheets break down quickly, and a wrong figure on a tax return is not something I want to discover later. I wanted a repeatable process that I could rerun at any time, inspect step by step, and trust because every number traces back to the original exports.

## What it does

It imports transaction exports from different sources and brings them into one common form. It then removes duplicates and flags odd records, such as missing origins or suspicious pricing, so that a person reviews them instead of the tool guessing. Gains are matched using first in, first out cost basis, as Portuguese rules expect. The final output is the set of figures a tax return needs, plus a preview so I can check the result before filing anything. Nothing about the data leaves my machine, which matters for something this personal.

## How it's built

It is a .NET command-line application with a local database. A staged flow keeps each concern separate: import, clean-up, matching and reporting. Corrections are written as explicit, reviewable rules and replayed on a fresh import, so the whole result can be rebuilt from the original exports whenever a rule changes. Backups are taken before any change that writes to the database, and wrapper scripts make the common routines one command.

<figure class="diagram">
<svg viewBox="0 0 540 90" role="img" aria-label="crypto-agent flow: imports, normalise and de-duplicate, FIFO matching, report">
<defs><marker id="m1" viewBox="0 0 10 10" refX="8" refY="5" markerWidth="7" markerHeight="7" orient="auto-start-reverse"><path d="M0 0L10 5L0 10z" class="mk"/></marker></defs>
<rect class="b" x="20" y="14" width="110" height="60" rx="10"/><text class="t" text-anchor="middle" x="75.0" y="40.0">Imports</text><text class="ts" text-anchor="middle" x="75.0" y="58.0">transaction exports</text>
<path class="ln" d="M130 44L150 44" marker-end="url(#m1)"/>
<rect class="b" x="150" y="14" width="110" height="60" rx="10"/><text class="t" text-anchor="middle" x="205.0" y="40.0">Normalise</text><text class="ts" text-anchor="middle" x="205.0" y="58.0">de-duplicate, flag</text>
<path class="ln" d="M260 44L280 44" marker-end="url(#m1)"/>
<rect class="b" x="280" y="14" width="110" height="60" rx="10"/><text class="t" text-anchor="middle" x="335.0" y="40.0">FIFO matching</text><text class="ts" text-anchor="middle" x="335.0" y="58.0">cost basis</text>
<path class="ln" d="M390 44L410 44" marker-end="url(#m1)"/>
<rect class="ba" x="410" y="14" width="110" height="60" rx="10"/><text class="t" text-anchor="middle" x="465.0" y="40.0">Report</text><text class="ts" text-anchor="middle" x="465.0" y="58.0">tax-return figures</text>
</svg>
<figcaption>Raw exports in, reviewable figures out</figcaption>
</figure>

## What's next

More import sources are the obvious step, since each new service brings its own format. After that comes better review tooling, so flagged records can be resolved faster and the reasoning for each decision is easier to read back later.
