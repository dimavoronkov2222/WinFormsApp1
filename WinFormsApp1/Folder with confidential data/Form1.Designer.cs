namespace WinFormsApp1.Folder_with_confidential_data
{
    partial class Add_Data
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Data));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            name = new TextBox();
            Surname = new TextBox();
            e_mail = new TextBox();
            Phone = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(285, 325);
            button1.Name = "button1";
            button1.Size = new Size(211, 89);
            button1.TabIndex = 0;
            button1.Text = "Publish confidential data";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(216, 32);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 62);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 2;
            label2.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(213, 91);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 3;
            label3.Text = "e-mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(215, 122);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 4;
            label4.Text = "Phone";
            // 
            // name
            // 
            name.Location = new Point(294, 25);
            name.Name = "name";
            name.Size = new Size(125, 27);
            name.TabIndex = 5;
            // 
            // Surname
            // 
            Surname.Location = new Point(294, 55);
            Surname.Name = "Surname";
            Surname.Size = new Size(125, 27);
            Surname.TabIndex = 6;
            // 
            // e_mail
            // 
            e_mail.Location = new Point(294, 88);
            e_mail.Name = "e_mail";
            e_mail.Size = new Size(125, 27);
            e_mail.TabIndex = 7;
            // 
            // Phone
            // 
            Phone.Location = new Point(294, 121);
            Phone.Name = "Phone";
            Phone.Size = new Size(125, 27);
            Phone.TabIndex = 8;
            // 
            // Add_Data
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Phone);
            Controls.Add(e_mail);
            Controls.Add(Surname);
            Controls.Add(name);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Add_Data";
            Text = "The window for publishing confidential data";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox name;
        private TextBox Surname;
        private TextBox e_mail;
        private TextBox Phone;
    }
}