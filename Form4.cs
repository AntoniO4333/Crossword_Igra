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
    public partial class Form4 : Form
    {
        public Form1 frm1;//menu
        public Form2 frm2;//rules

        Graphics g;
        public Form4()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }
        private void Menu_Click(object sender, EventArgs e)
        {
            if (frm1 == null) frm1 = new Form1();//Создаем указатель на форму 3
            frm1.frm4 = this;//Передаем форме 3 указатель на форму 1
            frm1.Show();//Показываем форму 3
            this.Hide();//Прячем форму 1 
        }

        Point lastpoint; //прописываем чтобы можно было двигать игру по экрану мышкой

        private void Form4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }
        private void Form4_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }


        private void lvl1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("C://Users//Anton Cheryomushkin//Desktop//игра на C#//игра на C#//Crossword_Igra//WhichLvlNow.txt");
            sw.WriteLine("1");
            sw.Close();

            frm2 = new Form2();//Создаем указатель на форму 3
            frm2.frm4 = this;//Передаем форме 3 указатель на форму 1
            frm2.Show();//Показываем форму 3
            this.Hide();//Прячем форму 1 
        }

        private void lvl2_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("C://Users//Anton Cheryomushkin//Desktop//игра на C#//игра на C#//Crossword_Igra//WhichLvlNow.txt");
            sw.WriteLine("2");
            sw.Close();
        }
    }
}
