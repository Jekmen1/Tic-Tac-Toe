using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class tictactoe : Form
    {   

        bool IsWinner = false;
        bool turn = false;
        int TurnCounter = 0;



        public tictactoe()
        {
            InitializeComponent();
        }

        private void tictactoe_Load(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
                  
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This game is made by jeko");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (turn)         
                button.Text = "X";         
            else
                button.Text = "O";

            TurnCounter++;

            turn = !turn;
            
            button.Enabled = false;
            ChekWinner();
            
        }

        private void ChekWinner()
        {
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (A1.Enabled))
                IsWinner = true;
            
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (B1.Enabled))
                IsWinner = true;

            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (C1.Enabled))
                IsWinner = true;

            
            // vertikaluri
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (A1.Enabled))
                IsWinner = true;

            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (A2.Enabled))
                IsWinner = true;

            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (A3.Enabled))
                IsWinner = true;

            // diagonali
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (A1.Enabled))
                IsWinner = true;

            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (C1.Enabled))
                IsWinner = true;

            if (IsWinner)
            {
                string winner = "";
                if (turn)
                    winner = "O";
                else winner = "X";

                MessageBox.Show($"Winner is {winner}");
                DisableButton();
            }

            // Draw
            if (TurnCounter == 9 && IsWinner == false)
                MessageBox.Show("Draw");

        }

        private void DisableButton()
        {
            foreach(Control control in Controls)
            {
                control.Enabled = false;
            }
        }
    }
}
