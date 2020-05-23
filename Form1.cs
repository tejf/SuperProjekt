using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt1
{
    public partial class Form1 : Form
    {
        bool turn = true;  // true = tura X,   false = tura Y
        int turn_count = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Bartosz Rajzer", "About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Click a button to put your mark on it. \n2. First to put 3 in a row wins.", "Instructions");
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;

            turn_count++;

            if (Equations.chechForWinner(new Equations.button(A1.Text, A1.Enabled), new Equations.button(A2.Text, A2.Enabled), new Equations.button(A3.Text, A3.Enabled), new Equations.button(B1.Text, B1.Enabled), new Equations.button(B2.Text, B2.Enabled), new Equations.button(B3.Text, B3.Enabled), new Equations.button(C1.Text, C1.Enabled), new Equations.button(C2.Text, C2.Enabled), new Equations.button(C3.Text, C3.Enabled)))
            {
                disableButtons();
                String winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";
                 MessageBox.Show("The winner is " + winner + "!", "Congratulations!");
            }
            else
            {
                if (turn_count == 9)
                    MessageBox.Show("Draw!\nTry again! ;)", "Unlucky!");
            }
        }

       

        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }
            catch { }

        }



     
    }

    
}
