using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Collection
    {
        protected List<Card> cards = new List<Card>();

        virtual public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public void RemoveCard(Card card)
        {
            foreach (Card c in cards)
            {
                if (c.Name == card.Name)
                {
                    cards.Remove(c);
                }
            }
        }

        public void SearchCard(string criteria)
        {
            var results = from card in cards where card.ToString().Contains(criteria) select card;
            foreach(var card in results)
            {
                Console.WriteLine(card);
            }
        }
        public void DisplayCollection()
        {
            foreach (var card in cards)
            {
                Console.WriteLine(card);
            }
        }
        public List<Card> GetCards()
        {
            return new List<Card>(cards);
        }
    }
}
