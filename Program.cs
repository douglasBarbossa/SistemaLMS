using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace SistemaLMS
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno joazinho = new Aluno();
            joazinho.setNome("João Ribeiro");
            joazinho.setIdade(14);
            joazinho.Matricula = "ra180";
            joazinho.Presente = false;
            joazinho.ResponderPresenca();
            joazinho.imprimir();

            Aluno ritinha = new Aluno();
            ritinha.setNome("Rita de Cassia");
            ritinha.setIdade(12);
            ritinha.Matricula = "ra181";
            ritinha.Presente = true;
            ritinha.ResponderPresenca();
            ritinha.imprimir();

            Professor jose = new Professor();
            jose.nome = "José Firmino";
            jose.setIdade(40);
            jose.ValorHora = 30;
            jose.Tipo = 1;
            jose.Bonus = 0;
            WriteLine("Salario {0:c}", jose.CalcularSalarioFinal(120));
            jose.imprimir();
            jose.addAluno(joazinho);
            jose.addAluno(ritinha);
            jose.ImprimirAlunos();

            Professor maria = new Professor();
            maria.nome = "Maria Oliveira";
            maria.setIdade(42);
            maria.ValorHora = 30;
            maria.Tipo = 2;
            maria.Bonus = 15;
            WriteLine("Salario {0:c}", maria.CalcularSalarioFinal(120));
            maria.imprimir();
            maria.addAluno(joazinho);
            maria.ImprimirAlunos();

            ReadLine();
        }
    }
}
