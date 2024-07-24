namespace HMS_Hospital_Managment_System_
{
    partial class DiagnosisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagnosisForm));
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            PatientIdTb = new ComboBox();
            MedicineTb = new TextBox();
            DiagnosisTb = new TextBox();
            PatientTb = new TextBox();
            DiagId = new TextBox();
            SymptomsTb = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            DiagnosisGV = new DataGridView();
            label3 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DiagnosisGV).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            panel1.Size = new Size(1065, 122);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(494, 63);
            label2.Name = "label2";
            label2.Size = new Size(182, 50);
            label2.TabIndex = 4;
            label2.Text = "Diagnosis";
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
            // PatientIdTb
            // 
            PatientIdTb.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PatientIdTb.FormattingEnabled = true;
            PatientIdTb.Items.AddRange(new object[] { "Male", "Female" });
            PatientIdTb.Location = new Point(25, 214);
            PatientIdTb.Name = "PatientIdTb";
            PatientIdTb.Size = new Size(214, 33);
            PatientIdTb.TabIndex = 13;
            PatientIdTb.Text = "Patient Id";
            PatientIdTb.SelectionChangeCommitted += PatientIdTb_SelectionChangeCommitted;
            // 
            // MedicineTb
            // 
            MedicineTb.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MedicineTb.ForeColor = Color.Purple;
            MedicineTb.Location = new Point(271, 253);
            MedicineTb.Name = "MedicineTb";
            MedicineTb.Size = new Size(214, 30);
            MedicineTb.TabIndex = 12;
            MedicineTb.Text = "Medicines";
            // 
            // DiagnosisTb
            // 
            DiagnosisTb.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DiagnosisTb.ForeColor = Color.Purple;
            DiagnosisTb.Location = new Point(271, 214);
            DiagnosisTb.Name = "DiagnosisTb";
            DiagnosisTb.Size = new Size(214, 30);
            DiagnosisTb.TabIndex = 11;
            DiagnosisTb.Text = "Diagnosis";
            // 
            // PatientTb
            // 
            PatientTb.Enabled = false;
            PatientTb.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PatientTb.ForeColor = Color.Purple;
            PatientTb.Location = new Point(25, 253);
            PatientTb.Name = "PatientTb";
            PatientTb.Size = new Size(214, 30);
            PatientTb.TabIndex = 10;
            PatientTb.Text = "Patient Name";
            // 
            // DiagId
            // 
            DiagId.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DiagId.ForeColor = Color.Purple;
            DiagId.Location = new Point(25, 178);
            DiagId.Name = "DiagId";
            DiagId.Size = new Size(214, 30);
            DiagId.TabIndex = 9;
            DiagId.Text = "Diagnosis Id";
            // 
            // SymptomsTb
            // 
            SymptomsTb.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SymptomsTb.ForeColor = Color.Purple;
            SymptomsTb.Location = new Point(271, 178);
            SymptomsTb.Name = "SymptomsTb";
            SymptomsTb.Size = new Size(214, 30);
            SymptomsTb.TabIndex = 8;
            SymptomsTb.Text = "Symptoms";
            // 
            // button4
            // 
            button4.BackColor = Color.Purple;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.WhiteSmoke;
            button4.Location = new Point(194, 386);
            button4.Name = "button4";
            button4.Size = new Size(129, 54);
            button4.TabIndex = 18;
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
            button3.Location = new Point(329, 312);
            button3.Name = "button3";
            button3.Size = new Size(129, 54);
            button3.TabIndex = 17;
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
            button2.Location = new Point(194, 312);
            button2.Name = "button2";
            button2.Size = new Size(129, 54);
            button2.TabIndex = 16;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Purple;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(59, 312);
            button1.Name = "button1";
            button1.Size = new Size(129, 54);
            button1.TabIndex = 15;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DiagnosisGV
            // 
            DiagnosisGV.BackgroundColor = Color.White;
            DiagnosisGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DiagnosisGV.Location = new Point(49, 531);
            DiagnosisGV.Name = "DiagnosisGV";
            DiagnosisGV.RowHeadersWidth = 51;
            DiagnosisGV.Size = new Size(931, 224);
            DiagnosisGV.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Purple;
            label3.Location = new Point(393, 478);
            label3.Name = "label3";
            label3.Size = new Size(247, 50);
            label3.TabIndex = 20;
            label3.Text = "Diagnosis List";
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(494, 128);
            panel2.Name = "panel2";
            panel2.Size = new Size(559, 359);
            panel2.TabIndex = 21;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(194, 311);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(101, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Blue;
            label9.Location = new Point(455, 10);
            label9.Name = "label9";
            label9.Size = new Size(53, 28);
            label9.TabIndex = 10;
            label9.Text = "Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Blue;
            label8.Location = new Point(320, 210);
            label8.Name = "label8";
            label8.Size = new Size(100, 28);
            label8.TabIndex = 9;
            label8.Text = "Medicines";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(21, 210);
            label7.Name = "label7";
            label7.Size = new Size(105, 28);
            label7.TabIndex = 8;
            label7.Text = "Symptoms";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(310, 74);
            label6.Name = "label6";
            label6.Size = new Size(97, 28);
            label6.TabIndex = 7;
            label6.Text = "Diagnosis";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(21, 74);
            label5.Name = "label5";
            label5.Size = new Size(129, 28);
            label5.TabIndex = 6;
            label5.Text = "Patient Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(94, -3);
            label4.Name = "label4";
            label4.Size = new Size(280, 41);
            label4.TabIndex = 5;
            label4.Text = "Diagnosis Summary";
            // 
            // DiagnosisForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 767);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(DiagnosisGV);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(PatientIdTb);
            Controls.Add(MedicineTb);
            Controls.Add(DiagnosisTb);
            Controls.Add(PatientTb);
            Controls.Add(DiagId);
            Controls.Add(SymptomsTb);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DiagnosisForm";
            Text = "DiagnosisForm";
            Load += DiagnosisForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DiagnosisGV).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private ComboBox PatientIdTb;
        private TextBox MedicineTb;
        private TextBox DiagnosisTb;
        private TextBox PatientTb;
        private TextBox DiagId;
        private TextBox SymptomsTb;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView DiagnosisGV;
        private Label label3;
        private Panel panel2;
        private Label label4;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private PictureBox pictureBox2;
    }
}