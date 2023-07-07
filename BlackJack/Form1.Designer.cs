namespace BlackJack
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblscorePlayer = new Label();
            lblDealer = new Label();
            btnHit = new Button();
            btnStay = new Button();
            dealerCard1 = new PictureBox();
            dealerCard2 = new PictureBox();
            playerCard2 = new PictureBox();
            playerCard1 = new PictureBox();
            playerCard4 = new PictureBox();
            playerCard3 = new PictureBox();
            playerCard6 = new PictureBox();
            playerCard5 = new PictureBox();
            playerCard8 = new PictureBox();
            playerCard7 = new PictureBox();
            playerCard9 = new PictureBox();
            btnNewGame = new Button();
            dealerDraws = new Label();
            ((System.ComponentModel.ISupportInitialize)dealerCard1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealerCard2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerCard2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerCard1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerCard4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerCard3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerCard6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerCard5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerCard8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerCard7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerCard9).BeginInit();
            SuspendLayout();
            // 
            // lblscorePlayer
            // 
            lblscorePlayer.AutoSize = true;
            lblscorePlayer.BackColor = Color.Transparent;
            lblscorePlayer.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblscorePlayer.ForeColor = SystemColors.ButtonFace;
            lblscorePlayer.Location = new Point(850, 421);
            lblscorePlayer.Margin = new Padding(2, 0, 2, 0);
            lblscorePlayer.Name = "lblscorePlayer";
            lblscorePlayer.Size = new Size(106, 28);
            lblscorePlayer.TabIndex = 0;
            lblscorePlayer.Text = "Your score:";
            // 
            // lblDealer
            // 
            lblDealer.AutoSize = true;
            lblDealer.BackColor = Color.Transparent;
            lblDealer.ForeColor = SystemColors.ButtonFace;
            lblDealer.Location = new Point(850, 9);
            lblDealer.Margin = new Padding(2, 0, 2, 0);
            lblDealer.Name = "lblDealer";
            lblDealer.Size = new Size(113, 25);
            lblDealer.TabIndex = 1;
            lblDealer.Text = "Dealer score:";
            // 
            // btnHit
            // 
            btnHit.Location = new Point(568, 374);
            btnHit.Margin = new Padding(2);
            btnHit.Name = "btnHit";
            btnHit.Size = new Size(112, 34);
            btnHit.TabIndex = 2;
            btnHit.Text = "Hit";
            btnHit.UseVisualStyleBackColor = true;
            btnHit.Click += btnHit_Click;
            // 
            // btnStay
            // 
            btnStay.Location = new Point(568, 435);
            btnStay.Margin = new Padding(2);
            btnStay.Name = "btnStay";
            btnStay.Size = new Size(112, 34);
            btnStay.TabIndex = 3;
            btnStay.Text = "Stay";
            btnStay.UseVisualStyleBackColor = true;
            btnStay.Click += btnStay_Click;
            // 
            // dealerCard1
            // 
            dealerCard1.Location = new Point(235, 12);
            dealerCard1.Margin = new Padding(2);
            dealerCard1.MaximumSize = new Size(75, 107);
            dealerCard1.MinimumSize = new Size(75, 107);
            dealerCard1.Name = "dealerCard1";
            dealerCard1.Size = new Size(75, 107);
            dealerCard1.SizeMode = PictureBoxSizeMode.AutoSize;
            dealerCard1.TabIndex = 6;
            dealerCard1.TabStop = false;
            // 
            // dealerCard2
            // 
            dealerCard2.Location = new Point(344, 12);
            dealerCard2.Margin = new Padding(2);
            dealerCard2.MaximumSize = new Size(75, 107);
            dealerCard2.MinimumSize = new Size(75, 107);
            dealerCard2.Name = "dealerCard2";
            dealerCard2.Size = new Size(75, 107);
            dealerCard2.SizeMode = PictureBoxSizeMode.AutoSize;
            dealerCard2.TabIndex = 7;
            dealerCard2.TabStop = false;
            // 
            // playerCard2
            // 
            playerCard2.Location = new Point(371, 374);
            playerCard2.Margin = new Padding(2);
            playerCard2.MaximumSize = new Size(75, 107);
            playerCard2.MinimumSize = new Size(75, 107);
            playerCard2.Name = "playerCard2";
            playerCard2.Size = new Size(75, 107);
            playerCard2.SizeMode = PictureBoxSizeMode.AutoSize;
            playerCard2.TabIndex = 9;
            playerCard2.TabStop = false;
            // 
            // playerCard1
            // 
            playerCard1.Location = new Point(235, 374);
            playerCard1.Margin = new Padding(2);
            playerCard1.MaximumSize = new Size(75, 107);
            playerCard1.MinimumSize = new Size(75, 107);
            playerCard1.Name = "playerCard1";
            playerCard1.Size = new Size(75, 107);
            playerCard1.SizeMode = PictureBoxSizeMode.AutoSize;
            playerCard1.TabIndex = 8;
            playerCard1.TabStop = false;
            // 
            // playerCard4
            // 
            playerCard4.Location = new Point(168, 184);
            playerCard4.Margin = new Padding(2);
            playerCard4.MaximumSize = new Size(75, 107);
            playerCard4.MinimumSize = new Size(75, 107);
            playerCard4.Name = "playerCard4";
            playerCard4.Size = new Size(75, 107);
            playerCard4.SizeMode = PictureBoxSizeMode.AutoSize;
            playerCard4.TabIndex = 11;
            playerCard4.TabStop = false;
            // 
            // playerCard3
            // 
            playerCard3.Location = new Point(32, 184);
            playerCard3.Margin = new Padding(2);
            playerCard3.MaximumSize = new Size(75, 107);
            playerCard3.MinimumSize = new Size(75, 107);
            playerCard3.Name = "playerCard3";
            playerCard3.Size = new Size(75, 107);
            playerCard3.SizeMode = PictureBoxSizeMode.AutoSize;
            playerCard3.TabIndex = 10;
            playerCard3.TabStop = false;
            // 
            // playerCard6
            // 
            playerCard6.Location = new Point(442, 184);
            playerCard6.Margin = new Padding(2);
            playerCard6.MaximumSize = new Size(75, 107);
            playerCard6.MinimumSize = new Size(75, 107);
            playerCard6.Name = "playerCard6";
            playerCard6.Size = new Size(75, 107);
            playerCard6.SizeMode = PictureBoxSizeMode.AutoSize;
            playerCard6.TabIndex = 13;
            playerCard6.TabStop = false;
            // 
            // playerCard5
            // 
            playerCard5.Location = new Point(308, 184);
            playerCard5.Margin = new Padding(2);
            playerCard5.MaximumSize = new Size(75, 107);
            playerCard5.MinimumSize = new Size(75, 107);
            playerCard5.Name = "playerCard5";
            playerCard5.Size = new Size(75, 107);
            playerCard5.SizeMode = PictureBoxSizeMode.AutoSize;
            playerCard5.TabIndex = 12;
            playerCard5.TabStop = false;
            // 
            // playerCard8
            // 
            playerCard8.Location = new Point(702, 184);
            playerCard8.Margin = new Padding(2);
            playerCard8.MaximumSize = new Size(75, 107);
            playerCard8.MinimumSize = new Size(75, 107);
            playerCard8.Name = "playerCard8";
            playerCard8.Size = new Size(75, 107);
            playerCard8.SizeMode = PictureBoxSizeMode.AutoSize;
            playerCard8.TabIndex = 15;
            playerCard8.TabStop = false;
            // 
            // playerCard7
            // 
            playerCard7.Location = new Point(568, 184);
            playerCard7.Margin = new Padding(2);
            playerCard7.MaximumSize = new Size(75, 107);
            playerCard7.MinimumSize = new Size(75, 107);
            playerCard7.Name = "playerCard7";
            playerCard7.Size = new Size(75, 107);
            playerCard7.SizeMode = PictureBoxSizeMode.AutoSize;
            playerCard7.TabIndex = 14;
            playerCard7.TabStop = false;
            // 
            // playerCard9
            // 
            playerCard9.Location = new Point(834, 184);
            playerCard9.Margin = new Padding(2);
            playerCard9.MaximumSize = new Size(75, 107);
            playerCard9.MinimumSize = new Size(75, 107);
            playerCard9.Name = "playerCard9";
            playerCard9.Size = new Size(75, 107);
            playerCard9.SizeMode = PictureBoxSizeMode.AutoSize;
            playerCard9.TabIndex = 16;
            playerCard9.TabStop = false;
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new Point(12, 32);
            btnNewGame.Margin = new Padding(2);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(162, 45);
            btnNewGame.TabIndex = 17;
            btnNewGame.Text = "Restart";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // dealerDraws
            // 
            dealerDraws.AutoSize = true;
            dealerDraws.BackColor = Color.Transparent;
            dealerDraws.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dealerDraws.ForeColor = SystemColors.ButtonFace;
            dealerDraws.Location = new Point(399, 144);
            dealerDraws.Margin = new Padding(2, 0, 2, 0);
            dealerDraws.Name = "dealerDraws";
            dealerDraws.Size = new Size(128, 28);
            dealerDraws.TabIndex = 18;
            dealerDraws.Text = "Dealer draws:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 529);
            Controls.Add(dealerDraws);
            Controls.Add(btnNewGame);
            Controls.Add(playerCard9);
            Controls.Add(playerCard8);
            Controls.Add(playerCard7);
            Controls.Add(playerCard6);
            Controls.Add(playerCard5);
            Controls.Add(playerCard4);
            Controls.Add(playerCard3);
            Controls.Add(playerCard2);
            Controls.Add(playerCard1);
            Controls.Add(dealerCard2);
            Controls.Add(dealerCard1);
            Controls.Add(btnStay);
            Controls.Add(btnHit);
            Controls.Add(lblDealer);
            Controls.Add(lblscorePlayer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dealerCard1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealerCard2).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerCard2).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerCard1).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerCard4).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerCard3).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerCard6).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerCard5).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerCard8).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerCard7).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerCard9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblscorePlayer;
        private Label lblDealer;
        private Button btnHit;
        private Button btnStay;
        private PictureBox dealerCard1;
        private PictureBox dealerCard2;
        private PictureBox playerCard2;
        private PictureBox playerCard1;
        private PictureBox playerCard4;
        private PictureBox playerCard3;
        private PictureBox playerCard6;
        private PictureBox playerCard5;
        private PictureBox playerCard8;
        private PictureBox playerCard7;
        private PictureBox playerCard9;
        private Button btnNewGame;
        private Label dealerDraws;
    }
}