---
title: "Tone & Tome"
tagline: "An automated pipeline that turns stories into narrated video."
order: 5
kind: project
---

A pipeline that reads a book for its mood, then turns each chapter into a slow, wordless video to read by.

## Problem

Reading goes better with the right atmosphere, and most reading playlists ignore the book in your hands. I wanted a soundtrack that follows a story: a quiet moving scene and fitting music for every chapter, lasting about as long as the chapter takes to read. Doing that by hand is hours of work per chapter, so the machine has to do nearly all of it, without ever showing or quoting the book.

## What it does

For each chapter it works out the setting, time of day, weather and feeling, then produces a handful of still scenes, brings them gently to life with motion, and lays music underneath that matches the mood. The length comes from an estimate of reading time. The results are published as a YouTube channel of reading soundtracks. A person stays in the loop: I pick the stills I like and approve each finished video before it goes public. Every asset, track and model is credited, and a video cannot be assembled while a credit is missing.

## How it's built

A small orchestrator keeps the queue and the state of every chapter as a series of steps, and shows progress on a web page. The heavy generation work runs on a separate machine with a graphics card, and only when that machine is switched on. When it is off, those steps simply wait while everything else carries on, so nothing fails because of a sleeping computer. Language models plan the scenes, image models paint the places, and ffmpeg assembles the video. Everything runs locally, at no running cost.

<figure class="diagram">
<svg viewBox="0 0 540 90" role="img" aria-label="Pipeline: source text, analysis, generation, assembled video">
<defs><marker id="m1" viewBox="0 0 10 10" refX="8" refY="5" markerWidth="7" markerHeight="7" orient="auto-start-reverse"><path d="M0 0L10 5L0 10z" class="mk"/></marker></defs>
<rect class="b" x="20" y="14" width="110" height="60" rx="10"/><text class="t" text-anchor="middle" x="75.0" y="40.0">Source text</text><text class="ts" text-anchor="middle" x="75.0" y="58.0">read, never shown</text>
<path class="ln" d="M130 44L150 44" marker-end="url(#m1)"/>
<rect class="b" x="150" y="14" width="110" height="60" rx="10"/><text class="t" text-anchor="middle" x="205.0" y="40.0">Analysis</text><text class="ts" text-anchor="middle" x="205.0" y="58.0">mood and scenes</text>
<path class="ln" d="M260 44L280 44" marker-end="url(#m1)"/>
<rect class="b" x="280" y="14" width="110" height="60" rx="10"/><text class="t" text-anchor="middle" x="335.0" y="40.0">Generation</text><text class="ts" text-anchor="middle" x="335.0" y="58.0">stills, motion, music</text>
<path class="ln" d="M390 44L410 44" marker-end="url(#m1)"/>
<rect class="ba" x="410" y="14" width="110" height="60" rx="10"/><text class="t" text-anchor="middle" x="465.0" y="40.0">Video</text><text class="ts" text-anchor="middle" x="465.0" y="58.0">edited, reviewed</text>
</svg>
<figcaption>Text is only analysed; the output is images, motion and music</figcaption>
</figure>

## What's next

The remaining roadmap is about scale and polish: more music sources with licence checks, smoother assembly and loudness, batch runs across a whole book, and a gentler way to wake the generation machine. The first complete book is the live test that decides how much of the manual review can safely be dropped.
