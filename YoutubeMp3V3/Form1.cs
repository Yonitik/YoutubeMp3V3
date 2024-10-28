using System.Diagnostics;

namespace YoutubeMp3V3
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

        private void RunPythonaScript(string url, string fileType)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "python",
                    Arguments = $"Resources\\Ytmp3.py \"{url}\" {fileType}",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(psi))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    string errors = process.StandardError.ReadToEnd();

                    process.WaitForExit();
                    MessageBox.Show($"{output}");


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            string url = rjTextBox1.Texts;
            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Lutfen Gecerli Bir Link Giriniz Veya Bir Dosya Turu Seciniz");
                return;
            }
            RunPythonaScript(url,"mp3");
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            string url = rjTextBox1.Texts;
            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Lutfen Gecerli Bir Link Giriniz Veya Bir Dosya Turu Seciniz");
                return;
            }
            RunPythonaScript(url,"mp4");
        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
