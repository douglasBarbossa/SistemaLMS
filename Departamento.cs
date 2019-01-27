using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLMS
{
    class Departamento
    {
        private string _nome;
        public string Nome
        {
            get => _nome;
            set => _nome = value;             
        }

        public List<Professor> professores = new List<Professor>();

        public void addProfessor(Professor professor)
        {

        }
    }
}
