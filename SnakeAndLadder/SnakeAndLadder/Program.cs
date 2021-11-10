using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To SNAKE AND LADDER Game");
            SnakeAndLadder playerOne = new SnakeAndLadder();
            playerOne.DieRolling();
            playerOne.PlayerCheck();
        }
    }
}

