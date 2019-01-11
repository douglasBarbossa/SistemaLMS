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


        public void estaPresente(bool presenca)
        {
            this.presente = presenca;
            if (presenca)
            {
                WriteLine("Esta presente!");
            }
            else
            {
                WriteLine("Faltou!!");
            }
    
        }
        public void imprimir()
        {
            WriteLine("Nome: {0}", this.getNome());
            WriteLine("Idade: {0}", this.getIdade());
            WriteLine("Marticula: {0}", this.Matricula);
            WriteLine("Presente: {0}", this.Presente);
            WriteLine("\n -------------------------------------------------------- \n");
        }
    }
}
