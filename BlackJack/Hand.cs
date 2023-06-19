using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Hand
    {
        private List <Card> cards;
        public List<Card> Cards
        {
            get { return cards; }
        }
        public Hand(int Starting, Deck Deck)
        {
            if (Deck == null)
                throw new DeckException("No deck available to draw from");
            if (Deck.Cards.Count == 0)
                throw new DeckException("No more cards available");
            cards = new List<Card>();
            for (int i=0; i<Starting; i++)
            {
                Deck.DrawCard(this);
            }
        }
        public void AddValue (Card drawn, ref int currentScore)
        {
            if (drawn.CardFace == Face.Ace)
            {
                if (currentScore <= 10)
                    currentScore += 11;
                else
                    currentScore += 1;
            }
            else if (drawn.CardFace == Face.Jack || drawn.CardFace == Face.Queen || drawn.CardFace == Face.King)
                currentScore += 10;
            else
                currentScore += (int)drawn.CardFace;
        }
    }
}
