using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP
{
    class Rastejante
    {
        public int metro { get; set; }
        private string nome;

        public Rastejante(int _metro)
        {
            metro = _metro;
        }

        public string Nome
        {
            get {return nome; }
            set { nome = value; }
        }
    }
}
