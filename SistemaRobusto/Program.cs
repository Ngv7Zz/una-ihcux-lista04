using System;


Console.Clear();
Console.WriteLine("=== SISTEMA DE CADASTRO EXPERT ===");

try 
{
    Console.Write("\nDigite sua idade para continuar: ");
    string entrada = Console.ReadLine();

   
    int idade = int.Parse(entrada);

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"\n✅ Acesso liberado! Idade {idade} registrada com sucesso.");
}
catch (FormatException)
{

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\n[ERRO DE UX]: Você digitou letras em um campo que só aceita números!");
    Console.WriteLine("DICA: Tente novamente inserindo apenas algarismos (ex: 25).");
}
finally
{
    Console.ResetColor();
    Console.WriteLine("\n-------------------------------------------");
    Console.WriteLine("O sistema encerrou a tentativa de operação.");
    Console.WriteLine("Pressione qualquer tecla para sair...");
    Console.ReadKey();
}