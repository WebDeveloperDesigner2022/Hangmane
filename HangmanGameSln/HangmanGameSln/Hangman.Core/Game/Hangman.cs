using System;
using HangmanRenderer.Renderer;

namespace Hangman.Core.Game
{
    public class HangmanGame
    {
        private GallowsRenderer _renderer;
        

        public HangmanGame()
        {
            _renderer = new GallowsRenderer();
        }

        public void Run()
        {
            _renderer.Render(5, 5, 6);

            Console.SetCursorPosition(0, 13);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Your current guess: ");
            Console.WriteLine("--------------");
            Console.SetCursorPosition(0, 15);

            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("What is your next guess: ");

            string[] words = { "Hang", "fire", "save man", "run" };
            var nextGuess = Console.ReadLine();
            Random random = new Random();
            int range = words.Length - 1;
            int select = random.Next(0, range);
            Console.WriteLine(select);
            _renderer.Render(5, 5, 5);
            string guess = Console.ReadLine();
            foreach (string word in words)
            {

            }
        }

       /* public void PlayGame()
        {
           
        }*/
    }
}
