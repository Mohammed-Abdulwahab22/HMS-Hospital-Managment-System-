namespace HMS_Hospital_Managment_System_
{
    partial class DoctorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorForm));
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            DocId = new TextBox();
            DocName = new TextBox();
            DocExp = new TextBox();
            DocPass = new TextBox();
            DoctorGV = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DoctorGV).BeginInit();
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
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(494, 63);
            label2.Name = "label2";
            label2.Size = new Size(135, 50);
            label2.TabIndex = 4;
            label2.Text = "Doctor";
            label2.Click += label2_Click;
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
            // DocId
            // 
            DocId.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DocId.ForeColor = Color.Purple;
            DocId.Location = new Point(54, 165);
            DocId.Name = "DocId";
            DocId.Size = new Size(214, 30);
            DocId.TabIndex = 1;
            DocId.Text = "Doctor Id";
            // 
            // DocName
            // 
            DocName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DocName.ForeColor = Color.Purple;
            DocName.Location = new Point(54, 201);
            DocName.Name = "DocName";
            DocName.Size = new Size(214, 30);
            DocName.TabIndex = 2;
            DocName.Text = "Doctor Name";
            // 
            // DocExp
            // 
            DocExp.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DocExp.ForeColor = Color.Purple;
            DocExp.Location = new Point(54, 237);
            DocExp.Name = "DocExp";
            DocExp.Size = new Size(214, 30);
            DocExp.TabIndex = 3;
            DocExp.Text = "Years Of Experience";
            // 
            // DocPass
            // 
            DocPass.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DocPass.ForeColor = Color.Purple;
            DocPass.Location = new Point(54, 304);
            DocPass.Name = "DocPass";
            DocPass.Size = new Size(214, 30);
            DocPass.TabIndex = 4;
            DocPass.Text = "Password";
            // 
            // DoctorGV
            // 
            DoctorGV.BackgroundColor = Color.White;
            DoctorGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DoctorGV.Location = new Point(462, 201);
            DoctorGV.Name = "DoctorGV";
            DoctorGV.RowHeadersWidth = 51;
            DoctorGV.Size = new Size(499, 420);
            DoctorGV.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Purple;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(14, 383);
            button1.Name = "button1";
            button1.Size = new Size(129, 54);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Purple;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.WhiteSmoke;
            button2.Location = new Point(149, 383);
            button2.Name = "button2";
            button2.Size = new Size(129, 54);
            button2.TabIndex = 7;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Purple;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.WhiteSmoke;
            button3.Location = new Point(284, 383);
            button3.Name = "button3";
            button3.Size = new Size(129, 54);
            button3.TabIndex = 8;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Purple;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.WhiteSmoke;
            button4.Location = new Point(149, 457);
            button4.Name = "button4";
            button4.Size = new Size(129, 54);
            button4.TabIndex = 9;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Purple;
            label3.Location = new Point(589, 145);
            label3.Name = "label3";
            label3.Size = new Size(216, 50);
            label3.TabIndex = 16;
            label3.Text = "Doctors List";
            // 
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1047, 655);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(DoctorGV);
            Controls.Add(DocPass);
            Controls.Add(DocExp);
            Controls.Add(DocName);
            Controls.Add(DocId);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DoctorForm";
            Text = "DoctorForm";
            Load += DoctorForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DoctorGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox DocId;
        private TextBox DocName;
        private TextBox DocExp;
        private TextBox DocPass;
        private DataGridView DoctorGV;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label3;
    }
}