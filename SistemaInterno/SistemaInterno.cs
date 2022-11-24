using ByteBank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string login, string senha)
        {
            //lógica de logar

            bool usuarioAutenticado = funcionario.Autenticar(login, senha);
            if (usuarioAutenticado == true)
            {
                Console.WriteLine("Bem vindo ao Sistema Interno.");
                return true;
            }
            else
            {
                Console.WriteLine("Login ou Senha Inválida.");
                return false;
            }
        }
    }
}