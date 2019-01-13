using Lab04_TicTacToe.Classes;
using System;
using System.Text;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            int turn = 0;
            bool displayGame = true;
            while (displayGame)
            {
                turn++;
                if(turn > 1)
                {
                    Console.WriteLine("Do you want to again? y/n");

                }
                else
                {
                    Console.WriteLine("Welcome to Tic Tac Toe!");
                    Console.WriteLine("Do you want to play? y/n");
                   
                }
                string input = Console.ReadLine();
                switch (input)
                {
                    case "y":
                        Console.Clear();
                        Player p1 = new Player();
                        Player p2 = new Player();
                        Game play = new Game(p1, p2);
                        play.Play();
                        break;
                    case "n":
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
