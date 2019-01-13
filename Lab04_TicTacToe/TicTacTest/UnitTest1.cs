using System;
using Xunit;
using Lab04_TicTacToe;

namespace TicTacTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestForWinners()
        {
            ///Arrange
            Player p1 = new Player();
            Player p2 = new Player();
            Game play = new Game(p1, p2);
            play.Play();
            ///Act
            ///Assert
        }
    }
}
