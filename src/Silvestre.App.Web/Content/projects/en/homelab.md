---
title: "HomeLab"
tagline: "Infrastructure as code for a self-hosted home lab."
order: 4
kind: project
---

The lab is the quiet machinery behind my other projects: a small private cloud at home, described as code so it can be understood, repaired and rebuilt.

## Problem

A home server rack tends to turn into folklore. Things work because of a command typed once, a setting nobody wrote down, a certificate that renews itself until it doesn't. I wanted the lab to behave like a production system: documented, patched on a schedule, and loud when something is wrong. Rebuilding after a failure should be a boring afternoon, not an archaeology project.

## What it does

It hosts the services I rely on day to day, including my own apps. A Proxmox cluster runs the workloads, a NAS holds storage and a few applications, and a VPN mesh gives private access from anywhere. A secrets manager keeps credentials out of the repository, an observability stack collects metrics and raises alerts, and n8n and Home Assistant handle automation around the house and around the lab itself. Patching runs on a timetable, with the riskier machines handled more carefully than the routine ones.

## How it's built

Everything is managed as code with Ansible: an inventory sorts machines into groups by how safe they are to update, and roles bring each service to its documented state. Playbooks are run from a Linux control environment, and a scheduled runner does the routine weekly work on its own. The written docs are kept alongside the code as the human-readable counterpart. Anything that cannot be automated, such as creating a new guest, is written up as a runbook instead.

<figure class="diagram">
<svg viewBox="0 0 520 250" role="img" aria-label="HomeLab layers: Ansible on top manages the home cluster, storage, mesh VPN, secrets, observability and automation layers">
<defs><marker id="m1" viewBox="0 0 10 10" refX="8" refY="5" markerWidth="7" markerHeight="7" orient="auto-start-reverse"><path d="M0 0L10 5L0 10z" class="mk"/></marker></defs><rect class="ba" x="20" y="14" width="480" height="50" rx="10"/><text class="t" text-anchor="middle" x="260.0" y="37.0">Ansible</text><text class="ts" text-anchor="middle" x="260.0" y="55.0">the lab described and managed as code</text><rect class="b" x="20" y="104" width="150" height="60" rx="10"/><text class="t" text-anchor="middle" x="95.0" y="132.0">Home cluster</text><text class="ts" text-anchor="middle" x="95.0" y="150.0">virtualised workloads</text><rect class="b" x="185" y="104" width="150" height="60" rx="10"/><text class="t" text-anchor="middle" x="260.0" y="132.0">Storage</text><text class="ts" text-anchor="middle" x="260.0" y="150.0">a NAS for files and apps</text><rect class="b" x="350" y="104" width="150" height="60" rx="10"/><text class="t" text-anchor="middle" x="425.0" y="132.0">Mesh / VPN</text><text class="ts" text-anchor="middle" x="425.0" y="150.0">private remote access</text><rect class="b" x="20" y="180" width="150" height="60" rx="10"/><text class="t" text-anchor="middle" x="95.0" y="208.0">Secrets</text><text class="ts" text-anchor="middle" x="95.0" y="226.0">a secrets manager</text><rect class="b" x="185" y="180" width="150" height="60" rx="10"/><text class="t" text-anchor="middle" x="260.0" y="208.0">Observability</text><text class="ts" text-anchor="middle" x="260.0" y="226.0">metrics and alerts</text><rect class="b" x="350" y="180" width="150" height="60" rx="10"/><text class="t" text-anchor="middle" x="425.0" y="208.0">Automation</text><text class="ts" text-anchor="middle" x="425.0" y="226.0">n8n and Home Assistant</text><path class="ln" d="M260 64L260 102" marker-end="url(#m1)"/>
</svg>
<figcaption>Ansible sits above every layer and is the single way changes are made</figcaption>
</figure>

## What's next

The goal is to shrink the manual surface: more of the patching and alert handling moving to automatic runs, and fewer one-off steps in the runbooks. Part of that is letting agents do routine operations under supervision, which is covered in [how the lab is operated with agents](/projects/workflow).
