using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        Button[] keyboard = new Button[32];
        private void Main_Load(object sender, EventArgs e)
        {
            this.Width = 668;
            for (int i = 0; i < 32; i++)
            {
                keyboard[i] = new Button();
                keyboard[i].Width = 40;
                keyboard[i].Height = 40;
                if (i< 16) keyboard[i].Top = 350;
                else keyboard[i].Top = keyboard[0].Top+keyboard[0].Height;
                keyboard[i].Left = keyboard[i].Width*(i%16)+5;
                //"а" имеет номер 1072, "А" - 1040
                keyboard[i].Text = Convert.ToString(Convert.ToChar(1040 + i));
                Controls.Add(keyboard[i]);
            }
        }
    }
}
