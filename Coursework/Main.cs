using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Coursework
{

    public partial class Main : Form
    {
        static string word = "";
        Button[] keyboard = new Button[32];
        Label[] letters;
        SoundPlayer pancil1 = new SoundPlayer("pencil-write-on-sound.wav");
        int chance;// Осталось попыток

        public Main(string w)
        {
            InitializeComponent();
            word = w.ToUpper();
            letters = new Label[word.Length];
            chance = (word.Length / 4 + 1) * 4;
            Сhance_label.Text = ("Осталось попыток:" + "\n" + chance);
            All_pictureBox_invisible();
        }


        private void All_pictureBox_invisible()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            // Создание клавиатуры
            for (int i = 0; i < 32; i++)
            {
                keyboard[i] = new Button();
                keyboard[i].Width = this.Width / 16 - 2;
                keyboard[i].Height = 40;
                if (i < 16) keyboard[i].Top = 350;
                else keyboard[i].Top = keyboard[0].Top + keyboard[0].Height;
                keyboard[i].Anchor = (AnchorStyles.Bottom);
                keyboard[i].Click += key_cliced;
                keyboard[i].Font = new Font("CyrillicRibbon", 15, FontStyle.Bold);
                keyboard[i].Left = keyboard[i].Width * (i % 16) + 7;
                //"а" имеет номер 1072, "А" - 1040
                keyboard[i].Text = Convert.ToString(Convert.ToChar(1040 + i));
                Controls.Add(keyboard[i]);
            }
            // Инициализация букв            
            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = new Label();
                letters[i].Font = new Font("CyrillicRibbon", 29, FontStyle.Underline | FontStyle.Bold);
                letters[i].Text = "  ";
                letters[i].AutoSize = true;
                letters[i].Top = 230;
                letters[i].BackColor = System.Drawing.Color.Transparent;
                letters[i].Anchor = (AnchorStyles.Left | AnchorStyles.Top);
                if (i == 0) letters[i].Left = 7;
                else letters[i].Left = letters[i - 1].Right + 8;
                Controls.Add(letters[i]);
            }
        }
        int filled = 0;
        private void key_cliced(object sender, EventArgs e)
        {
            Button key = (Button)sender;
            bool mistake_flag = true;

            // Поиск буквы
            for (int i = 0; i < word.Length; i++)
            {
                if (key.Text == Convert.ToString(word[i]))
                {
                    mistake_flag = false;
                    pancil1.Play();
                    letters[i].Text = key.Text;
                    filled++;
                }
            }
            key.Hide();

            // Если ошибка
            if (mistake_flag)
            {
                if (chance == (word.Length / 4 + 1) * 3)
                {
                    All_pictureBox_invisible();
                    pancil1.Play();
                    pictureBox1.Visible = true;
                }
                if (chance == (word.Length / 4 + 1) * 2)
                {
                    All_pictureBox_invisible();
                    pancil1.Play();
                    pictureBox2.Visible = true;
                }
                if (chance == (word.Length / 4 + 1))
                {
                    All_pictureBox_invisible();
                    pancil1.Play();
                    pictureBox3.Visible = true;
                }

                chance--;
            }

            Сhance_label.Text = ("Осталось попыток:" + "\n" + chance);
            if (chance == 0) // поражение
            {
                All_pictureBox_invisible();
                pictureBox4.Visible = true;
                MessageBox.Show("Поражение :(" + "\n" + "Правельный ответ: " + word);
                Form f = new Start();
                f.Show();
                this.Hide();
            }
            if (filled == letters.Length) // победа
            {
                MessageBox.Show("Победа :)");
                Form f = new Start();
                f.Show();
                this.Hide();
            }

        }
        private void Main_SizeChanged(object sender, EventArgs e)
        {
            // Автоматическое масштабирование клавиатуры
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

        private void surreder_Click(object sender, EventArgs e)
        {
            All_pictureBox_invisible();
            pictureBox4.Visible = true;
            MessageBox.Show("Поражение :(" + "\n" + "Правельный ответ: " + word);
            Form f = new Start();
            f.Show();
            this.Hide();
        }
    }
}
