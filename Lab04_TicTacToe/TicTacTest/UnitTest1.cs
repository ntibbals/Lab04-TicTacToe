using System;
using Xunit;
using Lab04_TicTacToe.Classes;
using Lab04_TicTacToe;

namespace TicTacTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestForWinners()
        {
            ///Test game will return a winner
            Player p1 = new Player();
            Player p2 = new Player();
            Game play = new Game(p1, p2);

            play.Board.GameBoard = new string[,]
            {
            {"X", "2", "3"},
            {"X", "5", "6"},
            {"X", "8", "9"},
            };
            
            p1.Marker = "X";
            p2.Marker = "O";
            Assert.True(play.CheckForWinner(play.Board));
        }
        [Fact]
        public void TestForSwitch()
        {
            ///Test turn will switch
            Player p1 = new Player();
            Player p2 = new Player();
            Game play = new Game(p1, p2);

            p1.IsTurn = true;
            
            Assert.Equal(p1, play.NextPlayer());
        }
    }
}
