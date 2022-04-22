using System;
using System.Collections.Generic;
using HangmanRenderer.Renderer;

namespace Hangman.Core.Game
{
    public class HangmanGame
    {
        private GallowsRenderer _renderer;
        int select;
        List<string> words;
        string currentWord;
        public HangmanGame()
        {
            _renderer = new GallowsRenderer();
            words = new List<string> { "Hang", "fire", "save", "run", "eating", "jumping", "delete" };
            Random random = new Random();
            int range = words.Count - 1;
            select = random.Next(0, range);
            currentWord = words[select].ToLower();
        }

        public void Run()
        {
            int wrong = 0;
            int count = 0;
            _renderer.Render(5, 5, 6);// life on maximum

            Console.SetCursorPosition(0, 13);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Your current guess: ");
            Console.WriteLine("--------------");
            Console.SetCursorPosition(0, 15);

            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("What is your next guess: ");
            char nextGuess; 
            
            //Console.WriteLine(currentWord);
            while (wrong < 6)
            {
                nextGuess = char.Parse(Console.ReadLine());

                if (currentWord.Contains(nextGuess))
                {
                    Console.WriteLine("Your guess is correct.");
                    
                }
                else if (!currentWord.Contains(nextGuess))
                {
                    Console.WriteLine("You guess was wrong");
                    Console.WriteLine("Guess again.....");
                    wrong++;
                    if (wrong == 1)
                    {
                        _renderer.Render(5, 5, 5);
                    }
                    if (wrong == 2)
                    {
                        _renderer.Render(5, 5, 4);
                    }
                    if (wrong == 3)
                    {
                        _renderer.Render(5, 5, 3);
                    }
                    if (wrong == 4)
                    {
                        _renderer.Render(5, 5, 2);
                    }
                    if (wrong == 5)
                    {
                        _renderer.Render(5, 5, 1);
                    }
                    if (wrong == 5) { 
                        _renderer.Render(5, 5, 0);
                    }
                    if (wrong == 6)
                    {
                        Console.WriteLine($"word is {currentWord}");
                        break;
                    }
                }
                if (count == currentWord.Length)
                {
                    Console.WriteLine($"congradulations you got correct word:  {currentWord}");
                }
               

                
                count++;

            }  
        }  

    }
}
