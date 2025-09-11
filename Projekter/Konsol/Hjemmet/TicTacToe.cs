using System.Runtime.InteropServices;

namespace Hjemmet
{


using System;
using System.Linq;
public class TicTacToe
{
    string[] grid = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

    public void Start()
    {
        bool isPlayer1Turn = true;
        int numTurns = 0;

        while (!CheckVictory() && numTurns != 9)
        {
            PrintGrid();
            Console.WriteLine(isPlayer1Turn ? "Player 1 turn!" : "Player 2 turn!");

            string choice = Console.ReadLine();

            if (grid.Contains(choice) && choice != "X" && choice != "0")
            {
                int gridIndex = Convert.ToInt32(choice) - 1;

                grid[gridIndex] = isPlayer1Turn ? "X" : "O";

                numTurns++;
                isPlayer1Turn = !isPlayer1Turn;
            }
            else
            {
                Console.WriteLine("Invalid choice, please pick an available number.");
            }
        }

        PrintGrid();

        if (CheckVictory())
            Console.WriteLine(isPlayer1Turn ? "Player 2 wins!" : "Player 1 wins!"); 
        else
            Console.WriteLine("It's a tie!");
    }

    bool CheckVictory()
    {
        bool row1 = grid[0] == grid[1] && grid[1] == grid[2];
        bool row2 = grid[3] == grid[4] && grid[4] == grid[5];
        bool row3 = grid[6] == grid[7] && grid[7] == grid[8];
        bool col1 = grid[0] == grid[3] && grid[3] == grid[6];
        bool col2 = grid[1] == grid[4] && grid[4] == grid[7];
        bool col3 = grid[2] == grid[5] && grid[5] == grid[8];
        bool diagDown = grid[0] == grid[4] && grid[4] == grid[8];
        bool diagUp = grid[6] == grid[4] && grid[4] == grid[2];

        return row1 || row2 || row3 || col1 || col2 || col3 || diagDown || diagUp;
    }

    void PrintGrid()
    {
        Console.WriteLine();
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"{grid[i * 3]}|{grid[i * 3 + 1]}|{grid[i * 3 + 2]}");
            if (i < 2)
                Console.WriteLine("-+-+-");
        }
        Console.WriteLine();
    }
}
}
