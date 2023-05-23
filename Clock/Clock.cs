using Clock;
using System;

namespace Clock
{
    public partial class Clock : Form
    {
        Author author;
        SettingsMenu settings_menu;
        Bitmap bmp;
        Graphics gr;
        Settings settings;
        Settings default_settings;
        bool use_custom_colors;


        readonly float Pic_Width, Pic_Height, CenterY, CenterX;


        public Clock()
        {
            InitializeComponent();

            Pic_Width = ClockBox.Width;
            Pic_Height = ClockBox.Height;

            bmp = new Bitmap((int)Pic_Width, (int)Pic_Height);
            CenterX = Pic_Width / 2;
            CenterY = Pic_Height / 2;

            author = new Author();
            default_settings = new Settings();
            settings = new Settings();
            use_custom_colors = true;

            ClockTimer.Interval = 50;
            ClockTimer.Start();
        }

        private void AuthorButton_Click(object sender, EventArgs e)
        {
            author.ShowDialog();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            settings_menu = new SettingsMenu(settings, use_custom_colors);
            settings_menu.ShowDialog();

            settings = settings_menu.menu_settings;
            use_custom_colors = settings_menu.CustomColorCheckBox.Checked;
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            gr = Graphics.FromImage(bmp);
            gr.Clear(Color.Transparent);

            // Clock colors.
            Color hrColor;
            Color minColor;
            Color secColor;
            Color circleColor;
            Color ticksColor;
            Color numColor;
            Color digitalBackgroundColor;
            Color digitalTextColor;
            Color digitalBorderColor;

            // Time offset.
            TimeSpan offset;

            if (use_custom_colors)
            {
                hrColor = settings.HourColor;
                minColor = settings.MinuteColor;
                secColor = settings.SecondColor;
                circleColor = settings.BackgroundColor;
                ticksColor = settings.TicksColor;
                numColor = settings.NumColor;
                digitalBackgroundColor = settings.DigitalBackgroudColor;
                digitalTextColor = settings.DigitalTextColor;
                digitalBorderColor = settings.DigitalBorderColor;
                offset = settings.Offset;
            }
            else
            {
                hrColor = default_settings.HourColor;
                minColor = default_settings.MinuteColor;
                secColor = default_settings.SecondColor;
                circleColor = default_settings.BackgroundColor;
                ticksColor = default_settings.TicksColor;
                numColor = default_settings.NumColor;
                digitalBackgroundColor = default_settings.DigitalBackgroudColor;
                digitalTextColor = default_settings.DigitalTextColor;
                digitalBorderColor = default_settings.DigitalBorderColor;
                offset = default_settings.Offset;
            }

            // Hand lengths.
            float hourLength = settings.HourLength;
            float minLength = settings.MinLength;
            float secLength = settings.SecLength;

            // Digital clock length and height
            float digitalClockLength = settings.DigitalClockLength;
            float digitalClockHeight = settings.DigitalClockHeight;


            // Hand thicknesses
            float hourThickness = settings.HourThickness;
            float minThickness = settings.MinThickness;
            float secThickness = settings.SecThickness;
            float ticksThickness = settings.TicksThickness;

            // Digital border thicknesses
            float digitalBorderThickness = settings.DigitalBorderThickness;

            // Calculating time
            DateTime dateTime = DateTime.UtcNow + offset;

            float hour = dateTime.Hour % 12 + (float)dateTime.Minute / 60; // convert 24hrs to 12hrs format
            float minute = dateTime.Minute + (float)dateTime.Second / 60;
            float sec = dateTime.Second + (float)dateTime.Millisecond / 1000;

            // Calculating radians
            float hourRadian = (float)(hour * 360 / 12 * Math.PI / 180);
            float minRadian = (float)(minute * 360 / 60 * Math.PI / 180);
            float secRadian = (float)(sec * 360 / 60 * Math.PI / 180);

            // Calculating start points
            float secStartPointX = (float)(secLength / 9 * System.Math.Sin(secRadian));
            float secStartPointY = (float)(secLength / 9 * System.Math.Cos(secRadian));

            float minStartPointX = (float)(minLength / 120 * System.Math.Sin(minRadian));
            float minStartPointY = (float)(minLength / 120 * System.Math.Cos(minRadian));

            float hourStartPointX = (float)(hourLength / 100 * System.Math.Sin(hourRadian));
            float hourStartPointY = (float)(hourLength / 100 * System.Math.Cos(hourRadian));

            float secEndPointX = (float)(secLength * System.Math.Sin(secRadian));
            float secEndPointY = (float)(secLength * System.Math.Cos(secRadian));

            float minEndPointX = (float)(minLength * System.Math.Sin(minRadian));
            float minEndPointY = (float)(minLength * System.Math.Cos(minRadian));

            float hourEndPointX = (float)(hourLength * System.Math.Sin(hourRadian));
            float hourEndPointY = (float)(hourLength * System.Math.Cos(hourRadian));

            // Calculate the position of the rectangle
            float rectangleX = CenterX - (digitalClockLength / 2);
            float rectangleY = CenterY + digitalClockHeight;

            gr.FillEllipse(new SolidBrush(circleColor), 0, 0, Pic_Width, Pic_Width);

            for (int i = 0; i < 60; i++)
            {
                int temp = 140;
                if (i % 5 == 0) // Draw 5 minute ticks.
                {
                    gr.DrawLine(new Pen(ticksColor, ticksThickness + 2),
                      CenterX +
                      (float)((Pic_Width - temp) / 1.50F * System.Math.Sin(i * 6 * Math.PI / 180)),
                      CenterY -
                      (float)((Pic_Width - temp) / 1.50F * System.Math.Cos(i * 6 * Math.PI / 180)),
                      CenterX +
                      (float)((Pic_Width - temp) / 1.62F * System.Math.Sin(i * 6 * Math.PI / 180)),
                      CenterY -
                      (float)((Pic_Width - temp) / 1.62F * System.Math.Cos(i * 6 * Math.PI / 180)));

                    gr.DrawString($"{12 - i / 5}".ToString(), new Font("Segoe Ui", 20), new SolidBrush(numColor),
                      CenterX - 15 +
                      (float)((Pic_Width - temp) / 1.85F * System.Math.Sin((60 - i) * 6 * Math.PI / 180)),
                      CenterY - 19 -
                      (float)((Pic_Width - temp) / 1.85F * System.Math.Cos((60 - i) * 6 * Math.PI / 180)));
                }
                else // draw 1 minute ticks.
                {
                    gr.DrawLine(new Pen(ticksColor, ticksThickness),
                      CenterX - 1 +
                      (float)((Pic_Width - temp) / 1.50F * System.Math.Sin(i * 6 * Math.PI / 180)),
                      CenterY - 1 -
                      (float)((Pic_Width - temp) / 1.50F * System.Math.Cos(i * 6 * Math.PI / 180)),
                      CenterX - 1 +
                      (float)((Pic_Width - temp) / 1.60F * System.Math.Sin(i * 6 * Math.PI / 180)),
                      CenterY - 1 -
                      (float)((Pic_Width - temp) / 1.60F * System.Math.Cos(i * 6 * Math.PI / 180)));
                }
            }

            gr.FillRectangle(new SolidBrush(digitalBackgroundColor),
                rectangleX,
                rectangleY,
                digitalClockLength,
                digitalClockHeight);

            gr.DrawRectangle(new Pen(digitalBorderColor, digitalBorderThickness),
               rectangleX - 1,
               rectangleY + 1,
               digitalClockLength,
               digitalClockHeight);

            gr.DrawString(dateTime.ToLongTimeString() + "\nUTC" + offset.TotalHours.ToString("+0;-#"), 
                new Font("Segoe Ui", 14), new SolidBrush(digitalTextColor),
                rectangleX,
                rectangleY);

            // Draw hour hand.
            gr.DrawLine(new Pen(hrColor, hourThickness),
                        CenterX - hourStartPointX,
                        CenterY + hourStartPointY,
                        CenterX + hourEndPointX,
                        CenterY - hourEndPointY);
            // Draw minute hand.
            gr.DrawLine(new Pen(minColor, minThickness),
                        CenterX - minStartPointX,
                        CenterY + minStartPointY,
                        CenterX + minEndPointX,
                        CenterY - minEndPointY);
            // Draw second hand.
            gr.DrawLine(new Pen(secColor, secThickness),
                        CenterX - secStartPointX,
                        CenterY + secStartPointY,
                        CenterX + secEndPointX,
                        CenterY - secEndPointY);
            // Draw circle of second hand.
            gr.FillEllipse(new SolidBrush(secColor), CenterX - 6, CenterY - 6, 12, 12);
            gr.DrawEllipse(new Pen(ticksColor, 3), 1, 1, Pic_Width - 3, Pic_Height - 3);

            ClockBox.Image = bmp;
            gr.Dispose();

        }
    }
}