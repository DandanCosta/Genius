# Genius

## Sobre

O brinquedo [Genius](https://www.estrela.com.br/jogo-genius-estrela-100543353_est_pai/p) é um jogo eletrônico de memória popular nos anos 80. Lançado no Brasil pela [Estrela](https://www.estrela.com.br/), é a versão brasileira do americano Simon, da [Hasbro](https://products.hasbro.com/pt-br).

[![Genius - Estrela](/img/genius.png)](https://estrela.vteximg.com.br/arquivos/ids/163355-1000-1000/Jogo-Genius-Produto-Estrela.jpg?v=636661399595430000)

## Instruções

O objetivo do jogo é repetir corretamente a sequência de sinais proposta pelo próprio jogo, cada vez mais longa. Há quatro cores (vermelho, verde, azul e amarelo), e cada um emite um som característico.

São quatro níveis de dificuldade, que indicam quantas cores deverão ser acertadas:

| Dificuldade | Tamanho da sequência |
| :---------: | :------------------: |
|      1      |       8 rodadas      |
|      2      |      14 rodadas      |
|      3      |      20 rodadas      |
|      4      |      31 rodadas      |

Depois que o usuário seleciona a dificuldade, o jogo irá iniciar uma rodada com uma cor e cada rodada adiciona uma cor 

```
Rodada 1 de 8
Memorize a sequência:
-> Amarelo
```
O usuario terá que memorizar a sequência e digitar a letra correspndente com a cor  

```
Agora é sua vez! Digite a sequência usando:
R = Vermelho | G = Verde | Y = Amarelo | B = Azul 
Botão #1 = Y
```

Caso o usuário acerte a cor, ele passará para a próxima rodada, onde a cor anterior será mostrada juntamente de uma nova cor, e assim sucessivamente.

```
Rodada 2 de 8
Memorize a sequência:
-> Amarelo
-> Azul
```

Caso o usuário erre, será mostrado a sequência correta que deveria ser digitada e o jogo finaliza.

```
Agora é sua vez! Digite a sequência usando:
R = Vermelho | G = Verde | Y = Amarelo | B = Azul 
Botão #1 = G
Errou! O correto era Amarelo. Você perdeu!
```

Obsevação: Qualquer valor inserido fora das letras correspondente as cores fechará o progama e serã considerado derrota

```
Agora é sua vez! Digite a sequência usando:
R = Vermelho | G = Verde | Y = Amarelo | B = Azul 
Botão #1 = K
Entrada invalida. Você perdeu!
```

O jogo se estenderá até que o usuário vença todas as rodadas delimitadas pela dificuldade selecionada ou erre a sequência.

## _Download_

- [Genius](/dist/Genius.zip) 

## Execução

Caso não seja utilizado o windows (Não recomendado, pois o programa utiliza recursos disponíveis apenas no windows), execute o programa utilizando o seguinte comando:

```
dotnet Genius.dll
```

## Criado por 

- [Danilo Costa dos Reis](https://github.com/DandanCosta)
- [Carlos Eduardo Coutinho Paredes](https://github.com/CarlosEduardo113)

---

Fontes: [Manual](https://statics-submarino.b2w.io/manuais/111703711.pdf); [_Reverse Engineering an MB Electronic Simon Game_, da Waiting for Friday](<https://www.waitingforfriday.com/?p=586#:~:text=On%20the%20full%E2%80%90size%20version%20of%20Simon%20the%20lights%20are,B3%20(true%20pitch%20247.942%20Hz)>).
