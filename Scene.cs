using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Phantom
{
    public class Scene
    {
        public string[] CurrentDialog { get; set; }
        public int LineIndex { get; set; }
        public int TickIndex { get; set; }

        public int TransitionSceneProgress { get; set; }

        public int SceneNumber { get; set; }

        public System.Windows.Forms.Label CurrentLabel { get; set; }

        public Scene(string[] current, System.Windows.Forms.Label lbl)
        {
            CurrentDialog = current;
            CurrentLabel = lbl;
            TickIndex = 0;
            LineIndex = 0;
            TransitionSceneProgress = 0;
            SceneNumber = 0;


            // 6 dialogue scenes, 8 transitions, 1 cipher game, 1 encryption game, 1 decision scene 

            //  Timer.Interval = 3;

        }


        public void DisplayDialogue(string s, Timer t)
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
                t.Stop(); //stop the timer for the current string
            }
        }

        public void Fade()
        {

        }

        public void Decrypt(string updated, string old, Timer t)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(old); //we put the old string in the sb so we can change exact positions of the letters

            if (TickIndex < old.Length)
            {
                char c = updated.ToCharArray()[TickIndex];
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
