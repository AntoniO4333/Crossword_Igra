using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crossword_Igra
{
    public partial class Form2 : Form
    {
        public Form1 frm1;
        public Form3 frm3;//rules

        Graphics g;
        Pen myPenBlack = new Pen(Color.Black, 3);
        SolidBrush redBr = new SolidBrush(Color.Red);

        Button[] b1 = new Button[5];

        string sl = "СЛОВО";        
        char[] slovo = { 'С','Л','О','В','О' };
        bool t = false;
        public Form2()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            TopLeft.Text = "С";
            TopRight.Text = "Л";
            MiddleLeft.Text = "О";
            MiddleRight.Text = "В";
            Bottom.Text = "О";
            BottomLeft.Text = "А";           
            DrawButtons(300, 160, sl, t);
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            g.FillEllipse(redBr, 700, 300, 100, 100); //красный круг
            DrawRecs(300, 160, 500, 200); //СЛОВО
        }


        private void TopLeft_Click(object sender, EventArgs e)
        {
            label1.Text += "С";
        }

        private void TopRight_Click(object sender, EventArgs e)
        {
            label1.Text += "Л";
        }

        private void MiddleLeft_Click(object sender, EventArgs e)
        {
            label1.Text += "О";
        }

        private void MiddleRight_Click(object sender, EventArgs e)
        {
            label1.Text += "В";
        }

        private void Bottom_Click(object sender, EventArgs e)
        {
            label1.Text += "О";
        }
        private void BottomLeft_Click(object sender, EventArgs e)
        {
            label1.Text += "А";
        }
        Point lastpoint; //прописываем чтобы можно было двигать игру по экрану мышкой

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
        }

        private void ввод_Click(object sender, EventArgs e)
        {
            if (label1.Text == "СЛОВО")
            {
                t = true;
                for(int i = 0; i < 5; i++) b1[i].Visible = false;
                DrawButtons(300, 160, sl, t);
                t = false;
            }
            label1.Text = "";
        }

        public void DrawRecs(int x, int y, int x1, int y1)
        {
            for (int i = x; i <= x1; i += 40)
            {
                g.DrawLine(myPenBlack, i, y, i, y1);
            }
            for (int i = y; i <= y1; i += 40)
            {
                g.DrawLine(myPenBlack, x, i, x1, i);
            }
        }
        public void DrawButtons(int x, int y, string s, bool t)
        {
            //формируем массив кнопок       
            for (int i = 0; i < s.Length; i++)
            {
                char[] sl2 = s.ToCharArray();
                b1[i] = new Button();
                b1[i].Left = x + i * 40;
                b1[i].Top = y;
                b1[i].Size = new Size(40, 40);
                b1[i].Tag = i;
                b1[i].Click += b1_Click;
                b1[i].BackColor = Color.White;
                b1[i].ForeColor = Color.Red; b1[i].Font = new Font("Arial", 25, FontStyle.Regular);
                Controls.Add(b1[i]);
                b1[i].Enabled = false;
                if (t == true)
                {
                    b1[i].Text = Convert.ToString(sl2[i]);
                }
            }
        }
        public void b1_Click(object sender, EventArgs e)

        {

            /*Button Tb;
            Tb = (Button)sender; //Пpeoбpазование
            if((int)Tb.Tag == 1) //Преобразуем Tag B int
            {
                MessageBox.Show("Победа");
                for (int i = 0; i < 4; i++) b1[i].Hide(); //Прячем все кнопки
            }
            else Tb.Hide(); //Прячем кнопку*/
        }
    }
}
