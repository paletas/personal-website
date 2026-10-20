---
title: "HomeLab"
tagline: "Infraestrutura como código para um laboratório doméstico."
order: 4
kind: project
---

O laboratório é a maquinaria silenciosa por detrás dos meus outros projetos: uma pequena nuvem privada em casa, descrita como código para que possa ser compreendida, reparada e reconstruída.

## Problema

Um rack de servidores doméstico tende a tornar-se folclore. As coisas funcionam por causa de um comando digitado uma vez, uma configuração que ninguém documentou, um certificado que se renova sozinho até deixar de o fazer. Queria que o laboratório se comportasse como um sistema de produção: documentado, atualizado segundo um calendário e ruidoso quando algo está errado. Reconstruir após uma falha deve ser uma tarde aborrecida, não um projeto de arqueologia.

## O que faz

Aloja os serviços de que dependo no dia a dia, incluindo as minhas próprias aplicações. Um cluster Proxmox executa as cargas de trabalho, um NAS armazena ficheiros e algumas aplicações, e uma mesh VPN dá acesso privado a partir de qualquer lugar. Um gestor de segredos mantém as credenciais fora do repositório, uma pilha de observabilidade recolhe métricas e lança alertas, e o n8n e o Home Assistant tratam da automação em casa e no próprio laboratório. A aplicação de patches decorre segundo um calendário, com as máquinas de maior risco tratadas com mais cuidado do que as de rotina.

## Como é construído

Tudo é gerido como código com Ansible: um inventário organiza as máquinas em grupos consoante a segurança de as atualizar, e as roles colocam cada serviço no seu estado documentado. Os playbooks são executados a partir de um ambiente de controlo Linux, e um executor agendado faz o trabalho semanal de rotina por conta própria. A documentação escrita mantém-se junto ao código como contraparte legível por humanos. O que não pode ser automatizado, como criar um novo guest, é descrito num runbook.

<figure class="diagram">
<svg viewBox="0 0 520 250" role="img" aria-label="Camadas do HomeLab: Ansible no topo gere o cluster doméstico, armazenamento, mesh VPN, segredos, observabilidade e camadas de automação">
<defs><marker id="m1" viewBox="0 0 10 10" refX="8" refY="5" markerWidth="7" markerHeight="7" orient="auto-start-reverse"><path d="M0 0L10 5L0 10z" class="mk"/></marker></defs><rect class="ba" x="20" y="14" width="480" height="50" rx="10"/><text class="t" text-anchor="middle" x="260.0" y="37.0">Ansible</text><text class="ts" text-anchor="middle" x="260.0" y="55.0">o laboratório descrito e gerido como código</text><rect class="b" x="20" y="104" width="150" height="60" rx="10"/><text class="t" text-anchor="middle" x="95.0" y="132.0">Cluster doméstico</text><text class="ts" text-anchor="middle" x="95.0" y="150.0">cargas de trabalho virtualizadas</text><rect class="b" x="185" y="104" width="150" height="60" rx="10"/><text class="t" text-anchor="middle" x="260.0" y="132.0">Armazenamento</text><text class="ts" text-anchor="middle" x="260.0" y="150.0">um NAS para ficheiros e aplicações</text><rect class="b" x="350" y="104" width="150" height="60" rx="10"/><text class="t" text-anchor="middle" x="425.0" y="132.0">Mesh / VPN</text><text class="ts" text-anchor="middle" x="425.0" y="150.0">acesso privado de qualquer lugar</text><rect class="b" x="20" y="180" width="150" height="60" rx="10"/><text class="t" text-anchor="middle" x="95.0" y="208.0">Segredos</text><text class="ts" text-anchor="middle" x="95.0" y="226.0">um gestor central de segredos</text><rect class="b" x="185" y="180" width="150" height="60" rx="10"/><text class="t" text-anchor="middle" x="260.0" y="208.0">Observabilidade</text><text class="ts" text-anchor="middle" x="260.0" y="226.0">métricas, dashboards, alertas</text><rect class="b" x="350" y="180" width="150" height="60" rx="10"/><text class="t" text-anchor="middle" x="425.0" y="208.0">Automação</text><text class="ts" text-anchor="middle" x="425.0" y="226.0">n8n e Home Assistant</text><path class="ln" d="M260 64L260 102" marker-end="url(#m1)"/>
</svg>
<figcaption>O Ansible está acima de todas as camadas e é a única forma de fazer alterações</figcaption>
</figure>

## O que se segue

O objetivo é reduzir a superfície manual: mais da aplicação de patches e do tratamento de alertas a passarem a execuções automáticas, e menos passos pontuais nos runbooks. Parte disso é permitir que agentes façam operações de rotina sob supervisão, o que é abordado em [como o laboratório é operado com agentes](/pt/projects/workflow).