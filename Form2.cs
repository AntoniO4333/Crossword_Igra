using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Crossword_Igra
{
    public partial class Form2 : Form
    {
        public Form1 frm1;//menu
        public Form2 frm2;//menu
        public Form4 frm4;//menu
        public Form3 frm3;//rules

        Graphics g;
        Pen myPenBlack = new Pen(Color.Black, 3);
        SolidBrush redBr = new SolidBrush(Color.Red);
        SolidBrush whiteBr = new SolidBrush(Color.White);

        StreamReader f = new StreamReader("C://Users//Anton Cheryomushkin//Desktop//игра на C#//игра на C#//Crossword_Igra//Words_lvl1.txt");

        Point lastpoint; //прописываем чтобы можно было двигать игру по экрану мышкой
                        
        string TL = "С";
        string TR = "Л";
        string ML = "О";
        string MR = "В";
        string B = "О";
        string BL = "А";


        int count = 0;

        int lvl;

        public Form2()
        {
            StreamReader sw = new StreamReader("C://Users//Anton Cheryomushkin//Desktop//игра на C#//игра на C#//Crossword_Igra//WhichLvlNow.txt");
            lvl = Convert.ToInt32(sw.ReadLine());
            sw.Close();

            InitializeComponent();
            g = this.CreateGraphics();                       

            if(lvl == 2)
            {
                TL = "Д";
                TR = "Л";
                ML = "Л";
                MR = "Р";
                B = "О";
                BL = "А";
                TopLeft.Text = "Д";
                TopRight.Text = "Л";
                MiddleLeft.Text = "Л";
                MiddleRight.Text = "Р";
                Bottom.Text = "О";
                BottomLeft.Text = "А";
            }
            TopLeft.Text = TL;
            TopRight.Text = TR;
            MiddleLeft.Text = ML;
            MiddleRight.Text = MR;
            Bottom.Text = B;
            BottomLeft.Text = BL;
        }
        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            g.FillEllipse(redBr, 700, 300, 100, 100); //красный круг
            if (lvl == 1)
            {                
                DrawRecs(300, 160, 500, 200); //СЛОВО 
                DrawRecs(300, 160, 340, 320); //САЛО
                DrawRecs(180, 200, 340, 240); //СОВА
                DrawRecs(420, 160, 460, 360); //ВОЛОС
                DrawRecs(460, 40, 500, 200); //СОЛО
                DrawRecs(460, 80, 620, 120); //ОВАЛ
                DrawRecs(340, 80, 380, 200); //ВАЛ
                DrawRecs(220, 160, 260, 280); //ВОЛ
                DrawRecs(380, 320, 500, 360); //ОСА
            }
            if(lvl == 2)
            {

            }
        }
        
        private void TopLeft_Click(object sender, EventArgs e)
        {
            label1.Text += TL;
            TopLeft.Visible = false;
        }
        private void TopRight_Click(object sender, EventArgs e)
        {
            label1.Text += TR;
            TopRight.Visible = false;
        }
        private void MiddleLeft_Click(object sender, EventArgs e)
        {
            label1.Text += ML;
            MiddleLeft.Visible = false;
        }
        private void MiddleRight_Click(object sender, EventArgs e)
        {
            label1.Text += MR;
            MiddleRight.Visible = false;
        }
        private void Bottom_Click(object sender, EventArgs e)
        {
            label1.Text += B;
            Bottom.Visible = false;

        }
        private void BottomLeft_Click(object sender, EventArgs e)
        {
            label1.Text += BL;
            BottomLeft.Visible = false;
        }        


        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }
        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }


        private void Rules_Click(object sender, EventArgs e)
        {
            if (frm3 == null) frm3 = new Form3();//Создаем указатель на форму 3
            frm3.frm2 = this;//Передаем форме 3 указатель на форму 1
            frm3.Show();//Показываем форму 3
            this.Hide();//Прячем форму 1 
        }
        private void Menu_Click(object sender, EventArgs e)
        {
            if (frm1 == null) frm1 = new Form1();//Создаем указатель на форму 3
            frm1.frm2 = this;//Передаем форме 3 указатель на форму 1
            frm1.Show();//Показываем форму 3
            this.Hide();//Прячем форму 1 
        }


        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            VisibleButtons();
        }
        private void ввод_Click(object sender, EventArgs e)
        {
            StreamReader f = new StreamReader("C://Users//Anton Cheryomushkin//Desktop//игра на C#//игра на C#//Crossword_Igra//Words_lvl1.txt");
            //lvl1
            bool b = false;
            while (!f.EndOfStream)
            {
                b = false;
                string sf = f.ReadLine();
                int xf = Convert.ToInt32(f.ReadLine());
                int yf = Convert.ToInt32(f.ReadLine());
                int cf = Convert.ToInt32(f.ReadLine());

                if (label1.Text == sf)
                {
                    DrawButtons(xf, yf, sf, cf);
                    b = true;
                    count++;
                    break;
                }                                               
            }
            if (b == false)
            {
                MessageBox.Show("Этого слова нет в кроссворде, попробуй другое!");
            }
            label1.Text = "";
            VisibleButtons();
            if(count == 9)
            {
                count = 0;
                MessageBox.Show("Уровень " + Convert.ToString(lvl) + " пройден!");
                Win();
            }
        }


        public void DrawRecs(int x, int y, int x1, int y1)
        {
            g.FillRectangle(whiteBr, x, y, x1 - x, y1 - y);

            for (int i = x; i <= x1; i += 40)
            {
                g.DrawLine(myPenBlack, i, y, i, y1);
            }
            for (int i = y; i <= y1; i += 40)
            {
                g.DrawLine(myPenBlack, x, i, x1, i);
            }
        }
        public void DrawButtons(int x, int y, string s, int t)
        {
            //формируем массив кнопок
            Button[] b1 = new Button[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                char[] sl2 = s.ToCharArray();
                b1[i] = new Button();
                if (t == 0) { b1[i].Left = x + i * 40; b1[i].Top = y; }
                if (t == 1) { b1[i].Top = y + i * 40; b1[i].Left = x; }
                b1[i].Size = new Size(40, 40);
                b1[i].Tag = i;
                b1[i].Click += b1_Click;
                b1[i].BackColor = Color.White;
                b1[i].ForeColor = Color.Black; b1[i].Font = new Font("Arial", 25, FontStyle.Regular);
                Controls.Add(b1[i]);
                b1[i].Text = Convert.ToString(sl2[i]);
            }
        }
        public void VisibleButtons()
        {
            TopLeft.Visible = true;
            TopRight.Visible = true;
            MiddleLeft.Visible = true;
            MiddleRight.Visible = true;
            Bottom.Visible = true;
            BottomLeft.Visible = true;

        }


        public void Win()
        {
            StreamWriter se = new StreamWriter("C://Users//Anton Cheryomushkin//Desktop//игра на C#//игра на C#//Crossword_Igra//WhichLvlNow.txt");
            lvl++;
            se.WriteLine(lvl);
            se.Close();

            this.Hide();
            frm2 = new Form2();
            frm2.Show();
        }


        public void b1_Click(object sender, EventArgs e)

        {
        }
    }
}
