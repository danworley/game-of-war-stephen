using System;
using System.Collections.Generic;

namespace GameOfWar
{
    internal class Game
    {
        public Game()
        {
        }

        public List<int> CreateDeck()
        {
            var cards = new List<int>();

            for(int i=0; i<4; i++)
            {
                for (int j = 2; j <= 14; j++)
                {
                    cards.Add(j);
                }
            }
            return cards;
        }
    }
}