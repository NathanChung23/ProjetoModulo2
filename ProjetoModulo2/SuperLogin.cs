using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoModulo2
{
    abstract class SuperLogin
    {
        public abstract bool Login(string usuario, dynamic senha);
        public abstract bool Logout();

        protected virtual bool Autentica(string usuario, dynamic senha, TipoLogin tipo)
        {
            if (tipo == TipoLogin.LoginGmail)
            {
                if (senha is String)
                {
                    if (usuario == "nathan@gmail.com" && senha == "123")
                    {
                        return true;
                    }
                    else
                        return false;
                }
                else
                {
                    return false;
                }
            }
            else if (tipo == TipoLogin.LoginFacebook)
            {
                if (senha is String)
                {
                    if (usuario == "Nathan Chung" && senha == "123")
                        return true;
                    else
                        return false;
                }
                else
                    return false;
            }
            else
            {
                if (senha is String)
                {
                    if (usuario == "@NathanChung" && senha == "123")
                        return true;
                    else
                        return false;
                }
                else
                    return false;
            }
        }
    }
}
