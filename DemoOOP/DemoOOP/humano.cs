using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoOOP;

namespace DemoOOP
{
    class humano : Mamiferos
    {
        public int idade { get; set; }

        public humano(int _idade)
        {
            idade = _idade;
        }

        public override void Andar()
        {
            System.Console.WriteLine("Homano andando com {0} pes", Patas);
        }

        public override void Imposto(int valor)
        {
            int taxa = valor * 10;
            System.Console.WriteLine("Taxa de pessoa = {0}", taxa);
        }
    }
}
