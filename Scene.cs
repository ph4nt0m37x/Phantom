using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using static System.TimeZoneInfo;


namespace Phantom
{
    public class Scene
    {
        public string[] CurrentDialog { get; set; }
        public int LineIndex { get; set; }
        public int TickIndex { get; set; }

        public int DialogCounter { get; set; }

        public int SceneNumber { get; set; }

        public Label CurrentLabel { get; set; }

        public Timer T { get; set; }
        public Scene(string[] current, Label lbl, Timer t)
        {
            CurrentDialog = current;
            CurrentLabel = lbl;
            DialogCounter = 0;
            TickIndex = 0;
            LineIndex = 0;
            T = t;
            SceneNumber = 0;

        }

        public void DisplayLine(string s)
        {
            CurrentLabel.Show();

            if (TickIndex < s.Length) //if theres a next character in the string, add to label
            {
                char c = s.ToCharArray()[TickIndex++];
                CurrentLabel.Text += c;
            }
            else // if done writing
            {
                TickIndex = 0; //reset character position for next string
                LineIndex++; //go to next line in the script
                T.Stop(); //stop the timer for the current string
            }
        }

        public bool DisplayDialog(string s)
        {
            CurrentDialog = Dialogue.Dialogues[DialogCounter];

            if (LineIndex < CurrentDialog.Length) //check if theres still lines in the current dialogue scene
            {
                if (!T.Enabled) //if the dialogue timer is done , start it again for the next line
                {
                    CurrentLabel.Text = "";
                    T.Start();
                }
                else //if timer still going and form is clicked, immediately write dialogue
                {
                    T.Stop();
                    CurrentLabel.Text = CurrentDialog[LineIndex];
                    LineIndex++; //go next line after finishing
                    TickIndex = 0; // reset character position for next string
                }
                return false;
            }
            else //when dialog scene is finished - reset dialog box (we reuse it a lot, best not to delete)
            {
                CurrentLabel.Text = "";
                TickIndex = 0;
                LineIndex = 0;
                DialogCounter++;
                return true;
            }
        }


        public void Decrypt(string decrypted, string encrypted, Timer t)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(encrypted); //we put the old string in the sb so we can change exact positions of the letters

            if (TickIndex < encrypted.Length)
            {
                char c = decrypted.ToCharArray()[TickIndex];
                sb[TickIndex] = c;

                CurrentLabel.Text = sb.ToString(); //replace the letter in the old string with the one in the new

            }
            else // when done
            {
                TickIndex = 0; //reset letter positioning
                LineIndex++; // go next line if it exists
                t.Stop(); // stop timer cause string is done
            }
        }
    }
}
