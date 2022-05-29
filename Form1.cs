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
    public partial class Form1 : Form
    {
        public Form2 frm2;//play
        public Form3 frm3;//rules
        public Form4 frm4;//rules
        public Form1()
        {
            InitializeComponent();
        }

        private void play_Click(object sender, EventArgs e)
        {
            if (frm2 == null){                
                StreamWriter sw = new StreamWriter("C://Users//Anton Cheryomushkin//Desktop//игра на C#//игра на C#//Crossword_Igra//WhichLvlNow.txt");
                sw.WriteLine("1");
                sw.Close();

                frm2 = new Form2();//Создаем указатель на форму 2
            }
            frm2.frm1 = this;//Передаем форме 2 указатель на форму 1
            frm2.Show();//Показываем форму 2
            this.Hide();//Прячем форму 1       
        }

        private void Rules_Click(object sender, EventArgs e)
        {
            if (frm3 == null) frm3 = new Form3();//Создаем указатель на форму 3
            frm3.frm1 = this;//Передаем форме 3 указатель на форму 1
            frm3.Show();//Показываем форму 3
            this.Hide();//Прячем форму 1 
        }
private void ВыборУровня_Click(object sender, EventArgs e)
        {
            if (frm4 == null) frm4 = new Form4();//Создаем указатель на форму 3
            frm4.frm1 = this;//Передаем форме 3 указатель на форму 1
            frm4.Show();//Показываем форму 3
            this.Hide();//Прячем форму 1 
        }


        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        Point lastpoint; //прописываем чтобы можно было двигать игру по экрану мышкой
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
