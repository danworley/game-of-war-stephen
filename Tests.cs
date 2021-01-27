using NUnit.Framework;
using System.Collections.Generic;

namespace GameOfWar
{
    public class Tests
    {
        [Test]
        public void Can_Get_A_Deck()
        {
            var cards = new List<int>();

            for(int i=0; i<4; i++)
            {
                for (int j = 2; j <= 14; j++)
                {
                    cards.Add(j);
                }
            }

            Assert.That(cards.Count, Is.EqualTo(52));
        }
    }
}