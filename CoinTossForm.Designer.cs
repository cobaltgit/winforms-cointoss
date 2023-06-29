namespace CoinToss
{
    partial class CoinTossForm
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
            Coin = new PictureBox();
            TossButton = new Button();
            ((System.ComponentModel.ISupportInitialize)Coin).BeginInit();
            SuspendLayout();
            // 
            // Coin
            // 
            Coin.Image = Properties.Resources.Tails;
            Coin.Location = new Point(20, 17);
            Coin.Name = "Coin";
            Coin.Size = new Size(185, 189);
            Coin.TabIndex = 0;
            Coin.TabStop = false;
            // 
            // TossButton
            // 
            TossButton.Location = new Point(75, 220);
            TossButton.Name = "TossButton";
            TossButton.Size = new Size(75, 23);
            TossButton.TabIndex = 1;
            TossButton.Text = "Toss";
            TossButton.UseVisualStyleBackColor = true;
            TossButton.Click += TossButton_Click;
            // 
            // CoinTossForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(224, 251);
            Controls.Add(TossButton);
            Controls.Add(Coin);
            Name = "CoinTossForm";
            Text = "Coin Toss";
            Load += CoinTossForm_Load;
            ((System.ComponentModel.ISupportInitialize)Coin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Coin;
        private Button TossButton;
    }
}