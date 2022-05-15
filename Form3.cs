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
    public partial class Form3 : Form
    {
        public Form1 frm1;
        public Form2 frm2;//play
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (frm1 == null) frm1 = new Form1();//Создаем указатель на форму 3
            frm1.frm3 = this;//Передаем форме 3 указатель на форму 1
            frm1.Show();//Показываем форму 3
            this.Hide();//Прячем форму 1 
        } 
        private void Play_Click(object sender, EventArgs e)
        {
            if (frm2 == null) frm2 = new Form2();//Создаем указатель на форму 3
            frm2.frm3 = this;//Передаем форме 3 указатель на форму 2
            frm2.Show();//Показываем форму 3
            this.Hide();//Прячем форму 2 
        }  
        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        Point lastpoint; //прописываем чтобы можно было двигать игру по экрану мышкой

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
            TransparencyKey = BackColor;
        }
    }
}
