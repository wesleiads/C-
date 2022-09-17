using System;
using Security.Cryptography;
using Sistem.IO;

namespace Aula3
{
    class Program
    {
      static bool cadastrar(string username, string password)
      {
         string linha = username + "=" + password;
         File.AppendAllText("user.txt", linha);
      }
        static void Main(string[] args)
        {

           System.Console.WriteLine("Bem vindo");
           System.Console.WriteLine("Digite 1 para logar");
           System.Console.WriteLine("Digite 2 para cadastrar");
           System.Console.WriteLine("Digite 3 para sair");
         
           bool sair= false;
           while(!sair)
           {
              int opcao = 0;
              try
              {
                opcao= int.Parse.Console.ReadLine());
              }
              catch (Exception erro)
              {
                System.Console.WriteLine(erro.message);
                //nada
              }
              switch(opcao)
              {
                case 1:
                //logar
                break;
                case 2:
                //cadastrar
                System.Console.WriteLine("Digite o nome do usuario");
                 string username = System.Console.ReadLine();
                System.Console.WriteLine("Digite a senha");
                 string password = System.Console.ReadLine();
                 System.Console.WriteLine("Confirme a senha");
                 string confirm = System.Console.ReadLine();
                 if(password!=confirm)
                 {
                    System.Console.WriteLine("As senhas não deram match");
                 }
                 else
                 {

                    if(cadastrar(username, password))
                    {
                        System.Console.WriteLine("Cadastro efetuado");
                    }
                    else
                    {
                     System.Console.WriteLine("Não foi possível cadastrar");
                    }

                 }
                break;
                case 3:
                //sair
                sair = true;
                break;
                default:
                Console.WriteLine("Opção inválida tente novamente");
                break;

              }
           }

       }
   }
}