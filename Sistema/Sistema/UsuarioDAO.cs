using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{
    public class UsuarioDAO
    {
        public static bool Cadastrar(UsuarioTO user)
        {
            return true;
        }

        public static void Deletar(UsuarioTO user)
        {

        }

        public static UsuarioTO Logar(UsuarioTO user)
        {
            return user;
        }
    }
}
