using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLMS
{
    class Pessoa
    {
        public string nome;
        public int idade;

        public string getNome()
        {
            return this.nome;
        }
        public void setNome(string _nome)
        {
            this.nome = _nome;
        }
        public int getIdade()
        {
            return this.idade;
        }
        public void setIdade(int _idade)
        {
            this.idade = _idade;
        }
        public string ResponderPresenca()
        {
            return "Estou aqui";
        }
    }
}
