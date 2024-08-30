﻿using System;
using System.Drawing;
using System.Windows.Forms;



namespace Phantom
{
    public class Choice
    {
        Button optionA = new Button();
        Button optionB = new Button();
        String textA;
        String textB;

        Timer t;

        public static bool expose;


        public Choice(String textA, String textB, Timer t) //const for the choice, textA and textB are the text displayed on the buttons
        {
            this.textA = textA;
            this.textB = textB;
            expose = true; // 
            this.t = t;
        }
        public void SpawnChoiceButtons() //func to spawn both buttons
        {
            
            optionA.Location = new Point(50, 355);
            optionA.Size = new Size(338, 68);
            optionA.ForeColor = Color.White;
            optionA.Font = new Font("Unispace", 20);
            optionA.Text = textA;
            optionA.Click += new EventHandler(Button_Click);
            Phantom.ActiveForm.Controls.Add(optionA);
            optionB.Location = new Point(480, 355);
            optionB.Size = new Size(338, 68);
            optionB.ForeColor = Color.White;
            optionB.Font = new Font("Unispace", 20);
            optionB.Text = textB;
            optionB.Click += new EventHandler(Button_Click);
            Phantom.ActiveForm.Controls.Add(optionB);
            optionA.BringToFront();
            optionB.BringToFront();

        }
        private void Button_Click(object sender, EventArgs e)//func for when buttons are placed (works for both)
        {
            Button button = sender as Button;
            if (button != null)
            {
                if (button.Text == optionA.Text)
                {
                    expose = true;
                    DeleteChoiceButtons(); //add func to go to correct scene
                }
                else if (button.Text == optionB.Text)
                {
                    expose = false;
                    DeleteChoiceButtons(); //add func to go to correct scene
                }

                t.Start();
            }
        }
        public void DeleteChoiceButtons() //delete buttons 
        {
            optionA.Dispose();
            optionB.Dispose();
        }
    }
}
