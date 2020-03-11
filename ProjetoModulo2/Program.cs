using System;

namespace ProjetoModulo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu;
            string usuario;
            string senha;
            TipoLogin tipo;
            do
            {
                Console.WriteLine("1 - Usar conta do GMAIL");
                Console.WriteLine("2 - Usar conta do Facebook");
                Console.WriteLine("3 - Usar conta do Instagram");
                Console.WriteLine("4 - Sair");
                menu = Convert.ToInt32(Console.ReadLine());
                if (menu == 1)
                {
                    Console.Write("Informe o e-mail: ");
                    usuario = Console.ReadLine();
                    Console.Write("Informe a senha: ");
                    senha = Console.ReadLine();
                    LoginGmail gmail = new LoginGmail();
                    gmail.Login(usuario, senha);
                    if (gmail.Login(usuario, senha))
                        Console.WriteLine("Login realizado");
                    else
                        Console.WriteLine("Login falhou");
                }
                else if (menu == 2)
                {
                    Console.Write("Informe o login: ");
                    usuario = Console.ReadLine();
                    Console.Write("Informe a senha: ");
                    senha = Console.ReadLine();
                    LoginFacebook facebook = new LoginFacebook();
                    facebook.Login(usuario, senha);
                    if (facebook.Login(usuario, senha))
                        Console.WriteLine("Login realizado");
                    else
                        Console.WriteLine("Login falhou");
                }
                else if (menu == 3)
                {
                    Console.Write("Informe o login com @: ");
                    usuario = Console.ReadLine();
                    Console.Write("Informe a senha: ");
                    senha = Console.ReadLine();
                    LoginInstagram instagram = new LoginInstagram();
                    if (instagram.Login(usuario, senha))
                        Console.WriteLine("Login realizado");
                    else
                        Console.WriteLine("Login falhou");
                }
                else if (menu == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opção Inválida!!!");
                }
            } while (menu != 4);
        }
    }
}
