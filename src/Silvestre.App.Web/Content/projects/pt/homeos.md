---
title: "HomeOS"
tagline: "Uma aplicação web para gerir a casa: receitas, despensa e refeições."
order: 3
kind: project
---

O HomeOS é uma pequena aplicação web auto-hospedada que reúne a gestão quotidiana de um lar num só lugar.

## Problema

As receitas vivem numa aplicação, a lista de compras noutra, e a questão do que está realmente na despensa não vive na cabeça de ninguém. Cada ferramenta funciona bem sozinha, mas nenhuma conhece as outras, pelo que o mesmo ingrediente é introduzido três vezes. Queria uma ferramenta doméstica minha para executar, que mantém os seus dados em casa, e suficientemente simples para compreender de ponta a ponta.

## O que faz

As peças partilham um catálogo de ingredientes. As receitas podem ser navegadas, pesquisadas, ajustadas para um número de doses e seguidas passo a passo num modo de cozinhar. A despensa controla o que está em stock, e um plano semanal coloca as receitas no calendário. A partir daí, os ingredientes de uma receita vão para a lista de compras num clique, opcionalmente com estimativas de preço por loja do [Savvori](/pt/projects/savvori). Um painel une os módulos, e a interface funciona em inglês e português.

## Como é construído

Um único projeto web .NET serve tanto as páginas renderizadas no servidor como uma API JSON, apoiado por uma base de dados incorporada, e funciona confortavelmente numa única máquina pequena. A interatividade vem de atualizações de página controladas pelo servidor em vez de um framework do lado do cliente, e todos os recursos de front-end vêm incluídos com a aplicação para que nada carregue de terceiros. É testado com testes unitários e testes de componentes ao estilo de comportamento, e é distribuído como imagem de contentor.

<figure class="diagram">
<svg viewBox="0 0 540 270" role="img" aria-label="Arquitetura do HomeOS: uma única aplicação web e API aloja módulos de receitas, despensa, plano de refeições e compras sobre uma base de dados local, implementada como contentor">
<defs><marker id="m1" viewBox="0 0 10 10" refX="8" refY="5" markerWidth="7" markerHeight="7" orient="auto-start-reverse"><path d="M0 0L10 5L0 10z" class="mk"/></marker></defs><rect class="b" x="20" y="14" width="300" height="52" rx="10"/><text class="t" text-anchor="middle" x="170.0" y="38.0">Aplicação web e API</text><text class="ts" text-anchor="middle" x="170.0" y="56.0">um serviço, páginas mais JSON</text><rect class="b" x="20" y="106" width="115" height="50" rx="10"/><text class="t" text-anchor="middle" x="77.5" y="129.0">Receitas</text><text class="ts" text-anchor="middle" x="77.5" y="147.0">módulo</text><rect class="b" x="145" y="106" width="115" height="50" rx="10"/><text class="t" text-anchor="middle" x="202.5" y="129.0">Despensa</text><text class="ts" text-anchor="middle" x="202.5" y="147.0">módulo</text><rect class="b" x="270" y="106" width="115" height="50" rx="10"/><text class="t" text-anchor="middle" x="327.5" y="129.0">Plano de refeições</text><text class="ts" text-anchor="middle" x="327.5" y="147.0">módulo</text><rect class="b" x="395" y="106" width="115" height="50" rx="10"/><text class="t" text-anchor="middle" x="452.5" y="129.0">Compras</text><text class="ts" text-anchor="middle" x="452.5" y="147.0">módulo</text><rect class="b" x="20" y="196" width="300" height="52" rx="10"/><text class="t" text-anchor="middle" x="170.0" y="220.0">Base de dados local</text><text class="ts" text-anchor="middle" x="170.0" y="238.0">incorporada, ficheiro único</text><rect class="bd" x="380" y="14" width="130" height="52" rx="10"/><text class="t" text-anchor="middle" x="445.0" y="38.0">Contentor</text><text class="ts" text-anchor="middle" x="445.0" y="56.0">uma imagem implementável</text><path class="ln" d="M77 66L77 104" marker-end="url(#m1)"/><path class="ln" d="M202 66L202 104" marker-end="url(#m1)"/><path class="ln" d="M327 66L327 104" marker-end="url(#m1)"/><path class="ln" d="M452 66L452 104" marker-end="url(#m1)"/><path class="ln" d="M170 156L170 194" marker-end="url(#m1)"/>
</svg>
<figcaption>um serviço, vários módulos, uma base de dados local</figcaption>
</figure>

## O que se segue

O início de sessão é a lacuna óbvia, pois por agora assume uma rede de confiança. Para além disso, o plano são ligações mais profundas entre os módulos, como a despensa aparar automaticamente a lista de compras, e uma utilização mais fluida num telemóvel na cozinha, onde se passa a maior parte do tempo do modo de cozinhar. Ligações de preços mais apertadas ao Savvori também estão na lista.
