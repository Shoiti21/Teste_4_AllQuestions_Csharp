using System;
using System.Collections.Generic;
using System.Text;

namespace Teste_4_allQuestions_Csharp
{
    class Pessoa
    {
        private String _Nome;
        private int _Idade;
        public Pessoa(String nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }
        public String Nome { get; }
        public int Idade { get; }
        public Pessoa() { }
        public void MaiorIdade(List<Pessoa> pessoaMaior)
        {
            foreach (Pessoa pessoa in pessoaMaior)
            {
                if (pessoa.Idade > _Idade)
                {
                    _Idade = pessoa.Idade;
                    _Nome = pessoa.Nome;
                }
            }
            Console.WriteLine("A pessoa mais velha é o " + _Nome);
        }
        public void qtdPessoas(List<Pessoa> qtdpessoa)
        {
            int soma = qtdpessoa.Count;
            Console.WriteLine("ANTES:");
            Console.WriteLine("Total de pessoas: " + soma);

        }
        public void qtdPessoasDeMaior(List<Pessoa> qtdpessoa)
        {
            int soma = 0;
            foreach (Pessoa pessoa in qtdpessoa)
            {
                if (pessoa.Idade >= 18)
                {
                    soma++;
                }
            }
            Console.WriteLine("DEPOIS (somente pessoas igual ou maior que 18):");
            Console.WriteLine("Total de pessoas: " + soma);
        }
        public void existeJessica(List<Pessoa> listaPessoa)
        {
            bool elaExiste = false;
            foreach (Pessoa pessoa in listaPessoa)
            {
                if (pessoa.Nome == "Jessica")
                {
                    elaExiste = true;   
                }
                else
                {
                    elaExiste = false;
                }
            }
            if (elaExiste == true)
            {
                Console.WriteLine("Ela existe nessa lista");
            }
            else
            {
                Console.WriteLine("Ela não existe nessa lista");
            }
        }
    }
}
