namespace Clock
{
    partial class Author
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Author));
            GitHubPicture = new PictureBox();
            AuthorPicture = new PictureBox();
            TelegramPicture = new PictureBox();
            GmailPicture = new PictureBox();
            AuthorInformationLabel = new Label();
            AuthorToolTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)GitHubPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AuthorPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TelegramPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GmailPicture).BeginInit();
            SuspendLayout();
            // 
            // GitHubPicture
            // 
            GitHubPicture.BackColor = Color.FromArgb(32, 32, 32);
            GitHubPicture.BackgroundImageLayout = ImageLayout.Stretch;
            GitHubPicture.Image = (Image)resources.GetObject("GitHubPicture.Image");
            GitHubPicture.Location = new Point(667, 300);
            GitHubPicture.Name = "GitHubPicture";
            GitHubPicture.Size = new Size(135, 138);
            GitHubPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            GitHubPicture.TabIndex = 1;
            GitHubPicture.TabStop = false;
            AuthorToolTip.SetToolTip(GitHubPicture, "GitHub");
            GitHubPicture.Click += GitHubPicture_Click;
            // 
            // AuthorPicture
            // 
            AuthorPicture.BackgroundImageLayout = ImageLayout.Stretch;
            AuthorPicture.Image = (Image)resources.GetObject("AuthorPicture.Image");
            AuthorPicture.Location = new Point(12, 12);
            AuthorPicture.Name = "AuthorPicture";
            AuthorPicture.Size = new Size(318, 426);
            AuthorPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            AuthorPicture.TabIndex = 2;
            AuthorPicture.TabStop = false;
            AuthorToolTip.SetToolTip(AuthorPicture, "Instagram");
            AuthorPicture.Click += AuthorPicture_Click;
            // 
            // TelegramPicture
            // 
            TelegramPicture.BackgroundImageLayout = ImageLayout.Stretch;
            TelegramPicture.Image = (Image)resources.GetObject("TelegramPicture.Image");
            TelegramPicture.Location = new Point(502, 300);
            TelegramPicture.Name = "TelegramPicture";
            TelegramPicture.Size = new Size(135, 138);
            TelegramPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            TelegramPicture.TabIndex = 3;
            TelegramPicture.TabStop = false;
            AuthorToolTip.SetToolTip(TelegramPicture, "Telegram");
            TelegramPicture.Click += TelegramPicture_Click;
            // 
            // GmailPicture
            // 
            GmailPicture.BackgroundImageLayout = ImageLayout.Stretch;
            GmailPicture.Image = (Image)resources.GetObject("GmailPicture.Image");
            GmailPicture.Location = new Point(337, 300);
            GmailPicture.Name = "GmailPicture";
            GmailPicture.Size = new Size(135, 138);
            GmailPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            GmailPicture.TabIndex = 4;
            GmailPicture.TabStop = false;
            AuthorToolTip.SetToolTip(GmailPicture, "Gmail");
            GmailPicture.Click += GmailPicture_Click;
            // 
            // AuthorInformationLabel
            // 
            AuthorInformationLabel.AutoSize = true;
            AuthorInformationLabel.FlatStyle = FlatStyle.Flat;
            AuthorInformationLabel.Font = new Font("PokePixel GBA", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            AuthorInformationLabel.ForeColor = Color.White;
            AuthorInformationLabel.Location = new Point(337, 54);
            AuthorInformationLabel.Name = "AuthorInformationLabel";
            AuthorInformationLabel.Size = new Size(472, 210);
            AuthorInformationLabel.TabIndex = 5;
            AuthorInformationLabel.Text = "2nd year student \r\nof computer engineering \r\nspecialty in Khai university\r\n\r\nMain hobby: Video Games \r\nFavourite series: Pokémon";
            AuthorInformationLabel.TextAlign = ContentAlignment.MiddleCenter;
            AuthorToolTip.SetToolTip(AuthorInformationLabel, "About me");
            // 
            // Author
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(815, 450);
            Controls.Add(AuthorInformationLabel);
            Controls.Add(GmailPicture);
            Controls.Add(TelegramPicture);
            Controls.Add(AuthorPicture);
            Controls.Add(GitHubPicture);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Author";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Author";
            ((System.ComponentModel.ISupportInitialize)GitHubPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)AuthorPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)TelegramPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)GmailPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox GitHubPicture;
        private PictureBox AuthorPicture;
        private PictureBox TelegramPicture;
        private PictureBox GmailPicture;
        private Label AuthorInformationLabel;
        private ToolTip AuthorToolTip;
    }
}