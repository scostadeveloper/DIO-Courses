let level = ranked(100, 10)
function ranked(vitorias, derrotas) {
    let somatorio = vitorias - derrotas
    console.log(`Voce tem ${somatorio} vitorias`)
    if (somatorio > 101) {
        console.log("Elo Imortal")
    } else if (somatorio <= 100 && somatorio >= 91) {
        console.log("Elo Lendario")
    } else if (somatorio <= 90 && somatorio >= 81) {
        console.log("Elo Diamante")
    } else if (somatorio <= 80 && somatorio >= 51) {
        console.log("Elo Ouro")
    } else if (somatorio <= 50 && somatorio >= 21) {
        console.log("Elo Prata")
    } else if (somatorio <= 20 && somatorio >= 11) {
        onsole.log("Elo Bronze")
    } else if (somatorio <= 10) {
        console.log("Elo Ferro")
    }
}


