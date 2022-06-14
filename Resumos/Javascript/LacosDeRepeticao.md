# Laços de repetição

**O que são? Para que Serve?**

*Laços de repetição ou loop são comandos que permitem que certa parte do codigo seja repetida diversas vezes.*

*Então basicamente são comandos que permitem vc repetir certa parte do codigo até que uma certa condição estabelecida seja cumprida.*

*Então vc pode fazer que um trecho de codigo seja repetido até que certa condição estabelecida seja cumprida ou percorrer um array analisando indivualmente cada elemento.*

E tem algumas formas de fazer um laço de repetição e é oque vamos ver aqui:
__________

### **Topicos:**

- O for loop padrão
- Saindo do loop com o break
- continue
- while
- do ... while

__________

## O for loop padrão

*o For é um loop simples, então vc usa geralmente quando quer uma quantidade definida de repetiçoes, mas vc pode usar tb como laço infinito.*

*a estrutura do For é composta por um incializador, a condição de continuidade, e a variavel de controle que é incrementada ou decrementada.*

![image](https://user-images.githubusercontent.com/81869607/155259035-bb31c913-d4b2-4f84-a07f-c7c31fea4d9b.png)

- inicializador

*Que conta o número de vezes que o loop foi executado*

- condição de saída(array/length)

*usamos um operador de comparação, um teste para verificar se a condição de saída foi atendida.*

- iterador (incrementar/decrementar)

*sempre é executado cada vez que o loop passou por uma iteração completa.*

enquanto for verdadeiro, o loop será executado.
__________

## Break

*Se você quiser sair de um loop antes que todas as iterações sejam concluídas, você poderá usar a instrução break.*

*A instrução break termina o loop imediatamente e passa o controle sobre a próxima instrução após o loop.*

![image](https://miro.medium.com/max/1400/1*CRAVHkHDrC8LU6mheqktYg.png)

```
Nesse exemplo, o loop for incrementa a variável i de 1 até 10. No corpo do loop, a instrução if verifica se i é divisível por 3. Se for, a instrução break é executada e o loop é encerrado.
O controle é passado para a próxima instrução fora do loop que exibe a variável i na janela do console.
```

- saida

__________

## Continue

*A instrução continue ignora a iteração atual de um loop e passa para a próxima. E ela vai no topo do loop para não acasionar erros.*

![image](https://miro.medium.com/max/1400/1*r6G0M3aTjEmli8JLSBBp3g.png)

```
Primeiro, a variável couter é definida como zero.
Segundo, as etapas do loop for percorrem os caracteres da string e contam quantas letras s existem. Se o caractere atual não for um s, a instrução continue ignorará o restante do loop e examinará o próximo caractere da string. Caso o caractere atual seja o s o script incrementa a variável do contador.
Terceiro, o console.log mostra na janela do console quantas letras s existem na string.
```

- pular para prox

## while (enquanto)

*o while é usado quando não sabemos quantas vezes um determinado bloco de codigo precisa ser repetido. então a execução vai continuar até que a condição estabelecida seja verdadeira onde ela retorna um valor booleano, que é o true e false.*

*variável inicializadora é definida antes do loop, já no FOR ele é definido dentro da estrutura do loop.*

![image](https://user-images.githubusercontent.com/81869607/157058027-18d7c8b3-b0e2-4d74-b3e1-74f38bae0e9c.png)

- inicializador fica do lado de fora
- condição de saída
- decrementando
- código pode nunca ser executado se a condição não passar

## do ... whil

*O do/while tem quase o mesmo funcionamento que o while, a diferença é que com o uso dele teremos os comandos executados ao menos uma única vez.*

*Em um loop do ... while, o código dentro das chaves é sempre executado uma vez antes da verificação ser feita para ver se deve ser executada novamente.*

![image](https://user-images.githubusercontent.com/81869607/155263248-27f126d0-96e8-4eea-8323-f32f8430e800.png)

- final
- primeiro loop sem condição

_______
