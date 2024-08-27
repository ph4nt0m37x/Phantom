using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Phantom
{
    internal class Keypad
    {
        Button[] buttons = new Button[12];
        Timer  timer = new Timer();
        String answer;
        String input = "";
        Label screen = new Label();
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
            new Point(39, 42),
            new Point(125, 42),
            new Point(211, 42),
            new Point(39, 128),
            new Point(125, 128),
            new Point(211, 128),
            new Point(39, 214),
            new Point(125, 214),
            new Point(211, 214),
            new Point(39, 300),
            new Point(125, 300),
            new Point(211, 300)
        };
        public Keypad(Timer t, String answer) //const (give it the right timer so it can stop the game until the minigame is done)
        {
            this.answer = answer;
            this.timer = t;

        }

        public Button spawnButton(string s, Point p) //func to spawn a single button with text s at point p
        {
            Button button = new Button();
            button.Text = s;

            button.Location = p;
            button.Show();
            button.Enabled = true;
            button.Size = new System.Drawing.Size(80, 80);
            button.BackColor = Color.LightSlateGray;
            button.ForeColor = Color.White;
            button.FlatAppearance.BorderColor = Color.LightSteelBlue;
            button.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 2;
            button.Click += new EventHandler(Button_Click);

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
            screen.Location = new Point(567, 46);
            screen.BackColor = Color.LightSteelBlue;
            Phantom.ActiveForm.Controls.Add(screen);
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
                            foreach (Button b in buttons)
                            {
                                b.Dispose();
                            }
                            screen.Dispose();
                            timer.Start();
                        }
                        else { screen.Text = ""; input = ""; } // failure (not finished)

                    }

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
