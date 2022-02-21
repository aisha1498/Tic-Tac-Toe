using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class TicTacToeGame
    {
        static void Main(string[] args)
        {
            var stillPlaying = true;
            Console.WriteLine("Welcome to Tic Tac Toe Game.");

            while (stillPlaying)
            {
                Console.WriteLine("What woulde you like to do?");
                Console.WriteLine("1. Start a new Game\n");
                Console.WriteLine("2. Quite");
                Console.WriteLine(" Type a number and <enter>:");
            }
            //making array
          char[] arr = { ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
          

        }
    }
}
