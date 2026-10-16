<!-- head -->
# I steer. The agents {{do the typing}}.

I guide, Claude learns and understands, and we iterate on a written plan together. That is where most of the work happens. Then it implements, and we validate the result together.

<!-- loop | The loop -->
### Learn
who: Claude

It reads the repo, the docs and the current state, and comes back with facts and where each one came from. No edits, no guessing.

### Understand
who: Claude + me

It tells me how it read the request and asks what the code cannot answer: scope, trade-offs, what “done” means. I answer. Nothing moves on while a question is open.

### Plan, together
who: where the bulk of the work is

We iterate on a plan written in plain language: the batches, the decisions, and the scenarios that will prove it works. I read it, push back, change it. Nothing gets built until I approve that exact version.

### Implement
who: Claude

Now it builds, with cheaper models taking the mechanical steps. If reality does not match the plan, it stops and says so instead of improvising a design.

### Validate, together
who: independent agent + me

A separate agent runs the scenarios from the plan, unchanged, and shows evidence. I look at it and decide whether it is right.

<!-- prototype | Prototype fast -->
## Show, don’t describe.

Before I approve a plan, I want to see the thing. Claude turns an idea into a clickable prototype in minutes, I react to it, and we go again. Looking at a rough version teaches us more than a page of requirements, and changing it costs almost nothing.

```
# this site, before any code was approved
mockup v1   direction + theme
mockup v2   my photo, framed
mockup v3   stack: add AI tooling
mockup v4   WISC-III in the nav
mockup v5   every page, clickable
→ then the plan gets approved
```

<!-- behaviour | Behaviour first -->
## BDD is how we agree, and how I check.

Every acceptance criterion becomes a scenario in plain language, in the Given / When / Then style of BDD, before a line of code exists. It is the contract between me and the agents: what the thing must do, described from the outside, in words I can read.

Scenarios do not replace tests. The agents still write unit, integration and end-to-end tests, because those catch what a sentence cannot. BDD is the layer I own: I read the scenarios, and I watch them pass alongside the rest of the suite.

```
# from this site's own plan
Scenario: Old post links still work
  Given a reader opens an old post URL
  When  the request reaches the new site
  Then  they are sent to the new page
  And   the response is a permanent redirect

Scenario: Works on a phone
  Given a 375px wide screen
  When  I open any page
  Then  nothing scrolls sideways

─ validation, side by side ─
✓ scenarios    what I read and approve
✓ unit tests   logic, edge cases
✓ integration  parts working together
✓ end-to-end   a real browser, real flow
```

<!-- unbounded | Unbounded -->
## If I can *read* the behaviour, I can *use* it. The language and the technology become details.

The scenarios say what the system does, not how it is built. So the same way of working holds whether the answer is C#, Go, TypeScript or something I have never touched. I do not need to know the idiom to know the result is right, because I validate the behaviour, not the syntax.

<!-- benefits | What this gives me -->
### Judgement stays mine

I decide what gets built and when it is done. The agents never decide either.

### Mistakes are cheap early

Most of the effort goes into the plan, where a wrong turn costs a sentence, not a rewrite.

### Proof, not promises

“Done” is a scenario that passes. A separate agent checks it, and I see the evidence.

<!-- under-the-hood | Under the hood -->
Stronger models (Opus) do the thinking and planning. Smaller and cheaper ones do the repetitive work, and a failed check is what escalates a step. Work happens in isolated git worktrees, lands through pull requests, and merging is my call. Secrets never go into prompts.

<!-- in-practice | In practice -->
## This site was built this way.

The redesign you are looking at went through the same loop: every question asked and answered, a plan iterated until I approved it, scenarios written before the code, and a design gate where I approved the look before the rest got built.

<!-- contact -->
## Curious how it works for your team?

Happy to talk about it.

cta: Get in touch →
