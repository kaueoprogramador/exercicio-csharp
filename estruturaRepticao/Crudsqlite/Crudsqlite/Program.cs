using Microsoft.Data.Sqlite;
using System.ComponentModel;

var conn = new SqliteConnection("Data Source = frutas.db");
conn.Open();

var criartabela = conn.CreateCommand();
criartabela.CommandText = @"CREATE TABLE IF NOT EXISTS frutas (idFruta INTEGER PRIMARY KEY AUTOINCREMENT, nomeFruta TEXT NOT NULL UNIQUE)";

criartabela.ExecuteNonQuery();

Console.WriteLine($"banco frutas criado: {Path.GetFullPath("frutas.db")}");

// --------- MENU -------------
List<string> listaFrutas = new List<string>();
int opcao;
do
{
    mostrarmenu();

    string entrada = Peguntar("opicao: ");

    if (!int.TryParse(entrada, out opcao))
    {
        opcao = -1;
    }

    switch (opcao)
    {
        case 1:
            ListarFrutas();
            break;
        case 2:
            AdicionarFrutas();
            break;
        case 0:
            Console.WriteLine("Até mais");
            break;
        default:
            Console.WriteLine("opção inválida!");
            break;
    }
}
while (opcao != 0);


void AdicionarFrutas()
{
    Console.WriteLine("Informe o nome da fruta nova: ");
    string frutaNova = Console.ReadLine()!;

    // validar se a fruta existe. QUAL FRUTA ??????

    if (listaFrutas.Contains(frutaNova))
    {
        Console.WriteLine("A lista já possui essa fruta");
    }
    else if (frutaNova == "")
    {
        Console.WriteLine("O nome não pode ficar vazio!");
    }
    else
    {
        // 1. banco
        var inserir = conn.CreateCommand();
        inserir.CommandText = "INSERT INTO frutas(nomeFruta) VALUES ($nomeFruta)";
        inserir.Parameters.AddWithValue("$nomeFruta", frutaNova);
        inserir.ExecuteNonQuery();

        // 2. Adiciona na lista 
        listaFrutas.Add(frutaNova);
        Console.WriteLine($"{frutaNova} adicionada com sucesso!");
    }
}



void ListarFrutas()
{
    listaFrutas = new List<string>();

    var selecionarFrutas = conn.CreateCommand();

    selecionarFrutas.CommandText = "" +
        "SELECT nomeFruta FROM frutas ORDER BY nomeFruta Asc";

    // executar a query
    var leitor = selecionarFrutas.ExecuteReader();

    while (leitor.Read())
    {
        listaFrutas.Add(leitor.GetString(0));
    }

    foreach (var f in listaFrutas)
    {
        Console.WriteLine(f);
    }

    


}

string Peguntar(string mensagem){
    Console.WriteLine(mensagem);
    return (Console.ReadLine());
}

void mostrarmenu(){
    Console.WriteLine();
    Console.WriteLine("===== FRUTAS =====");
    Console.WriteLine("[1] - Listar Frutas");
    Console.WriteLine("[2] - Adicionar Frutas");
    Console.WriteLine("[3] - Atualizar Frutas");
    Console.WriteLine("[4] - Remover Frutas");
    Console.WriteLine("[5] - Verificar se existe");
    Console.WriteLine("[6] - Ordenar Lista");
    Console.WriteLine("[0] - Sair");    
}