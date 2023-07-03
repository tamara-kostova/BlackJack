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
            lblscoreComputer = new Label();
            btnHit = new Button();
            btnStay = new Button();
            btnDeal = new Button();
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.SuspendLayout();
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
            // lblscoreComputer
            // 
            lblscoreComputer.AutoSize = true;
            lblscoreComputer.Location = new Point(970, 9);
            lblscoreComputer.Name = "lblscoreComputer";
            lblscoreComputer.Size = new Size(59, 25);
            lblscoreComputer.TabIndex = 1;
            lblscoreComputer.Text = "label1";
            // 
            // btnHit
            // 
            btnHit.Location = new Point(943, 241);
            btnHit.Name = "btnHit";
            btnHit.Size = new Size(112, 34);
            btnHit.TabIndex = 2;
            btnHit.Text = "Hit";
            btnHit.UseVisualStyleBackColor = true;
            btnHit.Click += btnHit_Click;
            // 
            // btnStay
            // 
            btnStay.Location = new Point(943, 293);
            btnStay.Name = "btnStay";
            btnStay.Size = new Size(112, 34);
            btnStay.TabIndex = 3;
            btnStay.Text = "Stay";
            btnStay.UseVisualStyleBackColor = true;
            btnStay.Click += btnStay_Click;
            // 
            // btnDeal
            // 
            btnDeal.Location = new Point(943, 135);
            btnDeal.Name = "btnDeal";
            btnDeal.Size = new Size(112, 34);
            btnDeal.TabIndex = 5;
            btnDeal.Text = "Deal";
            btnDeal.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            splitContainer1.Size = new Size(824, 449);
            splitContainer1.SplitterDistance = 224;
            splitContainer1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 504);
            Controls.Add(splitContainer1);
            Controls.Add(btnDeal);
            Controls.Add(btnStay);
            Controls.Add(btnHit);
            Controls.Add(lblscoreComputer);
            Controls.Add(lblscorePlayer);
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblscorePlayer;
        private Label lblscoreComputer;
        private Button btnHit;
        private Button btnStay;
        private Button btnDeal;
        private SplitContainer splitContainer1;
    }
}