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
        public Form3 frm3;//rules
        public Form4 frm4;//menu
        

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
        bool OSA_s = false;
        bool VOL_s = false;
        bool VAL_s = false;
        bool OVAL_s = false;
        bool SOLO_s = false;
        bool VOLOS_s = false;
        bool SOVA_s = false;
        bool SALO_S = false;
        bool SLOVO_s = false;
        //lvl1

        bool DOLLAR_s = false;
        bool LORD_s = false;
        bool ORDA_s = false;
        bool ROLL_s = false;
        bool DAR_s = false;
        bool DOL_s = false;
        bool LAD_s = false;
        bool ROD_s = false;
        //lvl2

        bool LEPESTOK_s = false;
        bool TELESKOP_s = false;
        bool OTPLESK_s = false;
        bool SLEPOK_s = false;
        bool TEPLO_s = false;
        bool KLOP_s = false;
        bool POLE_s = false;
        bool SOK_s = false;
        bool KOT_s = false;
        //lvl3

        int count = 0;
        int points;

        int lvl;

        public Form2()
        {
            StreamReader sw = new StreamReader("C://Users//Anton Cheryomushkin//Desktop//игра на C#//игра на C#//Crossword_Igra//WhichLvlNow.txt");
            lvl = Convert.ToInt32(sw.ReadLine());
            sw.Close();

            StreamReader ss = new StreamReader("C://Users//Anton Cheryomushkin//Desktop//игра на C#//игра на C#//Crossword_Igra//points.txt");
            points = Convert.ToInt32(ss.ReadLine());
            ss.Close();

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
            }
            if (lvl == 3)
            {
                TL = "Т";
                TR = "С";
                ML = "Е";
                MR = "П";
                B = "Е";
                BL = "Л";
                MiddleUpLeft.Text = "О";
                MiddleUpRight.Text = "К";
                MiddleUpLeft.Visible = true;
                MiddleUpRight.Visible = true;
                MiddleLeft.Location = new Point(650, 365);
                MiddleRight.Location = new Point(810, 365);
                TopLeft.Location = new Point(695, 255);
                TopRight.Location = new Point(765, 255);
                BottomLeft.Location = new Point(695, 410);
                Bottom.Location = new Point(765, 410);
                button2.Location = new Point(640,477);
                button2.Size = new Size(235,55);
                label1.Location = new Point(650,485);
            }

            TopLeft.Text = TL;
            TopRight.Text = TR;
            MiddleLeft.Text = ML;
            MiddleRight.Text = MR;
            Bottom.Text = B;
            BottomLeft.Text = BL;

            label2.Text = "Points: " + Convert.ToString(points);

            if (lvl == 1) подсказка.Visible = true;
            else подсказка.Visible = false;
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
                DrawRecs(240, 160, 480, 200); //ДОЛЛАР
                DrawRecs(240, 40, 280, 200); //ЛОРД
                DrawRecs(160, 40, 280, 80); //ДОЛ
                DrawRecs(160, 40, 200, 160); //ДАР
                DrawRecs(400, 40, 440, 200); //ОРДА
                DrawRecs(320, 160, 360, 280); //ЛАД
                DrawRecs(240, 240, 360, 280); //РОД
                DrawRecs(240, 240, 280, 400); //РОЛЛ
            }
            if(lvl == 3)
            {
                /*bool LEPESTOK_s = false;
                bool TELESKOP_s = false;
                bool OTPLESK_s = false;
                bool COK_s = false;
                bool SLEPOK_s = false;
                bool PEKLO_s = false;
                bool LEPET_s = false;
                bool SKELET_s = false;  
                bool STEKLO_s = false;
                bool KOT_s = false;
                bool KLOP_s = false;

                bool TEPLO_s = false;
                bool POLE_s = false;*/

                DrawRecs(160, 240, 480, 280); //ЛЕПЕСТОК
                DrawRecs(240, 160, 280, 440); //ОТПЛЕСК
                DrawRecs(40, 400, 360, 440); //ТЕЛЕСКОП
                DrawRecs(200, 400, 240, 520); //СОК
                DrawRecs(80, 160, 320, 200); //СЛЕПОК
                DrawRecs(120, 360, 160, 520); //КЛОП
                DrawRecs(40, 320, 80, 440); //КОТ
                DrawRecs(160, 40, 200, 200); //ПОЛЕ
                DrawRecs(400, 80, 440, 280); //ТЕПЛО
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
        private void MiddleUpLeft_Click(object sender, EventArgs e)
        {
            label1.Text += MiddleUpLeft.Text;
            MiddleUpLeft.Visible = false;           
        }
        private void MiddleUpRight_Click(object sender, EventArgs e)
        {
            label1.Text += MiddleUpRight.Text;
            MiddleUpRight.Visible = false;
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

            StreamReader f2 = new StreamReader("C://Users//Anton Cheryomushkin//Desktop//игра на C#//игра на C#//Crossword_Igra//Words_lvl2.txt");

            StreamReader f3 = new StreamReader("C://Users//Anton Cheryomushkin//Desktop//игра на C#//игра на C#//Crossword_Igra//Words_lvl3.txt");

            bool b = false;
            while (!f.EndOfStream)
            {
                b = false;
                string sf = f.ReadLine();
                int xf = Convert.ToInt32(f.ReadLine());
                int yf = Convert.ToInt32(f.ReadLine());
                int cf = Convert.ToInt32(f.ReadLine());
                if(lvl == 2)
                {
                    sf = f2.ReadLine();
                    xf = Convert.ToInt32(f2.ReadLine());
                    yf = Convert.ToInt32(f2.ReadLine());
                    cf = Convert.ToInt32(f2.ReadLine());
                }
                if (lvl == 3)
                {
                    sf = f3.ReadLine();
                    xf = Convert.ToInt32(f3.ReadLine());
                    yf = Convert.ToInt32(f3.ReadLine());
                    cf = Convert.ToInt32(f3.ReadLine());
                }               

                if (label1.Text == sf)
                {
                    DrawButtons(xf, yf, sf, cf);
                    
                    if (sf == "СЛОВО" && SLOVO_s == false)
                    {
                        SLOVO_s = true;
                        count++;
                        b = true;
                        points_s();
                    }
                    if (sf == "ВОЛ" && VOL_s == false)
                    {
                        VOL_s = true;
                        count++;
                        b = true;
                        points_s();
                    }
                    if (sf == "ВАЛ" && VAL_s == false)
                    {
                        VAL_s = true;
                        count++;
                        b = true;
                        points_s();
                    }
                    if (sf == "ОВАЛ" && OVAL_s == false)
                    {
                        OVAL_s = true;
                        count++;
                        b = true;
                        points_s();
                    }
                    if (sf == "СОЛО" && SOLO_s == false)
                    {
                        SOLO_s = true;
                        count++;
                        b = true;
                        points_s();
                    }
                    if (sf == "ВОЛОС" && VOLOS_s == false)
                    {
                        VOLOS_s = true;
                        count++;
                        b = true;
                        points_s();
                    }
                    if (sf == "СОВА" && SOVA_s == false)
                    {
                        SOVA_s = true;
                        count++;
                        b = true;
                        points_s();
                    }
                    if (sf == "САЛО" && SALO_S == false)
                    {
                        SALO_S = true;
                        count++;
                        b = true;
                        points_s();
                    }
                    if (sf == "ОСА" && OSA_s == false)
                    {
                        OSA_s = true;
                        count++;
                        b = true;
                        points_s();
                    } 
                    

                    if (sf == "ДОЛЛАР" && DOLLAR_s == false)
                    {
                        DOLLAR_s = true;
                        count++;
                        b = true;
                        points_s();
                    }
                    if (sf == "ЛОРД" && LORD_s == false)
                    {
                        LORD_s = true;
                        count++;
                        b = true;
                        points_s();
                    }
                    if (sf == "ОРДА" && ORDA_s == false)
                    {
                        ORDA_s = true;
                        count++;
                        b = true;
                        points_s();
                    }
                    if (sf == "РОЛЛ" && ROLL_s == false)
                    {
                        ROLL_s = true;
                        count++;
                        b = true;
                        points_s();
                    }
                    if (sf == "ДАР" && DAR_s == false)
                    {
                        DAR_s = true;
                        count++;
                        b = true;
                        points_s();
                    }
                    if (sf == "ДОЛ" && DOL_s == false)
                    {
                        DOL_s = true;
                        count++;
                        b = true;
                        points_s();
                    }
                    if (sf == "ЛАД" && LAD_s == false)
                    {
                        LAD_s = true;
                        count++;
                        b = true;
                        points_s();
                    }
                    if (sf == "РОД" && ROD_s == false)
                    {
                        ROD_s = true;
                        count++;
                        b = true;
                        points_s();
                    }


                    if (sf == "ЛЕПЕСТОК" && DOLLAR_s == false)
                    {
                        LEPESTOK_s = true;
                        count++;
                        b = true;
                        points_s();
                    }
                    if (sf == "ТЕЛЕСКОП" && DOLLAR_s == false)
                    {
                        TELESKOP_s = true;
                        count++;
                        b = true;
                        points_s();
                    }
                    if (sf == "СЛЕПОК" && DOLLAR_s == false)
                    {
                        SLEPOK_s = true;
                        count++;
                        b = true;
                        points_s();
                    }
                    if (sf == "ТЕПЛО" && DOLLAR_s == false)
                    {
                        TEPLO_s = true;
                        count++;
                        b = true;
                        points_s();
                    }
                    if (sf == "КЛОП" && DOLLAR_s == false)
                    {
                        KLOP_s = true;
                        count++;
                        b = true;
                        points_s();
                    }
                    if (sf == "ПОЛЕ" && DOLLAR_s == false)
                    {
                        POLE_s = true;
                        count++;
                        b = true;
                        points_s();
                    }
                    if (sf == "СОК" && DOLLAR_s == false)
                    {
                        SOK_s = true;
                        count++;
                        b = true;
                        points_s();
                    }
                    if (sf == "КОТ" && DOLLAR_s == false)
                    {
                        KOT_s = true;
                        count++;
                        b = true;
                        points_s();
                    }
                    if (sf == "ОТПЛЕСК" && DOLLAR_s == false)
                    {
                        OTPLESK_s = true;
                        count++;
                        b = true;
                        points_s();
                    }
                    break;
                }                
            }
            if (b == false)
            {                
                if (points >= 1)
                {
                    StreamWriter sss = new StreamWriter("C://Users//Anton Cheryomushkin//Desktop//игра на C#//игра на C#//Crossword_Igra//points.txt");
                    points -= 1;
                    sss.WriteLine(Convert.ToString(points));
                    sss.Close();
                }
                MessageBox.Show("Этого слова нет в кроссворде или ты уже использовал это слово, попробуй другое!");
            }
            label1.Text = "";
            label2.Text = "Points: " + Convert.ToString(points);
            VisibleButtons();
            if (lvl == 1)
            {
                if (CW1() == true)
                {
                    count = 0;
                    MessageBox.Show("Уровень " + Convert.ToString(lvl) + " пройден!");
                    Win();
                }
            }
            if(lvl == 2)
            {
                if (CW2() == true)
                {
                    count = 0;
                    MessageBox.Show("Уровень " + Convert.ToString(lvl) + " пройден!");
                    Win();
                }
            }
            if(lvl == 3)
            {
                if (CW3() == true)
                {
                    count = 0;
                    MessageBox.Show("Уровень " + Convert.ToString(lvl) + " пройден!");
                    MessageBox.Show("Вы прошли игру! Вы набрали баллов:" + Convert.ToString(points));
                }
            }
        }
        private void подсказка_Click(object sender, EventArgs e)
        {
            if (points >= 5)
            {
                StreamWriter sss = new StreamWriter("C://Users//Anton Cheryomushkin//Desktop//игра на C#//игра на C#//Crossword_Igra//points.txt");
                points -= 5;
                sss.WriteLine(Convert.ToString(points));
                sss.Close();
                label2.Text = "Points: " + Convert.ToString(points);
                if (SLOVO_s == false)
                {
                    MessageBox.Show("'Word' на русском");
                }
                else if (VOL_s == false)
                {
                    MessageBox.Show("Бык, используемый в сельскохозяйственных работах");

                }
                else if (VAL_s == false)
                {
                    MessageBox.Show("Земляная насыпь");

                }
                else if (OVAL_s == false)
                {
                    MessageBox.Show("Вытянутый круг");

                }
                else if (SOLO_s == false)
                {
                    MessageBox.Show("Танец, исполняемый одним человеком");
                }
                else if (VOLOS_s == false)
                {
                    MessageBox.Show("Часть прически");

                }
                else if (SOVA_s == false)
                {
                    MessageBox.Show("Хищная ночная птица");

                }
                else if (SALO_S == false)
                {
                    MessageBox.Show("Украинское национальное блюдо");

                }
                else if (OSA_s == false)
                {
                    MessageBox.Show("Жалящее насекомое, которое любит сладкое");
                }
            }
            else MessageBox.Show("У вас недостаточно очков");
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
            if (lvl == 3)
            {
                MiddleUpLeft.Visible = true;
                MiddleUpRight.Visible = true;
            }
        }
        

        public void Win()
        {
            StreamWriter se = new StreamWriter("C://Users//Anton Cheryomushkin//Desktop//игра на C#//игра на C#//Crossword_Igra//WhichLvlNow.txt");
            lvl++;
            se.WriteLine(lvl);
            se.Close();

            this.Close();
            frm2 = new Form2();
            frm2.frm1 = this.frm1;            
            frm2.Show();
        }
        public void points_s()
        {
            StreamWriter sss = new StreamWriter("C://Users//Anton Cheryomushkin//Desktop//игра на C#//игра на C#//Crossword_Igra//points.txt");
            points += 2;
            sss.WriteLine(Convert.ToString(points));
            sss.Close();
        }
        public bool CW1()
        {
            bool t = false;
            if(OSA_s == true && VOL_s == true && VAL_s == true && OVAL_s == true && SOLO_s == true && VOLOS_s == true && SOVA_s == true && SALO_S == true && SLOVO_s == true) t = true;
            return t;
        }
        public bool CW2()
        {
            bool t = false;
            if (DOLLAR_s == true && LORD_s == true && ORDA_s == true && ROLL_s == true && DAR_s == true && DOL_s == true && LAD_s == true && ROD_s == true) t = true;
            return t;
        }
        public bool CW3()
        {
            bool t = false;
            if (LEPESTOK_s == true && TELESKOP_s == true && SLEPOK_s == true && KLOP_s == true && POLE_s == true && SOK_s == true && KOT_s == true && OTPLESK_s == true && TEPLO_s == true) t = true;
            return t;
        }



        public void b1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
