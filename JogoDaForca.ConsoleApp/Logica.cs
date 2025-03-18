namespace JogoDaForca.ConsoleApp;

class Logica
{
    public static char[] GerarArray(string palavra)
    {
        char[] array = new char[palavra.Length];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = '_';
        }
        return array;
    }
    public static string GerarPalavra()
    {
        string[] palavras = { "ABACATE", "ABACAXI", "ACEROLA", "ACAI", "ARACA", "BACABA", "BACURI", "BANANA", "CAJA", "CAJU", "CARAMBOLA", "CUPUACU", "GRAVIOLA", "GOIABA", "JABUTICABA", "JENIPAPO", "MACA", "MANGABA", "MANGA", "MARACUJA", "MURICI", "PEQUI", "PITANGA", "PITAYA", "SAPOTI", "TANGERINA", "UMBU", "UVA", "UVAIA" };

        Random geradorNumeros = new Random();

        int indiceEscolhido = geradorNumeros.Next(palavras.Length);

        return palavras[indiceEscolhido];
    }
}
