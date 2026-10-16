<!-- head -->
# Eu oriento. Os agentes {{escrevem o código}}.

Eu oriento, o Claude aprende e compreende, e iteramos em conjunto sobre um plano escrito. É aí que está a maior parte do trabalho. Depois o Claude implementa e validamos o resultado em conjunto.

<!-- loop | O ciclo -->
### Aprender
who: Claude

Lê o repositório, a documentação e o estado atual, e volta com factos e a origem de cada um. Sem alterações, sem suposições.

### Compreender
who: Claude + eu

Diz-me como interpretou o pedido e pergunta o que o código não consegue responder: âmbito, compromissos, o que significa “concluído”. Eu respondo. Nada avança enquanto houver uma pergunta em aberto.

### Planear, em conjunto
who: onde está a maior parte do trabalho

Iteramos sobre um plano escrito em linguagem simples: os lotes, as decisões e os cenários que vão provar que funciona. Leio-o, contesto, altero. Nada é construído até eu aprovar essa versão exata.

### Implementar
who: Claude

Agora constrói, com modelos mais baratos a tratar dos passos mecânicos. Se a realidade não corresponder ao plano, interrompe e avisa, em vez de improvisar um desenho.

### Validar, em conjunto
who: agente independente + eu

Um agente separado executa os cenários do plano, sem os alterar, e mostra evidências. Eu vejo-as e decido se está certo.

<!-- prototype | Prototipar depressa -->
## Mostrar, não descrever.

Antes de aprovar um plano, quero ver a coisa. O Claude transforma uma ideia num protótipo clicável em minutos, eu reajo, e voltamos a tentar. Ver uma versão em bruto ensina-nos mais do que uma página de requisitos, e alterá-la custa quase nada.

```
# este site, antes de qualquer código ser aprovado
mockup v1   direção + tema
mockup v2   a minha fotografia, enquadrada
mockup v3   stack: juntar ferramentas de IA
mockup v4   WISC-III na navegação
mockup v5   todas as páginas, clicáveis
→ só depois o plano é aprovado
```

<!-- behaviour | Comportamento primeiro -->
## O BDD é como combinamos, e como eu verifico.

Cada critério de aceitação torna-se um cenário em linguagem simples, no estilo Given / When / Then do BDD, antes de existir uma linha de código. É o contrato entre mim e os agentes: o que a coisa tem de fazer, descrito de fora, em palavras que consigo ler.

Os cenários não substituem os testes. Os agentes continuam a escrever testes unitários, de integração e de ponta a ponta, porque esses apanham o que uma frase não apanha. O BDD é a camada que me pertence: leio os cenários e vejo-os passar ao lado do resto da bateria de testes.

```
# do plano deste mesmo site
Cenário: Os links antigos do blogue continuam a funcionar
  Dado que um leitor abre o URL de um artigo antigo do blogue
  Quando o pedido chega ao novo site
  Então é reencaminhado para a nova página
  E   a resposta é um redirecionamento permanente

Cenário: Funciona num telemóvel
  Dado um ecrã com 375px de largura
  Quando abro qualquer página
  Então nada desliza na horizontal

─ validação, lado a lado ─
✓ cenários       o que eu leio e aprovo
✓ unitários      lógica, casos limite
✓ integração     partes a funcionar em conjunto
✓ ponta a ponta  um browser real, um fluxo real
```

<!-- unbounded | Sem fronteiras -->
## Se consigo *ler* o comportamento, consigo *usá-lo*. A linguagem e a tecnologia passam a ser detalhes.

Os cenários dizem o que o sistema faz, não como é construído. Por isso a mesma forma de trabalhar serve quer a resposta seja C#, Go, TypeScript ou algo em que nunca toquei. Não preciso de conhecer o idioma para saber que o resultado está certo, porque valido o comportamento, não a sintaxe.

<!-- benefits | O que isto me dá -->
### O discernimento continua a ser meu

Decido o que se constrói e quando está concluído. Os agentes nunca decidem nenhuma das duas coisas.

### Os erros saem baratos cedo

A maior parte do esforço vai para o plano, onde uma curva errada custa uma frase, não uma reescrita.

### Provas, não promessas

“Concluído” é um cenário que passa. Um agente separado verifica-o e eu vejo as evidências.

<!-- under-the-hood | Por baixo do capô -->
Os modelos mais fortes (Opus) tratam de pensar e planear. Os mais pequenos e baratos fazem o trabalho repetitivo, e uma verificação falhada é o que faz um passo subir de nível. O trabalho acontece em git worktrees isoladas, chega através de pull requests e a decisão de integrar é minha. Os segredos nunca entram nos prompts.

<!-- in-practice | Na prática -->
## Este site foi construído assim.

A reformulação que está a ver passou pelo mesmo ciclo: cada pergunta feita e respondida, um plano iterado até eu o aprovar, cenários escritos antes do código e uma barreira de desenho em que aprovei o aspeto antes de o resto ser construído.

<!-- contact -->
## Quer saber como isto funcionaria na sua equipa?

Terei gosto em falar sobre isso.

cta: Entrar em contacto →
