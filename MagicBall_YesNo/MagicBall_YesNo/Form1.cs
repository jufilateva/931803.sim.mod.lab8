using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicBall_YesNo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rn = new Random();

        
        public void Ans(double p)
        {
            
            double a = (double)rn.NextDouble();
            
            if (a > p) l_ans.Text = "Yes";
            else l_ans.Text = "No";

        }

        public void MagicAns()
        {
            double a = (double)rn.NextDouble();
           
            double[] A = new double[5];
            string[] phrase = { "Ты уверен, что того стоит?", "Лучшая идея за неделю!", "Я бы на твоем месте не принимал поспешных решений...", "Дерзай!", "Может, лучше передумаешь, пока не поздно?" };
            A[0] = 0.2;
            for (int i = 1; i < 5; i++)
            {
                A[i] = A[i - 1] + 0.2;
            }
            for (int i = 0; i < 5; i++)
            {
                if ((a - A[i]) < 0)
                {
                    l_magicans.Text = phrase[i];
                    break;
                }
            }
            
            /*switch (needed)
            {
                case 1:
                    l_magicans.Text = "Ты уверен, что того стоит?";
                    break;
                case 2:
                    l_magicans.Text = "Лучшая идея за неделю!";
                    break;
                case 3:
                    l_magicans.Text = "Я бы на твоем месте не принимал поспешных решений...";
                    break;
                case 4:
                    l_magicans.Text = "Дерзай!";
                    break;
                case 5:
                    l_magicans.Text = "Может, лучше передумаешь, пока не поздно?";
                    break;
            }*/
        }
        private void b_yesno_Click(object sender, EventArgs e)
        {
            Ans(0.6);
        }

        private void b_ball_Click(object sender, EventArgs e)
        {
            MagicAns();
        }
    }
}
