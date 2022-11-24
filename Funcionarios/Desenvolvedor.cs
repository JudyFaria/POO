using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string cpf) : base(cpf, 3000)
        {
                
        }
        public override double getBonificacao()
        {
            return this.Salario * 0.25; // 0.25 = 25%
        }

        public override void AumentarSalario()
        {
            this.Salario += 1.1;
        }
    }
}
