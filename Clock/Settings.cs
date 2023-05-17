namespace Clock
{
    class Settings
    {
        // Clock colors.
        public Color HourColor { get; set; } = Color.Black;
        public Color MinuteColor { get; set; } = Color.Black;
        public Color SecondColor { get; set; } = Color.Red;
        public Color BackgroundColor { get; set; } = Color.Silver;
        public Color TicksColor { get; set; } = Color.Black;
        public Color NumColor { get; set; } = Color.Black;

        // Hand lengths.
        public float HourLength { get; set; } = 100;
        public float MinLength { get; set; } = 125;
        public float SecLength { get; set; } = 140;

        // Hand thicknesses
        public float HourThickness { get; set; } = 7;
        public float MinThickness { get; set; } = 4;
        public float SecThickness { get; set; } = 2;
        public float TicksThickness { get; set; } = 1;

        // Time offset.
        public TimeSpan Offset { get; set; } = TimeSpan.Zero;
    }
}
