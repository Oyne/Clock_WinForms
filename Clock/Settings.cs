namespace Clock
{
    class Settings
    {
        // Clock colors.
        public Color HourColor { get; set; } = Color.PaleGoldenrod;
        public Color MinuteColor { get; set; } = Color.PaleGoldenrod;
        public Color SecondColor { get; set; } = Color.Goldenrod;
        public Color BackgroundColor { get; set; } = Color.CadetBlue;
        public Color TicksColor { get; set; } = Color.PaleGoldenrod;
        public Color NumColor { get; set; } = Color.White;
        public Color DigitalBackgroudColor { get; set; } = Color.DarkGoldenrod;
        public Color DigitalTextColor { get; set; } = Color.PaleGoldenrod;
        public Color DigitalBorderColor { get; set; } = Color.LightGoldenrodYellow;


        // Hand lengths.
        public float HourLength { get; set; } = 140;
        public float MinLength { get; set; } = 160;
        public float SecLength { get; set; } = 180;

        // Digital clock length and height
        public float DigitalClockLength { get; set; } = 90;
        public float DigitalClockHeight { get; set; } = 60;


        // Hand thicknesses
        public float HourThickness { get; set; } = 7;
        public float MinThickness { get; set; } = 5;
        public float SecThickness { get; set; } = 3;
        public float TicksThickness { get; set; } = 1;

        // Digital border thicknesses
        public float DigitalBorderThickness { get; set; } = 4;


        // Time offset.
        public TimeSpan Offset { get; set; } = TimeSpan.Zero;
    }
}
