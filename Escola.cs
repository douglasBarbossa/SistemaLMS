using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SistemaLMS
{
    class Escola
    {
        private string _nome;
        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }

        public List<Departamento> departamentos = new List<Departamento>();

        public List<Professor> professores = new List<Professor>();
        private Escola _escola = new Escola();
        public Escola setEscola
        {
            get => _escola;
            set => _escola = value;
        }

        public void addDepartamento(Departamento departamento)
        {
            this.departamentos.Add(departamento);
        }
        public void ListarDepartamentos()
        {
            foreach (Departamento departamento in this.departamentos)
            {
                WriteLine("Departamento: {0}", departamento.Nome);
            }
            WriteLine("\n -------------------------------------------------------- \n");
        }
    }
}
