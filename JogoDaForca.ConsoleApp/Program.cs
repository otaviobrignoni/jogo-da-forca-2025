namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] palavras = { "ABACATE", "ABACAXI", "ACEROLA", "ACAI", "ARACA", "BACABA", "BACURI", "BANANA", "CAJA", "CAJU", "CARAMBOLA", "CUPUACU", "GRAVIOLA", "GOIABA", "JABUTICABA", "JENIPAPO", "MACA", "MANGABA", "MANGA", "MARACUJA", "MURICI", "PEQUI", "PITANGA", "PITAYA", "SAPOTI", "TANGERINA", "UMBU", "UVA", "UVAIA" };

                Random geradorNumeros = new Random();

                int indiceEscolhido = geradorNumeros.Next(palavras.Length);

                string palavraEscolhida = palavras[indiceEscolhido];

                char[] letrasEncontradas = new char[palavraEscolhida.Length];

                for (int i = 0; i < letrasEncontradas.Length; i++)
                {
                    letrasEncontradas[i] = '_';
                }

                bool jogadorGanhou = false;
                bool jogadorPerdeu = false;
                int quantidadeErros = 0;

                do
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

                    Console.Write("Digite uma letra válida -> ");
                    string entradaInical = Console.ReadLine().ToUpper();

                    while (entradaInical.Length > 1)
                    {
                        Console.Write("Informe apenas uma letra -> ");
                        entradaInical = Console.ReadLine().ToUpper();
                        continue;
                    }
                    char chute = entradaInical[0];

                    bool letraEncontrada = false;

                    for (int i = 0; i < palavraEscolhida.Length; i++)
                    {
                        char caratereAutal = palavraEscolhida[i];
                        if (chute == palavraEscolhida[i])
                        {
                            letrasEncontradas[i] = chute;
                            letraEncontrada = true;
                        }
                    }

                    if (letraEncontrada == false)
                        quantidadeErros++;

                    jogadorPerdeu = quantidadeErros > 5;
                    if (jogadorPerdeu)
                    {
                        Console.Clear();
                        Console.WriteLine("--------------------------------------------------------");
                        Console.WriteLine("Você não descobriu a palavra. Que pena!");
                        Console.WriteLine("--------------------------------------------------------");
                    }

                    jogadorGanhou = String.Join("", letrasEncontradas) == palavraEscolhida;

                    if (jogadorGanhou)
                    {
                        Console.Clear();
                        Console.WriteLine("--------------------------------------------------------");
                        Console.WriteLine($"Você descobriu a palavra: {palavraEscolhida}. Parabéns!");
                        Console.WriteLine("--------------------------------------------------------");
                    }

                } while (jogadorGanhou == false && jogadorPerdeu == false);
                Console.Write("Deseja continuar? (S/N): ");

                string opcao = Console.ReadLine().ToUpper();

                if (opcao != "S")
                    break;
            }
        }
    }
}
