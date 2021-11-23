using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe_snts
{
    public partial class Form1 : Form
    {
        int cnt = 0;
        bool disX;
        string ltr = "";

        void isdraw(int x)
        {
            if (x == 9)
            {
                msg("1");
                disable(true);
                cleartxt();
            }
        }
        void disable(bool x)
        {
            cnt = 0;
            a1.Enabled = x;
            a2.Enabled = x;
            a3.Enabled = x;
            a4.Enabled = x; 
            a5.Enabled = x;
            a6.Enabled = x;
            a7.Enabled = x;
            a8.Enabled = x;
            a9.Enabled = x;
        }
        void cleartxt()
        {
            cnt = 0;
            ltr = "";
            a1.Text = "";
            a2.Text = "";
            a3.Text = "";
            a4.Text = "";
            a5.Text = "";
            a6.Text = "";
            a7.Text = "";
            a8.Text = "";
            a9.Text = "";
        }
        void msg(string x)
        {
            if (x == "X" || x == "O")
            {
                MessageBox.Show("Player " + x + " wins!");
            }
            else if(x=="1")
            {
                MessageBox.Show("Game is draw!");
        }
            }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void a1_Click(object sender, EventArgs e)
        {
            ltr = new string(new char[] { });
            if (cnt == 0)
            {
                a1.Enabled = false;
                cnt = cnt + 1;
                a1.Text = "X";
                disX = false;
            }
            else if (!disX)
            {
                a1.Enabled = false;
                cnt = cnt + 1;
                
                a1.Text = "O";
                disX = true;
                if (a2.Text == "O" && a3.Text == "O")
                { 
                    msg("O");
                    disable(false);
                    
                }
                if (a4.Text == "O" && a7.Text == "O")
                {
                    msg("O");
                    disable(false);
                    
                }
                if (a5.Text == "O" && a9.Text == "O")
                {
                    msg("O");
                    disable(false);
                   
                }

            }
            else
            {
                a1.Enabled = false;
                cnt = cnt + 1;
                a1.Text = "X";
                disX = false;
                if (a2.Text == "X" && a3.Text == "X")
                {
                    msg("X");
                    disable(false);
                    
                }
                if (a4.Text == "X" && a7.Text == "X")
                {
                    msg("X");
                    disable(false);
                    
                }
                if (a5.Text == "X" && a9.Text == "X")
                {
                    msg("X");
                    disable(false);
                    
                }
            }
            if (cnt == 9)
            {
                msg("1");
                disable(false);
                
            }
        }

        private void a3_Click(object sender, EventArgs e)
        {
            ltr = new string(new char[] { });
            if (cnt == 0)
            {
                a3.Enabled = false;
                cnt = cnt + 1;
                a3.Text = "X";
                disX = false;
            }
            else if (!disX)
            {
                a3.Enabled = false;
                cnt = cnt + 1;
                a3.Text = "O";
                disX = true;
                ltr = "O";
                if (a1.Text == ltr && a2.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                    
                }
                if (a5.Text == ltr && a7.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                    
                }
                if (a6.Text == ltr && a9.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                    
                }

            }
            else 
            {
                a3.Enabled = false;
                cnt = cnt + 1;
                a3.Text = "X";
                disX = false;
                ltr = "X";
                if (a1.Text == ltr && a2.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                    
                }
                if (a5.Text == ltr && a7.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                    
                }
                if (a6.Text == ltr && a9.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                    
                }
            }
             if(cnt == 9)
            {
                msg("1");
                disable(false);
                
            }
        }

        private void a5_Click(object sender, EventArgs e)
        {
            ltr = new string(new char[] { });
            if (cnt == 0)
            {
                a5.Enabled = false;
                cnt = cnt + 1;
                a5.Text = "X";
                disX = false;
            }
            else if (!disX)
            {
                a5.Enabled = false;
                cnt = cnt + 1;
                a5.Text = "O";
                disX = true;
                ltr = "O";
                if (a1.Text == ltr && a9.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                  
                }
                if (a4.Text == ltr && a6.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                   
                }
                if (a7.Text == ltr && a3.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                   
                }
                if (a8.Text == ltr && a2.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                    
                }
            }
            else 
            {
                a5.Enabled = false;
                cnt = cnt + 1;
                a5.Text = "X";
                disX = false;
                ltr = "X";
                if (a1.Text == ltr && a9.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                    
                }
                if (a4.Text == ltr && a6.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                    
                }
                if (a7.Text == ltr && a3.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                   
                }
                if (a8.Text == ltr && a2.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                   
                }
            }
             if (cnt == 9)
            {
                msg("1");
                disable(false);
                
            }
        }

        private void a2_Click(object sender, EventArgs e)
        {
            ltr = new string(new char[] { });
            if (cnt == 0)
            {
                a2.Enabled = false;
                cnt = cnt + 1;
                a2.Text = "X";
                disX = false;
            }
            else if (!disX)
            {
                a2.Enabled = false;
                cnt = cnt + 1;
                a2.Text = "O";
                disX = true;
                ltr = "O";
                if (a1.Text==ltr && a3.Text == ltr)
                {
                    msg("X");
                    disable(false);
                  
                }
                if (a5.Text == ltr && a8.Text == ltr)
                {
                    msg("X");
                    disable(false);
                    
                }
            }
            else 
            {
                a2.Enabled = false;
                cnt = cnt + 1;
                a2.Text = "X";
                disX = false;
                ltr = "X";
                if (a1.Text == ltr && a3.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                    
                }
                if (a5.Text == ltr && a8.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                    
                }
            }
           if(cnt == 9)
            {
                msg("1");
                disable(false);
                
            }


        }

        private void a4_Click(object sender, EventArgs e)
        {
            ltr = new string(new char[] { });
            if (cnt == 0)
            {
                a4.Enabled = false;
                cnt = cnt + 1;
                a4.Text = "X";
                disX = false;
            }
            else if (!disX)
            {
                a4.Enabled = false;
                cnt = cnt + 1;
                a4.Text = "O";
                disX = true;
                ltr = "O";
                if (a1.Text == ltr && a7.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                    
                }
                if (a5.Text == ltr && a6.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                    
                }
            }
            else 
            {
                a4.Enabled = false;
                cnt = cnt + 1;
                a4.Text = "X";
                disX = false;
                ltr = "X";
                if (a1.Text == ltr && a7.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                    
                }
                if (a5.Text == ltr && a6.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                    
                }
            }
             if (cnt == 9)
            {
                msg("1");
                disable(false);
                
            }
        }

        private void a6_Click(object sender, EventArgs e)
        {
            ltr = new string(new char[] { });
            if (cnt == 0)
            {
                a6.Enabled = false;
                cnt = cnt + 1;
                a6.Text = "X";
                disX = false;
            }
            else if (!disX)
            {
                a6.Enabled = false;
                cnt = cnt + 1;
                a6.Text = "O";
                disX = true;
                ltr = "O";
                if (a3.Text == ltr && a9.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                    
                }
                if (a5.Text == ltr && a4.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                    
                }
            }
            else 
            {
                a6.Enabled = false;
                cnt = cnt + 1;
                a6.Text = "X";
                disX = false;
                ltr = "X";
                if (a3.Text == ltr && a9.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                  
                }
                if (a5.Text == ltr && a4.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                    
                }
            }
           if (cnt == 9)
            {
                msg("1");
                disable(false);
                
            }
        }

        private void a7_Click(object sender, EventArgs e)
        {
            ltr = new string(new char[] { });
            if (cnt == 0)
            {
                a7.Enabled = false;
                cnt = cnt + 1;
                a7.Text = "X";
                disX = false;
            }
            else if (!disX)
            {
                a7.Enabled = false;
                cnt = cnt + 1;
                a7.Text = "O";
                disX = true;
                ltr = "O";
                if (a1.Text == ltr && a4.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                   
                }
                if (a5.Text == ltr && a3.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                    
                }
                if (a8.Text == ltr && a9.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                    
                }
            }
            else 
            {
                a7.Enabled = false;
                cnt = cnt + 1;
                a7.Text = "X";
                disX = false;
                ltr = "X";
                if (a1.Text == ltr && a4.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                   
                }
                if (a5.Text == ltr && a3.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                    
                }
                if (a8.Text == ltr && a9.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                    
                }
            }
            if (cnt == 9)
            {
                msg("1");
                disable(false);
               
            }
        }

        private void a8_Click(object sender, EventArgs e)
        {
            ltr = new string(new char[] { });
            if (cnt == 0)
            {
                a8.Enabled = false;
                cnt = cnt + 1;
                a8.Text = "X";
                disX = false;
            }
            else if (!disX)
            {
                a8.Enabled = false;
                cnt = cnt + 1;
                a8.Text = "O";
                disX = true;
                ltr = "O";
                if (a5.Text == ltr && a2.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                   
                }
                if (a7.Text == ltr && a9.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                    
                }
            }
            else 
            {
                a8.Enabled = false;
                cnt = cnt + 1;
                a8.Text = "X";
                disX = false;
                ltr = "X";
                if (a5.Text == ltr && a2.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                    
                }
                if (a7.Text == ltr && a9.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                    
                }
            }
            if (cnt == 9)
            {
                msg("1");
                disable(false);
                
            }
        }

        private void a9_Click(object sender, EventArgs e)
        {
            ltr = new string(new char[] { });
            if (cnt == 0)
            {
                a9.Enabled = false;
                cnt = cnt + 1;
                a9.Text = "X";
                disX = false;
            }
            else if (!disX)
            {
                a9.Enabled = false;
                cnt = cnt + 1;
                a9.Text = "O";
                disX = true;
                ltr = "O";
                if (a1.Text == ltr && a5.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                    
                }
                if (a7.Text == ltr && a8.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                    
                }
                if (a6.Text == ltr && a3.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                   
                }
            }
            else 
            {
                a9.Enabled = false;
                cnt = cnt + 1;
                a9.Text = "X";
                disX = false;
                ltr = "X";
                if (a1.Text == ltr && a5.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                    
                }
                if (a7.Text == ltr && a8.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                    
                }
                if (a6.Text == ltr && a3.Text == ltr)
                {
                    msg(ltr);
                    disable(false);
                    
                }
            }
             if (cnt == 9)
            {
                msg("1");
                disable(false);
                
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            disable(true);
            cleartxt();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
