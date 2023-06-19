using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Deck
    {
        private List<Card> cards;
        public List<Card> Cards
        {
            get { return this.cards; }
            set { this.cards = value; }
        }
        public Deck() { 
            Cards = new List<Card>();
            ShuffleDeck();
        }

        private void ShuffleDeck()
        {
            cards.Clear();
            for (int i=1; i<=4; i++)
            {
                for (int j=1; j<=13; j++)
                {
                    Card card = new Card();
                    card.CardFace = (Face)j;
                    card.CardSuit = (Suit)i;
                    cards.Add(card);
                }
            }
            Random random = new Random();
            cards = cards.OrderBy(x => random.Next()).ToList();
        }
        public Card DrawCard (Hand Hand)
        {
            Card drawn = cards[cards.Count - 1];
            cards.Remove(drawn);
            Hand.Cards.Add(drawn);
            return drawn;
        }
    }
}
