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

        public Form2()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            TopLeft.Text = "С";
            TopRight.Text = "Л";
            MiddleLeft.Text = "О";
            MiddleRight.Text = "В";
            Bottom.Text = "О";
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            g.FillEllipse(redBr, 700, 300, 100, 100); //красный круг
            DrawRecs(300, 160, 500, 200); //СЛОВО
        }
        public void DrawRecs(int x, int y, int x1, int y1)
        {
            for(int i = x; i <= x1; i += 40)
            {
                g.DrawLine(myPenBlack, i, y, i, y1);
            }
            for (int i = y; i <= y1; i += 40)
            {
                g.DrawLine(myPenBlack, x, i, x1, i);
            }
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
            if (frm3 == null)  frm3 = new Form3();//Создаем указатель на форму 3
            frm3.frm2 = this;//Передаем форме 3 указатель на форму 1
            frm3.Show();//Показываем форму 3
            this.Hide();//Прячем форму 1 
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            if(frm1 == null) frm1 = new Form1();//Создаем указатель на форму 3
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
            if(label1.Text == "СЛОВО")
            {
                Label label2 = new Label();
                label2.Text = "СЛОВО";
                label2.Location = new Point(300, 160);
                label2.BorderStyle = BorderStyle.FixedSingle;
            }
            label1.Text = "";
        }
    }
}
