using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
	public class Game
	{
        /// <summary>
        /// Create first Player Object 
        /// </summary>
		public Player PlayerOne { get; set; }
        /// <summary>
        /// Create second Player Object
        /// </summary>
		public Player PlayerTwo { get; set; }
        /// <summary>
        /// Initialize a Winnder Player Object
        /// </summary>
		public Player Winner { get; set; }
        /// <summary>
        /// Instantiate a Game Board Object
        /// </summary>
		public Board Board { get; set; }


		/// <summary>
		/// Require 2 players and a board to start a game. 
		/// </summary>
		/// <param name="p1">Player 1</param>
		/// <param name="p2">Player 2</param>
		public Game(Player p1, Player p2)
		{
			PlayerOne = p1;
			PlayerTwo = p2;
			Board = new Board();
		}

		/// <summary>
		/// Activate the Play of the game
		/// </summary>
		/// <returns>Winner</returns>
		public Player Play()
		{
            ///Call stack for initailizing properties of the Player Objects already instantiated
            PlayerOne.Name = "Player One";
            PlayerTwo.Name = "Player Two";
            PlayerOne.Marker = "X";
            PlayerTwo.Marker = "O";
            PlayerOne.IsTurn = true;
            string[,] gb = Board.GameBoard;
            int turn = 0;
            /// while loop runs until either their is a winner or draw
            while (CheckForWinner(Board) == false && turn < 9)
            {
                turn++;
                Board.DisplayBoard(gb);
                Console.WriteLine();
                NextPlayer().TakeTurn(Board);
                SwitchPlayer();
            }

            CheckForWinner(Board);
            if (CheckForWinner(Board) == false)
            {
                Console.WriteLine("You've reached a draw!");
            }
            else
            {
                Console.WriteLine($"{Winner.Name} won the game!");
            }

            Board.DisplayBoard(gb);
            return Winner;
		}


		/// <summary>
		/// Check if winner exists
		/// </summary>
		/// <param name="board">current state of the board</param>
		/// <returns>if winner exists</returns>
		public bool CheckForWinner(Board board)
		{
			int[][] winners = new int[][]
			{
				new[] {1,2,3},
				new[] {4,5,6},
				new[] {7,8,9},

				new[] {1,4,7},
				new[] {2,5,8},
				new[] {3,6,9},

				new[] {1,5,9},
				new[] {3,5,7}
			};

			// Given all the winning conditions, Determine the winning logic. 
			for (int i = 0; i < winners.Length; i++)
			{
				Position p1 = Player.PositionForNumber(winners[i][0]);
				Position p2 = Player.PositionForNumber(winners[i][1]);
				Position p3 = Player.PositionForNumber(winners[i][2]);

				string a = Board.GameBoard[p1.Row, p1.Column];
				string b = Board.GameBoard[p2.Row, p2.Column];
				string c = Board.GameBoard[p3.Row, p3.Column];

                // return true if a winner has been reached. 
                if (a == "X" && b == "X" && c == "X")
                {
                    Winner = PlayerOne;
                    return true;
                }
                else if (a == "O" && b == "O" && c == "O")
                {
                    Winner = PlayerTwo;
                    return true;
                }
            }
   
            return false;
		}


		/// <summary>
		/// Determine next player
		/// </summary>
		/// <returns>next player</returns>
		public Player NextPlayer()
		{
			return (PlayerOne.IsTurn) ? PlayerOne : PlayerTwo;
		}

		/// <summary>
		/// End one players turn and activate the other
		/// </summary>
		public void SwitchPlayer()
		{
			if (PlayerOne.IsTurn)
			{
              
				PlayerOne.IsTurn = false;

              
				PlayerTwo.IsTurn = true;
			}
			else
			{
				PlayerOne.IsTurn = true;
				PlayerTwo.IsTurn = false;
			}
		}


	}
}
