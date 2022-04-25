using System;
using System.Collections.Generic;
using System.Text;
using HangmanRenderer.Renderer;

namespace Hangman.Core.Game
{
    public class HangmanGame
    {
        private GallowsRenderer _renderer;
        int select;
        List<string> words;
        string currentWord;
        string displayGuess;
        public HangmanGame()
        {
            _renderer = new GallowsRenderer();
            words = new List<string> { "Hang", "fire", "save", "run", "eating", "jumping", "delete" };
            Random random = new Random();
            int range = words.Count;
            select = random.Next(0, range);
            currentWord = words[select].ToLower();
        }

        public void Run()
        {
            int wrong = 0;
            int count = 0;
            _renderer.Render(5, 5, 6);// life on maximum

            Console.SetCursorPosition(0, 15);
            Console.ForegroundColor = ConsoleColor.Blue;
           // Console.Write("Your current guess: ");

            char[] displayToPlayer = currentWord.ToCharArray();
            char [] playerToDisplay = new char[displayToPlayer.Length];
            
            for (int i = 0; i < currentWord.Length; i++)
            {
                displayGuess += "-";
            }
             
            
            
            Console.SetCursorPosition(0, 15);

            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("What is your next guess: ");
            Console.SetCursorPosition (0, 16);
            Console.WriteLine(displayGuess);
            char nextGuess; 
            
            //Console.WriteLine(currentWord);
            while (wrong < 6)
            {
                Console.SetCursorPosition(0, 13);
                nextGuess = char.Parse(Console.ReadLine());

                if (currentWord.Contains(nextGuess))
                {
                    //Console.SetCursorPosition(0, 15);
                    

                }
                else if (!currentWord.Contains(nextGuess))
                {
                    //Console.SetCursorPosition(0, 15);

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
                        Console.SetCursorPosition(0, 15);
                        Console.WriteLine($"word is {currentWord}");
                        break;
                    }
                }
                if (count == currentWord.Length )
                {
                   // Console.SetCursorPosition(0, 15);
                    // Console.WriteLine($"congradulations you got correct word:  {currentWord}                                                    ");
                    //break;
                }
               

                
                count++;

            }  
        }  

    }
}