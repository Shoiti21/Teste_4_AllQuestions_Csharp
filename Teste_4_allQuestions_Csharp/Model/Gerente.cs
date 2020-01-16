using System;
using System.Collections.Generic;
using System.Text;

namespace Teste_4_allQuestions_Csharp.Model
{
    class Gerente:Funcionario
    {
        private double _qtdBonificacao;
        public Gerente(String nome, int idade, double salario, double qtdbonificacao) : base(nome, idade, salario)
        {
            this._qtdBonificacao = qtdbonificacao;
        }
        public double Bonificacao()
        {
            return this.Salario +=this._qtdBonificacao;
        }
    }
}
