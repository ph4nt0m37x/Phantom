using System.Drawing;
using System.Windows.Forms;


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

        public Timer dialogTimer;

        public static bool FAIL;

        public int DialogCounter;

        Keypad keypad;

        public Encryption Encryption;

        public Choice Choice;


        public static bool END_GAME;


        public Image[] Images =
        {
            
            Properties.Resources.opening, //0
            Properties.Resources.preCipher, //1
            Properties.Resources.cipher, //2
            Properties.Resources.postCipher, //3
            Properties.Resources.serverRoom, //4
            Properties.Resources.encrypt, //5
            Properties.Resources.postEncryption //6
          
        };



        public Transition(Timer t1, Label label) {

            dialogTimer = t1; //setting the dialogue timer
            this.label = label; // setting the label in which letters shall be written
            sceneCount = 0; //what scene it is in order to change the background

            END_GAME = false;
            FAIL = false;
            hasDialog = false; //whether the scene has dialog and to implement it
            DialogCounter = 0; //which dialog it is in the array 
            TickCount = 0; //using the transition timer for the writing of the dialog
            isDone = false; //whether the transition is done
            currScene = new Scene(Dialogue.TransitionLines[0], label, t1);
            textWritten = false;


            keypad = new Keypad(dialogTimer, "0109");
            Encryption = new Encryption(dialogTimer);
            Choice = new Choice("Expose NeuroSync", "Side with Specter", dialogTimer);
        }

        public bool Fade(bool isDone)
        {
                this.isDone = isDone; 

                if (sceneCount == 0 ||sceneCount == 1)
                {
                    hasDialog = true;
                    currScene.CurrentDialog = Dialogue.TransitionLines[DialogCounter];
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
                    if (END_GAME)
                    {
                        Phantom.ActiveForm.Close();
                    }

                    else if (sceneCount < Images.Length)
                    {
                        


                        if (sceneCount == 2) //keypad minigame starts
                        {
                            keypad.spawnAllButtons();
                            
                        }

                        else if (sceneCount == 3)
                        {
                            keypad.DeleteButtons();
                            
                        }

                        else if (sceneCount == 5) // encryption minigame starts
                        {
                            Encryption.createGame();
                            
                        }
                        else if (sceneCount == 6) // choice scene appears
                        {
                            Encryption.DeleteAll();
                            //choice here

                            Choice.SpawnChoiceButtons();

                        }

                        Phantom.ActiveForm.BackgroundImage = Images[sceneCount];
                  
                     }
                    else
                    {
                        Phantom.ActiveForm.BackgroundImage = null;
                        keypad.DeleteButtons();
                        Encryption.DeleteAll();
                    }


                    label.Text = "";
            }

            else if (TickCount >= 20 && TickCount < 40) //timer for fade in
            {
                Phantom.ActiveForm.Opacity += 0.05;
            }

            if (TickCount == 40)
                {

                if(sceneCount == 2 || sceneCount == 5 || sceneCount == 6)
                    {
                        dialogTimer.Stop();
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
                label.Enabled = false;
                FadeToNext();
            }
            else
            {
                if (TickCount == 1)
                {
                    label.Enabled = true;
                }
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
                    dialogTimer.Start();

                }
                else if (TickCount == 300)
                {
                    textWritten = true;
                    TickCount = 0;
                    DialogCounter++;
                    currScene.TickIndex = 0;
                }
            }



        }
    }
}
