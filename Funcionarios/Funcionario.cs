using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        //private int _tipo;


        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set;}
        
        public static int totalDeFuncionarios { get; private set; }

        public Funcionario(string cpf, double salario)
        {
            this.Cpf = cpf;
            this.Salario = salario;

            totalDeFuncionarios++;
        }

        public abstract double getBonificacao();

        public abstract void AumentarSalario();

    }
}
