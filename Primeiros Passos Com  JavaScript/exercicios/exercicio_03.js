/*
Elabore um algoritimo que calcule o que deve ser pago por um produto, considerando o preço normal de 
etiqueta e a escolha da condição de pagamento.
Utilize os códigos da tabela a seguir para ler qual a condição de pagamento escolhido e efetuar o 
cálculo adequado.

Codificação do pagamento:
- Á vista Débito, recebe 10% de desconto;
- Á vista no Dinheiro ou PIX, recebe 15% de desconto;
- Em duas vezes, preço normal de etiqueta sem juros;
- Acima de duas vezes, preço normal de etiqueta mais juros de 10%.
*/

let valor = 15;
let formaPagamento = 4;

if(formaPagamento === 1){
    console.log(valor - (valor* 0.1));
}
else if(formaPagamento === 2){
    console.log(valor - (valor*0.15));
}
else if(formaPagamento === 3){
    console.log(valor);
}
else if(formaPagamento === 4){
    console.log(valor +(valor*0.1));
}
else{
    console.log("Escolha a forma de pagamento");
}