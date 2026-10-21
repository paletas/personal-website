---
title: "PlanAhead"
tagline: "Um planeador de finanças pessoais para orçamento, poupança, impostos e investimentos."
order: 1
kind: project
---

As ferramentas financeiras costumam olhar para trás: registam o que foi gasto e deixam o planeamento para uma folha de cálculo. O PlanAhead parte da direção oposta. É um planeador de finanças pessoais para utilizadores portugueses, construído em torno da questão de como devem ser os próximos meses, e o registo existe para alimentar essa resposta.

## Problema

Os salários em Portugal têm as suas próprias regras de impostos e contribuições, e a maioria das aplicações de orçamento ignora-as ou obriga a uma solução manual. Queria um único sítio que entenda o salário líquido, os compromissos recorrentes e os objetivos de longo prazo, para que um plano feito hoje continue a valer daqui a alguns meses.

## O que faz

A aplicação cobre o ciclo financeiro do dia a dia e vai mais além.

- **Calculadoras públicas.** Salário (bruto para líquido segundo as regras locais), amortização antecipada e comparação de refinanciamento funcionam sem conta, e são a porta de entrada.
- **Acompanhamento.** Contas, transações, categorias, transferências entre contas e receitas e despesas recorrentes compõem uma imagem do que entra e sai.
- **Planeamento.** Orçamentos e fundos de reserva separam dinheiro para custos futuros conhecidos: um fundo de reserva calcula o valor mensal de uma fatura anual ou semestral a partir das próprias despesas recorrentes.
- **Crédito habitação e património.** Contas de crédito com projeções e uma visão de património líquido que reúne tudo.
- **Investimentos.** Posições, compras e vendas, splits de ações, lotes de custo de aquisição e uma estimativa de mais-valias, com preços e taxas de câmbio vindos de várias fontes de dados de mercado que se apoiam umas às outras.
- **Impostos.** Um estimador da declaração anual de impostos que explica o resultado escalão a escalão e compara cenários. Os rendimentos de trabalho estão cobertos para 2025; as outras categorias estão no roteiro, e o desenho permite que cada país acrescente as suas regras.
- **Importação.** Importação em massa a partir de ficheiros genéricos, mais conversores que transformam o extrato de cada banco ou corretora nesse mesmo formato, para que todas as fontes passem por um único circuito validado. Uma sincronização bancária opcional pode alimentar transações automaticamente.
- **Duas línguas.** Todo o texto visível ao utilizador existe em português e inglês.

## Como é construído

O PlanAhead é uma aplicação em camadas sobre .NET 10. Um cliente web renderizado no servidor (Razor Pages com HTMX) fala apenas com uma API REST sem estado, nunca com a base de dados diretamente. A API entrega o trabalho a uma camada de handlers que contêm as regras de negócio, independentes de como o pedido chega, e esses handlers leem e escrevem em PostgreSQL através de uma camada de dados. Manter as regras numa camada neutra em termos de transporte significa que a mesma lógica serve o cliente web e qualquer cliente futuro. O Aspire liga as peças em desenvolvimento e nos testes.

<figure class="diagram">
<svg viewBox="0 0 520 330" role="img" aria-label="Camadas do PlanAhead: um cliente web chama uma API, que chama handlers, que usam armazenamento; sincronização bancária é uma entrada opcional para os handlers">
<defs><marker id="m1" viewBox="0 0 10 10" refX="8" refY="5" markerWidth="7" markerHeight="7" orient="auto-start-reverse"><path d="M0 0L10 5L0 10z" class="mk"/></marker></defs><rect class="b" x="20" y="14" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="120.0" y="38.0">Cliente web</text><text class="ts" text-anchor="middle" x="120.0" y="56.0">páginas renderizadas no servidor</text><rect class="b" x="20" y="96" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="120.0" y="120.0">API</text><text class="ts" text-anchor="middle" x="120.0" y="138.0">backend sem estado</text><rect class="b" x="20" y="178" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="120.0" y="202.0">Handlers</text><text class="ts" text-anchor="middle" x="120.0" y="220.0">lógica de negócio</text><rect class="b" x="20" y="260" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="120.0" y="284.0">Armazenamento</text><text class="ts" text-anchor="middle" x="120.0" y="302.0">base de dados relacional</text><rect class="bd" x="300" y="178" width="200" height="52" rx="10"/><text class="t" text-anchor="middle" x="400.0" y="202.0">Sincronização bancária</text><text class="ts" text-anchor="middle" x="400.0" y="220.0">entrada opcional</text><path class="ln" d="M120 66L120 94" marker-end="url(#m1)"/><path class="ln" d="M120 148L120 176" marker-end="url(#m1)"/><path class="ln" d="M120 230L120 258" marker-end="url(#m1)"/><path class="ln" d="M300 204L222 204" marker-end="url(#m1)"/>
</svg>
<figcaption>os pedidos descem pelas camadas; a sincronização bancária é uma entrada opcional</figcaption>
</figure>

## Escolhas de engenharia

- **CQRS leve, feito em casa.** Comandos e consultas passam por um pequeno mediador próprio em vez de uma biblioteca de terceiros, o que mantém o circuito simples e totalmente nosso para alterar.
- **Resultados, não exceções.** As falhas esperadas, como uma regra não cumprida, voltam como resultados explícitos de operação em vez de exceções, e os handlers lêem-se como uma história clara de sucesso ou falha.
- **Dinheiro é sempre decimal.** Todos os valores usam aritmética decimal exata, nunca vírgula flutuante.
- **Isolamento por utilizador por omissão.** Cada consulta é limitada ao utilizador autenticado por filtros globais, e um teste que entra como dois utilizadores diferentes verifica que um nunca vê os dados do outro.
- **HTMX primeiro.** Pequenas atualizações dirigidas pelo servidor mantêm as páginas rápidas sem uma framework pesada no cliente.

## Testes

Testes de ponta a ponta ao nível do browser percorrem a aplicação real sobre uma base de dados nova e descartável, com a fronteira dos dados de mercado simulada para que os resultados sejam repetíveis. Verificam valores calculados, não apenas que a página abre, e já apanharam erros reais do produto. Uma funcionalidade só é dada como concluída quando tem cobertura de ponta a ponta.

## Como foi crescendo

O PlanAhead começou em 2024 como um projeto escrito à mão, antes de eu trabalhar com agentes de IA. Desde então a forma de trabalhar mudou. Hoje o repositório inclui instruções para agentes e algumas skills do projeto para tarefas repetíveis, como acrescentar um importador de banco. Cada funcionalidade tem um pequeno documento de desenho que explica o que faz e porquê; os agentes leem-no antes de começar e atualizam-no no fim. A arquitetura e os testes continuam a ser meus de definir, e os agentes trabalham dentro deles. O ritmo nota-se: a maior parte dos commits do projeto foi em 2026.
## O que se segue

O roteiro é sobretudo sobre profundidade e não sobre largura: categorização mais inteligente das transações, períodos de orçamento mais flexíveis com alertas, relatórios mais ricos, mais categorias de rendimento no estimador de impostos e opções de autenticação mais fortes. A visão a mais longo prazo é suportar outros países, cada um com o seu quadro fiscal.
