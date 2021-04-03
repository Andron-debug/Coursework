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
        static string word = "";
        public Main(string w)
        {
            InitializeComponent();
            word = w.ToUpper();
            letters = new Label[word.Length];
            chance = word.Length / 3 + 1;
            Сhance_label.Text = ("Осталось попыток:"+"\n"+chance);
        }
        
        Button[] keyboard = new Button[32];
        Label[] letters;
        int chance;// Осталось попыток
        private void Main_Load(object sender, EventArgs e)
        {
            // Создание клавиатуры
            for (int i = 0; i < 32; i++)
            {
                keyboard[i] = new Button();
                keyboard[i].Width = this.Width/16-2;
                keyboard[i].Height = 40;
                if (i< 16) keyboard[i].Top = 350;
                else keyboard[i].Top = keyboard[0].Top+keyboard[0].Height;
                keyboard[i].Anchor = (AnchorStyles.Bottom);
                keyboard[i].Click += key_cliced;
                keyboard[i].Left = keyboard[i].Width*(i%16)+7;
                //"а" имеет номер 1072, "А" - 1040
                keyboard[i].Text = Convert.ToString(Convert.ToChar(1040 + i));
                Controls.Add(keyboard[i]);
            }
                        
            for (int i = 0; i<letters.Length; i++)
            {
                letters[i] = new Label();
                letters[i].Font = new Font ("Segoe UI", 25, FontStyle.Underline| FontStyle.Bold);
                letters[i].Text = "  ";
                letters[i].AutoSize = true;
                letters[i].Top = 200;
                letters[i].Anchor = (AnchorStyles.Left | AnchorStyles.Top);
                if (i == 0) letters[i].Left = 7;
                else letters[i].Left = letters[i - 1].Right+8;
                Controls.Add(letters[i]);
            }
        }
        int filled = 0;
        private void key_cliced(object sender, EventArgs e)
        {
            Button key = (Button)sender;
            bool mistake_flag = true;

            for (int i = 0; i < word.Length; i++)
            {
                if (key.Text == Convert.ToString(word[i]))
                {
                    mistake_flag = false;
                    letters[i].Text = key.Text;
                    filled++;
                }
            }
            key.Hide();
            if (mistake_flag) chance--;
            Сhance_label.Text = ("Осталось попыток:" + "\n" + chance);
            if (chance == 0) MessageBox.Show("Поражение :("+"\n"+"Правельный ответ: " + word);
            if (filled == letters.Length) MessageBox.Show("Победа :)");
        }
        private void Main_SizeChanged(object sender, EventArgs e)
        {
            this.Width -= this.Width % 16;
            for (int i = 0; i < 32; i++)
            {
                keyboard[i].Width = this.Width / 16 - 2;
                keyboard[i].Left = keyboard[i].Width * (i % 16) + 7;
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
