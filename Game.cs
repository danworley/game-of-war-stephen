using System;
using System.Collections.Generic;
using System.Linq;

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

        public List<int> Shuffle(List<int> deck)
        {
            var deckToBeShuffled = deck.ToList();
            for(int i = 0; i < 99; i++)
            {
                var r1 = new Random();
                var indexA = r1.Next(0, 51);

                var r2 = new Random();
                var indexB = r2.Next(0, 51);

                var valueBeingSwapped = deckToBeShuffled[indexA];
                deckToBeShuffled[indexA] = deckToBeShuffled[indexB];
                deckToBeShuffled[indexB] = valueBeingSwapped;
            }
            return deckToBeShuffled;
        }

        internal (List<int> PlayerOne, List<int> PlayerTwo) Deal(List<int> shuffledDeck)
        {
            throw new NotImplementedException();
        }
    }
}