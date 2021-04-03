using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Coursework
{
    public partial class Manual_input : Form
    {
        public Manual_input()
        {
            InitializeComponent();
        }

        private void Srtart_Click(object sender, EventArgs e)
        {
            Form f = new Main(Word_textBox.Text);
            f.Show();
            this.Hide();
        }
    }
}
