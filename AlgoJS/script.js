/*Crie uma variavel para armazenar o nome e a quantidade de experiência (XP) de um heroi
depois utilize uma estrutura de decisão para apresentar algumas mensagens abaixo:

Se XP for menor que 1.000 = Ferro
Se XP for entre 1.001 e 3.000 = Bronze
Se XP for entre 3.001 e 4.000 = Prata
Se XP for entre 4.001 e 7.000 = Ouro
Se XP for entre 7.001 e 8.000 = Platina
Se XP for entre 8.001 e 9.000 = Diamante
Se XP for entre 9.001 e 10.000 = Ascendente
Se XP for maior ou igual a 10.001 Radiante 

Saida##
Ao final deve se exibir uma mensagem:
"O heroi de nome **[nome]** esta no nivel de **[Nivel]**"
 */

let nome = "Sergio"
let xp = 123112

if (xp >= 10001) {
    console.log("O heroi de nome "+ nome +" esta no ranking Radiante")
} else if (xp <= 10000 && xp >= 9001) {
    console.log("O heroi de nome "+ nome +" esta no ranking Ascendente")
} else if (xp <= 9000 && xp >= 8001 ) {
    console.log("O heroi de nome "+ nome +" esta no ranking Diamante")
} else if (xp <= 8000 && xp >= 7001) {
    console.log(" O heroi de nome "+ nome +" esta no ranking Platina")
} else if (xp <= 7000 && xp >= 4001) {
    console.log(" O heroi de nome "+ nome +" esta no ranking Ouro")
} else if (xp <= 4000 && xp >= 3001) {
    console.log("O heroi de nome "+ nome +" esta no ranking Prata")
} else if (xp <= 3000 && xp >= 1001) {
    console.log("O heroi de nome "+ nome +" esta no ranking Bronze")
} else if (xp <= 1000) {
    console.log("O heroi de nome "+ nome +" esta no ranking Ferro")
} else {
    console.log("Valor indefinido")
}
