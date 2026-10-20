---
title: "PlanAhead"
tagline: "Uma aplicação de planeamento para organizar a semana."
order: 1
kind: project
---

As ferramentas financeiras costumam olhar para trás: registam o que foi gasto e deixam o planeamento para uma folha de cálculo. O PlanAhead parte da direção oposta. É um planeador de finanças pessoais para utilizadores portugueses, construído em torno da questão de como devem ser os próximos meses, e o registo existe para alimentar essa resposta.

## Problema

Os salários em Portugal têm as suas próprias regras de impostos e contribuições, e a maioria das aplicações de orçamento ignora-as ou obriga a uma solução manual. Queria um único sítio que entenda o salário líquido, os compromissos recorrentes e os objetivos de longo prazo, para que um plano feito hoje continue a valer daqui a alguns meses.

## O que faz

A aplicação cobre o ciclo financeiro do dia a dia. Uma calculadora de salário transforma o vencimento bruto em líquido segundo as regras locais. Contas, transações e itens recorrentes compõem uma imagem do que entra e sai, e orçamentos e fundos de reserva reservam dinheiro para custos futuros conhecidos. O acompanhamento de crédito hipotecário e de ativos adiciona os itens maiores e mais lentos, e os relatórios reúnem tudo numa visão de para onde as coisas caminham. Extratos podem ser importados em massa, e uma sincronização bancária opcional pode alimentar transações automaticamente.

## Como é construído

O PlanAhead é uma aplicação .NET em camadas. Um cliente web renderizado no servidor fala apenas com uma API sem estado, nunca com a base de dados diretamente. A API entrega o trabalho a uma camada de handlers que contêm as regras de negócio, independentes de como o pedido chega, e esses handlers leem e escrevem numa base de dados relacional através de uma camada de dados. Manter as regras numa camada neutra em termos de transporte significa que a mesma lógica serve o cliente web e qualquer cliente futuro. As páginas favorecem pequenas atualizações dirigidas pelo servidor em vez de código pesado no lado do cliente, e toda a solução é coberta por testes de ponta a ponta ao nível do browser.

<figure class="diagram">
<svg viewBox="0 0 520 330" role="img" aria-label="Camadas do PlanAhead: um cliente web chama uma API, que chama handlers, que usam armazenamento; sincronização bancária é uma entrada opcional para os handlers">
<defs><marker id="m1" viewBox="0 0 10 10" refX="8" refY="5" markerWidth="7" markerHeight="7" orient="auto-start-reverse"><path d="M0 0L10 5L0 10z" class="mk"/></marker></defs><rect class="b" x="20" y="14" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="120.0" y="38.0">Cliente web</text><text class="ts" text-anchor="middle" x="120.0" y="56.0">páginas renderizadas no servidor</text><rect class="b" x="20" y="96" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="120.0" y="120.0">API</text><text class="ts" text-anchor="middle" x="120.0" y="138.0">backend sem estado</text><rect class="b" x="20" y="178" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="120.0" y="202.0">Handlers</text><text class="ts" text-anchor="middle" x="120.0" y="220.0">lógica de negócio</text><rect class="b" x="20" y="260" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="120.0" y="284.0">Armazenamento</text><text class="ts" text-anchor="middle" x="120.0" y="302.0">base de dados relacional</text><rect class="bd" x="300" y="178" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="400.0" y="202.0">Sincronização bancária</text><text class="ts" text-anchor="middle" x="400.0" y="220.0">entrada opcional</text><path class="ln" d="M120 66L120 94" marker-end="url(#m1)"/><path class="ln" d="M120 148L120 176" marker-end="url(#m1)"/><path class="ln" d="M120 230L120 258" marker-end="url(#m1)"/><path class="ln" d="M300 204L222 204" marker-end="url(#m1)"/>
</svg>
<figcaption>os pedidos descem pelas camadas; a sincronização bancária é uma entrada opcional</figcaption>
</figure>

## O que se segue

O roteiro foca-se mais em profundidade do que em amplitude: categorização mais inteligente de transações, períodos de orçamento mais flexíveis com alertas, relatórios mais ricos, e opções de autenticação mais fortes. A visão de longo prazo é o suporte para outros países, cada um com o seu próprio enquadramento fiscal.
