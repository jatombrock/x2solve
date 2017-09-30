using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polynom_Löser
{
    public partial class Form1 : Form
    {
            double ax;
            double bx;
            double c;
            int round = 10;
            bool valid;
        
        public Form1()
        {
            InitializeComponent();
        }

        public void zeropoint()
        {

            bool undernull = false;

            double top1;
            double top2;
            double bot;
            double sqrt;
            double sqrtvalue;

            double erg1;
            double erg2;


            try
                {
                    sqrtvalue = Math.Pow(bx, 2) - 4 * ax * c;
                    bot = 2 * ax;           //untere Teil der abc-Formel
                  
                    string sqrtlow1;
                    string sqrtlow2;

                    if (sqrtvalue < 0)
                        undernull = true;
                    else
                        undernull = false;

                   
                    if (undernull == true)
                    {
                        double p = bx / ax;
                        double q = (c / ax);

                        double value = Math.Pow(p/2 , 2) - q;
                           
                        double front = - (p / 2); // Vordere Teil der pq formel
                               front = Math.Round(front, round);
                        double back1 =  Math.Sqrt(value * (-1));
                        double back2 =  Math.Sqrt(value * (-1));

                        sqrtlow1 = front.ToString() + "+" + (Math.Round(back1, round)).ToString() + "i";
                        sqrtlow2 = front.ToString() + "-" +(Math.Round(back2, round)).ToString() + "i";

                        lb_lös1.Text = "1:  " + sqrtlow1.ToString();
                        lb_lös2.Text = "2:  " + sqrtlow2.ToString();
 
                }
                    else
                    {
                        sqrt = Math.Sqrt(sqrtvalue);

                        top1 = -bx + sqrt;
                        top2 = -bx - sqrt;

                        erg1 = Math.Round(top1 / bot, round);
                        erg2 = Math.Round(top2 / bot, round);

                        lb_lös1.Text = "1:  " + erg1.ToString();
                        lb_lös2.Text = "2:  " + erg2.ToString();
                    
                    }

                        

                }
                catch (Exception) { throw; }
            
        }

        public void Vertex()
        {

            double topx;
            double topy;

            double botx;
            double boty;


            double ergx;
            double ergy;

            //////////ergx/////////////////////
            topx = bx;
            botx = 2 * ax;
            ergx = - topx / botx;
            //////////ergx/////////////////////

            //////////ergy/////////////////////
            topy = Math.Pow(bx, 2);
            boty = 4 * ax;
            ergy = c - (topy / boty);
            //////////ergy/////////////////////

            ergx = Math.Round(ergx, round);
            ergy = Math.Round(ergy, round);

            ///////////////point////////////////////
            string point;
            double bx2 = Math.Round((bx / ax)/2, round - 3);
            double frac =  Math.Round(Math.Pow((bx2),2), round - 3);
            point = ax.ToString() + "(" + "x" + "+ (" + bx2.ToString() + "))² " + "+ (" +  (- ax * frac + c).ToString() + ")";
            ////////////////////////////////////////


            //////////////output////////////////////
            lb_verx.Text = "x:  " + ergx.ToString();
            lb_very.Text = "y:  " + ergy.ToString();
            lb_vertexp.Text = "P: " +point;
            ////////////////////////////////////////
            

        }

        public double fraction(string checktext)
        {
            try
            {
                string[] parts = checktext.Split('/');
                double top = Convert.ToDouble(parts[0]);
                double bot = Convert.ToDouble(parts[1]);
                double erg = top / bot;

                return erg;
            }
            catch (Exception)
            {
                double erg = Convert.ToDouble(checktext);
                return erg;
            }
           
        }

        public double sqrt(string checksqrt)
        {

            string a =  checksqrt.Substring(checksqrt.IndexOf("sqrt("), checksqrt.IndexOf(")"));
            double b = Convert.ToDouble(a);
            double c = Math.Sqrt(b);

            return c;
        }

        private void bt_lösen_Click(object sender, EventArgs e)
        {
            if (txt_ax.Text == "" && txt_bx.Text == "" && txt_c.Text == "")
            {
                MessageBox.Show("Please fill in all fields");
            }
            else
            {
                try
                {
                        ax = fraction(txt_ax.Text);
                        bx = fraction(txt_bx.Text);
                        c = fraction(txt_c.Text);
                    
                        zeropoint();
                        Vertex();
                        bt_showGraph.Enabled = true;
                }
                catch (Exception)
                   {
                        MessageBox.Show("Enter numbers only(2)");
                   }
                }
            }
        
        private void Form1_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.FromArgb(45, 190, 96);
            menuStrip1.BackColor = Color.FromArgb(123, 134, 138);
            bt_showGraph.Enabled = false;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This software as a whole:" + Environment.NewLine + "Copyright ©2016-2017 Jan Tombrock" + Environment.NewLine + "All rights reserved.");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
 }

