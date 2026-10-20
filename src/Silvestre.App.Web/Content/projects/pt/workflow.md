---
title: "Como construo com agentes"
tagline: "Um plano escrito, cenários como contrato e uma verificação independente."
order: 0
kind: workflow
---

Uma pessoa, muitos projetos e um conjunto de agentes mantidos sob controlo apertado por um hub que guarda as regras.

## Problema

Giro vários projetos de vulto em simultâneo, e sou a única pessoa. Os agentes podem assumir grande parte dessa carga, mas deixados sozinhos desviam-se, repetem-se uns aos outros e tocam no que não devem. Também esquecem entre sessões. Precisava de guardrails que vivam fora de qualquer conversa isolada, para que cada sessão comece das mesmas regras e cada alteração possa ser rastreada e revertida.

## O que faz

O trabalho flui através de um pipeline fixo: aprender, compreender, planear, planear em lotes, executar, verificar. Um modelo mais forte faz o pensamento e escreve o plano. Um modelo de nível intermédio executa-o. Os passos mecânicos vão para modelos gratuitos com contexto muito grande, servidos através de um gateway que alojo eu próprio, e o gratuito é sempre tentado primeiro. Um agente independente verifica depois o resultado face ao plano. O mesmo hub executa o trabalho rotineiro: patching agendado, alertas e skills que atualizam documentação. Vários projetos grandes avançam em paralelo, cada um no seu espaço.

## Como é construído

<figure class="diagram">
<svg viewBox="0 0 540 90" role="img" aria-label="Pipeline de fases com escalões de modelo: modelo forte planeia, modelo intermédio executa, modelos gratuitos assumem passos mecânicos, agente independente verifica">
<defs><marker id="m1" viewBox="0 0 10 10" refX="8" refY="5" markerWidth="7" markerHeight="7" orient="auto-start-reverse"><path d="M0 0L10 5L0 10z" class="mk"/></marker></defs>
<rect class="b" x="20" y="14" width="110" height="60" rx="10"/><text class="t" text-anchor="middle" x="75.0" y="40.0">Aprender</text><text class="ts" text-anchor="middle" x="75.0" y="58.0">modelo forte</text>
<path class="ln" d="M130 44L150 44" marker-end="url(#m1)"/>
<rect class="b" x="150" y="14" width="110" height="60" rx="10"/><text class="t" text-anchor="middle" x="205.0" y="40.0">Planear</text><text class="ts" text-anchor="middle" x="205.0" y="58.0">modelo forte</text>
<path class="ln" d="M260 44L280 44" marker-end="url(#m1)"/>
<rect class="b" x="280" y="14" width="110" height="60" rx="10"/><text class="t" text-anchor="middle" x="335.0" y="40.0">Executar</text><text class="ts" text-anchor="middle" x="335.0" y="58.0">modelo médio</text>
<path class="ln" d="M390 44L410 44" marker-end="url(#m1)"/>
<rect class="ba" x="410" y="14" width="110" height="60" rx="10"/><text class="t" text-anchor="middle" x="465.0" y="40.0">Verificar</text><text class="ts" text-anchor="middle" x="465.0" y="58.0">agente isolado</text>
</svg>
<figcaption>O modelo caro planeia, modelos mais baratos constroem, e um agente separado verifica</figcaption>
</figure>

O hub é um repositório à parte. Guarda as regras permanentes, as skills que os agentes podem invocar e um registo de todos os projetos. Cada tarefa tem um workspace: uma cópia isolada dos repositórios relevantes no seu próprio branch, para que os checkouts principais nunca sejam editados diretamente e o trabalho chegue ao mundo apenas através de pull requests revistas. Progresso, planos e evidências de cada tarefa são escritos em ficheiros, para que uma nova sessão retome exatamente onde a anterior parou.

<figure class="diagram">
<svg viewBox="0 0 540 90" role="img" aria-label="Hub, workspaces e repositórios ligados nos dois sentidos">
<defs><marker id="m2" viewBox="0 0 10 10" refX="8" refY="5" markerWidth="7" markerHeight="7" orient="auto-start-reverse"><path d="M0 0L10 5L0 10z" class="mk"/></marker></defs>
<rect class="ba" x="20" y="14" width="140" height="60" rx="10"/><text class="t" text-anchor="middle" x="90.0" y="40.0">Hub</text><text class="ts" text-anchor="middle" x="90.0" y="58.0">regras, skills, registo</text>
<rect class="b" x="200" y="14" width="140" height="60" rx="10"/><text class="t" text-anchor="middle" x="270.0" y="40.0">Workspaces</text><text class="ts" text-anchor="middle" x="270.0" y="58.0">um por tarefa</text>
<rect class="b" x="380" y="14" width="140" height="60" rx="10"/><text class="t" text-anchor="middle" x="450.0" y="40.0">Repos</text><text class="ts" text-anchor="middle" x="450.0" y="58.0">os próprios projetos</text>
<path class="ln" d="M160 44L200 44" marker-start="url(#m2)" marker-end="url(#m2)"/><path class="ln" d="M340 44L380 44" marker-start="url(#m2)" marker-end="url(#m2)"/>
</svg>
<figcaption>As tarefas nunca tocam nos checkouts principais; o hub acompanha todos os workspaces</figcaption>
</figure>

## O que se segue

Quero que mais do trabalho rotineiro corra sem supervisão, com os mesmos guardrails, e que mais passos mecânicos passem para modelos gratuitos sem perder qualidade. O pensamento e o juízo final ficam comigo, no [ciclo Aprender → Validar](/pt/ai) que sigo em todos os projetos.