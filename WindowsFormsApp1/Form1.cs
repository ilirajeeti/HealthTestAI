﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            var covidInfo = new CovidInformation();
            covidInfo.Show();
            this.Hide();

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            var covidTest = new CovidTest();
            covidTest.Show();
            this.Hide();
        }
    }
}
