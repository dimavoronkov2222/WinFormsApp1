using System.Xml;
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
            if (name.TextLength == 0 || surname.TextLength == 0 || e_mail.TextLength == 0 || phone.TextLength == 0)
            {
                MessageBox.Show("All fields must be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string data = " Name: " + name.Text + " Surname: " + surname.Text + " e-mail: " + e_mail.Text + " Phone: " + phone.Text;
                listBox1.Items.Add(data);
            }
        }
        private void exportxml(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML Files (*.xml)|*.xml";
            saveFileDialog.DefaultExt = "xml";
            saveFileDialog.AddExtension = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (XmlWriter writer = XmlWriter.Create(saveFileDialog.FileName))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Items");
                    foreach (var item in listBox1.Items)
                    {
                        writer.WriteElementString("Item", item.ToString());
                    }
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                }
            }
        }
        private void exporttxt(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "TXT Files (*.txt)|*.txt";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.AddExtension = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (var item in listBox1.Items)
                    {
                        writer.WriteLine(item.ToString());
                    }
                }
            }
        }
        private void importxml(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files (*.xml)|*.xml";
            openFileDialog.DefaultExt = "xml";
            openFileDialog.AddExtension = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                using (XmlReader reader = XmlReader.Create(openFileDialog.FileName))
                {
                    while (reader.Read())
                    {
                        if (reader.IsStartElement())
                        {
                            switch (reader.Name)
                            {
                                case "Item":
                                    if (reader.Read())
                                    {
                                        listBox1.Items.Add(reader.Value.Trim());
                                    }
                                    break;
                            }
                        }
                    }
                }
            }
        }
        private void importtxt(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "TXT Files (*.txt)|*.txt";
            openFileDialog.DefaultExt = "txt";
            openFileDialog.AddExtension = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        listBox1.Items.Add(line);
                    }
                }
            }
        }
    }
}