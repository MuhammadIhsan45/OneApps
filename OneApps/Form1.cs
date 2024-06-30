using System.Diagnostics;

namespace OneApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // URL ChatGPT
            string url = "https://chat.openai.com/";
            // Membuka URL di browser default
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Path to Discord executable
            string path = @"C:\Users\muhih\AppData\Local\Discord\app-1.0.9152\Discord.exe";
            // Membuka aplikasi Discord
            Process.Start(new ProcessStartInfo(path) { UseShellExecute = true });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Path to Brave executable
            string path = @"""C:\Program Files\BraveSoftware\Brave-Browser\Application\brave.exe""";
            // Membuka aplikasi Brave
            Process.Start(new ProcessStartInfo(path) { UseShellExecute = true });
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // URL FBS login
            string url = "https://fbs.com/cabinet/login";
            // Membuka URL di browser default
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // Path to Figma executable
            string path = @"C:\Users\muhih\AppData\Local\Figma\app-124.1.16\Figma.exe";
            // Membuka aplikasi Figma
            Process.Start(new ProcessStartInfo(path) { UseShellExecute = true });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Path to Spotify executable
            string path = @"C:\Users\muhih\AppData\Roaming\Spotify\Spotify.exe";
            // Membuka aplikasi Spotify
            Process.Start(new ProcessStartInfo(path) { UseShellExecute = true });
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // URL Google
            string url = "https://www.google.com/";
            // Membuka URL di browser default
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // URL Instagram
            string url = "https://www.instagram.com/";
            // Membuka URL di browser default
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // URL MQL 5
            string url = "https://www.mql5.com/en/signals/2232712";
            // Membuka URL di browser default
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Path to Remote Desktop Connection executable
            string path = Environment.ExpandEnvironmentVariables(@"%windir%\system32\mstsc.exe");

            // Membuka aplikasi Remote Desktop Connection
            Process.Start(new ProcessStartInfo(path) { UseShellExecute = true });
        }


        private void button10_Click(object sender, EventArgs e)
        {
            // Path to Telegram executable
            string path = @"C:\Users\muhih\AppData\Roaming\Telegram Desktop\Telegram.exe";
            // Membuka aplikasi Telegram
            Process.Start(new ProcessStartInfo(path) { UseShellExecute = true });
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // URL Tiktok ID
            string url = "https://www.tiktok.com/id-ID/";
            // Membuka URL di browser default
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Path to FBS Trader 4 executable
            string path = @"C:\Program Files (x86)\FBS Trader 4\terminal.exe";
            // Membuka aplikasi FBS Trader 4
            Process.Start(new ProcessStartInfo(path) { UseShellExecute = true });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // URL Youtube
            string url = "https://www.youtube.com/";
            // Membuka URL di browser default
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // URL WA
            string url = "https://web.whatsapp.com/";
            // Membuka URL di browser default
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}

