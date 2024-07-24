using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                PatientIdTb.ValueMember = "PatId";
                PatientIdTb.DataSource = dt;
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
            string mysql = "select * from PatientTbl where PatId=" + PatientIdTb.SelectedValue.ToString() + "";
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
                string query = "insert into DiagnosisTbl values(" + DiagId.Text + ",'" + PatientIdTb.SelectedValue.ToString() + "','" + PatientTb.Text + "','" + SymptomsTb.Text + "', '" + DiagnosisTb.Text + "','" + MedicineTb.Text + "' )";
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
    }
}
