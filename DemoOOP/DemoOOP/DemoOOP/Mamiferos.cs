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
        private string nome;
        public int Patas
        {
            get {return patas; }
            set { patas = value; }
        }

        public string Nome
        {
            get {return nome; }
            set { nome = value; }
        }

        public Mamiferos()
        {
            patas = 0;
            nome = "";
        }

        public abstract void Andar();

        public abstract void Imposto(int valor);
    }
}
