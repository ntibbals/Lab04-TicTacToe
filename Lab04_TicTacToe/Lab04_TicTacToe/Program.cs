using Lab04_TicTacToe.Classes;
using System;
using System.Text;

namespace Lab04_TicTacToe
{
    public class Program
    {
        /// <summary>
        /// Initializes continuous game upon page load until exited
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            int turn = 0; //tallies each game in order to display two varying messages
            bool displayGame = true;
            while (displayGame)
            {
                turn++;
                if(turn > 1)
                {
                    Console.WriteLine();
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
