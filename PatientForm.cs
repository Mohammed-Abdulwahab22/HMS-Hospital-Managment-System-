using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HMS_Hospital_Managment_System_
{
    public partial class PatientForm : Form
    {

        public PatientForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        void populate()
        {
            Con.Open();
            string query = "select * from PatientTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            PatientGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PatId.Text == "" || PatId.Text == "Patient Id" || PatName.Text == "" || PatName.Text == "Patient Name" || PatAd.Text == "" || PatAd.Text == "Patient Address" || PatPhone.Text == "" || PatPhone.Text == "Patient Phone" || PatAge.Text == "" || PatAge.Text == "Patient Age"
                || MajorTb.Text == "")
            {
                MessageBox.Show("No Empty Fill Accepted");
            }
            else
            {


                Con.Open();
                string query = "insert into PatientTbl values(" + PatId.Text + ",'" + PatName.Text + "','" + PatAd.Text + "','" + PatPhone.Text + "', " + PatAge.Text + ",'" + GenderCb.SelectedItem.ToString() + "','" + BloodCb.SelectedItem.ToString() + "','" + MajorTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Successfully Added");
                Con.Close();
                populate();
            }
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PatId.Text == "" || PatId.Text == "Patient Id")
            {
                MessageBox.Show("Enter the Doctor id");
            }
            else
            {
                Con.Open();
                string query = "delete from PatientTbl where PatId=" + PatId.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "UPDATE PatientTbl SET PatName = '" + PatName.Text + "', PatAddress = '" + PatAd.Text + "',PatPhone = '" + PatPhone.Text + "', PatAge = '" + PatAge.Text + "' ,PatGender = '" + GenderCb.SelectedItem.ToString() + "',PatBlood = '" + BloodCb.SelectedItem.ToString() + "',PatDisease = '" + MajorTb.Text + "' WHERE PatId = " + PatId.Text;
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Patient successfully updated");
            Con.Close();
            populate();
        }

        private void PatientGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatId.Text = PatientGV.CurrentRow.Cells[0].Value.ToString();
            PatName.Text = PatientGV.CurrentRow.Cells[1].Value.ToString();
            PatAd.Text = PatientGV.CurrentRow.Cells[2].Value.ToString();
            PatPhone.Text = PatientGV.CurrentRow.Cells[3].Value.ToString();
            PatAge.Text = PatientGV.CurrentRow.Cells[4].Value.ToString();
            GenderCb.SelectedText = PatientGV.CurrentRow.Cells[5].Value.ToString();
            BloodCb.SelectedText = PatientGV.CurrentRow.Cells[6].Value.ToString();
            MajorTb.Text = PatientGV.CurrentRow.Cells[7].Value.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
