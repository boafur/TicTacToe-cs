using System;

namespace TicTacToe
{
    class Program
    {
        public static void Main(string[] args)
        {
            char player = 'X';
            char[,] board = new char[3, 3];
            Initialize(board);
            Print(board);
            bool gameEnd = false;
            int movesPlayed = 0;

            while (gameEnd == false)
            {
                Console.Clear();
                Print(board);

                Console.WriteLine();
                Console.WriteLine($"It is {player}'s turn.");
                // Grab what row and column the user wants
                Console.Write("Please enter row: ");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter the column: ");
                int col = Convert.ToInt32(Console.ReadLine());

                if (board[row, col] == 'X' || board[row, col] == 'O')
                {
                    Console.WriteLine("Slot already taken, press any key to restart your turn.");
                    Console.ReadKey();
                    continue;
                }
                else
                {
                    // Set board values to X or O based off of what the user gave as input
                    board[row, col] = player;
                }

                // Check if the current player won
                // Horizontal checks
                if (player == board[0, 0] && player == board[0, 1] && player == board[0, 2])
                {
                    Console.WriteLine(player + " has won the game");
                    gameEnd = true;
                    break;
                }
                else if (player == board[1, 0] && player == board[1, 1] && player == board[1, 2])
                {
                    Console.WriteLine(player + " has won the game");
                    gameEnd = true;
                    break;
                }
                else if (player == board[2, 0] && player == board[2, 1] && player == board[2, 2])
                {
                    Console.WriteLine(player + " has won the game");
                    gameEnd = true;
                    break;
                }
                // Vertical checks
                else if (player == board[0, 0] && player == board[1, 0] && player == board[2, 0])
                {
                    Console.WriteLine(player + " has won the game");
                    gameEnd = true;
                    break;
                }
                else if (player == board[0, 1] && player == board[1, 1] && player == board[2, 1])
                {
                    Console.WriteLine(player + " has won the game");
                    gameEnd = true;
                    break;
                }
                else if (player == board[0, 2] && player == board[1, 2] && player == board[2, 2])
                {
                    Console.WriteLine(player + " has won the game");
                    gameEnd = true;
                    break;
                }
                // Diagonal checks
                else if (player == board[0, 0] && player == board[1, 1] && player == board[2, 2])
                {
                    Console.WriteLine(player + " has won the game");
                    gameEnd = true;
                    break;
                }
                else if (player == board[0, 2] && player == board[1, 1] && player == board[2, 0])
                {
                    Console.WriteLine(player + " has won the game");
                    gameEnd = true;
                    break;
                }
                else if (movesPlayed >= 9)
                {
                    Console.WriteLine("Draw, nobody won.");
                    gameEnd = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Something happened and the game ended early.");
                    gameEnd = true;
                    break;
                }

                player = ChangeTurn(player);

                movesPlayed++;
            }
        }

        static char ChangeTurn(char player)
        {
            if (player == 'O') return 'X'; else return 'O';

        }

        static void Initialize(char[,] board)
        {
            // Set the default value for each space on the board to nothing
            for (int rows = 0; rows < 3; rows++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[rows, col] = ' ';
                }
            }
        }

        static void Print(char[,] board)
        {
            Console.WriteLine("    0   1   2");
            // Print the board
            for (int row = 0; row < 3; row++)
            {
                Console.Write(row + " | ");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(board[row, col]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
        }
    }
}
