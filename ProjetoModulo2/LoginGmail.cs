using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoModulo2
{
    class LoginGmail : SuperLogin
    {
        public override bool Login(string usuario, dynamic senha)
        {
            bool verifica = Autentica(usuario, senha, TipoLogin.LoginGmail);
            if (verifica)
                return true;
            else
                return false;
        }

        public override bool Logout()
        {
            return true;
        }
    }
}
