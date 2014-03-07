using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsforms
{
    public partial class LeosFirstForm : Form
    {
        public LeosFirstForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bellend;

            bellend = "A Bellend";           

            button1.Text = bellend;

            button2.Visible = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}