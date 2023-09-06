// See https://aka.ms/new-console-template for more information
Console.Write("Digite seu primeiro nome:");
string nome = Console.ReadLine()!;
Console.Write(nome);
Console.WriteLine();
Console.Write("Digite seu sobrenome:");
string sobrenome = Console.ReadLine()!;
Console.Write(sobrenome);
Console.WriteLine();
Console.WriteLine($"Nome completo: {nome} {sobrenome}");
Console.WriteLine($"Nome de catálogo: {sobrenome.ToUpper()}, {nome}");


