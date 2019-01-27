using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace SistemaLMS
{
    class Professor : Pessoa
    {
        public List<Aluno> alunos = new List<Aluno>();

        private double _valorHora;
        public double ValorHora
        {
            get => _valorHora;
            set => _valorHora = value;
        }
        private int _tipo;
        public int Tipo
        {
            get => _tipo;
            set => _tipo = value;
        }
        private int _bonus;
        public int Bonus
        {
            get => _bonus;
            set => _bonus = value;
        }

        public void imprimir()
        {
            WriteLine("Nome: {0}", this.getNome());
            WriteLine("Idade: {0}", this.getIdade());
            WriteLine("Presente: {0}", this.ResponderPresenca());
            WriteLine("\n -------------------------------------------------------- \n");
        }
        public string ResponderPresenca()
        {
            return "Bateu o ponto corretamente!";
        }
        public double CalcularSalario(int horas)
        {
            return this.ValorHora * horas;
        }
        public double CalcularSalario(int horas, int bonificacao)
        {
            double valor = this.ValorHora * horas;
            double pct = bonificacao / 100;
            return valor + (valor * pct);
        }
        public double CalcularSalarioFinal(int horas)
        {
            if (this.Tipo == 1)
            {
                return this.CalcularSalario(horas);
            }
            else
            {
                var bonus = this.Bonus;
                return this.CalcularSalario(horas, bonus);
            }
        }

        public void addAluno(Aluno aluno)
        {
            this.alunos.Add(aluno);
        }

        public void ImprimirAlunos()
        {
            foreach (Aluno aluno in this.alunos)
            {
                WriteLine("Aluno: {0}", aluno.getNome());
            }
            WriteLine("\n -------------------------------------------------------- \n");
        }

    }
            

}
