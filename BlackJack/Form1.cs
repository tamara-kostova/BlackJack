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
            ClearTable();
            playerScore = 0;
            dealerScore = 0;
            Deck deck = new Deck();
            Hand player = new Hand(2, deck);
            Hand dealer = new Hand(2, deck);
            lblscoreComputer.Text = "0";
            lblscorePlayer.Text = "0";

        }

        private void ClearTable()
        {
            throw new NotImplementedException();
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            Card drawn = deck.DrawCard(player);
            player.Cards.Add(drawn);
            player.AddValue(drawn, ref playerScore);

        }

        private void btnStay_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            lblscoreComputer.Text = dealerScore.ToString();
            lblscorePlayer.Text = playerScore.ToString();
        }
    }
}