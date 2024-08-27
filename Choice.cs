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
    internal class Choice
    {
        Button optionA = new Button();
        Button optionB = new Button();
        String textA;
        String textB;
        public Choice(String textA, String textB) //const for the choice, textA and textB are the text displayed on the buttons
        {
            this.textA = textA;
            this.textB = textB;
        }
        public void SpawnChoiceButtons(String a, String b) //func to spawn both buttons
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
        }
        private void Button_Click(object sender, EventArgs e)//func for when buttons are placed (works for both)
        {
            Button button = sender as Button;
            if (button != null)
            {
                if (button.Text == optionA.Text)
                {
                    DeleteChoiceButtons(); //add func to go to correct scene
                }
                else if (button.Text == optionB.Text)
                {
                    DeleteChoiceButtons(); //add func to go to correct scene
                }
            }
        }
        public void DeleteChoiceButtons() //delete buttons 
        {
            optionA.Dispose();
            optionB.Dispose();
        }
    }
}
