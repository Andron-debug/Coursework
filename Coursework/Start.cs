using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Coursework
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Start_PVP_Click(object sender, EventArgs e)
        {
            Form f = new Manual_input();
            f.Show();
            this.Hide();
        }


        private void Start_Load(object sender, EventArgs e)
        {

        }


        private void Start_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        private void Start_PVP_Click(object sender, EventArgs e)
        {


        }
    }
}
