namespace Clock
{
    partial class Clock
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clock));
            SettingsButton = new Button();
            AuthorButton = new Button();
            ClockToolTip = new ToolTip(components);
            ClockTimer = new System.Windows.Forms.Timer(components);
            ClockBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ClockBox).BeginInit();
            SuspendLayout();
            // 
            // SettingsButton
            // 
            SettingsButton.BackColor = Color.FromArgb(32, 32, 32);
            SettingsButton.BackgroundImage = (Image)resources.GetObject("SettingsButton.BackgroundImage");
            SettingsButton.BackgroundImageLayout = ImageLayout.Stretch;
            SettingsButton.FlatAppearance.BorderSize = 0;
            SettingsButton.FlatStyle = FlatStyle.Flat;
            SettingsButton.ForeColor = Color.White;
            SettingsButton.Location = new Point(106, 603);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(88, 88);
            SettingsButton.TabIndex = 0;
            ClockToolTip.SetToolTip(SettingsButton, "Settings menu");
            SettingsButton.UseVisualStyleBackColor = false;
            SettingsButton.Click += SettingsButton_Click;
            // 
            // AuthorButton
            // 
            AuthorButton.BackColor = Color.FromArgb(32, 32, 32);
            AuthorButton.BackgroundImage = (Image)resources.GetObject("AuthorButton.BackgroundImage");
            AuthorButton.BackgroundImageLayout = ImageLayout.Stretch;
            AuthorButton.FlatAppearance.BorderSize = 0;
            AuthorButton.FlatStyle = FlatStyle.Flat;
            AuthorButton.ForeColor = Color.White;
            AuthorButton.Location = new Point(12, 603);
            AuthorButton.Name = "AuthorButton";
            AuthorButton.Size = new Size(88, 88);
            AuthorButton.TabIndex = 1;
            ClockToolTip.SetToolTip(AuthorButton, "Author");
            AuthorButton.UseVisualStyleBackColor = false;
            AuthorButton.Click += AuthorButton_Click;
            // 
            // ClockTimer
            // 
            ClockTimer.Tick += ClockTimer_Tick;
            // 
            // ClockBox
            // 
            ClockBox.Location = new Point(92, 47);
            ClockBox.Name = "ClockBox";
            ClockBox.Size = new Size(550, 550);
            ClockBox.TabIndex = 2;
            ClockBox.TabStop = false;
            // 
            // Clock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(732, 703);
            Controls.Add(ClockBox);
            Controls.Add(AuthorButton);
            Controls.Add(SettingsButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Clock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clock";
            ((System.ComponentModel.ISupportInitialize)ClockBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button SettingsButton;
        private Button AuthorButton;
        private ToolTip ClockToolTip;
        private System.Windows.Forms.Timer ClockTimer;
        private PictureBox ClockBox;
    }
}