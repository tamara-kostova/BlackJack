namespace BlackJack
{
    public partial class Form1 : Form
    {
        private readonly int Starting_hand = 2;
        private readonly int Max_cards = 11;
        PictureBox p;
        PictureBox q;
        Deck deck;
        Hand player;
        Hand dealer;
        int playerScore;
        int dealerScore;
        public Form1()
        {
            InitializeComponent();
        }
        public void NewGame()
        {
            playerScore = 0;
            dealerScore = 0;
        }
    }
}