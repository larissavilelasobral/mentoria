const numero1 = 10
const numero2 = 5
var operador = ';'

// -------------------------------------
function calculadora(operador, numero1, numero2) {
  var resultado
  if (operador == '+') {
    resultado = numero1 + numero2
  } else if (operador == '-') {
    resultado = numero1 - numero2
  } else if (operador == '/') {
    resultado = numero1 / numero2
  } else if (operador == '*') {
    resultado = numero1 * numero2
  } else {
    console.log('Voce nao sabe o que é uma calculadora, seu maluco')
  }
  console.log(resultado)
}
calculadora(operador, numero1, numero2)

