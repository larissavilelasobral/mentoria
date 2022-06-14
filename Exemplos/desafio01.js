//Escreva um programa que tenha uma função que receba uma lista aleatória de números e 
//retorne uma lista ordenada.

//Ex.: 
//parâmetro: [10, 5, 4, 1, 9, 22, 21, 23]
//retorno: [1, 4, 5, 9, 10, 21, 22, 23]

let listaDeNumeros = [10, 5, 4, 1, 9, 22, 21, 23];

function ordenarNumeros(listaDeNumeros){
  for(var index = 0; index < listaDeNumeros.length; index++){
    let indexA = index;

    for(var indexB = 0; indexB < listaDeNumeros.length; indexB++){ 

      if (listaDeNumeros[indexB] > listaDeNumeros[indexA]){     
          
        let reserva = listaDeNumeros[indexB]

        listaDeNumeros[indexB] = listaDeNumeros[indexA]
        listaDeNumeros[indexA] = reserva
      }     
    }
  }
  return listaDeNumeros;
}

let listaOrdenada = ordenarNumeros(listaDeNumeros);
console.log(listaOrdenada)