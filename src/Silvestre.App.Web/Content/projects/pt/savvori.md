---
title: "Savvori"
tagline: "Comparação de preços de supermercado e listas de compras."
order: 2
kind: project
---

O Savvori é uma ferramenta de comparação de preços de supermercado e lista de compras para famílias portuguesas. Cria uma lista e ele determina onde essa lista fica mais barata.

## Problema

O mesmo cesto custa quantias notavelmente diferentes dependendo de onde é comprado, mas comparar é tedioso. Cada cadeia nomeia, dimensiona e categoriza os seus produtos de forma diferente, pelo que uma comparação direta implica muito esforço a decifrar rótulos. Uma lista de compras que conhece os preços elimina esse trabalho.

## O que faz

O Savvori mantém um catálogo de produtos com os seus preços nas principais cadeias de supermercados, organizados numa taxonomia comum. Adiciona itens a uma lista e ele mostra o custo em cada cadeia e sugere a forma mais barata de completar a lista toda. A parte mais difícil é identificar que dois produtos com rótulos diferentes são a mesma coisa, e é aqui que entra o trabalho de correspondência e categorização. Também alimenta a lista de compras no [HomeOS](/pt/projects/homeos), para que um plano de refeições possa terminar com um total estimado.

## Como é construído

É uma aplicação .NET orquestrada localmente com Aspire. Uma aplicação web renderizada no servidor fica à frente de uma API web que gere as listas, a lógica de comparação e o otimizador de cesto. Ambas leem de uma base de dados embutida. Um pipeline separado recolhe preços de catálogos públicos e corresponde cada produto na taxonomia, usando um modelo de linguagem alojado localmente para ajudar nos casos ambíguos. Não há início de sessão, porque foi concebido para correr como ferramenta de utilizador único numa rede privada. Os testes cobrem a API, a camada web e fluxos completos no navegador.

<figure class="diagram">
<svg viewBox="0 0 520 250" role="img" aria-label="Arquitetura do Savvori: uma aplicação web chama uma API web apoiada por uma base de dados; um pipeline de correspondência alimentado por catálogos públicos escreve na mesma base de dados">
<defs><marker id="m1" viewBox="0 0 10 10" refX="8" refY="5" markerWidth="7" markerHeight="7" orient="auto-start-reverse"><path d="M0 0L10 5L0 10z" class="mk"/></marker></defs><rect class="b" x="20" y="14" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="120.0" y="38.0">Aplicação web</text><text class="ts" text-anchor="middle" x="120.0" y="56.0">listas de compras e preços</text><rect class="b" x="20" y="96" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="120.0" y="120.0">API web</text><text class="ts" text-anchor="middle" x="120.0" y="138.0">listas, comparação, otimizador</text><rect class="b" x="20" y="178" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="120.0" y="202.0">Base de dados</text><text class="ts" text-anchor="middle" x="120.0" y="220.0">produtos, preços, taxonomia</text><rect class="s1" x="300" y="96" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="400.0" y="120.0">Pipeline de correspondência</text><text class="ts" text-anchor="middle" x="400.0" y="138.0">recolher, corresponder, categorizar</text><rect class="bd" x="300" y="14" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="400.0" y="38.0">Fontes de preços</text><text class="ts" text-anchor="middle" x="400.0" y="56.0">catálogos públicos de supermercado</text><path class="ln" d="M120 66L120 94" marker-end="url(#m1)"/><path class="ln" d="M120 148L120 176" marker-end="url(#m1)"/><path class="ln" d="M400 66L400 94" marker-end="url(#m1)"/><path class="ln" d="M300 122L222 122" marker-end="url(#m1)"/><path class="ln" d="M400 148L222 196" marker-end="url(#m1)"/>
</svg>
<figcaption>o pipeline mantém o catálogo atualizado; a API apenas lê e otimiza</figcaption>
</figure>

## O que se segue

O foco atual é a correspondência assistida por modelo: gerar correspondências candidatas, classificá-las por confiança e encaminhar as incertas para uma fila de revisão em vez de adivinhar. Segue-se uma segunda versão mais limpa da taxonomia de categorias, informada pelo que a primeira errou.
