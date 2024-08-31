using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;


namespace Phantom
{
    public class Transition
    {
        public static int sceneCount = 0; //setting the scene for which we need the next wallpaper

        public int TickCount;

        public Label Label;

        public Scene CurrentScene;

        public bool hasDialog;

        public bool isDone;

        public bool textWritten;

        public Timer DialogTimer;

        public static bool FAIL;

        public int DialogCounter;

        public Keypad Keypad;

        public Encryption Encryption;

        public static bool END_GAME;


        public Image[] Images =
        {
            
            Properties.Resources.opening, //0
            Properties.Resources.preCipher, //1
            Properties.Resources.cipher, //2
            Properties.Resources.postCipher, //3
            Properties.Resources.serverRoom, //4
            Properties.Resources.encrypt, //5
            Properties.Resources.postEncryption, //6
            Properties.Resources.failApoc
        };



        public Transition(Timer t1, Label label) {

            DialogTimer = t1; //setting the dialogue timer
            this.Label = label; // setting the label in which letters shall be written
            sceneCount = 0; //what scene it is in order to change the background

            END_GAME = false;
            FAIL = false;
            hasDialog = false; //whether the scene has dialog and to implement it
            DialogCounter = 0; //which dialog it is in the array 
            TickCount = 0; //using the transition timer for the writing of the dialog
            isDone = false; //whether the transition is done
            CurrentScene = new Scene(Dialogue.TransitionLines[0], label, t1);
            textWritten = false;


            Keypad = new Keypad(DialogTimer, "0109");
            Encryption = new Encryption(DialogTimer);
        }

        public bool Fade(bool isDone)
        {

                this.isDone = isDone; 

                if (sceneCount == 0 ||sceneCount == 1 || FAIL && sceneCount > 8 && DialogCounter != 3 || !FAIL && sceneCount == 7 && DialogCounter != 3)
                {
                    hasDialog = true;
                    CurrentScene.CurrentDialog = Dialogue.TransitionLines[DialogCounter];
                }
                else
                {
                    hasDialog = false;
                }
             

                if (!isDone) //if the transition isnt done, meaning its new, check whether it has a dialog or just fade it
                {
                    if (hasDialog)
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
                    if (END_GAME && textWritten)
                    {
                        Phantom.ActiveForm.Close();
                    }

                    else if (sceneCount < Images.Length-1)
                    {
                        if (sceneCount == 2) //keypad minigame starts
                        {
                            Keypad.SpawnAllButtons();                          
                        }

                        if (sceneCount > 2)
                        {
                            Keypad.DeleteButtons();
                        }

                        if (sceneCount == 5) // encryption minigame starts
                        {
                            Encryption.CreateGame();
                            
                        }
                        if (sceneCount > 5) // choice scene appears
                        {
                            Encryption.DeleteLabel();

                        }

                        Phantom.ActiveForm.BackgroundImage = Images[sceneCount];
                  
                     }

                    else
                    {
                        if (FAIL && sceneCount == 8)
                        {
                            Phantom.ActiveForm.BackgroundImage = Images[7];
                        }
                        else
                        {
                            Phantom.ActiveForm.BackgroundImage = null;
                        }


                    }


                    Label.Text = "";
            }

            else if (TickCount >= 20 && TickCount < 40) //timer for fade in
            {
                Phantom.ActiveForm.Opacity += 0.05;
            }

            if (TickCount == 40)
                {

                if(sceneCount == 2 || sceneCount == 5) //stops the timer for the minigame to take place
                    {
                        DialogTimer.Stop();
                    }

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
                Label.Enabled = false;
                FadeToNext();
            }
            else
            {
                if (TickCount == 1)
                {
                    Label.Enabled = true;
                }
                if (TickCount < 20) //timer for fade out
                {
                    Phantom.ActiveForm.Opacity -= 0.05;
                }
                else if (TickCount == 20) //when the form is invisible, set wallpaper to black
                {
                    Label.Hide();
                    Phantom.ActiveForm.BackgroundImage = null;
                }
                else if (TickCount >= 20 && TickCount < 40) //timer for fade in
                {
                    Phantom.ActiveForm.Opacity += 0.05;
                }
                else if (TickCount >= 40 && TickCount < CurrentScene.CurrentDialog[0].Length + 40)
                {
                    Label.Show();
                    CurrentScene.DisplayLine(CurrentScene.CurrentDialog[0]);
                    DialogTimer.Start();

                }
                else if (TickCount == 300)
                {
                    textWritten = true;
                    TickCount = 0;
                    DialogCounter++;
                    CurrentScene.TickIndex = 0;
                }
            }



        }
    }
}
