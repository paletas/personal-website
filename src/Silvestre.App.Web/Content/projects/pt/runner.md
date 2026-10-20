---
title: "Runner"
tagline: "Um executor isolado para tarefas de automação repetíveis."
order: 6
kind: project
---

Um pequeno controlador que executa tarefas de agentes agendadas e a pedido sem supervisão, dentro de um ambiente isolado, e informa como correram.

## Problema

Os agentes são mais úteis quando funcionam enquanto não estou a ver, e é exatamente quando são mais preocupantes. Uma tarefa que corre durante a noite precisa de um limite ao que pode tocar, uma forma de manter segredos fora do que imprime, e um registo do que aconteceu. Sem isso, a automação sem supervisão é ou demasiado arriscada para agendar ou demasiado opaca para confiar, acabei por executar tudo à mão e a perder o propósito.

## O que faz

Cada tarefa corre sob um perfil com nome que descreve o que o agente pode fazer e o que lhe é dado. As tarefas podem ser lançadas por agendamento ou quando peço. Enquanto uma tarefa corre, a sua saída é limpa para que credenciais nunca cheguem a registos ou mensagens. Quando termina, recebo uma notificação, e o resultado vai para um histórico de execuções com telemetria básica, para que possa ver o que correu, quanto tempo levou e se se comportou.

## Como é construído

É um programa Python compacto com uma interface de linha de comandos e alguns módulos focados: configuração, perfis, uma pequena base de dados para histórico, remoção de segredos, notificações e telemetria. O próprio agente corre numa imagem de contentor que é construída e publicada por integração contínua, para que o controlador se mantenha simples e o ambiente isolado seja reproduzível. Onde é implementado, e as credenciais de que precisa, são geridos com o resto da configuração do meu laboratório em vez de neste projeto, e um conjunto de testes unitários protege o controlador.

<figure class="diagram">
<svg viewBox="0 0 540 90" role="img" aria-label="Fluxo do Runner: agendador ou linha de comandos, execução isolada, remoção de segredos, notificação e histórico">
<defs><marker id="m1" viewBox="0 0 10 10" refX="8" refY="5" markerWidth="7" markerHeight="7" orient="auto-start-reverse"><path d="M0 0L10 5L0 10z" class="mk"/></marker></defs>
<rect class="b" x="20" y="14" width="110" height="60" rx="10"/><text class="t" text-anchor="middle" x="75.0" y="40.0">Agendador / CLI</text><text class="ts" text-anchor="middle" x="75.0" y="58.0">iniciar uma tarefa</text>
<path class="ln" d="M130 44L150 44" marker-end="url(#m1)"/>
<rect class="b" x="150" y="14" width="110" height="60" rx="10"/><text class="t" text-anchor="middle" x="205.0" y="40.0">Ambiente isolado</text><text class="ts" text-anchor="middle" x="205.0" y="58.0">execução por perfil</text>
<path class="ln" d="M260 44L280 44" marker-end="url(#m1)"/>
<rect class="b" x="280" y="14" width="110" height="60" rx="10"/><text class="t" text-anchor="middle" x="335.0" y="40.0">Remoção de segredos</text><text class="ts" text-anchor="middle" x="335.0" y="58.0">segredos removidos</text>
<path class="ln" d="M390 44L410 44" marker-end="url(#m1)"/>
<rect class="ba" x="410" y="14" width="110" height="60" rx="10"/><text class="t" text-anchor="middle" x="465.0" y="40.0">Notificar + histórico</text><text class="ts" text-anchor="middle" x="465.0" y="58.0">resultado e registo</text>
</svg>
<figcaption>Cada execução é delimitada, limpa e registada</figcaption>
</figure>

## O que se segue

Quero perfis mais ricos para diferentes tipos de trabalho, melhores resumos nas notificações, e telemetria mais útil para detetar tarefas que estão a desviar-se ou a ficar mais lentas. O runner já faz uma parte das operações de rotina descritas em [como o laboratório é operado com agentes](/pt/projects/workflow), e o objetivo é alargar isso com cuidado.