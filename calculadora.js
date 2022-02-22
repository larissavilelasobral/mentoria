const numero1 = 10
const numero2 = 5
var operador = ')'

// -------------------------------------
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