// Desafio: Refaça a multiplicação e a divisão utilizando apenas os 
// operadores de "+" e de "-", soma sucessiva e subtrações sucessivas.
// 5 * 3 = 5 + 5 + 5 = 15 
// 10 / 2 → 10 - 2 - 2 - 2 - 2 - 2 = 0 → 
// (o valor foi subtraído de 2, 5 vezes até ser 0, logo o resultado é 5)

const numero1 = 5
const numero2 = 3
var operador = ';'

// -------------------------------------
function calculadora(numero1, numero2) {
  var resultado = 0
  for (let i = 1; i <= numero2; i++) {
    // 5 + 5 + 5 = 15 
    resultado = ++numero1
    console.log(resultado)
  }
  
}
calculadora(numero1, numero2)

