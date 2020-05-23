using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1
{
    public class Equations
    {
     public static bool chechForWinner(button A1, button A2, button A3, button B1, button B2, button B3, button C1, button C2, button C3)
    {
        bool there_is_a_winner = false;
        if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.pressed))
            there_is_a_winner = true;
        else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.pressed))
            there_is_a_winner = true;
        else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.pressed))
            there_is_a_winner = true;

        if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.pressed))
            there_is_a_winner = true;
        else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.pressed))
            there_is_a_winner = true;
        else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.pressed))
            there_is_a_winner = true;

        if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.pressed))
            there_is_a_winner = true;
        else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.pressed))
            there_is_a_winner = true;

            return there_is_a_winner;
       
    }

        public struct button
        {
            public button(string Text, bool pressed)
            {
                this.Text = Text;
                this.pressed = pressed;
            }
            public string Text;
            public bool pressed;
        }
    }
}
