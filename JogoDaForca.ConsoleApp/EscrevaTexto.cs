namespace JogoDaForca.ConsoleApp;

class EscrevaTexto
{
    public static void ExibirForca(int quantidadeErros, char[] letrasEncontradas)
    {
        string cabeca = quantidadeErros >= 1 ? " O " : "   ";
        string tronco = quantidadeErros >= 2 ? "X" : " ";
        string troncoInferior = quantidadeErros >= 2 ? " X " : "   ";
        string bracoEsquerdo = quantidadeErros >= 3 ? "/" : " ";
        string bracoDireito = quantidadeErros >= 4 ? "\\" : " ";
        string pernas = quantidadeErros >= 5 ? "/ \\" : "   ";
        Console.Clear();
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("Jogo da Forca 2025");
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine(" ___________        ");
        Console.WriteLine(" |/        |        ");
        Console.WriteLine(" |        {0}       ", cabeca);
        Console.WriteLine(" |        {0}{1}{2} ", bracoEsquerdo, tronco, bracoDireito);
        Console.WriteLine(" |        {0}       ", troncoInferior);
        Console.WriteLine(" |        {0}       ", pernas);
        Console.WriteLine(" |                  ");
        Console.WriteLine(" |                  ");
        Console.WriteLine("_|____              ");
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine($"Quandtidadede de erros: {quantidadeErros}");
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine($"Palavra escolhida: {String.Join("", letrasEncontradas)}");
        Console.WriteLine("--------------------------------------------------------");
    }
    public static void JogadorPerdeu()
    {
        Console.Clear();
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("Você não descobriu a palavra. Que pena!");
        Console.WriteLine("--------------------------------------------------------");
    }
    public static void JogadorGanhou(string palavraEscolhida)
    {
        Console.Clear();
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine($"Você descobriu a palavra: {palavraEscolhida}. Parabéns!");
        Console.WriteLine("--------------------------------------------------------");
    }
}
