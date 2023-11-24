var numeroSecreto = Math.floor(Math.random() * 100) + 1;
var iterador = 5;

var jogar = prompt('Quer jogar? (s/n)').toLowerCase();

while ((jogar === 's' || jogarDeNovo === 's') && iterador > 0) {
    var chute = parseInt(prompt('Digite um número de 1 a 100.'));

    if (chute === numeroSecreto) {
        alert('Acertou!');
        jogarDeNovo = prompt('Deseja jogar novamente? (s/n)').toLowerCase();
        if (jogarDeNovo === 's') {
            numeroSecreto = Math.floor(Math.random() * 100) + 1;
            iterador = 5;
        }
    } else if (chute !== numeroSecreto && iterador <= 0) {
        alert(`Se ferrou!`)
    }
    else if (chute > numeroSecreto) {
        alert(`Errou... O número secreto é menor que ${chute}. Você tem ${--iterador} chances.`);
    } else {
        alert(`Errou... O número secreto é maior que ${chute}. Você tem ${--iterador} chances.`);
    }
}

// if (chute !== numeroSecreto && iterador <= 0) {
//     alert(`Você esgotou suas chances. O número secreto era ${numeroSecreto}. Boa sorte na próxima vez.`);
// }