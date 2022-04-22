﻿using System;
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
            int life = 6;
            _renderer.Render(5, 5, life);

            Console.SetCursorPosition(0, 13);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Your current guess: ");
            Console.WriteLine("--------------");
            Console.SetCursorPosition(0, 15);

            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("What is your next guess: ");
            var nextGuess = Console.ReadLine();
            List <string> words = { "Hang", "fire", "save man", "run" };
            
            Random random = new Random();
            int range = words.Length - 1;
            int select = random.Next(0, range);
            
            string currentWord = words[select];
            foreach(char letter in currentWord){
                //decreases life when guess letter of the word is wrong
                if(nextGuess != letter){
                    life--;
                    _renderer.Render(5, 5, life); 
                }
                if(life == 0){
                     Console.SetCursorPosition(0, 20);
                     Console.WriteLine("Game over!");
                }
            }
        }  
    }
}
