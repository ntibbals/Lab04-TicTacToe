using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    public class Board
    {
		/// <summary>
		/// Tic Tac Toe Gameboard states
		/// </summary>
		public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};

        /// <summary>
        /// Nested forloop to display gameboard
        /// </summary>
        /// <param name="gameBoard">Gameboard multidimentional array</param>
		public void DisplayBoard(string[,] gameBoard)
		{

            for (int i = 0; i <3; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"|{gameBoard[i, j]}| ");
                }
            }

        }
	}
}
