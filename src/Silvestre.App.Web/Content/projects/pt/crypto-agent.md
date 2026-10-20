---
title: "crypto-agent"
tagline: "Uma ferramenta de linha de comandos para impostos sobre cripto."
order: 7
kind: project
---

Uma calculadora que transforma um conjunto de exportações de transações nos valores que uma declaração de cripto para o IRS português exige.

## Problema

A atividade em cripto espalhada por vários serviços deixa um rasto confuso: exportações em formatos diferentes, o mesmo movimento registado duas vezes, e entradas que por si só não fazem sentido. As regras fiscais exigem depois uma contabilidade precisa de custo de aquisição em tudo isto. As folhas de cálculo falham rapidamente, e um valor errado na declaração de IRS não é algo que queira descobrir mais tarde. Queria um processo repetível que pudesse executar a qualquer momento, inspecionar passo a passo, e em que confiasse porque cada número remonta às exportações originais.

## O que faz

Importa exportações de transações de diferentes fontes e coloca-as num formato comum. Remove depois duplicados e sinaliza registos estranhos, como origens em falta ou preços suspeitos, para que uma pessoa os analise em vez de a ferramenta adivinhar. Os ganhos são apurados pelo método "first in, first out" (FIFO) de custo de aquisição, como as regras portuguesas exigem. A saída final é o conjunto de valores que a declaração de IRS precisa, mais uma pré-visualização para conferir o resultado antes de submeter seja o que for. Nada sobre os dados sai da minha máquina, o que importa para algo tão pessoal.

## Como é construído

É uma aplicação de linha de comandos .NET com uma base de dados local. Um fluxo por etapas mantém cada preocupação separada: importação, limpeza, apuramento e relatório. As correções são escritas como regras explícitas e auditáveis e reexecutadas numa nova importação, para que todo o resultado possa ser reconstruído a partir das exportações originais sempre que uma regra muda. Cópias de segurança são feitas antes de qualquer alteração que escreva na base de dados, e scripts de wrapper tornam as rotinas comuns num só comando.

<figure class="diagram">
<svg viewBox="0 0 540 90" role="img" aria-label="fluxo do crypto-agent: importações, normalizar e desduplicar, apuramento FIFO, relatório">
<defs><marker id="m1" viewBox="0 0 10 10" refX="8" refY="5" markerWidth="7" markerHeight="7" orient="auto-start-reverse"><path d="M0 0L10 5L0 10z" class="mk"/></marker></defs>
<rect class="b" x="20" y="14" width="110" height="60" rx="10"/><text class="t" text-anchor="middle" x="75.0" y="40.0">Importações</text><text class="ts" text-anchor="middle" x="75.0" y="58.0">exportações</text>
<path class="ln" d="M130 44L150 44" marker-end="url(#m1)"/>
<rect class="b" x="150" y="14" width="110" height="60" rx="10"/><text class="t" text-anchor="middle" x="205.0" y="40.0">Normalizar</text><text class="ts" text-anchor="middle" x="205.0" y="58.0">limpar, sinalizar</text>
<path class="ln" d="M260 44L280 44" marker-end="url(#m1)"/>
<rect class="b" x="280" y="14" width="110" height="60" rx="10"/><text class="t" text-anchor="middle" x="335.0" y="40.0">Custo FIFO</text><text class="ts" text-anchor="middle" x="335.0" y="58.0">custo de aquisição</text>
<path class="ln" d="M390 44L410 44" marker-end="url(#m1)"/>
<rect class="ba" x="410" y="14" width="110" height="60" rx="10"/><text class="t" text-anchor="middle" x="465.0" y="40.0">Relatório</text><text class="ts" text-anchor="middle" x="465.0" y="58.0">valores para IRS</text>
</svg>
<figcaption>Exportações brutas na entrada, valores auditáveis na saída</figcaption>
</figure>

## O que se segue

Mais fontes de importação são o passo óbvio, pois cada novo serviço traz o seu formato. Depois virão melhores ferramentas de análise, para que registos sinalizados se resolvam mais depressa e a fundamentação de cada decisão seja mais fácil de reler mais tarde.
