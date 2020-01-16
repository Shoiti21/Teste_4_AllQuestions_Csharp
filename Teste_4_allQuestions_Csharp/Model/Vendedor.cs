using System;
using System.Collections.Generic;
using System.Text;

namespace Teste_4_allQuestions_Csharp.Model
{
    class Vendedor : Funcionario
    {
        private double _qtdBonificacao;
        public Vendedor(String nome, int idade, double salario) : base(nome, idade, salario){}
        public double Bonificacao()
        {
            return this.Salario += 3000.0;
        }
    }
}
