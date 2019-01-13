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
            ///Test game will check for a winner upon tic tact toe
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

            p1.IsTurn = false;
            Assert.Equal(p2, play.NextPlayer());
        }

        [Fact]
        public void TestForPosition()
        {
            ///Test game will return correct position
            Player p1 = new Player();
            Player p2 = new Player();
            Game play = new Game(p1, p2);

            int position = 4;
            Position expectedPosition = new Position(1, 0);
            Assert.Equal(expectedPosition, Player.PositionForNumber(position));
        }
        [Fact]
        public void TestForReturnofWinner()
        {
            ///Test game will return the correct winner upon game completion
            Player p1 = new Player();
            Player p2 = new Player();
            Game play = new Game(p1, p2);
            play.Board.GameBoard = new string[,]
{
            {"X", "2", "3"},
            {"4", "X", "6"},
            {"7", "8", "X"},
};
            p1.Marker = "X";
            p2.Marker = "O";

            Assert.Equal(p1, play.Play());
        }
    }
}
