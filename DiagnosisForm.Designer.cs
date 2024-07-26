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
            PatientIdCb = new ComboBox();
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
            diagsummary = new Panel();
            pictureBox2 = new PictureBox();
            label9 = new Label();
            medicineslbl = new Label();
            Symptomslbl = new Label();
            Diagnosislbl = new Label();
            PatientNamelbl = new Label();
            label4 = new Label();
            button5 = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DiagnosisGV).BeginInit();
            diagsummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Purple;
            panel1.Controls.Add(label5);
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
            // PatientIdCb
            // 
            PatientIdCb.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PatientIdCb.FormattingEnabled = true;
            PatientIdCb.Items.AddRange(new object[] { "Male", "Female" });
            PatientIdCb.Location = new Point(25, 214);
            PatientIdCb.Name = "PatientIdCb";
            PatientIdCb.Size = new Size(214, 33);
            PatientIdCb.TabIndex = 13;
            PatientIdCb.Text = "Patient Id";
            PatientIdCb.SelectionChangeCommitted += PatientIdTb_SelectionChangeCommitted;
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
            button2.Click += button2_Click;
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
            DiagnosisGV.CellContentClick += DiagnosisGV_CellContentClick;
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
            // diagsummary
            // 
            diagsummary.Controls.Add(pictureBox2);
            diagsummary.Controls.Add(label9);
            diagsummary.Controls.Add(medicineslbl);
            diagsummary.Controls.Add(Symptomslbl);
            diagsummary.Controls.Add(Diagnosislbl);
            diagsummary.Controls.Add(PatientNamelbl);
            diagsummary.Controls.Add(label4);
            diagsummary.Location = new Point(494, 128);
            diagsummary.Name = "diagsummary";
            diagsummary.Size = new Size(559, 359);
            diagsummary.TabIndex = 21;
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
            // medicineslbl
            // 
            medicineslbl.AutoSize = true;
            medicineslbl.BackColor = Color.Transparent;
            medicineslbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            medicineslbl.ForeColor = Color.Blue;
            medicineslbl.Location = new Point(320, 210);
            medicineslbl.Name = "medicineslbl";
            medicineslbl.Size = new Size(100, 28);
            medicineslbl.TabIndex = 9;
            medicineslbl.Text = "Medicines";
            // 
            // Symptomslbl
            // 
            Symptomslbl.AutoSize = true;
            Symptomslbl.BackColor = Color.Transparent;
            Symptomslbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Symptomslbl.ForeColor = Color.Blue;
            Symptomslbl.Location = new Point(21, 210);
            Symptomslbl.Name = "Symptomslbl";
            Symptomslbl.Size = new Size(105, 28);
            Symptomslbl.TabIndex = 8;
            Symptomslbl.Text = "Symptoms";
            // 
            // Diagnosislbl
            // 
            Diagnosislbl.AutoSize = true;
            Diagnosislbl.BackColor = Color.Transparent;
            Diagnosislbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Diagnosislbl.ForeColor = Color.Blue;
            Diagnosislbl.Location = new Point(310, 74);
            Diagnosislbl.Name = "Diagnosislbl";
            Diagnosislbl.Size = new Size(97, 28);
            Diagnosislbl.TabIndex = 7;
            Diagnosislbl.Text = "Diagnosis";
            // 
            // PatientNamelbl
            // 
            PatientNamelbl.AutoSize = true;
            PatientNamelbl.BackColor = Color.Transparent;
            PatientNamelbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PatientNamelbl.ForeColor = Color.Blue;
            PatientNamelbl.Location = new Point(21, 74);
            PatientNamelbl.Name = "PatientNamelbl";
            PatientNamelbl.Size = new Size(129, 28);
            PatientNamelbl.TabIndex = 6;
            PatientNamelbl.Text = "Patient Name";
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
            // button5
            // 
            button5.BackColor = Color.Purple;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.WhiteSmoke;
            button5.Location = new Point(688, 486);
            button5.Name = "button5";
            button5.Size = new Size(109, 39);
            button5.TabIndex = 22;
            button5.Text = "Print";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Desktop;
            label5.Location = new Point(949, 34);
            label5.Name = "label5";
            label5.Size = new Size(49, 54);
            label5.TabIndex = 8;
            label5.Text = "X";
            label5.Click += label5_Click;
            // 
            // DiagnosisForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 767);
            Controls.Add(button5);
            Controls.Add(diagsummary);
            Controls.Add(label3);
            Controls.Add(DiagnosisGV);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(PatientIdCb);
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
            diagsummary.ResumeLayout(false);
            diagsummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private ComboBox PatientIdCb;
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
        private Panel diagsummary;
        private Label label4;
        private Label label9;
        private Label medicineslbl;
        private Label Symptomslbl;
        private Label Diagnosislbl;
        private Label PatientNamelbl;
        private PictureBox pictureBox2;
        private Button button5;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Label label5;
    }
}