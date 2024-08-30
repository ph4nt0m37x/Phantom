﻿using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;



namespace Phantom
{
    internal class Keypad
    {
        Button[] buttons = new Button[12];

        Timer timer = new Timer();

        String answer;

        String input = "";

        Label screen = new Label();

        Label timerLabel = new Label();

        Timer timeLeft = new Timer();

        int seconds = new int();

        int counter = 0;

        public string[] buttonText = //text for the buttons
        {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "DEL",
            "0",
            ">"
        };

        public Point[] point = //points where buttons are spawned
        {
            new Point(89, 102),
            new Point(175, 102),
            new Point(261, 102),
            new Point(89, 188),
            new Point(175, 188),
            new Point(261, 188),
            new Point(89, 274),
            new Point(175, 274),
            new Point(261, 274),
            new Point(89, 360),
            new Point(175, 360),
            new Point(261, 360)
        };
        public Keypad(Timer t, String answer) //const (give it the right timer so it can stop the game until the minigame is done)
        {
            this.answer = answer;
            this.timer = t;
            seconds = 10;
            timeLeft.Interval = 1000;
            timeLeft.Tick += new EventHandler(timeLeft_Tick);

        }

        public Button spawnButton(string s, Point p) //func to spawn a single button with text s at point p
        {
            Button button = new Button();
            button.Text = s;

            button.Location = p;
            button.Show();
            button.Enabled = true;
            button.Size = new System.Drawing.Size(80, 80);
            button.BackColor = Color.Transparent;
            button.ForeColor = Color.White;
            button.FlatAppearance.BorderColor = Color.White;
            button.FlatAppearance.MouseOverBackColor = Color.GhostWhite;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 2;
            button.Click += new EventHandler(Button_Click);
            button.TabStop = true;
            button.Font = new Font("Unispace", 20);
            Phantom.ActiveForm.Controls.Add(button);
            return button;

        }
        public void spawnAllButtons() //func to spawn all buttons automagically
        {
            for (int i = 0; i < 12; i++)
            {
                buttons[i] = spawnButton(buttonText[i], point[i]);
                buttons[i].BringToFront();
            }
            screen.Enabled = true;
            screen.Font = new Font("Unispace", 25);
            screen.Size = new System.Drawing.Size(250, 50);
            screen.Location = new Point(90, 40);
            screen.BackColor = Color.Transparent;
            screen.ForeColor = Color.White;
            screen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            screen.BorderStyle = BorderStyle.FixedSingle;
            Phantom.ActiveForm.Controls.Add(screen);

            timerLabel.Enabled = true;
            timerLabel.Font = new Font("Unispace", 20);
            timerLabel.Size = new System.Drawing.Size(100, 50);
            timerLabel.Location = new Point(500, 40);
            timerLabel.BackColor = Color.Transparent;
            timerLabel.ForeColor = Color.White;
            timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            Phantom.ActiveForm.Controls.Add(timerLabel);
            timerLabel.Text = seconds.ToString();
            timeLeft.Start();
        }

        public void timeLeft_Tick(object sender, EventArgs e)
        {
            timerLabel.Text = seconds.ToString();
            seconds--;

            if (seconds == 0) {

                Transition.sceneCount = 10;
                Transition.FAIL = true;
                timeLeft.Stop();
                timer.Start();

            }

        }


        public void DeleteButtons()
        {
            foreach (Button b in buttons)
            {
                b.Dispose();
            }
            screen.Dispose();
            timerLabel.Dispose();
            timeLeft.Dispose();
        }

        private void Button_Click(object sender, EventArgs e) //event if button is clicked (works for all of the buttons)
        {
            Button button = sender as Button;
            if (button != null)
            {
                if (button.Text == "DEL" || button.Text == ">") //check if button pressed has special action
                {
                    if (button.Text == "DEL" && input.Length > 0) //if DEL pressed remove the most recent character
                    {
                        input = input.Remove(input.Length - 1);
                        screen.Text = input;
                    }
                    else
                    if (input.Length == 4)  //if > is pressed and the input field is full check if answer is correct
                    {
                        if (input == answer) //if correct stop minigame (gets rid of everything and starts the timer again)
                        {
                            timeLeft.Stop();
                            timer.Start();

                        }
                        else
                        {

                            if (counter < 2)
                            {
                                screen.Text = "";
                                input = "";

                          //     SystemSounds.Beep.Play();
                                counter++;

                            }
                            else
                            {
                                Transition.sceneCount = 10;
                                Transition.FAIL = true;
                                timeLeft.Stop();
                                timer.Start();
                            }
                        }

                    } // failure (not finished)

                }
                else // if not special input add input to input field 
                {
                    if (input.Length < 4)
                    {
                        input += button.Text;
                        screen.Text = input;
                    }
                }
            }
        }
    }
}

