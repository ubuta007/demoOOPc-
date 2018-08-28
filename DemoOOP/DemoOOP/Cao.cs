using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP
{
    class Cao : Mamiferos
    {
        private string raca { get; set; }

        public Cao(string _raca)
        {
            raca = _raca;
        }
        public override void Andar()
        {
            System.Console.WriteLine("Cao andado de raca {0} correndo com {1} patas", raca, Patas);
        }

        public override void Imposto(int valor)
        {
            int taxa = valor * 5;
            System.Console.WriteLine("Taxa de cao = {0}", taxa); 
        }
    }
}
