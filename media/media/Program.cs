//PROGRAMA PARA CALCULAR MÉDIA DE CINCO NOTAS:
//USAR CONSOLE.READLINE PARA LER A ENTRADA DAS NOTAS
//USAR SAÍDA DE DADOS FORMATADA COM INTERPOLAÇÃO


Console.WriteLine("Digite a primeira nota: ");
double nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
double nota2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota: ");
double nota3 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a quarta nota: ");
double nota4 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a quinta nota: ");
double nota5 = double.Parse(Console.ReadLine());


//PROCESSAMENTO DE DADOS - SOMA DAS NOTAS / qtd_notas
double media = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;


//SAÍDA DE DADOS - EXIBIÇÃO DE DADOS (WriteLine)
Console.WriteLine($"A média é:{media}");


//1.CONVERSÃO DE DADOS - ARREDONDAMENTO --> Math.Round
Console.WriteLine($"A média é:{Math.Round(media)}");

//2.CONVERSÃO DE DADOS - ARREDONDAMENTO --> ToString
Console.WriteLine($"A média é:{media.ToString("F0")}");

//3.CONVERSÃO DE DADOS - ARREDONDAMENTO --> F format
Console.WriteLine($"A média é:{media:F2}");