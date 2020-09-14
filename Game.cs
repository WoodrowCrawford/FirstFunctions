using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{

    struct Item
    {
        public int statBoost;
    }
    class Game
    {
        bool _gameOver = false;
        Player player1 = new Player("Sally", 101, 21);
        Player player2 = new Player("Kris", 150, 20);
        Item longSword;
        Item dagger;

        //Run the game
        public void Run()
        {
            Start();

            while(_gameOver == false)
            {
                Update();
            }

            End();
        }

       

        public void InitializeItems()
        {
            longSword.statBoost = 15;
            dagger.statBoost = 10;
        }

        //Displays two options to the player. Outputs the choice of the two options
        public void GetInput(out char input, string option1, string option2, string query)
        {

            Console.WriteLine(query);
            Console.WriteLine("1." + option1);
            Console.WriteLine("2." + option2);
            Console.WriteLine("> ");

            input = ' ';
            while (input != '1' && input != '2')
            {
                input = Console.ReadKey().KeyChar;
                if(input != '1' && input != '2')
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }

        //Equip items to both players in the begining of the game
        public void EquipItems()
        {
            //Get input for player one
            char input;
            GetInput(out input, "Longsword", "Dagger", "Welcome! Player one please choose a weapon.");
            //Equip item based on input value
            if (input == '1')
            {
                player1.EquipItem(longSword);
            }
            else if (input == '2')
            {
                _player1.EquipItem(dagger);
            }
        }
        //Performed once when the game begins
        public void Start()
        {
            
        }

        //Repeated until the game ends
        public void Update()
        {
            
        }

        //Performed once when the game ends
        public void End()
        {
            
        }
    }
}
