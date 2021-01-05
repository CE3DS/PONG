using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;


namespace Pong
{
    public partial class Pong : Form
    {
        Random random = new Random();

        private bool hitUpBorder = false;
        private bool hitDownBorder = false;
        private bool running = false;

        private bool moveUp = false;
        private bool moveDown = false;

        private bool goingLeft;
        private bool goingUp;

        private int playerScore = 0;
        private int NPCScore = 0;

        private int targetSpeedX = 10;
        private int targetSpeedY = 1;

        public Pong()
        {
            InitializeComponent();
        }

        private void Running()
        {
            if (running == true)
            {
                tmBackgroundColor.Stop();
                tmHUDColor.Stop();
                lblResetScore.Visible = false;
                lblStart.Visible = false;
                tmTarget.Enabled = true;
                tmNPC.Enabled = true;
                goingLeft = false;
                goingUp = false;
            }
            else
            {
                if ((playerScore > 0) || (NPCScore > 0))
                {
                    lblResetScore.Visible = true;
                }
                tmMovement.Stop();
                tmNPC.Stop();
                tmTarget.Stop();

                PlayerBox.Location = new Point(100, 200);
                NPCBox.Location = new Point(700, 200);
                Target.Location = new Point(390, 240);

                lblStart.Visible = true;
            }
        }

        private bool GetDirection(int targetY, int boxY)
        {
            bool boolean = true;
            if (targetY + 9 < boxY + 49)
                boolean = true;
            else boolean = false;

            int x = random.Next(0, 5);
            if (x > 3)
            {
                if (boolean == true) boolean = false;
                else boolean = true;
            }
            return boolean;
        }

        private void ChangeAngle(int targetY, int boxY)
        {
            if ((targetY + 9 > boxY + 24) && (targetY + 9 < boxY + 74))
                targetSpeedY = 1;
            else targetSpeedY = 3;

        }

        private void refreshScore()
        {
            lbNPCScore.Text = NPCScore.ToString("00");
            lbPlayerScore.Text = playerScore.ToString("00");
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clrBackground.ShowDialog();
            tmBackgroundColor.Start();
        }

        private void HUDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clrHUD.ShowDialog();
            tmHUDColor.Start();
        }

        private void tmBackgroundColor_Tick(object sender, EventArgs e)
        {
            this.BackColor = clrBackground.Color;
        }

        private void tmHUDColor_Tick(object sender, EventArgs e)
        {
            lbNPCScore.ForeColor = clrHUD.Color;
            lbPlayerScore.ForeColor = clrHUD.Color;
            lblStart.ForeColor = clrHUD.Color;
            lblResetScore.ForeColor = clrHUD.Color;
            Target.BackColor = clrHUD.Color;
            NPCBox.BackColor = clrHUD.Color;
            PlayerBox.BackColor = clrHUD.Color;
        }

        
        // Target -------------------------------------------------------------------
        private void tmTarget_Tick(object sender, EventArgs e)
        {
            if (goingLeft == true && goingUp == true)
            {
                Target.Location = new Point(Target.Location.X - targetSpeedX, Target.Location.Y - targetSpeedY);
                return;
            }
            if (goingLeft == true && goingUp == false)
            {
                Target.Location = new Point(Target.Location.X - targetSpeedX, Target.Location.Y + targetSpeedY);
                return;
            }
            if (goingLeft == false && goingUp == true)
            {
                Target.Location = new Point(Target.Location.X + targetSpeedX, Target.Location.Y - targetSpeedY);
                return;
            }
            if (goingLeft == false && goingUp == false)
            {
                Target.Location = new Point(Target.Location.X + targetSpeedX, Target.Location.Y + targetSpeedY);
                return;
            }
        }

        private void Target_LocationChanged(object sender, EventArgs e)
        {
            // Bater em cima
            if (Target.Location.Y <= 50)
            {
                goingUp = false;
            }
            // Bater em baixo
            else if (Target.Location.Y >= 430)
            {
                goingUp = true;
            }

            // Bater no player
            if ((Target.Location.X <= PlayerBox.Location.X + 18)
                && (Target.Location.X >= PlayerBox.Location.X + 10)
                && (Target.Location.Y > PlayerBox.Location.Y - 17)
                && (Target.Location.Y < PlayerBox.Location.Y + 99))
            {
                ChangeAngle(Target.Location.Y, PlayerBox.Location.Y);
                goingLeft = false;
                goingUp = GetDirection(Target.Location.Y, PlayerBox.Location.Y);
            }

            // Bater no oponente
            else if ((Target.Location.X >= NPCBox.Location.X - 18)
                && (Target.Location.X <= NPCBox.Location.X - 10)
                && (Target.Location.Y > NPCBox.Location.Y - 17)
                && (Target.Location.Y < NPCBox.Location.Y + 99))
            {
                ChangeAngle(Target.Location.Y, NPCBox.Location.Y);
                goingLeft = true;
                goingUp = GetDirection(Target.Location.Y, NPCBox.Location.Y);
            }

            // Ponto NPC
            else if (Target.Location.X <= 20)
            {
                running = false;
                NPCScore++;
                refreshScore();
                Running();
            }

            // Ponto Player
            else if (Target.Location.X >= 760)
            {
                running = false;
                playerScore++;
                refreshScore();
                Running();
            }
        }


        // Player ---------------------------------------------------
        private void PlayerBox_LocationChanged(object sender, EventArgs e)
        {
            if (PlayerBox.Location.Y <= 50)
                hitUpBorder = true;
            else hitUpBorder = false;

            if (PlayerBox.Location.Y >= 350)
                hitDownBorder = true;
            else hitDownBorder = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.R:
                    if (running == false)
                    {
                        playerScore = 0;
                        NPCScore = 0;
                        lblResetScore.Visible = false;
                        refreshScore();
                    }
                    break;

                case Keys.Up:
                    if (running == false)
                    {
                        running = true;
                        Running();
                    }
                    moveUp = true;
                    break;

                case Keys.Down:
                    if (running == false)
                    {
                        running = true;
                        Running();
                    }
                    moveDown = true;
                    break;

                case Keys.Escape:
                    this.Close();
                    break;
            }

            Move();
            tmMovement.Start();
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    moveUp = false;
                    break;

                case Keys.Down:
                    moveDown = false;
                    break;
            }

            if (!(moveUp || moveDown))
            {
                tmMovement.Stop();
            }
        }

        private void MoveUp()
        {
            if (hitUpBorder == false && moveUp == true)
            {
                PlayerBox.Location = new Point(PlayerBox.Location.X, PlayerBox.Location.Y - 5);
            }
        }
        private void MoveDown()
        {
            if (hitDownBorder == false && moveDown == true)
            {
                PlayerBox.Location = new Point(PlayerBox.Location.X, PlayerBox.Location.Y + 5);
            }
        }

        private void movementTimer_Tick(object sender, EventArgs e)
        {
            Move();
        }
        private new void Move()
        {
            if (moveUp == true) MoveUp();
            else if (moveDown == true) MoveDown();
        }



        // NPC
        private void tmNPC_Tick(object sender, EventArgs e)
        {
            if ((Target.Location.Y + 9 > NPCBox.Location.Y + 49) && (NPCBox.Location.Y < 350))
            {
                NPCBox.Location = new Point(NPCBox.Location.X, NPCBox.Location.Y + 3);
            }
            else if ((Target.Location.Y + 9 < NPCBox.Location.Y + 49) && (NPCBox.Location.Y > 50))
            {
                NPCBox.Location = new Point(NPCBox.Location.X, NPCBox.Location.Y - 3);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
