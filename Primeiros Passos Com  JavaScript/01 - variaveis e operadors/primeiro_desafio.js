// Faça um programa para calcular o valor gasto de combustivel em uma viagem.
// Você terá 3 variáveis. Sendo elas: 
// - 1 Preço do combustivel;
// - 2 Gasto médio de combustivel do carro por KM;
// - 3 Distância em KM da viagem;

// Imprima no console o valor que será gasto para realizar esta viagem.

console.log("Programa para calcular gastos de uma viagem")

const valorCombustivel = 5.79;
const consumoCar = 10;
const distancia = 100;
const mediaConsumo = 100/10;
const total = mediaConsumo*valorCombustivel;


console.log(total.toFixed(2));  //.toFixed() é utilizado para definir a quantidade de decimais