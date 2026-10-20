---
title: "HomeOS"
tagline: "A home-management web app for recipes, pantry and meal plans."
order: 3
kind: project
---

HomeOS is a small self-hosted web app that gathers the everyday running of a household in one place.

## Problem

Recipes live in one app, the shopping list in another, and the question of what is actually in the pantry lives in nobody's head. Each tool is fine alone, but none of them know about the others, so the same ingredient gets typed in three times. I wanted a household tool that is mine to run, keeps its data at home, and is small enough to understand end to end.

## What it does

The pieces share one ingredient catalogue. Recipes can be browsed, searched, scaled to a number of servings and followed step by step in a cooking mode. The pantry tracks what is in stock, and a weekly meal plan places recipes on the calendar. From there a recipe's ingredients go onto the shopping list in one click, optionally with per-store price estimates from [Savvori](/projects/savvori). A dashboard ties the modules together, and the interface works in English and Portuguese.

## How it's built

A single .NET web project serves both the server-rendered pages and a JSON API, backed by an embedded database, and it runs comfortably on one small machine. Interactivity comes from server-driven page updates rather than a client-side framework, and every front-end asset is bundled with the app so nothing loads from a third party. It is tested with unit tests and behaviour-style component tests, and it ships as a container image.

<figure class="diagram">
<svg viewBox="0 0 540 270" role="img" aria-label="HomeOS architecture: a single web app and API hosts recipe, pantry, meal plan and shopping modules over a local database, deployed as a container">
<defs><marker id="m1" viewBox="0 0 10 10" refX="8" refY="5" markerWidth="7" markerHeight="7" orient="auto-start-reverse"><path d="M0 0L10 5L0 10z" class="mk"/></marker></defs><rect class="b" x="20" y="14" width="300" height="52" rx="10"/><text class="t" text-anchor="middle" x="170.0" y="38.0">Web app and API</text><text class="ts" text-anchor="middle" x="170.0" y="56.0">one service, pages plus JSON</text><rect class="b" x="20" y="106" width="115" height="50" rx="10"/><text class="t" text-anchor="middle" x="77.5" y="129.0">Recipes</text><text class="ts" text-anchor="middle" x="77.5" y="147.0">module</text><rect class="b" x="145" y="106" width="115" height="50" rx="10"/><text class="t" text-anchor="middle" x="202.5" y="129.0">Pantry</text><text class="ts" text-anchor="middle" x="202.5" y="147.0">module</text><rect class="b" x="270" y="106" width="115" height="50" rx="10"/><text class="t" text-anchor="middle" x="327.5" y="129.0">Meal plan</text><text class="ts" text-anchor="middle" x="327.5" y="147.0">module</text><rect class="b" x="395" y="106" width="115" height="50" rx="10"/><text class="t" text-anchor="middle" x="452.5" y="129.0">Shopping</text><text class="ts" text-anchor="middle" x="452.5" y="147.0">module</text><rect class="b" x="20" y="196" width="300" height="52" rx="10"/><text class="t" text-anchor="middle" x="170.0" y="220.0">Local database</text><text class="ts" text-anchor="middle" x="170.0" y="238.0">embedded, single file</text><rect class="bd" x="380" y="14" width="130" height="52" rx="10"/><text class="t" text-anchor="middle" x="445.0" y="38.0">Container</text><text class="ts" text-anchor="middle" x="445.0" y="56.0">one deployable image</text><path class="ln" d="M77 66L77 104" marker-end="url(#m1)"/><path class="ln" d="M202 66L202 104" marker-end="url(#m1)"/><path class="ln" d="M327 66L327 104" marker-end="url(#m1)"/><path class="ln" d="M452 66L452 104" marker-end="url(#m1)"/><path class="ln" d="M170 156L170 194" marker-end="url(#m1)"/>
</svg>
<figcaption>one service, several modules, one local database</figcaption>
</figure>

## What's next

Sign-in is the obvious gap, since for now it assumes a trusted network. Beyond that, the plan is deeper links between the modules, such as the pantry automatically trimming the shopping list, and smoother use on a phone in the kitchen, where most of the cooking-mode time is actually spent. Tighter pricing links to Savvori are also on the list.
