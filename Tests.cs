using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GameOfWar
{
    public class Tests
    {
        private Game classUnderTest;
        private List<int> deck;

        [SetUp]
        public void Setup()
        {
            classUnderTest = new Game();
            deck = classUnderTest.CreateDeck();
        }

        [Test]
        public void Has_52_cards()
        {
            Assert.That(deck.Count, Is.EqualTo(52));
        }

        [Test]
        [TestCase(2, 4)]
        [TestCase(4, 4)]
        [TestCase(6, 4)]
        [TestCase(14, 4)]
        [TestCase(15, 0)]
        public void Can_create_a_deck_with_real_cards(int value, int expectedCount)
        {
            Assert.That(deck.Count(a => a == value), Is.EqualTo(expectedCount));
        }

        [Test]
        public void Something()
        {
            var copyOfDeck = deck.ToList();

            //Loop 100 times
            //Get a random value between 0 and 51
            //Get a random value between 0 and 51
            //Swap

            for(int i = 0; i < 99; i++)
            {
                var r1 = new Random();
                var indexA = r1.Next(0, 51);

                var r2 = new Random();
                var indexB = r2.Next(0, 51);

                var valueBeingSwapped = copyOfDeck[indexA];
                copyOfDeck[indexA] = copyOfDeck[indexB];
                copyOfDeck[indexB] = valueBeingSwapped;
            }

            Assert.That(copyOfDeck.SequenceEqual(deck), Is.False);
        }
    }
}