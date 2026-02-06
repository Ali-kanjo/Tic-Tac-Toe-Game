using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game
{
    public partial class frmMainGame: Form
    {

        enCurrentPlayer currentPlayer;
        enWinner Winner;
        stGameResults GameResults = new stGameResults();
        
        enum enCurrentPlayer { 
            Player1,
            Player2
        }
        enum enWinner
        {
            Player1,
            Player2,
            InProgress
        }

        struct stGameResults
        {
           public enWinner Winner;
           public bool GameOver;
           public int PlayCount;
                
        }

        private List<PictureBox> winningsCells=new List<PictureBox>();
        public frmMainGame()
        {
            InitializeComponent();
        }
        private void ShowGameOver()
        {
            if (GameResults.GameOver)
                return;

            lblCurrentPlayer.Text = "Game Over";
            GameResults.GameOver = true;

            if (winningsCells.Count()>0)
            {
                if (winningsCells.First<PictureBox>().Tag.ToString().Equals("X"))
                {
                    lblWinner.Text = "Player 1";
                    GameResults.Winner = enWinner.Player1;
                }
                else
                {
                    lblWinner.Text = "Player 2";
                    GameResults.Winner = enWinner.Player2;
                }
                MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lblWinner.Text = "Draw";
                GameResults.Winner = enWinner.InProgress;
                MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
             
        }
        private void AddToWinningsCells(PictureBox pb1,PictureBox pb2,PictureBox pb3)
        {
            winningsCells.Add(pb1);
            winningsCells.Add(pb2);
            winningsCells.Add(pb3);
        }
        private void MakePicturesBoxOriginalState()
        {
            ChangeBackColor(pb1, pb2, pb3, Color.Transparent);
            ChangeBackColor(pb4, pb5, pb6, Color.Transparent);
            ChangeBackColor(pb7, pb8, pb9, Color.Transparent);
            PictureBox[] pictureBoxes = { pb1, pb2, pb3, pb4, pb5, pb6, pb7, pb8, pb9 };

            foreach (PictureBox p in pictureBoxes)
            {
                p.Image = Resources.question_mark_96;
                p.Tag = "?";
            }
        }
        private void RestartGame()
        {
            winningsCells.Clear();
            MakePicturesBoxOriginalState();

            GameResults.GameOver = false;
            GameResults.PlayCount = 0;
            GameResults.Winner = enWinner.InProgress;

            currentPlayer = enCurrentPlayer.Player1;

            lblWinner.Text = "In Progress";
            lblCurrentPlayer.Text = "Player 1";

        }
        private void ChangeBackColor(PictureBox pb1, PictureBox pb2, PictureBox pb3,Color color)
        {
            pb1.BackColor = color;
            pb2.BackColor = color;
            pb3.BackColor = color;
        }
        private void MakeChangesInImages(PictureBox pb1,PictureBox pb2,PictureBox pb3,Color color)
        {
            ChangeBackColor(pb1, pb2, pb3, color);
            AddToWinningsCells(pb1, pb2, pb3);

        }
        private bool IsTherePicturesEquals(PictureBox pb1, PictureBox pb2, PictureBox pb3)
        {
            return (!pb1.Tag.ToString().Equals("?") && pb1.Tag.ToString().Equals(pb2.Tag.ToString()) && pb2.Tag.ToString().Equals(pb3.Tag.ToString()));
        }
        private bool CheckIfWinner()
        {
            if (IsTherePicturesEquals(pb1, pb2, pb3))
            {
                MakeChangesInImages(pb1, pb2, pb3, Color.GreenYellow);
                ShowGameOver();
                return true;
            }
            else if (IsTherePicturesEquals(pb1, pb4, pb7))
            {
                MakeChangesInImages(pb1, pb4, pb7, Color.GreenYellow);
                ShowGameOver();
                return true;
            }
            else if (IsTherePicturesEquals(pb1, pb5, pb9))
            {
                MakeChangesInImages(pb1, pb5, pb9, Color.GreenYellow);
                ShowGameOver();
                return true;
            }
            else if (IsTherePicturesEquals(pb2, pb5, pb8))
            {
                MakeChangesInImages(pb2, pb5, pb8, Color.GreenYellow);
                ShowGameOver();
                return true;
            }
            else if (IsTherePicturesEquals(pb3, pb5, pb7))
            {
                MakeChangesInImages(pb3, pb5, pb7, Color.GreenYellow);
                ShowGameOver();
                return true;
            }
            else if (IsTherePicturesEquals(pb3, pb6, pb9))
            {
                MakeChangesInImages(pb3, pb6, pb9, Color.GreenYellow);
                ShowGameOver();
                return true;
            }
            else if (IsTherePicturesEquals(pb4, pb5, pb6))
            {
                MakeChangesInImages(pb4, pb5, pb6, Color.GreenYellow);
                ShowGameOver();
                return true;
            }
            else if (IsTherePicturesEquals(pb7, pb8, pb9))
            {
                MakeChangesInImages(pb7, pb8, pb9, Color.GreenYellow);
                ShowGameOver();
                return true;
            }
            else
            {
                return false;
            }
        }
        private void CheckPlayRolesAndGetResult(PictureBox sender)
        {
            switch (currentPlayer)
            {
                case enCurrentPlayer.Player1:
                    sender.Image = Resources.X;
                    sender.Tag = "X";
                    GameResults.PlayCount++;
                    currentPlayer = enCurrentPlayer.Player2;
                    lblCurrentPlayer.Text = "Player 2";
                    CheckIfWinner();
                    break;

                case enCurrentPlayer.Player2:
                    sender.Image = Resources.O;
                    sender.Tag = "O";
                    GameResults.PlayCount++;
                    currentPlayer = enCurrentPlayer.Player1;
                    lblCurrentPlayer.Text = "Player 1";
                    CheckIfWinner();
                    break;
            }

            if (GameResults.PlayCount == 9)
                ShowGameOver();
        }
        private void PreparingInitialSituation()
        {

            lblCurrentPlayer.Text = "Player 1";
            lblWinner.Text = "In Progress";

            currentPlayer = enCurrentPlayer.Player1;
            GameResults.GameOver = false;
            Winner = enWinner.InProgress;
            GameResults.PlayCount = 0;
        }
        private void CheckXO(PictureBox sender)
        {
            if (GameResults.GameOver)
            {
                MessageBox.Show("Game Over Click Restart to another Game ", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (sender.Tag.ToString().Equals("?"))
            {
                CheckPlayRolesAndGetResult(sender);
            } else
            {
                MessageBox.Show("This Button already Used", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmMainGame_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Transparent, 15);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            e.Graphics.DrawLine(pen, 540, 120, 540, 450);
            e.Graphics.DrawLine(pen, 685, 120, 685, 450);

            e.Graphics.DrawLine(pen, 415, 225, 805, 225);
            e.Graphics.DrawLine(pen, 415, 350, 805, 350);

        }
        private void frmMainGame_Load(object sender, EventArgs e)
        {
            PreparingInitialSituation();
            
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
        private void PictureBoxesClick_MouseDown(object sender, MouseEventArgs e)
        {
            CheckXO((PictureBox)sender);
        }
        private void AllPictureBoxes_MouseEnter(object sender, EventArgs e)
        {
            PictureBox CurrentBox = (PictureBox)sender;
            if (GameResults.GameOver && winningsCells.Contains(CurrentBox))
            {
                CurrentBox.BackColor = Color.White;
            }
        }
        private void AllPictureBoxes_MouseLeave(object sender, EventArgs e)
        {
            PictureBox CurrentBox = (PictureBox)sender;
            if (GameResults.GameOver && winningsCells.Contains(CurrentBox))
            {
                CurrentBox.BackColor = Color.GreenYellow;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
