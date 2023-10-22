namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            listBox1 = new ListBox();
            name = new TextBox();
            surname = new TextBox();
            e_mail = new TextBox();
            phone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            SAVE = new SaveFileDialog();
            OPEN = new OpenFileDialog();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(127, 365);
            button1.Name = "button1";
            button1.Size = new Size(172, 86);
            button1.TabIndex = 0;
            button1.Text = "Add confidantial data";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(493, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(701, 724);
            listBox1.TabIndex = 1;
            // 
            // name
            // 
            name.Location = new Point(147, 108);
            name.Name = "name";
            name.Size = new Size(125, 27);
            name.TabIndex = 2;
            // 
            // surname
            // 
            surname.Location = new Point(147, 174);
            surname.Name = "surname";
            surname.Size = new Size(125, 27);
            surname.TabIndex = 3;
            // 
            // e_mail
            // 
            e_mail.Location = new Point(147, 239);
            e_mail.Name = "e_mail";
            e_mail.Size = new Size(125, 27);
            e_mail.TabIndex = 4;
            // 
            // phone
            // 
            phone.Location = new Point(147, 305);
            phone.Name = "phone";
            phone.Size = new Size(125, 27);
            phone.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 111);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 177);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 7;
            label2.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 246);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 8;
            label3.Text = "e-mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 312);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 9;
            label4.Text = "Phone";
            // 
            // button2
            // 
            button2.Location = new Point(12, 457);
            button2.Name = "button2";
            button2.Size = new Size(135, 90);
            button2.TabIndex = 10;
            button2.Text = "Export XML";
            button2.UseVisualStyleBackColor = true;
            button2.Click += exportxml;
            // 
            // button3
            // 
            button3.Location = new Point(295, 457);
            button3.Name = "button3";
            button3.Size = new Size(135, 90);
            button3.TabIndex = 11;
            button3.Text = "Export TXT";
            button3.UseVisualStyleBackColor = true;
            button3.Click += exporttxt;
            // 
            // OPEN
            // 
            OPEN.FileName = "openFileDialog1";
            // 
            // button4
            // 
            button4.Location = new Point(12, 553);
            button4.Name = "button4";
            button4.Size = new Size(135, 85);
            button4.TabIndex = 12;
            button4.Text = "Import XML";
            button4.UseVisualStyleBackColor = true;
            button4.Click += importxml;
            // 
            // button5
            // 
            button5.Location = new Point(295, 548);
            button5.Name = "button5";
            button5.Size = new Size(135, 90);
            button5.TabIndex = 13;
            button5.Text = "Import TXT";
            button5.UseVisualStyleBackColor = true;
            button5.Click += importtxt;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 759);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(phone);
            Controls.Add(e_mail);
            Controls.Add(surname);
            Controls.Add(name);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Publisher of confidential data";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private TextBox name;
        private TextBox surname;
        private TextBox e_mail;
        private TextBox phone;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
        private Button button3;
        private SaveFileDialog SAVE;
        private OpenFileDialog OPEN;
        private Button button4;
        private Button button5;
    }
}