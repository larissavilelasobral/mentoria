# Laços de repetição

**O que são? Para que Serve?**

*Laços de repetição ou loop são comandos que permitem que certa parte do codigo seja repetida diversas vezes.*

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

*a estrutura do For é composta por um incializador, a condição de continuidade, e a variavel de controle que é incrementada ou decrementada.*

![image](https://user-images.githubusercontent.com/81869607/155259035-bb31c913-d4b2-4f84-a07f-c7c31fea4d9b.png)

- inicializador
- condição de saída(array/length)
- iterador (incrementar/decrementar)

![image](https://user-images.githubusercontent.com/81869607/155260084-8572dd78-31e1-4224-a7f9-2e6ea6fad471.png)

enquanto for verdadeiro, o loop será executado.

__________
## Break

![image](https://miro.medium.com/max/1400/1*CRAVHkHDrC8LU6mheqktYg.png)

```
Nesse exemplo, o loop for incrementa a variável i de 1 até 10. No corpo do loop, a instrução if verifica se i é divisível por 3. Se for, a instrução break é executada e o loop é encerrado.
O controle é passado para a próxima instrução fora do loop que exibe a variável i na janela do console.
```
- saida
__________
## Continue

![image](https://miro.medium.com/max/1400/1*r6G0M3aTjEmli8JLSBBp3g.png)

```
Primeiro, a variável couter é definida como zero.
Segundo, as etapas do loop for percorrem os caracteres da string e contam quantas letras s existem. Se o caractere atual não for um s, a instrução continue ignorará o restante do loop e examinará o próximo caractere da string. Caso o caractere atual seja o s o script incrementa a variável do contador.
Terceiro, o console.log mostra na janela do console quantas letras s existem na string.
```
- pular para prox

## while (enquanto)

*variável inicializadora é definida antes do loop*

![image](https://user-images.githubusercontent.com/81869607/157058027-18d7c8b3-b0e2-4d74-b3e1-74f38bae0e9c.png)

- inicializador fica do lado de fora
- condição de saída
- decrementando
- código pode nunca ser executado se a condição não passar
## do ... whil

![image](https://user-images.githubusercontent.com/81869607/155263248-27f126d0-96e8-4eea-8323-f32f8430e800.png)

- final 
- primeiro loop sem condição

________
