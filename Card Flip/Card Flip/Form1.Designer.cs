namespace Card_Flip
{
    partial class cardFlip
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cardBackPictureBox = new System.Windows.Forms.PictureBox();
            this.cardFrontPictureBox = new System.Windows.Forms.PictureBox();
            this.showBackButton = new System.Windows.Forms.Button();
            this.showFaceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardBackPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFrontPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cardBackPictureBox
            // 
            this.cardBackPictureBox.Image = global::Card_Flip.Properties.Resources.backOfCard;
            this.cardBackPictureBox.Location = new System.Drawing.Point(25, 26);
            this.cardBackPictureBox.Name = "cardBackPictureBox";
            this.cardBackPictureBox.Size = new System.Drawing.Size(141, 223);
            this.cardBackPictureBox.TabIndex = 0;
            this.cardBackPictureBox.TabStop = false;
            // 
            // cardFrontPictureBox
            // 
            this.cardFrontPictureBox.Image = global::Card_Flip.Properties.Resources.frontOfCard;
            this.cardFrontPictureBox.Location = new System.Drawing.Point(172, 26);
            this.cardFrontPictureBox.Name = "cardFrontPictureBox";
            this.cardFrontPictureBox.Size = new System.Drawing.Size(138, 223);
            this.cardFrontPictureBox.TabIndex = 1;
            this.cardFrontPictureBox.TabStop = false;
            this.cardFrontPictureBox.Visible = false;
            // 
            // showBackButton
            // 
            this.showBackButton.Location = new System.Drawing.Point(58, 264);
            this.showBackButton.Name = "showBackButton";
            this.showBackButton.Size = new System.Drawing.Size(73, 40);
            this.showBackButton.TabIndex = 2;
            this.showBackButton.Text = "Show the Card Back";
            this.showBackButton.UseVisualStyleBackColor = true;
            this.showBackButton.Click += new System.EventHandler(this.showBackButton_Click);
            // 
            // showFaceButton
            // 
            this.showFaceButton.Location = new System.Drawing.Point(205, 264);
            this.showFaceButton.Name = "showFaceButton";
            this.showFaceButton.Size = new System.Drawing.Size(67, 40);
            this.showFaceButton.TabIndex = 3;
            this.showFaceButton.Text = "Show the Card Face";
            this.showFaceButton.UseVisualStyleBackColor = true;
            this.showFaceButton.Click += new System.EventHandler(this.showFaceButton_Click);
            // 
            // cardFlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 307);
            this.Controls.Add(this.showFaceButton);
            this.Controls.Add(this.showBackButton);
            this.Controls.Add(this.cardFrontPictureBox);
            this.Controls.Add(this.cardBackPictureBox);
            this.Name = "cardFlip";
            this.Text = "Card Flip";
            ((System.ComponentModel.ISupportInitialize)(this.cardBackPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFrontPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cardBackPictureBox;
        private System.Windows.Forms.PictureBox cardFrontPictureBox;
        private System.Windows.Forms.Button showBackButton;
        private System.Windows.Forms.Button showFaceButton;
    }
}

