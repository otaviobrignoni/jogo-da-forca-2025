namespace JogoDaForca.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string palavraEscolhida = Logica.GerarPalavra();
            char[] letrasEncontradas = Logica.GerarArray(palavraEscolhida);
           
            bool jogadorGanhou = false;
            bool jogadorPerdeu = false;
            int quantidadeErros = 0;
        
            do
            {                   
                EscrevaTexto.ExibirForca(quantidadeErros, letrasEncontradas);
                
                char chute = InsiraTexto.LetraUsuario();

                bool letraEncontrada = false;

                for (int i = 0; i < palavraEscolhida.Length; i++)
                {
                    if (chute == palavraEscolhida[i])
                    {
                        letrasEncontradas[i] = chute;
                        letraEncontrada = true;
                    }
                }
                if (letraEncontrada == false)
                    quantidadeErros++;

                jogadorGanhou = String.Join("", letrasEncontradas) == palavraEscolhida;
                jogadorPerdeu = quantidadeErros > 5;

                if (jogadorPerdeu)
                {
                    EscrevaTexto.JogadorPerdeu();
                }
                if (jogadorGanhou)
                {
                    EscrevaTexto.JogadorGanhou(palavraEscolhida);
                }

            } while (jogadorGanhou == false && jogadorPerdeu == false);

            char opcao = InsiraTexto.Continuar();
            if (opcao != 'S')
                break;
        }
    }
}
