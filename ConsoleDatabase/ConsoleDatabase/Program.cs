using AppDatabaseDLL;
using AppDatabaseDominio;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection conexao = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString);

            conexao.Open();
            Usuario usuario = new Usuario();
            UsuarioDAO usuarioDAO = new UsuarioDAO(); 

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Escolha uma das opções: \n0 - Cadastrar novo usuário \n1 - Editar usuário \n2 - Excluir usuário \n3 - Listar usuários \n4 - Sair \n");
            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "0":

                    Console.WriteLine("Digite o nome do usuário:");
                    usuario.UsuarioNome = Console.ReadLine();

                    Console.WriteLine("Digite o cargo do usuário:");
                    usuario.UsuarioCargo = Console.ReadLine();

                    Console.WriteLine("Digite a data de nascimento do usuário:");
                    usuario.UsuarioDataNasc = Convert.ToDateTime(Console.ReadLine());

                    usuarioDAO.insertUsuario(usuario);

                    usuarioDAO.selectAllUsuarios();

                    break;

                case "1":

                    Console.WriteLine("Digite o código do usuário:");
                    usuario.UsuarioId = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite o nome do usuário:");
                    usuario.UsuarioNome = Console.ReadLine();

                    Console.WriteLine("Digite o cargo do usuário:");
                    usuario.UsuarioCargo = Console.ReadLine();

                    Console.WriteLine("Digite a data de nascimento do usuário:");
                    usuario.UsuarioDataNasc = Convert.ToDateTime(Console.ReadLine());

                    usuarioDAO.updateUsuario(usuario);

                    usuarioDAO.selectAllUsuarios();

                    break;

                case "2":

                    Console.WriteLine("Digite o código do usuário:");
                    usuario.UsuarioId = Convert.ToInt32(Console.ReadLine());

                    usuarioDAO.deleteUsuario(usuario);

                    usuarioDAO.selectAllUsuarios();

                    break;

                case "3":

                    usuarioDAO.selectAllUsuarios();

                    break;
                
                case "4":

                    Environment.Exit(0);
                    break;

            }
        }
    }
}
