using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP
{
    class Zoo
    {
        public string nome { get; set; }

        List<Tuple<Mamiferos, Rastejante>> z = new List<Tuple<Mamiferos, Rastejante>>();

        public Zoo(Mamiferos _m, Rastejante _r) 
        {
            //List<Mamiferos, Rastejante> animais = new List<Mamiferos, Rastejante>();
            
            z.Add(new Tuple<Mamiferos, Rastejante>(_m,_r));
        }

        public void imprimir()
        {
            System.Console.WriteLine("Zoo tinas house: ");
            foreach (var dados in z)
            {
                System.Console.WriteLine("{0}", dados.Item1.Nome);
                System.Console.WriteLine("{0}", dados.Item2.Nome);
            }
        }
    }
}
