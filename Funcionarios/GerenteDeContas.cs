using ByteBank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    public class GerenteDeContas : FuncionarioAutenticavel
    {
        public GerenteDeContas(string cpf) : base(cpf, 4000)
        {
        }

        public override double getBonificacao()
        {
            return Salario * 0.25; // 0.25 = 25%
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }

        //public string Senha { get; set; }

        //public bool Autenticar(string senha) // o "bool" sempre espera um "return"!!!!
        //{
        //    return this.Senha == senha;
        //}
    }
}

