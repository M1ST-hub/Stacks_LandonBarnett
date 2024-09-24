using System;
using System.Collections.Generic;

namespace Stacks_LandonBarnett
{
    class Program
    {
        static void Main(string[] args)
        {
            // New array listing cards
            Card[] myCardsArray = new Card[]
            {
                new Card("Ace","Spades"),
                new Card("Jack","Clubs"),
                new Card("Queen","Diamonds"),
                new Card("Queen","Hearts"),
                new Card("10","Hearts"),
                new Card("2","Diamonds"),
                new Card("6","Spades"),
                new Card("9","Clubs"),
                new Card("Ace","Diamonds")
            };

            //Makes a new stack using cards array
            Stack<Card> startingDeck = new Stack<Card>(myCardsArray);

            //Prints statement and lists the cards in the deck
            Console.WriteLine("Cards in Deck");
            foreach (Card card in startingDeck)
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}!");
            }

            //prints a count of the cards in the deck
            Console.WriteLine($"Cards in the deck: {startingDeck.Count}");

            // Makes a list which is your hand and adds 3 cards
            List<Card> myHand = new List<Card>();
            myHand.Add(new Card("Jack", "Diamonds"));
            myHand.Add(new Card("8", "Hearts"));
            myHand.Add(new Card("3", "Diamonds"));

            //asks if you have any 8's
            Console.WriteLine("Got any 8's?");
            //if starting deck has anything thenmy hand adds starting deck
            if (startingDeck.Count > 0) ;
            {
                myHand.Add(startingDeck.Pop());
            }

            //prints statement cards in deck
            Console.WriteLine($"Cards in the deck: {startingDeck.Count}");

            //push first item in my hand to starting deck
            startingDeck.Push(myHand[0]);
            myHand.RemoveAt(0);

            //prints starting deck
            Console.WriteLine("Cards in Deck");
            foreach (Card card in startingDeck)
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}!");
            }
        }
    }
}