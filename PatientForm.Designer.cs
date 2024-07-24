namespace HMS_Hospital_Managment_System_
{
    partial class PatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            PatName = new TextBox();
            PatId = new TextBox();
            PatAd = new TextBox();
            PatPhone = new TextBox();
            PatAge = new TextBox();
            GenderCb = new ComboBox();
            BloodCb = new ComboBox();
            MajorTb = new TextBox();
            PatientGV = new DataGridView();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PatientGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Purple;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1047, 122);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(494, 63);
            label2.Name = "label2";
            label2.Size = new Size(136, 50);
            label2.TabIndex = 4;
            label2.Text = "Patient";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(229, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(337, 9);
            label1.Name = "label1";
            label1.Size = new Size(531, 54);
            label1.TabIndex = 1;
            label1.Text = "Hospital Managment System";
            // 
            // PatName
            // 
            PatName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PatName.ForeColor = Color.Purple;
            PatName.Location = new Point(76, 221);
            PatName.Name = "PatName";
            PatName.Size = new Size(214, 30);
            PatName.TabIndex = 2;
            PatName.Text = "Patient Name";
            // 
            // PatId
            // 
            PatId.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PatId.ForeColor = Color.Purple;
            PatId.Location = new Point(76, 185);
            PatId.Name = "PatId";
            PatId.Size = new Size(214, 30);
            PatId.TabIndex = 3;
            PatId.Text = "Patient Id";
            PatId.TextChanged += textBox2_TextChanged;
            // 
            // PatAd
            // 
            PatAd.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PatAd.ForeColor = Color.Purple;
            PatAd.Location = new Point(76, 257);
            PatAd.Name = "PatAd";
            PatAd.Size = new Size(214, 30);
            PatAd.TabIndex = 4;
            PatAd.Text = "Patient Address";
            // 
            // PatPhone
            // 
            PatPhone.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PatPhone.ForeColor = Color.Purple;
            PatPhone.Location = new Point(76, 293);
            PatPhone.Name = "PatPhone";
            PatPhone.Size = new Size(214, 30);
            PatPhone.TabIndex = 5;
            PatPhone.Text = "Patient Phone";
            // 
            // PatAge
            // 
            PatAge.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PatAge.ForeColor = Color.Purple;
            PatAge.Location = new Point(76, 329);
            PatAge.Name = "PatAge";
            PatAge.Size = new Size(214, 30);
            PatAge.TabIndex = 6;
            PatAge.Text = "Patient Age";
            // 
            // GenderCb
            // 
            GenderCb.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GenderCb.FormattingEnabled = true;
            GenderCb.Items.AddRange(new object[] { "Male", "Female" });
            GenderCb.Location = new Point(76, 365);
            GenderCb.Name = "GenderCb";
            GenderCb.Size = new Size(214, 33);
            GenderCb.TabIndex = 7;
            GenderCb.Text = "Gender";
            // 
            // BloodCb
            // 
            BloodCb.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BloodCb.FormattingEnabled = true;
            BloodCb.Items.AddRange(new object[] { "A+", "O+", "B+", "AB+", "A-", "O-", "B-", "AB-" });
            BloodCb.Location = new Point(76, 404);
            BloodCb.Name = "BloodCb";
            BloodCb.Size = new Size(214, 33);
            BloodCb.TabIndex = 8;
            BloodCb.Text = "Blood Group";
            // 
            // MajorTb
            // 
            MajorTb.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MajorTb.ForeColor = Color.Purple;
            MajorTb.Location = new Point(76, 443);
            MajorTb.Name = "MajorTb";
            MajorTb.Size = new Size(214, 30);
            MajorTb.TabIndex = 9;
            MajorTb.Text = "Major Disease";
            // 
            // PatientGV
            // 
            PatientGV.BackgroundColor = Color.White;
            PatientGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PatientGV.Location = new Point(461, 185);
            PatientGV.Name = "PatientGV";
            PatientGV.RowHeadersWidth = 51;
            PatientGV.Size = new Size(499, 420);
            PatientGV.TabIndex = 10;
            // 
            // button4
            // 
            button4.BackColor = Color.Purple;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.WhiteSmoke;
            button4.Location = new Point(161, 576);
            button4.Name = "button4";
            button4.Size = new Size(129, 54);
            button4.TabIndex = 14;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Purple;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.WhiteSmoke;
            button3.Location = new Point(296, 502);
            button3.Name = "button3";
            button3.Size = new Size(129, 54);
            button3.TabIndex = 13;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Purple;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.WhiteSmoke;
            button2.Location = new Point(161, 502);
            button2.Name = "button2";
            button2.Size = new Size(129, 54);
            button2.TabIndex = 12;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Purple;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(26, 502);
            button1.Name = "button1";
            button1.Size = new Size(129, 54);
            button1.TabIndex = 11;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Purple;
            label3.Location = new Point(591, 132);
            label3.Name = "label3";
            label3.Size = new Size(217, 50);
            label3.TabIndex = 15;
            label3.Text = "Patients List";
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1047, 650);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(PatientGV);
            Controls.Add(MajorTb);
            Controls.Add(BloodCb);
            Controls.Add(GenderCb);
            Controls.Add(PatAge);
            Controls.Add(PatPhone);
            Controls.Add(PatAd);
            Controls.Add(PatId);
            Controls.Add(PatName);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PatientForm";
            Text = "PatientForm";
            Load += PatientForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PatientGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox PatName;
        private TextBox PatId;
        private TextBox PatAd;
        private TextBox PatPhone;
        private TextBox PatAge;
        private ComboBox GenderCb;
        private ComboBox BloodCb;
        private TextBox MajorTb;
        private DataGridView PatientGV;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label3;
    }
}