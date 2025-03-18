namespace JogoDaForca.ConsoleApp;

class InsiraTexto
{
    public static char LetraUsuario()
    {
        Console.Write("Digite uma letra válida -> ");
        string entradaInicial = Console.ReadLine()!;
        while (string.IsNullOrWhiteSpace(entradaInicial) || entradaInicial.Length > 1)
        {
            Console.Write("Entrada inválida tente novamente -> ");
            entradaInicial = Console.ReadLine()!;
            continue;
        }
        return entradaInicial.ToUpper()[0];
    }
    public static char Continuar()
    {
        Console.Write("\nDeseja continuar? (S/N) -> ");
        string entradaUsuario = Console.ReadLine()!;
        while (entradaUsuario != "S" && entradaUsuario != "N" && entradaUsuario != "s" && entradaUsuario != "n" || (entradaUsuario == null))
        {
            Console.Write("Opção inválida, tente novamente -> ");
            entradaUsuario = Console.ReadLine()!;
        }
        return entradaUsuario.ToUpper()[0];
    }
}
