---
title: "Savvori"
tagline: "Grocery price comparison and shopping lists."
order: 2
kind: project
---

Savvori is a grocery price comparison tool and shopping list for Portuguese households. You build a list, and it works out where that list is cheapest.

## Problem

The same basket costs noticeably different amounts depending on where it is bought, but comparing is tedious. Every chain names, sizes and categorises its products differently, so a like-for-like comparison means a lot of squinting at labels. A shopping list that knows about prices removes that work.

## What it does

Savvori keeps a catalogue of products with their prices across the major supermarket chains, organised into a common taxonomy. You add items to a list and it shows the cost at each chain and suggests the cheapest way to fill the whole list. The harder half is identifying that two differently labelled products are the same thing, which is where the matching and categorisation work comes in. It also feeds the shopping list in [HomeOS](/projects/homeos), so a meal plan can end with an estimated total.

## How it's built

It is a .NET application orchestrated locally with Aspire. A server-rendered web app sits in front of a web API that owns the lists, the comparison logic and the basket optimiser. Both read from an embedded database. A separate pipeline gathers prices from public catalogues and matches each product into the taxonomy, using a locally hosted language model to help with the ambiguous cases. There is no sign-in, because it is meant to run as a single-user tool on a private network. Tests cover the API, the web layer and full browser flows.

<figure class="diagram">
<svg viewBox="0 0 520 250" role="img" aria-label="Savvori architecture: a web app calls a web API backed by a data store; a matching pipeline fed by public catalogues writes into the same store">
<defs><marker id="m1" viewBox="0 0 10 10" refX="8" refY="5" markerWidth="7" markerHeight="7" orient="auto-start-reverse"><path d="M0 0L10 5L0 10z" class="mk"/></marker></defs><rect class="b" x="20" y="14" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="120.0" y="38.0">Web app</text><text class="ts" text-anchor="middle" x="120.0" y="56.0">shopping lists and prices</text><rect class="b" x="20" y="96" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="120.0" y="120.0">Web API</text><text class="ts" text-anchor="middle" x="120.0" y="138.0">lists, comparison, optimiser</text><rect class="b" x="20" y="178" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="120.0" y="202.0">Data store</text><text class="ts" text-anchor="middle" x="120.0" y="220.0">products, prices, taxonomy</text><rect class="s1" x="300" y="96" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="400.0" y="120.0">Matching pipeline</text><text class="ts" text-anchor="middle" x="400.0" y="138.0">scrape, match, categorise</text><rect class="bd" x="300" y="14" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="400.0" y="38.0">Price sources</text><text class="ts" text-anchor="middle" x="400.0" y="56.0">public grocery catalogues</text><path class="ln" d="M120 66L120 94" marker-end="url(#m1)"/><path class="ln" d="M120 148L120 176" marker-end="url(#m1)"/><path class="ln" d="M400 66L400 94" marker-end="url(#m1)"/><path class="ln" d="M300 122L222 122" marker-end="url(#m1)"/><path class="ln" d="M400 148L222 196" marker-end="url(#m1)"/>
</svg>
<figcaption>the pipeline keeps the catalogue fresh; the API only reads and optimises</figcaption>
</figure>

## What's next

The current focus is model-assisted matching: generating candidate matches, tiering them by confidence, and routing the uncertain ones to a review queue instead of guessing. After that comes a cleaner second version of the category taxonomy, informed by what the first one got wrong.
