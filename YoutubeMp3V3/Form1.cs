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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text;
            string tur = Convert.ToString(comboBox1.SelectedItem);
            tur = tur.ToLower();
            if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(tur))
            {
                MessageBox.Show("Lutfen Gecerli Bir Link Giriniz Veya Bir Dosya Turu Seciniz");
                return;
            }
            RunPythonaScript(url, tur);
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
    }
}
