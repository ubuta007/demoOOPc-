using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new humano(10);
            pessoa.Patas = 4;

            var dog = new Cao("Pit Bull");
            dog.Patas = 2;

            //System.Console.WriteLine("a pessoa tem {0} paase {1} de idade", pessoa.Patas, pessoa.idade);
            pessoa.Andar();
            pessoa.Imposto(10);
            //System.Console.WriteLine("a pessoa tem {0} paase {1} de idade", pessoa.Patas, pessoa.idade);
            dog.Andar();
            dog.Imposto(10);
            System.Console.ReadLine();
        }
    }
}
