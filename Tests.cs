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
        public void Can_shuffle_deck()
        {
            var shuffledDeck = classUnderTest.Shuffle(deck);
            Assert.That(deck.SequenceEqual(shuffledDeck), Is.False);
        }

        [Test]
        public void Can_deal_to_two_players()
        {
            var shuffledDeck = classUnderTest.Shuffle(deck);
            var dealtDecks = classUnderTest.Deal(shuffledDeck);

            Assert.That(dealtDecks.PlayerOne.Count, Is.EqualTo(26));
            Assert.That(dealtDecks.PlayerTwo.Count, Is.EqualTo(26));
        }
    }
}