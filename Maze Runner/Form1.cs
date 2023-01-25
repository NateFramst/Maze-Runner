using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze_Runner
{
    public partial class Form1 : Form
    {
        //score
        Stopwatch scorecounter = new Stopwatch();
        int itemsCollected;
        long time = 1;
        long scoreCounter;

        double itemPostion;
        int defult = 0;

        string username;

        int Nate = 6540;

        int names;
        int SL;
        //temp
        int x;
        bool SUV = true;

        //movment 
        bool wDown;
        bool sDown;
        bool aDown;
        bool dDown;

        int pSpeed = 5;

        int mSpeed = 6;

        int mXs = 1;
        int mYs = 0;

        int stuck;

        int stuckX1;
        int stuckX2;
        int stuckY1;
        int stuckY2;


        // progress bar
        int timerSize;

        int n = 335;

        //pens
        Pen whitePenThick = new Pen(Color.White, 3);
        Pen whitePenThin = new Pen(Color.White, 1);
        Pen redPen = new Pen(Color.Red, 1);
        Pen yellowPen = new Pen(Color.Yellow, 1);

        //brushs
        Brush playerC = new SolidBrush(Color.Black);

        //player
        Rectangle player = new Rectangle(50, 50, 20, 20);

        //monster
        Rectangle monster = new Rectangle(420, 435, 20, 20);
        Rectangle monsterBrain = new Rectangle(430, 445, 1, 1);

        //item

        Rectangle item = new Rectangle(305, 105, 10, 10);



        //player sides

        //Rectangle pt = new Rectangle(50, 50, 20, 1);
        //Rectangle pb = new Rectangle(50, 70, 20, 1);
        //Rectangle pl = new Rectangle(50, 50, 1, 20);
        //Rectangle pr = new Rectangle(70, 50, 1, 21);


        //Inside
        Rectangle rect1 = new Rectangle(80, 80, 50, 70);
        Rectangle rect2 = new Rectangle(80, 180, 80, 70);
        Rectangle rect3 = new Rectangle(80, 280, 40, 150);
        Rectangle rect4 = new Rectangle(130, 80, 140, 30);
        Rectangle rect5 = new Rectangle(170, 150, 100, 100);
        Rectangle rect6 = new Rectangle(120, 380, 90, 50);
        Rectangle rect7 = new Rectangle(160, 280, 50, 60);
        Rectangle rect8 = new Rectangle(260, 280, 60, 60);
        Rectangle rect9 = new Rectangle(260, 380, 60, 50);
        Rectangle rect10 = new Rectangle(360, 280, 45, 60);
        Rectangle rect11 = new Rectangle(360, 380, 45, 50);
        Rectangle rect12 = new Rectangle(320, 180, 85, 70);
        Rectangle rect13 = new Rectangle(320, 80, 20, 60);
        Rectangle rect14 = new Rectangle(380, 80, 25, 60);

        //monster ai

        //row 1
        Rectangle RI1 = new Rectangle(60, 55, 5, 5);
        Rectangle RI2 = new Rectangle(295, 55, 5, 5);
        Rectangle RI3 = new Rectangle(360, 55, 5, 5);
        Rectangle RI4 = new Rectangle(427, 55, 5, 5);
        //row 2
        Rectangle RI5 = new Rectangle(60, 160, 5, 5);
        Rectangle RI6 = new Rectangle(148, 160, 5, 5);
        Rectangle RI7 = new Rectangle(148, 130, 5, 5);
        Rectangle RI8 = new Rectangle(295, 130, 5, 5);
        Rectangle RI9 = new Rectangle(295, 155, 5, 5);
        Rectangle RI10 = new Rectangle(360, 155, 5, 5);
        Rectangle RI11 = new Rectangle(427, 155, 5, 5);
        //row 3
        Rectangle RI12 = new Rectangle(60, 265, 5, 5);
        Rectangle RI13 = new Rectangle(138, 265, 5, 5);
        Rectangle RI14 = new Rectangle(234, 265, 5, 5);
        Rectangle RI15 = new Rectangle(295, 265, 5, 5);
        Rectangle RI16 = new Rectangle(340, 265, 5, 5);
        Rectangle RI17 = new Rectangle(427, 265, 5, 5);
        // row 4
        Rectangle RI18 = new Rectangle(138, 360, 5, 5);
        Rectangle RI19 = new Rectangle(234, 360, 5, 5);
        Rectangle RI20 = new Rectangle(340, 360, 5, 5);
        Rectangle RI21 = new Rectangle(427, 360, 5, 5);
        //row 5
        Rectangle RI22 = new Rectangle(60, 443, 5, 5);
        Rectangle RI23 = new Rectangle(234, 443, 5, 5);
        Rectangle RI24 = new Rectangle(340, 443, 5, 5);
        Rectangle RI25 = new Rectangle(427, 443, 5, 5);




        //list

        List<Rectangle> blocks = new List<Rectangle>();

        List<Rectangle> monsterR = new List<Rectangle>();

        List<long> ScoreCheck = new List<long>();

        List<string> usernames = new List<string>();



        public Form1()
        {
            InitializeComponent();
            blocks.Add(rect1);
            blocks.Add(rect2);
            blocks.Add(rect3);
            blocks.Add(rect4);
            blocks.Add(rect5);
            blocks.Add(rect6);
            blocks.Add(rect7);
            blocks.Add(rect8);
            blocks.Add(rect9);
            blocks.Add(rect10);
            blocks.Add(rect11);
            blocks.Add(rect12);
            blocks.Add(rect13);
            blocks.Add(rect14);

            monsterR.Add(RI1);
            monsterR.Add(RI2);
            monsterR.Add(RI3);
            monsterR.Add(RI4);
            monsterR.Add(RI5);
            monsterR.Add(RI6);
            monsterR.Add(RI7);
            monsterR.Add(RI8);
            monsterR.Add(RI9);
            monsterR.Add(RI10);
            monsterR.Add(RI11);
            monsterR.Add(RI12);
            monsterR.Add(RI13);
            monsterR.Add(RI14);
            monsterR.Add(RI15);
            monsterR.Add(RI16);
            monsterR.Add(RI17);
            monsterR.Add(RI18);
            monsterR.Add(RI19);
            monsterR.Add(RI20);
            monsterR.Add(RI21);
            monsterR.Add(RI22);
            monsterR.Add(RI23);
            monsterR.Add(RI24);
            monsterR.Add(RI25);

            for (int i = 0; i < 5; i++)
            {
                ScoreCheck.Add(default);
            }
            ScoreCheck.Add(Nate);




        }

        private void StartButton_MouseEnter(object sender, EventArgs e)
        {
            StartButton.ForeColor = Color.Green;
        }

        private void StartButton_MouseLeave(object sender, EventArgs e)
        {
            StartButton.ForeColor = Color.White;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            int i = 0;
            //start
            if (x == 0)
            {
                HighScores.Visible = false;
                HighScoreTitle.Text = "ENTER USERNAME";
                HighScores.Text = "";
                usernameInput.Visible = true;
                gameTick.Enabled = false;
            }
            if (x == 1)
            {
                M.Visible = false;
                A.Visible = false;
                Z.Visible = false;
                E.Visible = false;
                R.Visible = false;
                U.Visible = false;
                N.Visible = false;
                N2.Visible = false;
                E2.Visible = false;
                R2.Visible = false;
                Grass.Visible = false;
                usernameInput.Visible = false;
                HighScoreTitle.Visible = false;
                StartButton.Visible = false;
                gameTick.Enabled = true;
                score.Visible = true;
                ScoreTitle.Visible = true;
                timer.Visible = true;
                scorecounter.Start();
                this.Focus();

                username = usernameInput.Text;

                usernames.Add(username);

            }
            x++;
            i++;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            //draw maze
            if (x == 2)
            {
                //border
                e.Graphics.DrawLine(whitePenThick, 38, 39, 448, 39);
                e.Graphics.DrawLine(whitePenThick, 38, 38, 38, 463);
                e.Graphics.DrawLine(whitePenThick, 38, 461, 447, 461);
                e.Graphics.DrawLine(whitePenThick, 446, 463, 446, 38);
                //inside rct

                e.Graphics.DrawRectangle(whitePenThick, rect7);
                e.Graphics.DrawRectangle(whitePenThick, rect8);
                e.Graphics.DrawRectangle(whitePenThick, rect9);
                e.Graphics.DrawRectangle(whitePenThick, rect10);
                e.Graphics.DrawRectangle(whitePenThick, rect11);
                e.Graphics.DrawRectangle(whitePenThick, rect12);
                e.Graphics.DrawRectangle(whitePenThick, rect13);
                e.Graphics.DrawRectangle(whitePenThick, rect14);
                //inside lne

                //poly1
                e.Graphics.DrawLine(whitePenThick, 80, 80, 270, 80);
                e.Graphics.DrawLine(whitePenThick, 80, 79, 80, 150);
                e.Graphics.DrawLine(whitePenThick, 79, 150, 130, 150);
                e.Graphics.DrawLine(whitePenThick, 130, 152, 130, 110);
                e.Graphics.DrawLine(whitePenThick, 129, 110, 270, 110);
                e.Graphics.DrawLine(whitePenThick, 270, 112, 270, 79);


                //poly2
                e.Graphics.DrawLine(whitePenThick, 80, 180, 170, 180);
                e.Graphics.DrawLine(whitePenThick, 80, 180, 80, 250);
                e.Graphics.DrawLine(whitePenThick, 79, 250, 270, 250);
                e.Graphics.DrawLine(whitePenThick, 270, 252, 270, 149);
                e.Graphics.DrawLine(whitePenThick, 270, 150, 170, 150);
                e.Graphics.DrawLine(whitePenThick, 170, 149, 170, 182);


                //poly3
                e.Graphics.DrawLine(whitePenThick, 79, 280, 122, 280);
                e.Graphics.DrawLine(whitePenThick, 80, 280, 80, 432);
                e.Graphics.DrawLine(whitePenThick, 80, 430, 212, 430);
                e.Graphics.DrawLine(whitePenThick, 210, 430, 210, 379);
                e.Graphics.DrawLine(whitePenThick, 210, 380, 119, 380);
                e.Graphics.DrawLine(whitePenThick, 120, 380, 120, 280);

                //charaters
                e.Graphics.DrawRectangle(whitePenThin, player);

                e.Graphics.DrawRectangle(redPen, monster);

                //item

                e.Graphics.DrawRectangle(yellowPen, item);




                ////Test

                //e.Graphics.DrawRectangle(redPen, monsterBrain);


                //e.Graphics.DrawRectangle(redPen, RI1);
                //e.Graphics.DrawRectangle(redPen, RI2);
                //e.Graphics.DrawRectangle(redPen, RI3);
                //e.Graphics.DrawRectangle(redPen, RI4);
                //e.Graphics.DrawRectangle(redPen, RI5);
                //e.Graphics.DrawRectangle(redPen, RI6);
                //e.Graphics.DrawRectangle(redPen, RI7);
                //e.Graphics.DrawRectangle(redPen, RI8);
                //e.Graphics.DrawRectangle(redPen, RI9);
                //e.Graphics.DrawRectangle(redPen, RI10);
                //e.Graphics.DrawRectangle(redPen, RI11);
                //e.Graphics.DrawRectangle(redPen, RI12);
                //e.Graphics.DrawRectangle(redPen, RI13);
                //e.Graphics.DrawRectangle(redPen, RI14);
                //e.Graphics.DrawRectangle(redPen, RI15);
                //e.Graphics.DrawRectangle(redPen, RI16);
                //e.Graphics.DrawRectangle(redPen, RI17);
                //e.Graphics.DrawRectangle(redPen, RI18);
                //e.Graphics.DrawRectangle(redPen, RI19);
                //e.Graphics.DrawRectangle(redPen, RI20);
                //e.Graphics.DrawRectangle(redPen, RI21);
                //e.Graphics.DrawRectangle(redPen, RI22);
                //e.Graphics.DrawRectangle(redPen, RI23);
                //e.Graphics.DrawRectangle(redPen, RI24);
                //e.Graphics.DrawRectangle(redPen, RI25);









            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
            }
        }




        private void gameTick_Tick_1(object sender, EventArgs e)
        {

            //mouseX.Text = $"{Cursor.Position.X - 440}";
            //mmouseY.Text = $"{Cursor.Position.Y - 114}";

            //score
            time = (scorecounter.ElapsedMilliseconds) / 1000;
            scoreCounter = time / 5 + itemsCollected * 5;
            score.Text = $"{scoreCounter}";

            //spawning items

            if (player.IntersectsWith(item))
            {

                itemsCollected++;
                n = 335;
                Random itemLocation = new Random();

                itemPostion = itemLocation.Next(1, 7);

                if (itemPostion == 1)
                {
                    item.X = 305;
                    item.Y = 105;
                }
                else if (itemPostion == 2)
                {
                    item.X = 220;
                    item.Y = 125;
                }
                else if (itemPostion == 3)
                {
                    item.X = 54;
                    item.Y = 340;
                }
                else if (itemPostion == 4)
                {
                    item.X = 335;
                    item.Y = 400;
                }
                else if (itemPostion == 5)
                {
                    item.X = 420;
                    item.Y = 410;
                }
                else if (itemPostion == 6)
                {
                    item.X = 140;
                    item.Y = 50;
                }


            }










            if (wDown == true && player.Y >= 41)
            {
                //create temp variables with the x and y of the current location
                int y3 = player.Y;
                int x3 = player.X;

                player.Y -= pSpeed;


                for (int i = 0; i < blocks.Count(); i++)
                {
                    if (player.IntersectsWith(blocks[i]))
                    {
                        player.X = x3;
                        player.Y = y3;

                        break;
                    }
                }
            }


            if (sDown == true && player.Y <= 439)
            {
                int y3 = player.Y;
                int x3 = player.X;

                player.Y += pSpeed;


                for (int i = 0; i < blocks.Count(); i++)
                {
                    if (player.IntersectsWith(blocks[i]))
                    {
                        player.X = x3;
                        player.Y = y3;

                        break;
                    }
                }
            }
            if (aDown == true && player.X >= 41)
            {
                int y3 = player.Y;
                int x3 = player.X;

                player.X -= pSpeed;

                for (int i = 0; i < blocks.Count(); i++)
                {
                    if (player.IntersectsWith(blocks[i]))
                    {
                        player.X = x3;
                        player.Y = y3;

                        break;
                    }
                }
            }
            if (dDown == true && player.X <= 424)
            {
                int y3 = player.Y;
                int x3 = player.X;


                player.X += pSpeed;


                for (int i = 0; i < blocks.Count(); i++)
                {
                    if (player.IntersectsWith(blocks[i]))
                    {
                        player.X = x3;
                        player.Y = y3;

                        break;
                    }
                }
            }

            //monster
            int y = monster.Y;
            int x = monster.X;
            int y1 = monsterBrain.Y;
            int x1 = monsterBrain.X;

            monster.X -= mXs;
            monster.Y -= mYs;
            monsterBrain.X -= mXs;
            monsterBrain.Y -= mYs;

            for (int i = 0; i < monsterR.Count(); i++)
            {

                if (monsterBrain.IntersectsWith(monsterR[i]) && monsterBrain.Y - player.Y > 25)
                {

                    mXs = 0;
                    mYs = mSpeed;
                    stuckX1 = monsterBrain.X;
                    stuckY1 = monsterBrain.Y;

                }

                if (monsterBrain.IntersectsWith(monsterR[i]) && monsterBrain.X - player.X > 25)
                {
                    mXs = mSpeed;
                    mYs = 0;
                    stuckX1 = monsterBrain.X;
                    stuckY1 = monsterBrain.Y;
                }


                if (monsterBrain.IntersectsWith(monsterR[i]) && monsterBrain.Y - player.Y < -25)
                {
                    mXs = 0;
                    mYs = -mSpeed;
                    stuckX1 = monsterBrain.X;
                    stuckY1 = monsterBrain.Y;
                }

                if (monsterBrain.IntersectsWith(monsterR[i]) && monsterBrain.X - player.X < -25)
                {
                    mXs = -mSpeed;
                    mYs = 0;
                    stuckX1 = monsterBrain.X;
                    stuckY1 = monsterBrain.Y;

                }



            }
            for (int t = 0; t < blocks.Count(); t++)
            {
                if (monster.IntersectsWith(blocks[t]))
                {

                    monsterBrain.X = x1;
                    monsterBrain.Y = y1;
                    monster.X = x;
                    monster.Y = y;

                    mXs *= -1;
                    mYs *= -1;

                    stuck++;

                    stuckX2 = monsterBrain.X;
                    stuckY2 = monsterBrain.Y;


                    break;
                }
            }

            if (stuck > 2)
            {
                for (int t = 0; t < monsterR.Count(); t++)
                {
                    if (stuckY1 - stuckY2 != 0 && monsterBrain.IntersectsWith(monsterR[t]))
                    {
                        mYs = 0;

                        if (monsterBrain.X - player.X > 0)
                        {
                            mXs = mSpeed;
                            monster.X -= 10;
                            monsterBrain.X -= 10;
                        }
                        else if (monsterBrain.X - player.X < 0)
                        {
                            mXs = -mSpeed;
                            monster.X += 10;
                            monsterBrain.X += 10;

                        }
                        stuck = 0;
                    }

                    if (stuckX1 - stuckX2 != 0 && monsterBrain.IntersectsWith(monsterR[t]))
                    {
                        if (monsterBrain.X - player.X > 0)
                        {
                            mYs = mSpeed;
                            monster.Y -= 10;
                            monsterBrain.Y -= 10;
                        }
                        else if (monsterBrain.X - player.X < 0)
                        {
                            mYs = -mSpeed;
                            monster.Y += 10;
                            monsterBrain.Y += 10;
                        }
                        stuck = 0;
                        mXs = 0;

                    }


                }




            }








            if (monster.X <= 39)
            {
                mXs *= -1;
            }

            if (monster.X >= 441)
            {
                mXs *= -1;
            }

            if (monster.Y <= 38)
            {
                mYs *= -1;
            }

            if (monster.Y >= 437)
            {
                mYs *= -1;
            }

            if (monster.IntersectsWith(player))
            {
                gameStart();
            }


            //timer

            n = n - 1;
            timer.Size = new Size(n, 10);

            if (n == 0)
            {
                gameStart();
            }



            Refresh();
        }


        public void gameStart()
        {
            if (scoreCounter > ScoreCheck[4])
            {
                ScoreCheck.Add(scoreCounter);
            }

            monster.X = 420;
            monster.Y = 435;
            monsterBrain.X = 430;
            monsterBrain.Y = 445;
            player.X = 50;
            player.Y = 50;

            x = 0;
            M.Visible = true;
            A.Visible = true;
            Z.Visible = true;
            E.Visible = true;
            R.Visible = true;
            U.Visible = true;
            N.Visible = true;
            N2.Visible = true;
            E2.Visible = true;
            R2.Visible = true;
            Grass.Visible = true;
            HighScores.Visible = true;
            HighScoreTitle.Visible = true;
            StartButton.Visible = true;
            HS1.Visible = true;
            HS2.Visible = true;
            HS3.Visible = true;
            HS4.Visible = true;
            HS5.Visible = true;


            HighScoreTitle.Text = "HIGHSCORES";
            scorecounter.Reset();
            
            itemsCollected = 0;
            gameTick.Enabled = false;
            Refresh();

            ScoreCheck.Sort();
            ScoreCheck.Reverse();
            for (int i = 0; i < 5; i++)
            {
                if (scoreCounter == ScoreCheck[i]) 
                {
                    SL = i;
                }
            }

            //username.Reverse();

            //if (1 - SL == -3)
            //{
            //    HS5.Text = $"{username[0]}";
            //}
            //if (1 - SL == -2)
            //{
            //    HS4.Text = $"{username[0]}";
            //}
            //if (1 - SL == -1)
            //{
            //    HS3.Text = $"{username[0]}";

            //}
            //if (1 - SL == -0)
            //{
            //    HS2.Text = $"{username[0]}";
            //}



            ScoreCheck.RemoveAt(5);
            for (int i = 0; i < 5; i++)
            {
                string score = Convert.ToString(ScoreCheck[i]);

                HighScores.Text += $"\n{score}";
                HighScores.Text += "";
            }

            timer.Size = new Size(335, 10);
            timer.Visible = false;
            scoreCounter = 0;
        }
    }
}
