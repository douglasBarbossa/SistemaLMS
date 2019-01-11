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
            joazinho.estaPresente(false);
            joazinho.imprimir();

            Aluno ritinha = new Aluno();
            ritinha.setNome("Rita de Cassia");
            ritinha.setIdade(12);
            ritinha.Matricula = "ra181";
            ritinha.estaPresente(true);
            ritinha.imprimir();

            Professor jose = new Professor();
            jose.nome = "José Firmino";
            jose.idade = 45;
            jose.imprimir();

            ReadLine();
        }
    }
}
