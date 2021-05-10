using System;
using System.Windows.Forms;
using System.IO;
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


        private void Start_PVE_Click(object sender, EventArgs e)
        {
            //Слоаврь взят с http://blog.kislenko.net/show.php?id=1678
            Random r = new Random();
            string[] dict = File.ReadAllLines("Dict.txt");
            Form f = new Main(dict[r.Next(0, dict.Length)]);
            f.Show();
            this.Hide();
        }

        private void Start_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
 