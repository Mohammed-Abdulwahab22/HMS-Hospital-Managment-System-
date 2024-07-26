using System.Data;
using System.Data.SqlClient;

namespace HMS_Hospital_Managment_System_
{
    public partial class DiagnosisForm : Form
    {


        public DiagnosisForm()
        {
            InitializeComponent();
        }
        void populateCombo()
        {
            string sql = "select * from PatientTbl";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("PatId", typeof(int));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                PatientIdCb.ValueMember = "PatId";
                PatientIdCb.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }

        void populate()
        {
            Con.Open();
            string query = "select * from DiagnosisTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DiagnosisGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        string patname;
        void fetchpatientname()
        {
            Con.Open();
            string mysql = "select * from PatientTbl where PatId=" + PatientIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(mysql, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            Con.Close();
            foreach (DataRow dr in dt.Rows)
            {
                patname = dr["PatName"].ToString();
                PatientTb.Text = patname;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DiagId.Text == "" || DiagId.Text == "Diagnosis Id" || MedicineTb.Text == "" || MedicineTb.Text == "Medicines" || DiagnosisTb.Text == "" || PatientTb.Text == "Patient Name" || MedicineTb.Text == "" || MedicineTb.Text == "Medicines")

            {
                MessageBox.Show("No Empty Fill Accepted");
            }
            else
            {


                Con.Open();
                string query = "insert into DiagnosisTbl values(" + DiagId.Text + ",'" + PatientIdCb.SelectedValue.ToString() + "','" + PatientTb.Text + "','" + SymptomsTb.Text + "', '" + DiagnosisTb.Text + "','" + MedicineTb.Text + "' )";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis Successfully Added");
                Con.Close();
                populate();
            }
        }

        private void DiagnosisForm_Load(object sender, EventArgs e)
        {
            populateCombo();
            populate();
        }

        private void PatientIdTb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchpatientname();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DiagId.Text == "" || DiagId.Text == "Diagnosis Id")
            {
                MessageBox.Show("Enter the Diagnosis id");
            }
            else
            {
                Con.Open();
                string query = "delete from DiagnosisTbl where DiagId=" + DiagId.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void DiagnosisGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DiagId.Text = DiagnosisGV.CurrentRow.Cells[0].Value.ToString();
            PatientIdCb.SelectedValue = DiagnosisGV.CurrentRow.Cells[1].Value.ToString();
            PatientTb.Text = DiagnosisGV.CurrentRow.Cells[2].Value.ToString();
            SymptomsTb.Text = DiagnosisGV.CurrentRow.Cells[3].Value.ToString();
            DiagnosisTb.Text = DiagnosisGV.CurrentRow.Cells[4].Value.ToString();
            MedicineTb.Text = DiagnosisGV.CurrentRow.Cells[5].Value.ToString();
            PatientNamelbl.Text = DiagnosisGV.CurrentRow.Cells[2].Value.ToString();
            Diagnosislbl.Text = DiagnosisGV.CurrentRow.Cells[4].Value.ToString();
            Symptomslbl.Text = DiagnosisGV.CurrentRow.Cells[3].Value.ToString();
            medicineslbl.Text = DiagnosisGV.CurrentRow.Cells[5].Value.ToString();
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "UPDATE DiagnosisTbl SET PatId = '" + PatientIdCb.SelectedValue.ToString() + "', PatName = '" + PatientTb.Text + "', Symptoms = '" + SymptomsTb.Text + "',Diagnosis = '" + DiagnosisTb.Text + "',Medicines = '" + MedicineTb.Text + "' WHERE DiagId = " + DiagId.Text;
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Diagnosis successfully updated");
            Con.Close();
            populate();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(label4.Text + "\n" + PatientNamelbl.Text + "\n" + Diagnosislbl.Text + "\n" + Symptomslbl.Text + "\n" + medicineslbl.Text, new Font("Century Gothic", 30, FontStyle.Bold), Brushes.Red, new Point(230));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
