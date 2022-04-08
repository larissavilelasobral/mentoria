//Escreva um programa que tenha uma função que receba uma lista aleatória de números e 
//retorne uma lista ordenada.

//Ex.: 
//parâmetro: [10, 5, 4, 1, 9, 22, 21, 23]
//retorno: [1, 4, 5, 9, 10, 21, 22, 23]

let listaDeNumeros = [10, 5, 4, 1, 9, 22, 21, 23];

function ordenarNumeros(listaDeNumeros){
  for(var index = 0; index < listaDeNumeros.length; index++){
    let min_index = index;
    for(var i = 0; i < listaDeNumeros.length; i++){ 
      if (listaDeNumeros[i] > listaDeNumeros[min_index]){       
        let reserva = listaDeNumeros[i]
        listaDeNumeros[i] = listaDeNumeros[min_index]
        listaDeNumeros[min_index] = reserva
      }     
    }
  }
  return listaDeNumeros;
}

let listaOrdenada = ordenarNumeros(listaDeNumeros);
console.log(listaOrdenada)