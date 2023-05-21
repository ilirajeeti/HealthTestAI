using System;
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
    public partial class MoreInfo : Form
    {
        public MoreInfo()
        {
            InitializeComponent();
        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {
            var goBack = new CovidInformation();
            goBack.Show();
            this.Hide();
        }

        private void bunifuButton16_Click(object sender, EventArgs e)
        {
            var covidTest = new CovidTest();
            covidTest.Show();
            this.Hide();
        }
    }
}
