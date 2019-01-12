using Lab04_TicTacToe.Classes;
using System;
using System.Text;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game play = new Game(p1, p2);
            play.Play();


        }
    }
}
