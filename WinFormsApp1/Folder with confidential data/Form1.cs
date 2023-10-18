using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Folder_with_confidential_data
{
    public partial class Add_Data : Form
    {
        public Add_Data()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(name.TextLength == 0 || Surname.TextLength == 0 || e_mail.TextLength == 0 || Phone.TextLength == 0)
            {
                MessageBox.Show("All fields must be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
