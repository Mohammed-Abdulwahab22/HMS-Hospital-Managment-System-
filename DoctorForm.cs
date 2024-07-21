using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HMS_Hospital_Managment_System_
{
    public partial class DoctorForm : Form
    {
        SqlConnection Con = new SqlConnection();
        public DoctorForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        void populate()
        {
            Con.Open();
            string query = "select * from DoctorTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DoctorGV.DataSource = ds.Tables[0];
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
            if (DocId.Text == "" || DocId.Text == "Doctor Id" || DocName.Text == "" || DocName.Text == "Doctor Name" || DocExp.Text == "" || DocExp.Text == "Years Of Experience" || DocPass.Text == "" || DocPass.Text == "Password")
            {
                MessageBox.Show("No Empty Fill Accepted");
            }
            else
            {


                Con.Open();
                string query = "insert into DoctorTbl values(" + DocId.Text + ",'" + DocName.Text + "'," + DocExp.Text + ",'" + DocPass.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Successfully Added");
                Con.Close();
                populate();
            }
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
