﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_Hospital_Managment_System_
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        int startPoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 1;
            progressBar.Value = startPoint;
            if (progressBar.Value == 100)
            {
                progressBar.Value = 0;
                timer1.Stop();
                Form1 login = new Form1();
                login.Show();
                this.Hide();
            }
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
    }
}
