//int idadePericles = int.Parse(Console.ReadLine());
//do
//{
//    Console.WriteLine("errou digite novamente");

//    idadePericles = int.Parse(Console.ReadLine());
//} while (idadePericles != 57);

//Console.WriteLine("voce conseguiu adivinar a idade");



//Aula - 28/10
//ATIVIDADE 1:
//a soma dos valores de numeros?
//int[] numeros = { 2, 4, 6, 8 };
//int variavelCriada = 0;

//foreach(int numero in numeros)
//{
//    Console.WriteLine(numero);

//    variavelCriada += numero;
//}

//Console.WriteLine($"A soma dos números é de: {variavelCriada}");






//ATIVIDADE 2:
//Crie um programa que vai pedir um número para o usuário
//e o programa deve mostrar a tabuada desse número da seguinte maneira:
//5 x 1 = 5
//5 x 2 = 10...
//5 x 10 = 50

//Faça com que o programa continue perguntando um número para a 
//tabuada até que o usuário decida sair do programa:
//Console.WriteLine("Informe um número para a tabuada: ");
//int numTabuada = int.Parse(Console.ReadLine()!);

//for (int i = 1; i < 11; i++)
//{
//    Console.WriteLine($"{numTabuada} x {i} = {numTabuada * i}");
//}



//ATIVIDADE 3:
//Média com foreach
//Faça um programa que leia 5 números e informe a soma
//e a média dos números.

int[] ListaNumeros = { 1, 2, 4, 6, 7 };
int soma = 0;

foreach (int numerosInteiros in ListaNumeros)
{
    soma += numerosInteiros;
}

int divisao = soma / ListaNumeros.Length;




 

//ATIVIDADE 4:
//Faça um programa que, dado um conjunto de N números,
//determine o menor valor, o maior valor e a soma dos valores.



//ATIVIDADE 5:
//Numa eleição existem três candidatos. Faça um programa que peça o
//número total de eleitores. Peça para cada eleitor votar e ao final
// mostrar o número de votos de cada candidato.