// Desafio: Refaça a multiplicação e a divisão utilizando apenas os 
// operadores de "+" e de "-", soma sucessiva e subtrações sucessivas.
// 5 * 3 = 5 + 5 + 5 = 15 
// 10 / 2 → 10 - 2 - 2 - 2 - 2 - 2 = 0 
// (o valor foi subtraído de 2, 5 vezes até ser 0, logo o resultado é 5)
// 10 / 3 = 10 - 3 - 3 - 3 - 3 = -2 
// 5 / 2 = 5 - 2 - 2 = 1
// const numero1 =  5
// const numero2 = 3
// const operador = '*'
// 5 * 3 = 0 + 5 + 5 + 5 = 15
// 5 + 3 = 5 + 5 + 5 = 15
// 
function calculadora(numero1, numero2, operador) {

  if(operador == "+"){
    let resultadoSoma = soma(numero1, numero2)
    console.log(resultadoSoma)

  } else if(operador == "-"){
    let resultadoSubtracao = subtracao(numero1, numero2)
    console.log(resultadoSubtracao)

  } else if(operador == "*"){
    let resultadoMultiplicacao = multiplicacao(numero1, numero2)
    console.log(resultadoMultiplicacao)

  } else if(operador == "/"){
    let resultadoDivisao = divisao(numero1, numero2)
    console.log(resultadoDivisao.contador)
    console.log(resultadoDivisao.resultado)
  }
}
calculadora(1520, 1, "/")

function soma(numero1, numero2){
  let resultado = numero1 + numero2

  return resultado;
}

function subtracao(numero1, numero2){
  let resultado = numero1 - numero2

  return resultado;
}

function multiplicacao(numero1, numero2){
  let resultado = 0;
  for(var i = 1; i <= numero2; i++){
   resultado = resultado + numero1
  }
  // let resultado = numero1 * numero2
  return resultado;
}
// negativo
function divisao(numero1, numero2){
  let resultado = numero1;
  let contador = 0;
  while(resultado >= numero2){
    resultado = resultado - numero2
     resultado += 
    contador++
  }
  return {contador, resultado};
}