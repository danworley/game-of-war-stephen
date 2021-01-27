using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace GameOfWar
{
    public class Tests
    {
        [Test]
        public void Has_52_cards()
        {
            var classUnderTest = new Game();
            var deck = classUnderTest.CreateDeck();
            Assert.That(deck.Count, Is.EqualTo(52));
        }

        [Test]
        [TestCase(2)]
        [TestCase(4)]
        [TestCase(6)]
        [TestCase(14)]
        public void Can_create_a_deck_with_real_cards(int value)
        {
            var classUnderTest = new Game();
            var deck = classUnderTest.CreateDeck();

            Assert.That(deck.Count(a => a == value), Is.EqualTo(4));
        }

                
    }
}