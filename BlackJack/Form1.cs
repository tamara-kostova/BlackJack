using System.Diagnostics;

namespace BlackJack
{
    public partial class Form1 : Form
    {

        public static string DealerSecondCard, PlayerFirstCard, PlayerSecondCard;
        public static int pScore1, pScore2;
        public static bool isGameOver;
        private int playerScore, dealerScore, rnCard, rnSuit, playerCardsCount, cardValue;
        private int dScore1, dScore2;
        private string suit, card, dCard;


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            StartNewGame();
        }
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            DealPlayerCard();
        }

        private void btnStay_Click(object sender, EventArgs e)
        {
            Stay();
        }

        private void StartNewGame()
        {
            try
            {
                btnHit.Enabled = true;
                btnStay.Enabled = true;

                isGameOver = false;
                btnNewGame.Text = "Quit";

                playerCard3.Visible = false;
                playerCard4.Visible = false;
                playerCard5.Visible = false;
                playerCard6.Visible = false;
                playerCard7.Visible = false;
                playerCard8.Visible = false;
                playerCard9.Visible = false;

                lblDealer.Visible = true;

                rnCard = 0;
                rnSuit = 0;
                playerScore = 0;
                dealerScore = 0;
                playerCardsCount = 0;

                dScore1 = 0;
                dScore2 = 0;
                pScore1 = 0;
                pScore2 = 0;

                suit = null;
                card = null;
                dCard = null;

                Random random = new Random();

                dScore1 = random.Next(1, 13);
                ConvertFaceCardToNumberValue(dScore1);
                dScore1 = cardValue;
                dScore2 = random.Next(1, 13);
                ConvertFaceCardToNumberValue(dScore2);
                dScore2 = cardValue;
                ConvertFaceCardToFileName(dScore2);

                dealerScore = dScore1 + dScore2;

                dealerCard1.Image = Image.FromFile("cards/back-red-75-2.png");
                SelectSuit();
                dealerCard2.Image = Image.FromFile("cards/" + suit + "-" + card + "-75.png");
                DealerSecondCard = suit + "-" + card + "-75.png";

                lblDealer.Visible = true;
                lblDealer.Text = "Dealer score: " + dealerScore;

                if (dealerScore < 21)
                {
                    DealCard();
                    pScore1 = rnCard;

                    ConvertFaceCardToNumberValue(pScore1);
                    pScore1 = cardValue;
                    playerCard1.Image = Image.FromFile("cards/" + dCard);
                    PlayerFirstCard = dCard;

                    DealCard();
                    pScore2 = rnCard;

                    ConvertFaceCardToNumberValue(pScore2);
                    pScore2 = cardValue;
                    playerCard2.Image = Image.FromFile("cards/" + dCard);
                    PlayerSecondCard = dCard;

                    playerScore = pScore1 + pScore2;
                    playerCardsCount = 2;
                }
                else
                    GameOver("dealer21");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void DealCard()
        {
            Random random = new Random();
            rnCard = random.Next(1, 13);
            ConvertFaceCardToFileName(rnCard);
            ConvertFaceCardToNumberValue(rnCard);
            SelectSuit();
            dCard = suit + "-" + card + "-75.png";
        }

        private void DealPlayerCard()
        {
            DealCard();
            playerCardsCount++;

            if (playerCardsCount == 3)
            {
                playerCard3.Image = Image.FromFile("cards/" + dCard);
                playerCard3.Visible = true;
            }
            else if (playerCardsCount == 4)
            {
                playerCard4.Image = Image.FromFile("cards/" + dCard);
                playerCard4.Visible = true;
            }
            else if (playerCardsCount == 5)
            {
                playerCard5.Image = Image.FromFile("cards/" + dCard);
                playerCard5.Visible = true;
            }
            else if (playerCardsCount == 6)
            {
                playerCard6.Image = Image.FromFile("cards/" + dCard);
                playerCard6.Visible = true;
            }
            else if (playerCardsCount == 7)
            {
                playerCard7.Image = Image.FromFile("cards/" + dCard);
                playerCard7.Visible = true;
            }
            else if (playerCardsCount == 8)
            {
                playerCard8.Image = Image.FromFile("cards/" + dCard);
                playerCard8.Visible = true;
            }
            else if (playerCardsCount == 9)
            {
                playerCard9.Image = Image.FromFile("cards/" + dCard);
                playerCard9.Visible = true;
            }
            else
            {
                GameOver("tooManyCards");
            }

            playerScore += cardValue;
            lblscorePlayer.Text = "Total: " + playerScore;

            if (playerScore > 21)
                GameOver("playerBust");

        }
        private void Stay()
        {
            btnStay.Enabled = false;
            btnHit.Enabled = false;
            lblDealer.Visible = true;
            lblDealer.Text = "Dealer score: " + dealerScore;

            ConvertFaceCardToNumberValue(dScore1);
            dScore1 = cardValue;
            ConvertFaceCardToFileName(dScore1);
            SelectSuit();

            dealerCard1.Image = Image.FromFile("cards/" + suit + "-" + card + "-75.png");

            if (dealerScore < 17 && dealerScore <= 21)
            {
                DealCard();
                dealerScore += rnCard;
                Stay();
            }
            if (isGameOver == false)
            {
                if (dealerScore > 17 && dealerScore <= 21 && dealerScore > playerScore)
                    GameOver("dealerWins");
                else if (dealerScore > 21)
                    GameOver("dealerBust");
                else if (playerScore > dealerScore)
                    GameOver("playerWins");
                else if (playerScore == dealerScore)
                    GameOver("draw");
            }
        }
        private void GameOver(string Condition)
        {
            bool playerWon = false;
            bool isDraw = false;

            lblDealer.Visible = true;
            btnHit.Enabled = false;
            btnStay.Enabled = false;

            isGameOver = true;
            btnNewGame.Text = "New Game";

            ConvertFaceCardToFileName(dScore1);
            SelectSuit();
            dealerCard1.Image = Image.FromFile("cards/" + suit + "-" + card + "-75.png");

            if (Condition == "playerBust")
                MessageBox.Show("Loss");
            else if (Condition == "dealer21")
                MessageBox.Show("The dealer's hand was 21! Game over!", "Loss");
            else if (Condition == "dealerWins")
                MessageBox.Show("Shame, the dealer's hand was higher than yours.", "Loss");
            else if (Condition == "tooManyCards")
                MessageBox.Show("You used too many cards. You lost.", "Loss");
            else if (Condition == "playerWins")
            {
                MessageBox.Show("Your hand is higher than the dealer's. You win!", "Win");
                playerWon = true;
            }
            else if (Condition == "dealerBust")
            {
                MessageBox.Show("The dealer busted. You win!", "Win");
                playerWon = true;
            }
            else if (Condition == "draw")
            {
                MessageBox.Show("You tied with the dealer.", "Draw");
                isDraw = true;
            }
        }

        private int ConvertFaceCardToNumberValue(int FaceCard)
        {
            if (FaceCard == 11 || FaceCard == 12 || FaceCard == 13)
                cardValue = 10;
            else
                cardValue = FaceCard;

            return cardValue;
        }

        private string ConvertFaceCardToFileName(int FaceCard)
        {
            if (FaceCard == 1)
                card = "a";
            else if (FaceCard == 11)
                card = "j";
            else if (FaceCard == 12)
                card = "q";
            else if (FaceCard == 13)
                card = "k";
            else
                card = FaceCard.ToString();

            return card;
        }
        private string SelectSuit()
        {
            Random random = new Random();
            rnSuit = random.Next(1, 4);
            if (rnSuit == 1)
                suit = "clubs";
            else if (rnSuit == 2)
                suit = "diamonds";
            else if (rnSuit == 3)
                suit = "hearts";
            else if (rnSuit == 4)
                suit = "spades";

            return suit;
        }
    }
}