using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Deck : Collection
    {
        private const int MAX_DECK_SIZE = 60;
        private const int MAX_COPIES = 4;
        public override void AddCard(Card card)
        {
            if (cards.Count >= MAX_DECK_SIZE)
            {
                Console.WriteLine("Cannot add card. Deck is at maximum size.");
                return;
            }

            int copiesInDeck = 0;
            foreach(Card c in cards)
            {
                if (c.Name == card.Name)
                {
                    copiesInDeck++;
                }
            }

            if (copiesInDeck >= MAX_COPIES && card.Type != "Basic Land")
            {
                Console.WriteLine($"Cannot add more than {MAX_COPIES} copies of {card.Name}.");
                return;
            }

            base.AddCard(card);
        }
    }
}
