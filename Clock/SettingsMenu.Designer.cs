namespace Clock
{
    partial class SettingsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsMenu));
            DefaultSaveButton = new Button();
            CustomSaveButton = new Button();
            HourHandColorButton = new Button();
            MinuteHandColorButton = new Button();
            SecondHandColorButton = new Button();
            BackgroundColorButton = new Button();
            TicksBezelColorButton = new Button();
            NumbersColorButton = new Button();
            DigitalWatchBackgroundColorButton = new Button();
            DigitalWatchTextColorButton = new Button();
            DigitalWatchBorderColorButton = new Button();
            OffsetUpDown = new NumericUpDown();
            HourHandColorLabel = new Label();
            MinuteHandColorLabel = new Label();
            BackgroundColorLabel = new Label();
            SecondHandColorLabel = new Label();
            DigitalWatchTextColorLabel = new Label();
            DigitalWatchBackgroundColorLabel = new Label();
            NumbersColorLabel = new Label();
            TicksBezelColorLabel = new Label();
            OffsetLabel = new Label();
            DigitalWatchBorderColorLabel = new Label();
            CustomColorCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)OffsetUpDown).BeginInit();
            SuspendLayout();
            // 
            // DefaultSaveButton
            // 
            DefaultSaveButton.BackColor = Color.White;
            DefaultSaveButton.FlatAppearance.BorderSize = 0;
            DefaultSaveButton.FlatStyle = FlatStyle.Flat;
            DefaultSaveButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DefaultSaveButton.Location = new Point(304, 695);
            DefaultSaveButton.Name = "DefaultSaveButton";
            DefaultSaveButton.Size = new Size(241, 75);
            DefaultSaveButton.TabIndex = 0;
            DefaultSaveButton.Text = "Save default settings";
            DefaultSaveButton.UseVisualStyleBackColor = false;
            DefaultSaveButton.Click += DefaultSaveButton_Click;
            // 
            // CustomSaveButton
            // 
            CustomSaveButton.BackColor = Color.White;
            CustomSaveButton.FlatAppearance.BorderSize = 0;
            CustomSaveButton.FlatStyle = FlatStyle.Flat;
            CustomSaveButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CustomSaveButton.Location = new Point(18, 695);
            CustomSaveButton.Name = "CustomSaveButton";
            CustomSaveButton.Size = new Size(241, 75);
            CustomSaveButton.TabIndex = 1;
            CustomSaveButton.Text = "Save custom settings";
            CustomSaveButton.UseVisualStyleBackColor = false;
            CustomSaveButton.Click += CustomSaveButton_Click;
            // 
            // HourHandColorButton
            // 
            HourHandColorButton.BackColor = Color.White;
            HourHandColorButton.FlatAppearance.BorderSize = 0;
            HourHandColorButton.FlatStyle = FlatStyle.Flat;
            HourHandColorButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            HourHandColorButton.ForeColor = Color.Black;
            HourHandColorButton.Location = new Point(375, 76);
            HourHandColorButton.Name = "HourHandColorButton";
            HourHandColorButton.Size = new Size(170, 35);
            HourHandColorButton.TabIndex = 2;
            HourHandColorButton.Text = "Select";
            HourHandColorButton.UseVisualStyleBackColor = false;
            HourHandColorButton.Click += HourHandColorButton_Click;
            // 
            // MinuteHandColorButton
            // 
            MinuteHandColorButton.BackColor = Color.White;
            MinuteHandColorButton.FlatAppearance.BorderSize = 0;
            MinuteHandColorButton.FlatStyle = FlatStyle.Flat;
            MinuteHandColorButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            MinuteHandColorButton.ForeColor = Color.Black;
            MinuteHandColorButton.Location = new Point(375, 139);
            MinuteHandColorButton.Name = "MinuteHandColorButton";
            MinuteHandColorButton.Size = new Size(170, 35);
            MinuteHandColorButton.TabIndex = 3;
            MinuteHandColorButton.Text = "Select";
            MinuteHandColorButton.UseVisualStyleBackColor = false;
            MinuteHandColorButton.Click += MinuteHandColorButton_Click;
            // 
            // SecondHandColorButton
            // 
            SecondHandColorButton.BackColor = Color.White;
            SecondHandColorButton.FlatAppearance.BorderSize = 0;
            SecondHandColorButton.FlatStyle = FlatStyle.Flat;
            SecondHandColorButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            SecondHandColorButton.ForeColor = Color.Black;
            SecondHandColorButton.Location = new Point(375, 197);
            SecondHandColorButton.Name = "SecondHandColorButton";
            SecondHandColorButton.Size = new Size(170, 35);
            SecondHandColorButton.TabIndex = 4;
            SecondHandColorButton.Text = "Select";
            SecondHandColorButton.UseVisualStyleBackColor = false;
            SecondHandColorButton.Click += SecondHandColorButton_Click;
            // 
            // BackgroundColorButton
            // 
            BackgroundColorButton.BackColor = Color.White;
            BackgroundColorButton.FlatAppearance.BorderSize = 0;
            BackgroundColorButton.FlatStyle = FlatStyle.Flat;
            BackgroundColorButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BackgroundColorButton.ForeColor = Color.Black;
            BackgroundColorButton.Location = new Point(375, 260);
            BackgroundColorButton.Name = "BackgroundColorButton";
            BackgroundColorButton.Size = new Size(170, 35);
            BackgroundColorButton.TabIndex = 5;
            BackgroundColorButton.Text = "Select";
            BackgroundColorButton.UseVisualStyleBackColor = false;
            BackgroundColorButton.Click += BackgroundColorButton_Click;
            // 
            // TicksBezelColorButton
            // 
            TicksBezelColorButton.BackColor = Color.White;
            TicksBezelColorButton.FlatAppearance.BorderSize = 0;
            TicksBezelColorButton.FlatStyle = FlatStyle.Flat;
            TicksBezelColorButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TicksBezelColorButton.ForeColor = Color.Black;
            TicksBezelColorButton.Location = new Point(375, 323);
            TicksBezelColorButton.Name = "TicksBezelColorButton";
            TicksBezelColorButton.Size = new Size(170, 35);
            TicksBezelColorButton.TabIndex = 6;
            TicksBezelColorButton.Text = "Select";
            TicksBezelColorButton.UseVisualStyleBackColor = false;
            TicksBezelColorButton.Click += TicksBezelColorButton_Click;
            // 
            // NumbersColorButton
            // 
            NumbersColorButton.BackColor = Color.White;
            NumbersColorButton.FlatAppearance.BorderSize = 0;
            NumbersColorButton.FlatStyle = FlatStyle.Flat;
            NumbersColorButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            NumbersColorButton.ForeColor = Color.Black;
            NumbersColorButton.Location = new Point(375, 386);
            NumbersColorButton.Name = "NumbersColorButton";
            NumbersColorButton.Size = new Size(170, 35);
            NumbersColorButton.TabIndex = 7;
            NumbersColorButton.Text = "Select";
            NumbersColorButton.UseVisualStyleBackColor = false;
            NumbersColorButton.Click += NumbersColorButton_Click;
            // 
            // DigitalWatchBackgroundColorButton
            // 
            DigitalWatchBackgroundColorButton.BackColor = Color.White;
            DigitalWatchBackgroundColorButton.FlatAppearance.BorderSize = 0;
            DigitalWatchBackgroundColorButton.FlatStyle = FlatStyle.Flat;
            DigitalWatchBackgroundColorButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            DigitalWatchBackgroundColorButton.ForeColor = Color.Black;
            DigitalWatchBackgroundColorButton.Location = new Point(375, 449);
            DigitalWatchBackgroundColorButton.Name = "DigitalWatchBackgroundColorButton";
            DigitalWatchBackgroundColorButton.Size = new Size(170, 35);
            DigitalWatchBackgroundColorButton.TabIndex = 8;
            DigitalWatchBackgroundColorButton.Text = "Select";
            DigitalWatchBackgroundColorButton.UseVisualStyleBackColor = false;
            DigitalWatchBackgroundColorButton.Click += DigitalWatchBackgroundColorButton_Click;
            // 
            // DigitalWatchTextColorButton
            // 
            DigitalWatchTextColorButton.BackColor = Color.White;
            DigitalWatchTextColorButton.FlatAppearance.BorderSize = 0;
            DigitalWatchTextColorButton.FlatStyle = FlatStyle.Flat;
            DigitalWatchTextColorButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            DigitalWatchTextColorButton.ForeColor = Color.Black;
            DigitalWatchTextColorButton.Location = new Point(375, 512);
            DigitalWatchTextColorButton.Name = "DigitalWatchTextColorButton";
            DigitalWatchTextColorButton.Size = new Size(170, 35);
            DigitalWatchTextColorButton.TabIndex = 9;
            DigitalWatchTextColorButton.Text = "Select";
            DigitalWatchTextColorButton.UseVisualStyleBackColor = false;
            DigitalWatchTextColorButton.Click += DigitalWatchTextColorButton_Click;
            // 
            // DigitalWatchBorderColorButton
            // 
            DigitalWatchBorderColorButton.BackColor = Color.White;
            DigitalWatchBorderColorButton.FlatAppearance.BorderSize = 0;
            DigitalWatchBorderColorButton.FlatStyle = FlatStyle.Flat;
            DigitalWatchBorderColorButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            DigitalWatchBorderColorButton.ForeColor = Color.Black;
            DigitalWatchBorderColorButton.Location = new Point(375, 575);
            DigitalWatchBorderColorButton.Name = "DigitalWatchBorderColorButton";
            DigitalWatchBorderColorButton.Size = new Size(170, 35);
            DigitalWatchBorderColorButton.TabIndex = 10;
            DigitalWatchBorderColorButton.Text = "Select";
            DigitalWatchBorderColorButton.UseVisualStyleBackColor = false;
            DigitalWatchBorderColorButton.Click += DigitalWatchBorderColorButton_Click;
            // 
            // OffsetUpDown
            // 
            OffsetUpDown.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            OffsetUpDown.Location = new Point(375, 641);
            OffsetUpDown.Maximum = new decimal(new int[] { 14, 0, 0, 0 });
            OffsetUpDown.Minimum = new decimal(new int[] { 12, 0, 0, int.MinValue });
            OffsetUpDown.Name = "OffsetUpDown";
            OffsetUpDown.Size = new Size(170, 30);
            OffsetUpDown.TabIndex = 11;
            OffsetUpDown.ValueChanged += OffsetUpDown_ValueChanged;
            // 
            // HourHandColorLabel
            // 
            HourHandColorLabel.AutoSize = true;
            HourHandColorLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            HourHandColorLabel.ForeColor = Color.White;
            HourHandColorLabel.Location = new Point(12, 75);
            HourHandColorLabel.Name = "HourHandColorLabel";
            HourHandColorLabel.Size = new Size(190, 31);
            HourHandColorLabel.TabIndex = 12;
            HourHandColorLabel.Text = "Hour hand color";
            // 
            // MinuteHandColorLabel
            // 
            MinuteHandColorLabel.AutoSize = true;
            MinuteHandColorLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            MinuteHandColorLabel.ForeColor = Color.White;
            MinuteHandColorLabel.Location = new Point(12, 138);
            MinuteHandColorLabel.Name = "MinuteHandColorLabel";
            MinuteHandColorLabel.Size = new Size(213, 31);
            MinuteHandColorLabel.TabIndex = 13;
            MinuteHandColorLabel.Text = "Minute hand color";
            // 
            // BackgroundColorLabel
            // 
            BackgroundColorLabel.AutoSize = true;
            BackgroundColorLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            BackgroundColorLabel.ForeColor = Color.White;
            BackgroundColorLabel.Location = new Point(12, 264);
            BackgroundColorLabel.Name = "BackgroundColorLabel";
            BackgroundColorLabel.Size = new Size(205, 31);
            BackgroundColorLabel.TabIndex = 15;
            BackgroundColorLabel.Text = "Background color";
            // 
            // SecondHandColorLabel
            // 
            SecondHandColorLabel.AutoSize = true;
            SecondHandColorLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            SecondHandColorLabel.ForeColor = Color.White;
            SecondHandColorLabel.Location = new Point(12, 201);
            SecondHandColorLabel.Name = "SecondHandColorLabel";
            SecondHandColorLabel.Size = new Size(213, 31);
            SecondHandColorLabel.TabIndex = 14;
            SecondHandColorLabel.Text = "Second hand color";
            // 
            // DigitalWatchTextColorLabel
            // 
            DigitalWatchTextColorLabel.AutoSize = true;
            DigitalWatchTextColorLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            DigitalWatchTextColorLabel.ForeColor = Color.White;
            DigitalWatchTextColorLabel.Location = new Point(12, 516);
            DigitalWatchTextColorLabel.Name = "DigitalWatchTextColorLabel";
            DigitalWatchTextColorLabel.Size = new Size(267, 31);
            DigitalWatchTextColorLabel.TabIndex = 19;
            DigitalWatchTextColorLabel.Text = "Digital watch text color";
            // 
            // DigitalWatchBackgroundColorLabel
            // 
            DigitalWatchBackgroundColorLabel.AutoSize = true;
            DigitalWatchBackgroundColorLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            DigitalWatchBackgroundColorLabel.ForeColor = Color.White;
            DigitalWatchBackgroundColorLabel.Location = new Point(12, 453);
            DigitalWatchBackgroundColorLabel.Name = "DigitalWatchBackgroundColorLabel";
            DigitalWatchBackgroundColorLabel.Size = new Size(353, 31);
            DigitalWatchBackgroundColorLabel.TabIndex = 18;
            DigitalWatchBackgroundColorLabel.Text = "Digital watch background color";
            // 
            // NumbersColorLabel
            // 
            NumbersColorLabel.AutoSize = true;
            NumbersColorLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            NumbersColorLabel.ForeColor = Color.White;
            NumbersColorLabel.Location = new Point(12, 390);
            NumbersColorLabel.Name = "NumbersColorLabel";
            NumbersColorLabel.Size = new Size(173, 31);
            NumbersColorLabel.TabIndex = 17;
            NumbersColorLabel.Text = "Numbers color";
            // 
            // TicksBezelColorLabel
            // 
            TicksBezelColorLabel.AutoSize = true;
            TicksBezelColorLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            TicksBezelColorLabel.ForeColor = Color.White;
            TicksBezelColorLabel.Location = new Point(12, 327);
            TicksBezelColorLabel.Name = "TicksBezelColorLabel";
            TicksBezelColorLabel.Size = new Size(237, 31);
            TicksBezelColorLabel.TabIndex = 16;
            TicksBezelColorLabel.Text = "Ticks and bezel color";
            // 
            // OffsetLabel
            // 
            OffsetLabel.AutoSize = true;
            OffsetLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            OffsetLabel.ForeColor = Color.White;
            OffsetLabel.Location = new Point(12, 640);
            OffsetLabel.Name = "OffsetLabel";
            OffsetLabel.Size = new Size(80, 31);
            OffsetLabel.TabIndex = 21;
            OffsetLabel.Text = "Offset";
            // 
            // DigitalWatchBorderColorLabel
            // 
            DigitalWatchBorderColorLabel.AutoSize = true;
            DigitalWatchBorderColorLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            DigitalWatchBorderColorLabel.ForeColor = Color.White;
            DigitalWatchBorderColorLabel.Location = new Point(12, 579);
            DigitalWatchBorderColorLabel.Name = "DigitalWatchBorderColorLabel";
            DigitalWatchBorderColorLabel.Size = new Size(296, 31);
            DigitalWatchBorderColorLabel.TabIndex = 20;
            DigitalWatchBorderColorLabel.Text = "Digital watch border color";
            // 
            // CustomColorCheckBox
            // 
            CustomColorCheckBox.AutoSize = true;
            CustomColorCheckBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            CustomColorCheckBox.ForeColor = Color.White;
            CustomColorCheckBox.Location = new Point(18, 12);
            CustomColorCheckBox.Name = "CustomColorCheckBox";
            CustomColorCheckBox.Size = new Size(231, 35);
            CustomColorCheckBox.TabIndex = 22;
            CustomColorCheckBox.Text = "Use custom colors";
            CustomColorCheckBox.UseVisualStyleBackColor = true;
            // 
            // SettingsMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(559, 787);
            Controls.Add(CustomColorCheckBox);
            Controls.Add(OffsetLabel);
            Controls.Add(DigitalWatchBorderColorLabel);
            Controls.Add(DigitalWatchTextColorLabel);
            Controls.Add(DigitalWatchBackgroundColorLabel);
            Controls.Add(NumbersColorLabel);
            Controls.Add(TicksBezelColorLabel);
            Controls.Add(BackgroundColorLabel);
            Controls.Add(SecondHandColorLabel);
            Controls.Add(MinuteHandColorLabel);
            Controls.Add(HourHandColorLabel);
            Controls.Add(OffsetUpDown);
            Controls.Add(DigitalWatchBorderColorButton);
            Controls.Add(DigitalWatchTextColorButton);
            Controls.Add(DigitalWatchBackgroundColorButton);
            Controls.Add(NumbersColorButton);
            Controls.Add(TicksBezelColorButton);
            Controls.Add(BackgroundColorButton);
            Controls.Add(SecondHandColorButton);
            Controls.Add(MinuteHandColorButton);
            Controls.Add(HourHandColorButton);
            Controls.Add(CustomSaveButton);
            Controls.Add(DefaultSaveButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SettingsMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings Menu";
            ((System.ComponentModel.ISupportInitialize)OffsetUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DefaultSaveButton;
        private Button CustomSaveButton;
        private Button HourHandColorButton;
        private Button MinuteHandColorButton;
        private Button SecondHandColorButton;
        private Button BackgroundColorButton;
        private Button TicksBezelColorButton;
        private Button NumbersColorButton;
        private Button DigitalWatchBackgroundColorButton;
        private Button DigitalWatchTextColorButton;
        private Button DigitalWatchBorderColorButton;
        private NumericUpDown OffsetUpDown;
        private Label HourHandColorLabel;
        private Label MinuteHandColorLabel;
        private Label BackgroundColorLabel;
        private Label SecondHandColorLabel;
        private Label DigitalWatchTextColorLabel;
        private Label DigitalWatchBackgroundColorLabel;
        private Label NumbersColorLabel;
        private Label TicksBezelColorLabel;
        private Label OffsetLabel;
        private Label DigitalWatchBorderColorLabel;
        public CheckBox CustomColorCheckBox;
    }
}