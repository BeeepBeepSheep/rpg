using System;
using System.Collections.Generic;
using System.Text;

namespace RPG2
{
    class Game
    {
        //variables
        bool end;

        //private functions

        private void InitVariables()
        {
            this.end = false;
        }

        //constructors and destructors

        public Game()
        {
            this.InitVariables();
            Console.WriteLine("Hello from the game class");
        }
        public void Run()
        {
            while (this.end == false)
            {
                Console.WriteLine("Wtie a number");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number < 0)
                    this.end = true;
                else
                    Console.WriteLine("You inputted:" + number);
            }
            Console.WriteLine("ending game...");
        }
    }
}

