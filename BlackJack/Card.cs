using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace BlackJack
{
    public class Card
    {
        Image image;
        Suit cardSuit;
        Face cardFace;
        public Image Image
        {
            get
            {
                return this.image;
            }
        }
        public Suit CardSuit
        {
            get
            {
                return this.cardSuit;
            }
            set
            {
                this.cardSuit = value;
                GetImage();
            }
        }
        public Face CardFace
        {
            get
            {
                return this.cardFace;
            }
            set
            {
                this.cardFace = value;
                GetImage();
            }
        }

        public Card()
        {
            cardSuit = 0;
            cardFace = 0;
            image = null;
        }
        private void GetImage()
        {
            if (this.CardSuit != 0 && this.CardFace != 0)
            {
                int x = 0;
                int y = 0;
                int height = 97;
                int width = 73;
                switch (this.CardSuit)
                {
                    case Suit.Hearts:
                        y = 196;
                        break;
                    case Suit.Spades:
                        y = 98;
                        break;
                    case Suit.Clubs:
                        y = 0;
                        break;
                    case Suit.Diamonds:
                        y = 294;
                        break;
                }
                x = width * ((int)this.CardFace - 1);
                //ResourceManager r = BlackJack.Properties.Resources.ResourceManager;
                Bitmap source = new Bitmap("cards.png", true);
                Bitmap img = new Bitmap(width, height);
                Graphics g = Graphics.FromImage(img);
                g.DrawImage(source, new Rectangle(0, 0, width, height), new Rectangle(x, y, width, height), GraphicsUnit.Pixel);
                g.Dispose();
                this.image = img;
            }
        }
        public override string? ToString()
        {
            string val = "";
            switch (cardFace)
            {
                case Face.Two:
                case Face.Three:
                case Face.Four:
                case Face.Five:
                case Face.Six:
                case Face.Seven:
                case Face.Eight:
                case Face.Nine:
                case Face.Ten:
                    val = ((int)cardFace).ToString();
                    break;
                case Face.Ace:
                case Face.Jack:
                case Face.Queen:
                case Face.King:
                    val = ((int)cardFace).ToString();
                    break;
            }
            return val + " of " + cardSuit.ToString();
        }
    }
    public enum Suit
    {
        Hearts = 1,
        Spades = 2,
        Clubs = 3,
        Diamonds = 4
    }
    public enum Face
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }
}