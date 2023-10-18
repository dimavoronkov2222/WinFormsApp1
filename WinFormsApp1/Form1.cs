namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileContent = File.ReadAllText(fileDialog.FileName);
                int charCount = fileContent.Length;
                int maxCharCount = charCount;
                label3.Text = maxCharCount.ToString();
                int percent = (int)(((double)charCount / (double)maxCharCount) * 100);
                progressBar1.Value = percent;
            }
        }
    }
}