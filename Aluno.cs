using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace SistemaLMS
{
    class Aluno : Pessoa
    {
        private string matricula;
        private bool presente;
        public List<Professor> professores = new List<Professor>();

        public string Matricula
        {
            get => matricula;
            set => matricula = value;
        }

        public bool Presente
        {
            get => presente;
            set => presente = value;
        }


        public void imprimir()
        {
            WriteLine("Nome: {0}", this.getNome());
            WriteLine("Idade: {0}", this.getIdade());
            WriteLine("Marticula: {0}", this.Matricula);
            WriteLine("Presente: {0}", this.Presente);
            WriteLine("Presente: {0}", this.ResponderPresenca());
            WriteLine("\n -------------------------------------------------------- \n");
        }

        public string ResponderPresenca()
        {
            if (this.Presente)
            {
                return "PRESENTE!!";
            }
            else
            {
                return "FALTOU!!";
            }
        }
        public void addProfessor(Professor professor)
        {
            this.professores.Add(professor);
        }
    }
}
