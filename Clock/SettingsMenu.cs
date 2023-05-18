using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class SettingsMenu : Form
    {
        public Settings menu_settings { get; set; }

        public SettingsMenu(Settings settings, bool use_custom_colors)
        {
            InitializeComponent();
            menu_settings = settings;
            OffsetUpDown.Value = settings.Offset.Hours;
            CustomColorCheckBox.Checked = use_custom_colors;
        }

        private void HourHandColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                menu_settings.HourColor = color.Color;
            }
        }

        private void MinuteHandColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                menu_settings.MinuteColor = color.Color;
            }
        }

        private void SecondHandColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                menu_settings.SecondColor = color.Color;
            }
        }

        private void BackgroundColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                menu_settings.BackgroundColor = color.Color;
            }
        }

        private void TicksBezelColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                menu_settings.TicksColor = color.Color;
            }
        }

        private void NumbersColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                menu_settings.NumColor = color.Color;
            }
        }

        private void DigitalWatchBackgroundColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                menu_settings.DigitalBackgroudColor = color.Color;
            }
        }

        private void DigitalWatchTextColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                menu_settings.DigitalTextColor = color.Color;
            }
        }

        private void DigitalWatchBorderColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                menu_settings.DigitalBorderColor = color.Color;
            }
        }

        private void OffsetUpDown_ValueChanged(object sender, EventArgs e)
        {
            menu_settings.Offset = TimeSpan.FromHours((double)OffsetUpDown.Value);
        }

        private void DefaultSaveButton_Click(object sender, EventArgs e)
        {
            SaveSettings(new Settings(), false);

        }

        private void CustomSaveButton_Click(object sender, EventArgs e)
        {
            SaveSettings(menu_settings, true);
        }

        private void SaveSettings(Settings settings, bool is_custom)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            save.FilterIndex = 1;
            save.Title = "Save file";

            save.FileName = is_custom ? "settings_custom" : "settings_default";

            if (save.ShowDialog() == DialogResult.OK)
            {
                string fname = save.FileName;
                using (FileStream fs = new FileStream(fname, FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        string color;
                        //Hour hand color
                        color = settings.HourColor.ToString();
                        sw.WriteLine($"Hour hand color: {color.Substring(color.IndexOf('[') + 1, color.Length - color.IndexOf('[') - 2)}");
                        //Minute hand color
                        color = settings.MinuteColor.ToString();
                        sw.WriteLine($"Minute hand color: {color.Substring(color.IndexOf('[') + 1, color.Length - color.IndexOf('[') - 2)}");
                        //Second hand color
                        color = settings.SecondColor.ToString();
                        sw.WriteLine($"Second hand color: {color.Substring(color.IndexOf('[') + 1, color.Length - color.IndexOf('[') - 2)}");
                        //Background color
                        color = settings.BackgroundColor.ToString();
                        sw.WriteLine($"Background color: {color.Substring(color.IndexOf('[') + 1, color.Length - color.IndexOf('[') - 2)}");
                        //Ticks and bezel color
                        color = settings.TicksColor.ToString();
                        sw.WriteLine($"Ticks and bezel color: {color.Substring(color.IndexOf('[') + 1, color.Length - color.IndexOf('[') - 2)}");
                        //Numbers color
                        color = settings.NumColor.ToString();
                        sw.WriteLine($"Numbers color: {color.Substring(color.IndexOf('[') + 1, color.Length - color.IndexOf('[') - 2)}");
                        //Digital watch background color
                        color = settings.DigitalBackgroudColor.ToString();
                        sw.WriteLine($"Digital watch background color: {color.Substring(color.IndexOf('[') + 1, color.Length - color.IndexOf('[') - 2)}");
                        //Digital watch text color
                        color = settings.DigitalTextColor.ToString();
                        sw.WriteLine($"Digital watch text color: {color.Substring(color.IndexOf('[') + 1, color.Length - color.IndexOf('[') - 2)}");
                        //Digital watch border color
                        color = settings.DigitalBorderColor.ToString();
                        sw.WriteLine($"Digital watch border color: {color.Substring(color.IndexOf('[') + 1, color.Length - color.IndexOf('[') - 2)}");
                        //Offset
                        sw.WriteLine($"Offset: {settings.Offset.Hours}");

                    }
                }
            }
        }

    }
}
