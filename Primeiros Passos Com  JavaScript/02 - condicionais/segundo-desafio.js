/*Faça um programa para calcular o valor de uma viagem.

Você terá 5 variáveis. Sendo elas:
1 - Preço do etanol;
2 - Preço da gasolina;
3 - O tipo de combustivel que está no seu carro;
4 - Gasto médio de combustivel do carro por KM;
5 - Distância em KM da viagem;

Imprima no console o valor que será gasto para realizar esta viagem.    */

const priceEtanol = 4.10;
const priceGasolina = 6.30;
const myCarFuel = false;
const spentFuel = 10;
const distanceKm = 100;
const mediaConsumo = 100 / 10;
const totalEtanol = mediaConsumo * priceEtanol;
const totalGasolina = mediaConsumo * priceGasolina;

if (myCarFuel) {
    console.log("Você gastará R$", totalEtanol.toFixed(2), "de Etanol");
}

else {
    console.log("Você gastará R$", totalGasolina.toFixed(2), "de Gasolina");
}