using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xadrez.Models;

namespace Xadrez.Services
{
    public class System
    {
        public static Player Player1 { get; set; }
        public static Player Player2 { get; set; }
        public static void Options()
        {
            int option = 5;
            Console.Clear();
            Console.WriteLine("... Bem-vindo ...");
            Console.WriteLine("Aperte ENTER para continuar");
            Console.ReadKey();
            while (option != 0)
            {
                Console.Clear();
                Console.WriteLine("Deseja:");
                Console.WriteLine("1 - Cadastrar novo usuário");
                Console.WriteLine("2 - Logar e Iniciar novo jogo");
                Console.Write("Digite aqui: ");
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Opção Inválida");
                    Console.ReadKey();
                }
                
                switch (option)
                {
                    case 1:
                        try
                        {
                            Console.Write("Digite nome: ");
                            string name = Console.ReadLine();
                            Console.Write("Digite sua senha: ");
                            string senha = Console.ReadLine();
                            Player newPlayer = new Player(name);
                            newPlayer.Senha = senha;
                            PlayersLogin.AddNewPlayers(newPlayer);
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Opção Inválida");
                            Console.ReadKey();
                            return;
                        }
                        
                    case 2:
                        Console.WriteLine("Iniciando o jogo ...");
                        StartCheesGame();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
            
        }

        public static void StartCheesGame()
        {
            Board board = new Board();
            Board.PlayersListing();
            LoginMenu();
            board.StartBoard();
            int option = 1;
            while (option !=0)
            {
                
                try
                {
                    board.ShowBoard();
                    Console.WriteLine($"Vez do: {board.ShowPlayer()}");
                    Console.Write("Digite a Linha: ");
                    int Line = int.Parse(Console.ReadLine());
                    Console.Write("Digite a Coluna: ");
                    int Column = int.Parse(Console.ReadLine());
                    board.MovePiece(Line, Column, board.SelectPiece(Line, Column));
                    board.ShowBoard();
                }
                catch
                {
                    Console.WriteLine("Operação Inválida");
                    Console.ReadKey();
                    return;
                }
                
            }
            
            
        }
        public static void LoginMenu()
        {
            bool check1 = false;
            
            while (check1 != true)
            {
                try
                {
                    Console.Write("Digite o Nome do jogador1: ");
                    string name1 = Console.ReadLine();
                    Console.Write("Digite a senha do jogador1: ");
                    string password1 = Console.ReadLine();

                    Console.Write("Digite o Nome do jogador2: ");
                    string name2 = Console.ReadLine();
                    Console.Write("Digite a senha do jogador2: ");
                    string password2 = Console.ReadLine();
                    check1 = LoginSystem(name1, password1, name2, password2);
                }
                catch
                {
                    Console.WriteLine("Valor Inválido");
                    Console.ReadKey();
                    return;
                }
                
            }
        }

        public static bool LoginSystem(string name, string senha, string name2, string senha2) 
        {
            var resultName = Board.playerList.FindIndex(userName => userName.Nome == name);
            var resultSenha = Board.playerList.FindIndex(userPassword => userPassword.Senha == senha);
            var resultName2 = Board.playerList.FindIndex(userName => userName.Nome == name2);
            var resultSenha2 = Board.playerList.FindIndex(userPassword => userPassword.Senha == senha2);
            if (resultName == -1 || resultSenha == -1)            
                return false;
            else
            {
                Player1 = Board.playerList[resultName];
                Player2= Board.playerList[resultName2];
                
                return true;
            }
                
        }
    }
}
