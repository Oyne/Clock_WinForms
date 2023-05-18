using System.Diagnostics;
using System.Drawing.Text;

namespace Clock
{

    public partial class Author : Form
    {
        #region Custom font
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font PokePixelGba;
        #endregion

        public Author()
        {
            InitializeComponent();
            byte[] fontData = Properties.Resources.pokepixel_gba;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.pokepixel_gba.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.pokepixel_gba.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            PokePixelGba = new Font(fonts.Families[0], 16);
            AuthorInformationLabel.Font = PokePixelGba;
        }

        private void GitHubPicture_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/Oyne") { UseShellExecute = true });
        }

        private void TelegramPicture_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://t.me/Andreoyne") { UseShellExecute = true });
        }

        private void GmailPicture_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("mailto:a.a.litvinov@student.csn.khai.edu") { UseShellExecute = true });
        }

        private void AuthorPicture_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.instagram.com/andreoyne_litvinov/") { UseShellExecute = true });
        }
    }
}
