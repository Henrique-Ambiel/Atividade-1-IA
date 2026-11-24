# NPC Raycast Movement — Unity 🎮🔦

<p align="center">
  <img src="https://img.shields.io/static/v1?label=Engine&message=Unity%206&color=black&style=for-the-badge&logo=unity"/>
  <img src="https://img.shields.io/static/v1?label=Linguagem&message=C%23&color=blue&style=for-the-badge&logo=csharp"/>
  <img src="https://img.shields.io/static/v1?label=Categoria&message=Game%20Development&color=orange&style=for-the-badge"/>
  <img src="https://img.shields.io/static/v1?label=Status&message=Conclu%C3%ADdo&color=green&style=for-the-badge"/>
</p>

> Status do Projeto: ✔️ Concluído

### Tópicos

:small_blue_diamond: [Descrição do Projeto](#descrição-do-projeto)

:small_blue_diamond: [Funcionalidades](#funcionalidades)

:small_blue_diamond: [Funcionamento da Mecânica](#funcionamento-da-mecânica)

:small_blue_diamond: [Layout e Demonstração](#layout-e-demonstração)

:small_blue_diamond: [Pré-requisitos](#pré-requisitos)

:small_blue_diamond: [Como Executar](#como-rodar-a-aplicação-arrow_forward)

:small_blue_diamond: [Tecnologias Utilizadas](#tecnologias-linguagens-e-ferramentas)

:small_blue_diamond: [Objetivo Acadêmico](#objetivo-acadêmico)

---

## Descrição do Projeto

NPC Raycast Movement é um projeto desenvolvido na Unity utilizando C#, com o objetivo de implementar um sistema de movimentação para NPCs (*Non-Playable Characters*) em ambientes delimitados.

A mecânica utiliza Raycasting para detectar obstáculos durante o deslocamento do personagem, permitindo identificar situações em que é necessário inverter sua direção de movimentação por meio de um *flip*.

O projeto conta com duas cenas que demonstram a aplicação do mesmo conceito em diferentes situações.

## Funcionalidades

:heavy_check_mark: Movimentação automática de NPCs em espaços delimitados.

:heavy_check_mark: Detecção de obstáculos utilizando Raycast.

:heavy_check_mark: Identificação de colisões e limites de movimentação.

:heavy_check_mark: Inversão automática da direção do NPC (*Flip*).

:heavy_check_mark: Demonstração da mecânica em duas cenas diferentes.

## Funcionamento da Mecânica

O sistema de movimentação utiliza Raycasting para identificar obstáculos à frente do NPC e determinar quando sua direção deve ser alterada.

O funcionamento ocorre em três etapas:

1. **Movimentação:** o NPC percorre automaticamente um trecho delimitado do ambiente.
2. **Detecção:** um Raycast é projetado na direção do movimento para identificar possíveis obstáculos.
3. **Inversão de direção:** ao detectar um obstáculo, o NPC realiza um *flip* e passa a se movimentar na direção oposta.

## Layout e Demonstração

O projeto possui duas cenas que apresentam diferentes aplicações da mecânica de movimentação com Raycast.

> Adicione aqui capturas de tela ou GIFs demonstrando o comportamento do NPC nas duas cenas.

## Pré-requisitos

Para executar o projeto, são necessários:

- [Unity 6](https://unity.com/)
- [Visual Studio](https://visualstudio.microsoft.com/) ou outra IDE compatível com C#.

## Como Rodar a Aplicação :arrow_forward:

1. Clone este repositório:

\`\`\`bash
git clone URL_DO_REPOSITORIO
\`\`\`

2. Abra o Unity Hub.

3. Selecione a opção **Add Project** e localize a pasta clonada.

4. Abra o projeto utilizando a Unity 6.

5. No painel Project, localize as duas cenas disponíveis.

6. Execute a cena desejada para testar a movimentação do NPC.

## Tecnologias, Linguagens e Ferramentas

- [Unity 6](https://unity.com/)
- [C#](https://learn.microsoft.com/pt-br/dotnet/csharp/)
- Raycasting
- Detecção de obstáculos
- Movimentação de NPCs

## Objetivo Acadêmico

Este projeto foi desenvolvido como parte das atividades do curso de Jogos Digitais da PUC Campinas.

O objetivo foi explorar conceitos de programação de jogos utilizando Raycasting para detecção de obstáculos e implementação de comportamentos básicos de movimentação para personagens não controlados pelo jogador.

---
