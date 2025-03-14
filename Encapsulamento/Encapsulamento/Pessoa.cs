using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    internal class Pessoa
    {
        private string _nome;
        private int _idade;
        public string Endereco { get; set; }

        public string Nome {
            get {
                return _nome; 
            }
            set {
                if (value.Length > 15)
                {
                    _nome = value;
                }
            }
        }
    }
}
