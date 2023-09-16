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
            GmailPicture = new PictureBox();
            AuthorInformationLabel = new Label();
            AuthorToolTip = new ToolTip(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)GmailPicture).BeginInit();
            SuspendLayout();
            // 
            // GmailPicture
            // 
            GmailPicture.BackgroundImageLayout = ImageLayout.Stretch;
            GmailPicture.Image = (Image)resources.GetObject("GmailPicture.Image");
            GmailPicture.Location = new Point(12, 174);
            GmailPicture.Name = "GmailPicture";
            GmailPicture.Size = new Size(108, 106);
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
            AuthorInformationLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            AuthorInformationLabel.ForeColor = Color.White;
            AuthorInformationLabel.Location = new Point(70, 9);
            AuthorInformationLabel.Name = "AuthorInformationLabel";
            AuthorInformationLabel.Size = new Size(484, 152);
            AuthorInformationLabel.TabIndex = 5;
            AuthorInformationLabel.Text = "Chernyavsky Volodimyr Stanislavovich\r\n2nd year student \r\nof computer engineering \r\nspecialty in Khai university";
            AuthorInformationLabel.TextAlign = ContentAlignment.MiddleCenter;
            AuthorToolTip.SetToolTip(AuthorInformationLabel, "About me");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(126, 207);
            label1.Name = "label1";
            label1.Size = new Size(503, 38);
            label1.TabIndex = 6;
            label1.Text = "v.s.chernyavsjkyy@student.csn.khai.edu";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            AuthorToolTip.SetToolTip(label1, "About me");
            // 
            // Author
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(631, 292);
            Controls.Add(label1);
            Controls.Add(AuthorInformationLabel);
            Controls.Add(GmailPicture);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Author";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Author";
            ((System.ComponentModel.ISupportInitialize)GmailPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox GmailPicture;
        private Label AuthorInformationLabel;
        private ToolTip AuthorToolTip;
        private Label label1;
    }
}