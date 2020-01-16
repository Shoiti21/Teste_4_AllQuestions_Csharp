using System;
using System.Collections.Generic;
using System.Text;

namespace Teste_4_allQuestions_Csharp.Model
{
    class Supervisor : Funcionario
    {
        public Supervisor(String nome, int idade, double salario) : base(nome, idade, salario){}
        public double Bonificacao()
        {
            return this.Salario += 5000.0;
        }
    }
}
