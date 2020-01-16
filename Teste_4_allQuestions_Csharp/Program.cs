using System;
using System.Collections.Generic;
using Teste_4_allQuestions_Csharp.Model;

namespace Teste_4_allQuestions_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------------- QUESTÃO 1 --------------------------
            Pessoa p1 = new Pessoa("João", 15);
            Pessoa p2 = new Pessoa("Leandro", 21);
            Pessoa p3 = new Pessoa("Paulo", 17);
            Pessoa p4 = new Pessoa("Jessica", 18);

            Pessoa pessoas = new Pessoa();
            var listaPessoas = new List<Pessoa>();
            listaPessoas.Add(p1);
            listaPessoas.Add(p2);
            listaPessoas.Add(p3);
            listaPessoas.Add(p4);

            pessoas.MaiorIdade(listaPessoas);
            //-------------------------- QUESTÃO 2 --------------------------
            Console.WriteLine("_____________________________________________________");
            pessoas.qtdPessoas(listaPessoas);
            Console.WriteLine("_____________________________________________________");
            pessoas.qtdPessoasDeMaior(listaPessoas);
            //-------------------------- QUESTÃO 3 --------------------------
            Pessoa p5 = new Pessoa("Jessica", 18);
            var listaPessoas2 = new List<Pessoa>();
            listaPessoas2.Add(p5);
            listaPessoas2.Add(p2);
            Console.WriteLine("_____________________________________________________");
            Console.WriteLine("Lista 1:");
            pessoas.existeJessica(listaPessoas);
            Console.WriteLine("_____________________________________________________");
            Console.WriteLine("Lista 2:");
            pessoas.existeJessica(listaPessoas2);
            //-------------------------- QUESTÃO 4 --------------------------
            Console.WriteLine("_____________________________________________________");
            Gerente gerente = new Gerente("Yasuo",28,10000.0,10000.0);
            Supervisor supervisor = new Supervisor("Viktor",25,10000.0,5000.0);
            Vendedor vendedor = new Vendedor("Ashe",22,10000.0,3000.0);

            Console.WriteLine("O "+gerente.Nome+" é gerente com salário de R${0:0.00}",gerente.Bonificacao());
            Console.WriteLine("O " + supervisor.Nome + " é supervisor com salário de R${0:0.00}", supervisor.Bonificacao());
            Console.WriteLine("O " + vendedor.Nome + " é vendedor com salário de R${0:0.00}", vendedor.Bonificacao());
        }
    }
}
