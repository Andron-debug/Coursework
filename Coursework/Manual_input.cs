using System;
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
            bool ok = true;
            string word = Word_textBox.Text;
            word = word.Trim();
            word = word.ToUpper();
            // Проверка на то, что все буквы - кириллица
            for (int i = 0; i < word.Length; i++)
            {
                if ((Convert.ToInt32(word[i]) < 1040) || (Convert.ToInt32(word[i]) > 1072))
                {
                    ok = false;
                    MessageBox.Show("Содержит недопустимые символы." + "\n" + "Используйте только кириллицу.");
                    break;
                }
            }

            //Проверка на не пустую строку
            if (word == "")
            {
                ok = false;
                MessageBox.Show("Введите слово");
            }
            if (ok)
            {
                Form f = new Main(Word_textBox.Text);
                f.Show();
                this.Hide();
            }
        }

        private void Manual_input_Load(object sender, EventArgs e)
        {

        }
    }
}
