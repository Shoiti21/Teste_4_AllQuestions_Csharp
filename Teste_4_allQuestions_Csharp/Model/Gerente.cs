using System;
using System.Collections.Generic;
using System.Text;

namespace Teste_4_allQuestions_Csharp.Model
{
    class Gerente:Funcionario
    {
        public Gerente(String nome, int idade, double salario, double qtdbonificacao) : base(nome, idade, salario){}
        public double Bonificacao()
        {
            return this.Salario += 10000.0;
        }
    }
}
