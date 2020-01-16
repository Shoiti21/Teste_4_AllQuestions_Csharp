using System;
using System.Collections.Generic;
using System.Text;

namespace Teste_4_allQuestions_Csharp.Model
{
    class Funcionario
    {
        private String _nome;
        private int _idade;
        private double _salario;

        public Funcionario(String nome, int idade, double salario)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Salario = salario;
        }
        public String Nome { get; }
        public int Idade { get; }
        public double Salario { get; set; }

        public double Bonificacao()
        {
            return this.Salario;
        }
    }
}
