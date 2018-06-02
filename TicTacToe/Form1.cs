using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool computer = false;
        Button[] koumpi = new Button[25];
        int[] comp = new int[25];
        string [] XO = new string [2];
        int count = 0;
        string whowon;
        int x = 0;
        Random rand = new Random();
        int user_click;
        int randstop = 0;
        int randstop2 = 0;
        int ComOrUs;
        bool end = false;

       

        public Form1()
        {
            InitializeComponent();

            koumpi[0] = A11;
            koumpi[1] = A12;
            koumpi[2] = A13;
            koumpi[3] = A14;
            koumpi[4] = A15;
            koumpi[5] = A21;
            koumpi[6] = A22;
            koumpi[7] = A23;
            koumpi[8] = A24;
            koumpi[9] = A25;
            koumpi[10] = A31;
            koumpi[11] = A52;
            koumpi[12] = A33;
            koumpi[13] = A34;
            koumpi[14] = A35;
            koumpi[15] = A41;
            koumpi[16] = A32;
            koumpi[17] = A43;
            koumpi[18] = A44;
            koumpi[19] = A45;
            koumpi[20] = A51;
            koumpi[21] = A42;
            koumpi[22] = A53;
            koumpi[23] = A54;
            koumpi[24] = A55;
            
        }



        public void Winner(object sender, EventArgs e)

        {

            if (((A11.Text == A12.Text) && (A12.Text == A13.Text) && (A13.Text == A14.Text) && (A14.Text == A15.Text) && (!A15.Enabled)) || ((A21.Text == A22.Text) && (A22.Text == A23.Text) && (A23.Text == A24.Text) && (A24.Text == A25.Text) && (!A21.Enabled)) || ((A31.Text == A32.Text) && (A32.Text == A33.Text) && (A33.Text == A34.Text) && (A34.Text == A35.Text) && (!A35.Enabled)) || ((A41.Text == A42.Text) && (A42.Text == A43.Text) && (A43.Text == A44.Text) && (A44.Text == A45.Text) && (!A45.Enabled)) || ((A51.Text == A52.Text) && (A52.Text == A53.Text) && (A53.Text == A54.Text) && (A54.Text == A55.Text) && (!A55.Enabled)) || ((A11.Text == A21.Text) && (A21.Text == A31.Text) && (A31.Text == A41.Text) && (A41.Text == A51.Text) && (!A11.Enabled)) || ((A12.Text == A22.Text) && (A22.Text == A32.Text) && (A32.Text == A42.Text) && (A42.Text == A52.Text) && (!A52.Enabled)) || ((A13.Text == A23.Text) && (A23.Text == A33.Text) && (A33.Text == A43.Text) && (A43.Text == A53.Text) && (!A53.Enabled)) || ((A14.Text == A24.Text) && (A24.Text == A34.Text) && (A34.Text == A44.Text) && (A44.Text == A54.Text) && (!A54.Enabled)) || ((A15.Text == A25.Text) && (A25.Text == A35.Text) && (A35.Text == A45.Text) && (A45.Text == A55.Text) && (!A45.Enabled)) || ((A11.Text == A22.Text) && (A22.Text == A33.Text) && (A33.Text == A44.Text) && (A44.Text == A55.Text) && (!A11.Enabled)) || ((A15.Text == A24.Text) && (A24.Text == A33.Text) && (A33.Text == A42.Text) && (A42.Text == A51.Text) && (!A42.Enabled)))
            {
                MessageBox.Show("Winner Is The " + whowon + " Player");

                for (int i = 0; i < 25; i++)
                {
                    koumpi[i].Enabled = false;
                }
                end = true;
                

            }
            else if ((x==24)||(randstop==13) || (randstop2==13))
            {
                MessageBox.Show("Its A Draw!");
            }

        
        
        }
        

        public void VsCom(object sender, EventArgs e)
        {
            randstop += 1;
            koumpi[user_click].Text = XO[1];
            whowon = XO[1];
            koumpi[user_click].Enabled = false;
            Winner(sender, e);
            if ((randstop < 13)&&(end == false))
            {
                int tyxaio = rand.Next(0, 25);
                while (koumpi[tyxaio].Enabled == false)
                {
                    tyxaio = rand.Next(0, 25);
                }
                randstop2 += 1;
                koumpi[tyxaio].Text = XO[0];
                whowon = XO[0];
                koumpi[tyxaio].Enabled = false;
                Winner(sender, e);
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            XO[0] = "X";
            XO[1] = "O";
            randstop = 0;
            randstop2 = 0;
            menuStrip1.ForeColor = System.Drawing.Color.White;
            koumpi[0].ForeColor = System.Drawing.Color.AliceBlue;
            
            x = 0;
            count = 0;

            for (int i = 0; i < 25; i++)
            {
                koumpi[i].Text = " ";
                koumpi[i].Enabled = true;
            }

            if ((ComOrUs == 1) && (computer==true))
            {
                int first = rand.Next(0, 24);
                koumpi[first].Text = XO[0];
                koumpi[first].Enabled = false;
                randstop2 += 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (computer == false)
            {
                if (count == 0)
                {
                    A11.Text = XO[count];
                    whowon = XO[count];
                    count = 1;


                }
                else if (count == 1)
                {
                    A11.Text = XO[count];
                    whowon = XO[count];
                    count = 0;


                }

                A11.Enabled = false;

                x += 1;



                Winner(sender, e);

            }
            else
            {
                user_click = 0;
                VsCom(sender, e);
               

              

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (computer == false)
            {
                if (count == 0)
                {
                    A12.Text = XO[count];
                    whowon = XO[count];
                    count = 1;

                }
                else if (count == 1)
                {
                    A12.Text = XO[count];
                    whowon = XO[count];
                    count = 0;

                }

                Winner(sender, e);
                A12.Enabled = false;

                x += 1;
            }
            else
            {
                user_click = 1;
                VsCom(sender, e);
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (computer == false)
            {
                if (count == 0)
                {
                    A13.Text = XO[count];
                    whowon = XO[count];
                    count = 1;
                }
                else if (count == 1)
                {
                    A13.Text = XO[count];
                    whowon = XO[count];
                    count = 0;
                }
                A13.Enabled = false;
                Winner(sender, e);
                x += 1;
            }
            else
            {
                user_click = 2;
                VsCom(sender, e);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (computer == false)
            {
                if (count == 0)
                {
                    A14.Text = XO[count];
                    whowon = XO[count];
                    count = 1;
                }
                else if (count == 1)
                {
                    A14.Text = XO[count];
                    whowon = XO[count];
                    count = 0;
                }
                A14.Enabled = false;
                Winner(sender, e);
                x += 1;
            }
            else
            {
                user_click = 3;
                VsCom(sender, e);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (computer == false)
            {
                if (count == 0)
                {
                    A15.Text = XO[count];
                    whowon = XO[count];
                    count = 1;
                }
                else if (count == 1)
                {
                    A15.Text = XO[count];
                    whowon = XO[count];
                    count = 0;
                }
                A15.Enabled = false;
                Winner(sender, e);
                x += 1;
            }
            else
            {
                user_click = 4;
                VsCom(sender, e);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (computer == false)
            {
                if (count == 0)
                {
                    A21.Text = XO[count];
                    whowon = XO[count];
                    count = 1;

                }
                else if (count == 1)
                {
                    A21.Text = XO[count];
                    whowon = XO[count];
                    count = 0;
                }

                A21.Enabled = false;
                Winner(sender, e);
                x += 1;
            }
            else
            {
                user_click = 5;
                VsCom(sender, e);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (computer == false)
            {
                if (count == 0)
                {
                    A22.Text = XO[count];
                    whowon = XO[count];
                    count = 1;
                }
                else if (count == 1)
                {
                    A22.Text = XO[count];
                    whowon = XO[count];
                    count = 0;
                }
                A22.Enabled = false;
                Winner(sender, e);
                x += 1;
            }
            else
            {
                user_click = 6;
                VsCom(sender, e);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (computer == false)
            {
                if (count == 0)
                {
                    A23.Text = XO[count];
                    whowon = XO[count];
                    count = 1;
                }
                else if (count == 1)
                {
                    A23.Text = XO[count];
                    whowon = XO[count];
                    count = 0;
                }
                A23.Enabled = false;
                Winner(sender, e);
                x += 1;
            }
            else
            {
                user_click = 7;
                VsCom(sender, e);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (computer == false)
            {
                if (count == 0)
                {
                    A24.Text = XO[count];
                    whowon = XO[count];
                    count = 1;
                }
                else if (count == 1)
                {
                    A24.Text = XO[count];
                    whowon = XO[count];
                    count = 0;
                }
                A24.Enabled = false;
                Winner(sender, e);
                x += 1;
            }
            else
            {
                user_click = 8;
                VsCom(sender, e);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (computer == false)
            {
                if (count == 0)
                {
                    A25.Text = XO[count];
                    whowon = XO[count];
                    count = 1;
                }
                else if (count == 1)
                {
                    A25.Text = XO[count];
                    whowon = XO[count];
                    count = 0;
                }
                A25.Enabled = false;
                Winner(sender, e);
                x += 1;
            }
            else
            {
                user_click = 9;
                VsCom(sender, e);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (computer == false)
            {
                if (count == 0)
                {
                    A31.Text = XO[count];
                    whowon = XO[count];
                    count = 1;
                }
                else if (count == 1)
                {
                    A31.Text = XO[count];
                    whowon = XO[count];
                    count = 0;
                }
                A31.Enabled = false;
                Winner(sender, e);
                x += 1;
            }
            else
            {
                user_click = 10;
                VsCom(sender, e);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (computer == false)
            {
                if (count == 0)
                {
                    A52.Text = XO[count];
                    whowon = XO[count];
                    count = 1;
                }
                else if (count == 1)
                {
                    A52.Text = XO[count];
                    whowon = XO[count];
                    count = 0;
                }
                A52.Enabled = false;
                Winner(sender, e);
                x += 1;
            }
            else
            {
                user_click = 11;
                VsCom(sender, e);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (computer == false)
            {
                if (count == 0)
                {
                    A33.Text = XO[count];
                    whowon = XO[count];
                    count = 1;
                }
                else if (count == 1)
                {
                    A33.Text = XO[count];
                    whowon = XO[count];
                    count = 0;
                }
                A33.Enabled = false;
                Winner(sender, e);
                x += 1;
            }
            else
            {
                user_click = 12;
                VsCom(sender, e);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (computer == false)
            {
                if (count == 0)
                {
                    A34.Text = XO[count];
                    whowon = XO[count];
                    count = 1;
                }
                else if (count == 1)
                {
                    A34.Text = XO[count];
                    whowon = XO[count];
                    count = 0;
                }
                A34.Enabled = false;
                Winner(sender, e);
                x += 1;
            }
            else
            {
                user_click = 13;
                VsCom(sender, e);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (computer == false)
            {
                if (count == 0)
                {
                    A35.Text = XO[count];
                    whowon = XO[count];
                    count = 1;
                }
                else if (count == 1)
                {
                    A35.Text = XO[count];
                    whowon = XO[count];
                    count = 0;
                }
                A35.Enabled = false;
                Winner(sender, e);
                x += 1;
            }
            else
            {
                user_click = 14;
                VsCom(sender, e);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (computer == false)
            {
                if (count == 0)
                {
                    A41.Text = XO[count];
                    whowon = XO[count];
                    count = 1;
                }
                else if (count == 1)
                {
                    A41.Text = XO[count];
                    whowon = XO[count];
                    count = 0;
                }
                A41.Enabled = false;
                Winner(sender, e);
                x += 1;
            }
            else
            {
                user_click = 15;
                VsCom(sender, e);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (computer == false)
            {
                if (count == 0)
                {
                    A32.Text = XO[count];
                    whowon = XO[count];
                    count = 1;
                }
                else if (count == 1)
                {
                    A32.Text = XO[count];
                    whowon = XO[count];
                    count = 0;
                }
                A32.Enabled = false;
                Winner(sender, e);
                x += 1;
            }
            else
            {
                user_click = 16;
                VsCom(sender, e);
            }
        }

       

        private void button18_Click(object sender, EventArgs e)
        {
            if (computer == false)
            {
                if (count == 0)
                {
                    A43.Text = XO[count];
                    whowon = XO[count];
                    count = 1;
                }
                else if (count == 1)
                {
                    A43.Text = XO[count];
                    whowon = XO[count];
                    count = 0;
                }
                A43.Enabled = false;
                Winner(sender, e);
                x += 1;
            }
            else
            {
                user_click = 17;
                VsCom(sender, e);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (computer == false)
            {
                if (count == 0)
                {
                    A44.Text = XO[count];
                    whowon = XO[count];
                    count = 1;
                }
                else if (count == 1)
                {
                    A44.Text = XO[count];
                    whowon = XO[count];
                    count = 0;
                }
                A44.Enabled = false;
                Winner(sender, e);
                x += 1;
            }
            else
            {
                user_click = 18;
                VsCom(sender, e);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (computer == false)
            {
                if (count == 0)
                {
                    A45.Text = XO[count];
                    whowon = XO[count];
                    count = 1;
                }
                else if (count == 1)
                {
                    A45.Text = XO[count];
                    whowon = XO[count];
                    count = 0;
                }
                A45.Enabled = false;
                Winner(sender, e);
                x += 1;
            }
            else
            {
                user_click = 19;
                VsCom(sender, e);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (computer == false)
            {
                if (count == 0)
                {
                    A51.Text = XO[count];
                    whowon = XO[count];
                    count = 1;
                }
                else if (count == 1)
                {
                    A51.Text = XO[count];
                    whowon = XO[count];
                    count = 0;
                }
                A51.Enabled = false;
                Winner(sender, e);
                x += 1;
            }
            else
            {
                user_click = 20;
                VsCom(sender, e);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (computer == false)
            {
                if (count == 0)
                {
                    A42.Text = XO[count];
                    whowon = XO[count];
                    count = 1;
                }
                else if (count == 1)
                {
                    A42.Text = XO[count];
                    whowon = XO[count];
                    count = 0;
                }
                A42.Enabled = false;
                Winner(sender, e);
                x += 1;
            }
            else
            {
                user_click = 21;
                VsCom(sender, e);
            }
        }

        

        private void button23_Click(object sender, EventArgs e)
        {
            if (computer == false)
            {
                if (count == 0)
                {
                    A53.Text = XO[count];
                    whowon = XO[count];
                    count = 1;
                }
                else if (count == 1)
                {
                    A53.Text = XO[count];
                    whowon = XO[count];
                    count = 0;
                }
                A53.Enabled = false;
                Winner(sender, e);
                x += 1;
            }
            else
            {
                user_click = 22;
                VsCom(sender, e);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (computer == false)
            {
                if (count == 0)
                {
                    A54.Text = XO[count];
                    whowon = XO[count];
                    count = 1;
                }
                else if (count == 1)
                {
                    A54.Text = XO[count];
                    whowon = XO[count];
                    count = 0;
                }
                A54.Enabled = false;
                Winner(sender, e);
                x += 1;
            }
            else
            {
                user_click = 23;
                VsCom(sender, e);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (computer == false)
            {
                if (count == 0)
                {
                    A55.Text = XO[count];
                    whowon = XO[count];
                    count = 1;
                }
                else if (count == 1)
                {
                    A55.Text = XO[count];
                    whowon = XO[count];
                    count = 0;

                }
                A55.Enabled = false;
                Winner(sender, e);
                x += 1;
            }
            else
            {
                user_click = 24;
                VsCom(sender, e);

            }
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iNSTRUCTIONSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" ");

        }

       

        private void nEWGAMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            computer = false;
            Form1_Load(sender, e);
            count = 0;
        }

        private void oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            computer = false;
            Form1_Load(sender, e);
            count = 1;
        }

        

        

        private void playerFirstToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ComOrUs = 0;
            computer = true;
            Form1_Load(sender, e);
        }

        private void computerFirstToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ComOrUs = 1;
            computer = true;
            Form1_Load(sender, e);
        }







    }
}
