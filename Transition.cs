using Phantom.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.TimeZoneInfo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Phantom
{
    public class Transition
    {
        public static int sceneCount = 0; //setting the scene for which we need the next wallpaper

        public int TickCount;

        public Label label;

        public Scene currScene;

        public bool hasDialog;

        public bool isDone;

        public bool textWritten;

        public Timer timer;

        public int DialogCounter;

        public Image[] Images =
        {
            
            Properties.Resources.opening,
            Properties.Resources.preCipher,
            //put cipher photo
            Properties.Resources.postCipher,
            Properties.Resources.serverRoom,
            Properties.Resources.encryptionGame,
            Properties.Resources.postEncryption
          
        };



        public Transition(Timer t, Label label) {

            timer = t; //setting the dialogue timer
            this.label = label; // setting the label in which letters shall be written
            sceneCount = 0; //what scene it is in order to change the background

            hasDialog = false; //whether the scene has dialog and to implement it
            DialogCounter = 0; //which dialog it is in the array 
            TickCount = 0; //using the transition timer for the writing of the dialog
            isDone = false; //whether the transition is done
            currScene = new Scene(Dialogue.TransitionLines[0], label, t);
            textWritten = false;
            
        }

        public bool Fade(bool isDone)
        {
            this.isDone = isDone;

            if (sceneCount == 1)
            {   
                hasDialog = true;
                currScene.CurrentDialog = Dialogue.TransitionLines[sceneCount];
            }
            else
            {
                hasDialog = false;
            }


            if (!isDone)
            {
                if(hasDialog)
                {
                    DisplayText();
                }
                else
                {
                    FadeToNext();
                }
              
            }

            return this.isDone;
        }

        public void FadeToNext()
        {
            if (!isDone)
            {
                if (TickCount < 20) //timer for fade out
            {
                Phantom.ActiveForm.Opacity -= 0.05;
            }

            else if (TickCount == 20) // change background image
            {
                Phantom.ActiveForm.BackgroundImage = Images[sceneCount];
                label.Text = "";
            }

            else if (TickCount >= 20 && TickCount < 40) //timer for fade in
            {
                Phantom.ActiveForm.Opacity += 0.05;
            }

            if (TickCount == 40)
                {
                TickCount = 0;
                isDone = true;
                textWritten = false;
                sceneCount++;
                }
            }
            
        }


        public void DisplayText()
        {
            if (textWritten)
            {
                FadeToNext();
            }
            else
            {
                if (TickCount < 20) //timer for fade out
                {
                    Phantom.ActiveForm.Opacity -= 0.05;
                }
                else if (TickCount == 20) //when the form is invisible, set wallpaper to black
                {
                    label.Hide();
                    Phantom.ActiveForm.BackgroundImage = null;
                }
                else if (TickCount >= 20 && TickCount < 40) //timer for fade in
                {
                    Phantom.ActiveForm.Opacity += 0.05;
                }
                else if (TickCount >= 40 && TickCount < currScene.CurrentDialog[0].Length + 40)
                {
                    label.Show();
                    currScene.DisplayLine(currScene.CurrentDialog[0]);
                    timer.Start();

                }
                else if (TickCount == 300)
                {
                    textWritten = true;
                    TickCount = 0;
                    DialogCounter++;
                    currScene.CurrentDialog = Dialogue.TransitionLines[DialogCounter];
                }
            }
            

        }


    }
}
