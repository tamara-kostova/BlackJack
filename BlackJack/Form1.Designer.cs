﻿namespace BlackJack
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
            btnDeal = new Button();
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
            lblscorePlayer.Location = new Point(970, 424);
            lblscorePlayer.Name = "lblscorePlayer";
            lblscorePlayer.Size = new Size(59, 25);
            lblscorePlayer.TabIndex = 0;
            lblscorePlayer.Text = "label1";
            // 
            // lblDealer
            // 
            lblDealer.AutoSize = true;
            lblDealer.Location = new Point(784, 9);
            lblDealer.Name = "lblDealer";
            lblDealer.Size = new Size(59, 25);
            lblDealer.TabIndex = 1;
            lblDealer.Text = "label1";
            // 
            // btnHit
            // 
            btnHit.Location = new Point(567, 374);
            btnHit.Name = "btnHit";
            btnHit.Size = new Size(112, 34);
            btnHit.TabIndex = 2;
            btnHit.Text = "Hit";
            btnHit.UseVisualStyleBackColor = true;
            btnHit.Click += btnHit_Click;
            // 
            // btnStay
            // 
            btnStay.Location = new Point(567, 435);
            btnStay.Name = "btnStay";
            btnStay.Size = new Size(112, 34);
            btnStay.TabIndex = 3;
            btnStay.Text = "Stay";
            btnStay.UseVisualStyleBackColor = true;
            btnStay.Click += btnStay_Click;
            // 
            // btnDeal
            // 
            btnDeal.Location = new Point(703, 405);
            btnDeal.Name = "btnDeal";
            btnDeal.Size = new Size(112, 34);
            btnDeal.TabIndex = 5;
            btnDeal.Text = "Deal";
            btnDeal.UseVisualStyleBackColor = true;
            // 
            // dealerCard1
            // 
            dealerCard1.Location = new Point(235, 12);
            dealerCard1.Name = "dealerCard1";
            dealerCard1.Size = new Size(88, 129);
            dealerCard1.TabIndex = 6;
            dealerCard1.TabStop = false;
            // 
            // dealerCard2
            // 
            dealerCard2.Location = new Point(371, 12);
            dealerCard2.Name = "dealerCard2";
            dealerCard2.Size = new Size(88, 129);
            dealerCard2.TabIndex = 7;
            dealerCard2.TabStop = false;
            // 
            // playerCard2
            // 
            playerCard2.Location = new Point(371, 374);
            playerCard2.Name = "playerCard2";
            playerCard2.Size = new Size(88, 129);
            playerCard2.TabIndex = 9;
            playerCard2.TabStop = false;
            // 
            // playerCard1
            // 
            playerCard1.Location = new Point(235, 374);
            playerCard1.Name = "playerCard1";
            playerCard1.Size = new Size(88, 129);
            playerCard1.TabIndex = 8;
            playerCard1.TabStop = false;
            // 
            // playerCard4
            // 
            playerCard4.Location = new Point(168, 184);
            playerCard4.Name = "playerCard4";
            playerCard4.Size = new Size(88, 129);
            playerCard4.TabIndex = 11;
            playerCard4.TabStop = false;
            // 
            // playerCard3
            // 
            playerCard3.Location = new Point(32, 184);
            playerCard3.Name = "playerCard3";
            playerCard3.Size = new Size(88, 129);
            playerCard3.TabIndex = 10;
            playerCard3.TabStop = false;
            // 
            // playerCard6
            // 
            playerCard6.Location = new Point(443, 184);
            playerCard6.Name = "playerCard6";
            playerCard6.Size = new Size(88, 129);
            playerCard6.TabIndex = 13;
            playerCard6.TabStop = false;
            // 
            // playerCard5
            // 
            playerCard5.Location = new Point(307, 184);
            playerCard5.Name = "playerCard5";
            playerCard5.Size = new Size(88, 129);
            playerCard5.TabIndex = 12;
            playerCard5.TabStop = false;
            // 
            // playerCard8
            // 
            playerCard8.Location = new Point(703, 184);
            playerCard8.Name = "playerCard8";
            playerCard8.Size = new Size(88, 129);
            playerCard8.TabIndex = 15;
            playerCard8.TabStop = false;
            // 
            // playerCard7
            // 
            playerCard7.Location = new Point(567, 184);
            playerCard7.Name = "playerCard7";
            playerCard7.Size = new Size(88, 129);
            playerCard7.TabIndex = 14;
            playerCard7.TabStop = false;
            // 
            // playerCard9
            // 
            playerCard9.Location = new Point(834, 184);
            playerCard9.Name = "playerCard9";
            playerCard9.Size = new Size(88, 129);
            playerCard9.TabIndex = 16;
            playerCard9.TabStop = false;
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new Point(36, 33);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(96, 45);
            btnNewGame.TabIndex = 17;
            btnNewGame.Text = "Surrender";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 504);
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
            Controls.Add(btnDeal);
            Controls.Add(btnStay);
            Controls.Add(btnHit);
            Controls.Add(lblDealer);
            Controls.Add(lblscorePlayer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
        private Button btnDeal;
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
    }
}