using ByteBank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf):base(cpf, 5000)
        {
        }

        public override double getBonificacao()
        {
            return Salario * 0.5; // 0.5 = 50%
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

    //    public string Senha { get; set; }

    //    public bool Autenticar(string senha) // o "bool" sempre espera um "return"!!!!
    //    {
    //        return this.Senha == senha;
    //    }
    }
}
