using Lab04_TicTacToe.Classes;
using System;
using System.Text;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Player p1 = new Player();
            Player p2 = new Player();
            Board playBoard = new Board();
            Game game= new Game (p1, p2);
        }
    }
}
