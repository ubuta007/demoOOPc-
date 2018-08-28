using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP
{
    abstract class Mamiferos
    {
        private int patas;

        public int Patas
        {
            get {return patas; }
            set { patas = value; }
        }

        public Mamiferos()
        {
            patas = 0;
        }

        public abstract void Andar();

        public abstract void Imposto(int valor);
    }
}
