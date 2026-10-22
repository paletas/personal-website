---
title: "PlanAhead"
tagline: "Um planeador de finanças pessoais para orçamento, poupança, impostos e investimentos."
order: 1
kind: project
---

O PlanAhead é um planeador de finanças pessoais para utilizadores portugueses, construído em torno da questão de como devem ser os próximos meses, e não apenas do que foi gasto. Converte o salário bruto em líquido segundo as regras locais, acompanha contas, itens recorrentes, orçamentos e fundos de poupança, e mostra para onde as coisas caminham. É uma aplicação .NET em camadas, com as regras de negócio separadas do cliente web.

<figure class="diagram">
<svg viewBox="0 0 520 330" role="img" aria-label="Camadas do PlanAhead: um cliente web chama uma API, que chama handlers, que usam armazenamento; sincronização bancária é uma entrada opcional para os handlers">
<defs><marker id="m1" viewBox="0 0 10 10" refX="8" refY="5" markerWidth="7" markerHeight="7" orient="auto-start-reverse"><path d="M0 0L10 5L0 10z" class="mk"/></marker></defs><rect class="b" x="20" y="14" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="120.0" y="38.0">Cliente web</text><text class="ts" text-anchor="middle" x="120.0" y="56.0">páginas renderizadas no servidor</text><rect class="b" x="20" y="96" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="120.0" y="120.0">API</text><text class="ts" text-anchor="middle" x="120.0" y="138.0">backend sem estado</text><rect class="b" x="20" y="178" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="120.0" y="202.0">Handlers</text><text class="ts" text-anchor="middle" x="120.0" y="220.0">lógica de negócio</text><rect class="b" x="20" y="260" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="120.0" y="284.0">Armazenamento</text><text class="ts" text-anchor="middle" x="120.0" y="302.0">base de dados relacional</text><rect class="bd" x="300" y="178" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="400.0" y="202.0">Sincronização bancária</text><text class="ts" text-anchor="middle" x="400.0" y="220.0">entrada opcional</text><path class="ln" d="M120 66L120 94" marker-end="url(#m1)"/><path class="ln" d="M120 148L120 176" marker-end="url(#m1)"/><path class="ln" d="M120 230L120 258" marker-end="url(#m1)"/><path class="ln" d="M300 204L222 204" marker-end="url(#m1)"/>
</svg>
<figcaption>os pedidos descem pelas camadas; a sincronização bancária é uma entrada opcional</figcaption>
</figure>
