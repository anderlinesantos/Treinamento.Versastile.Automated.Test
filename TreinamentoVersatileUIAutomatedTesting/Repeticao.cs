using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TreinamentoVersatileUIAutomatedTesting
{
    public class Repeticao
    {
        [Test]
        public void Test2()
        {
            int index = 0;
            // 1ºExemplo é um array
            string[] nomes = { "Anderline", "Aline", "Alan", "Mari" };
            while(index < nomes.Length)
            {
                Console.WriteLine("Imprimindo nomes While: " + nomes[index]);
                index++;
            }

            for (var i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Imprimindo nomes pelo FOR: " + nomes[i]);
            }

            foreach(var nome in nomes)
            {
                Console.WriteLine("Imprimindo nomes pelo FOREACH: " + nomes);
            }

            // 2º exemplo com o List
            List<int> list = new List<int>();
            index = 1;

            while(index <= 10)
            {
                list.Add(index);
                Console.WriteLine($"Adicionando o número inteiro: '{index}' na List");
                index++;
            }
        }
    }
}
