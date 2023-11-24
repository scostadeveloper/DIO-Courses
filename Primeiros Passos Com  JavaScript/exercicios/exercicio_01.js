/* Calcule a média de 3 notas e imprima a sua média e a sua classificação conforme a tabela abaixo:

Média = (nota 1 + nota 2 + nota 3) /3;

Classificação:
- Média menor que 5, reprovação;
- Média entre 5 e 7, recuperação;
- Média acima de 7, passou de semestre.
*/
console.log("Programa que calcula a média de 3 notas.")

let nota1 = 11;
let nota2 = 11;
let nota3 = 11;
let media = (nota1 + nota2 + nota3) / 3;

if (media <= 4) {
    console.log("Sua nota é:", media, "Você está reprovado!");
}

else if (media >= 5 && media <= 6) {
    console.log("Sua nota é:", media, "Você está de recuperação!");
}

else if (media >= 7 && media <= 10) {
    console.log("Sua nota é:", media, "Você está aprovado!");
}

else if (media >= 11) {
    console.log("O limite do valor das notas é 10");
}

else {
    console.log("Insira suas notas");
}