using Clock;
using System;

namespace Clock
{
    public partial class Clock : Form
    {
        private Author? _author = new Author();

        


        public Clock()
        {
            InitializeComponent();
        }

        private void Clock_Load(object sender, EventArgs e)
        {

        }

        private void AuthorButton_Click(object sender, EventArgs e)
        {
            _author.ShowDialog();
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            DateTime _current_time = DateTime.Now;
            int _hour = _current_time.Hour % 12; // also converts 24hrs to 12hrs format
            int _minute = _current_time.Minute;
            int _sec = _current_time.Second;

            double _hourRadian = _hour * 360 / 12 * Math.PI / 180;

            double _minRadian = _minute * 360 / 60 * Math.PI / 180;
            double _secRadian = _sec * 360 / 60 * Math.PI / 180;

            double hourEndPointX = 5 * System.Math.Sin(_hourRadian);
            double hourEndPointY = 5 * System.Math.Cos(_hourRadian);
        }
}