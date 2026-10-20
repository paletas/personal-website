---
title: "Tone & Tome"
tagline: "Um pipeline automatizado que transforma histórias em vídeo narrado."
order: 5
kind: project
---

Um pipeline que lê um livro para perceber o seu tom e depois transforma cada capítulo num vídeo lento, sem palavras, para acompanhar a leitura.

## Problema

A leitura flui melhor com a atmosfera certa, e a maioria das listas de reprodução para ler ignora o livro que temos nas mãos. Queria uma banda sonora que acompanhasse a história: uma cena em movimento tranquila e música adequada para cada capítulo, com a duração aproximada do tempo de leitura desse capítulo. Fazer isso à mão leva horas por capítulo, pelo que a máquina tem de fazer quase tudo, sem nunca mostrar ou citar o livro.

## O que faz

Para cada capítulo, determina o cenário, a hora do dia, o tempo atmosférico e o sentimento, depois produz algumas cenas estáticas, dá-lhes vida suavemente com movimento e coloca por baixo música que combina com o tom. A duração resulta de uma estimativa do tempo de leitura. Os resultados são publicados num canal YouTube de bandas sonoras para leitura. Uma pessoa mantém-se no processo: escolho as imagens que gosto e aprovo cada vídeo finalizado antes de ele ficar público. Cada recurso, faixa e modelo é creditado, e um vídeo não pode ser montado enquanto faltar um crédito.

## Como é construído

Um pequeno orquestrador mantém a fila e o estado de cada capítulo como uma série de passos e mostra o progresso numa página web. O trabalho pesado de geração corre numa máquina separada com placa gráfica, e apenas quando essa máquina está ligada. Quando está desligada, esses passos apenas esperam enquanto o resto continua, para que nada falhe por causa de um computador a dormir. Modelos de linguagem planeiam as cenas, modelos de imagem desenham os lugares e o ffmpeg monta o vídeo. Tudo corre localmente, sem custos de execução.

<figure class="diagram">
<svg viewBox="0 0 540 90" role="img" aria-label="Pipeline: texto de origem, análise, geração, vídeo montado">
<defs><marker id="m1" viewBox="0 0 10 10" refX="8" refY="5" markerWidth="7" markerHeight="7" orient="auto-start-reverse"><path d="M0 0L10 5L0 10z" class="mk"/></marker></defs>
<rect class="b" x="20" y="14" width="110" height="60" rx="10"/><text class="t" text-anchor="middle" x="75.0" y="40.0">Texto-fonte</text><text class="ts" text-anchor="middle" x="75.0" y="58.0">só lido, oculto</text>
<path class="ln" d="M130 44L150 44" marker-end="url(#m1)"/>
<rect class="b" x="150" y="14" width="110" height="60" rx="10"/><text class="t" text-anchor="middle" x="205.0" y="40.0">Análise</text><text class="ts" text-anchor="middle" x="205.0" y="58.0">tom e cenas</text>
<path class="ln" d="M260 44L280 44" marker-end="url(#m1)"/>
<rect class="b" x="280" y="14" width="110" height="60" rx="10"/><text class="t" text-anchor="middle" x="335.0" y="40.0">Geração</text><text class="ts" text-anchor="middle" x="335.0" y="58.0">imagens e música</text>
<path class="ln" d="M390 44L410 44" marker-end="url(#m1)"/>
<rect class="ba" x="410" y="14" width="110" height="60" rx="10"/><text class="t" text-anchor="middle" x="465.0" y="40.0">Vídeo</text><text class="ts" text-anchor="middle" x="465.0" y="58.0">montado, revisto</text>
</svg>
<figcaption>O texto é apenas analisado; o resultado são imagens, movimento e música</figcaption>
</figure>

## O que se segue

O roteiro restante foca-se na escala e no polimento: mais fontes de música com verificação de licenças, montagem e sonoridade mais suaves, execuções em lote de um livro inteiro e uma forma mais delicada de acordar a máquina de geração. O primeiro livro completo é o teste real que ditará quanto da revisão manual pode ser dispensado em segurança.