//int[] valores = new int[5];

//for (int i = 0; i < valores.Length; i++)
//{
//    Console.WriteLine($"informe o valor {i+1}");
//    valores[i] = int.Parse(Console.ReadLine());
//}

//foreach (var v in valores)
//{
//    Console.WriteLine(v);
    
//}

List<string> frutas = new List<string> { "pera","maracuja","manga"};

frutas.Add("uva");
frutas.Remove("pera");
Console.WriteLine(frutas.Contains("uva"));

frutas.Remove("maracuja");
frutas.Insert(1, "maca");

foreach (var f in frutas)
{
    Console.WriteLine(f);
    
}
frutas.Add("pera");
frutas.Remove("uva");

foreach (var f in frutas)
{
    Console.WriteLine(f);
    
}
Console.WriteLine(frutas.Contains("uva"));