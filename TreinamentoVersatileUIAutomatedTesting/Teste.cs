using NUnit.Framework;
    /*
     C#   Type    Valores possíveis de se armazenar
          bool    Verdadeiro ou Falso (Valores booleanos)
          char    Um caractere (16 bits)
          string  Sequencia de caracteres (16 bits por caractere)
          long    Sequencia de caracteres muito grandes (64 bits)
          byte    0 a 255 (8 bits)
          int     Sequencia de números inteiros (32 bits)
          decimal Sequencia de números de ponto flutuante (128 bits)
          double  Sequencia de números de ponto flutuante (64 bits)
          float   Sequencia de números de ponto flutuante (32 bits)
          object  Qualquer tipo
     */

namespace TreinamentoVersatileUIAutomatedTesting
{
    public class Teste
    {
        // Variável do tipo CHAR
        char InicialNomeDoMeio = 'A';
        object CharObject = 'A';
        // Variável do tipo String (Coleção de Caracteres)
        string Nome = "Anderline";
        object StringObj = "StringObj";
        //Variável do tipo INT
        int Idade = 30;
        object IntObj = 1;
        //Variável do tipo Boolean
        bool EHomem = true;
        object boolObj = false;

        [Test]
        public void Test()
        {
            // As variáveis do tipo "var" e "object" são variáveis coringa que podem receber qualquer tipo
            string nomeString = "Anderline String";
            var nomeVar = "Anderline Var";
            object nomeObj = "Anderline Object";

            int numeroInt = 1;
            var numVar = 2;
            object numObj = 3;

            bool eHomem = false;
            var eMulher = true;
            object eObj = false;

            Console.WriteLine($"Olá! Meu nome é {nomeString} e tenho  {numVar} anos! Será que eu sou mulher? {eMulher}");
        }
    }
}

