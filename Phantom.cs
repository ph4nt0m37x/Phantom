using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.TimeZoneInfo;


namespace Phantom
{
    public partial class Phantom : Form
    {

        public int ValidClick;
        public Scene MainScene;
        public Scene Credits;
        public Scene Transition;
        public Phantom()
        {
            InitializeComponent();
            DoubleBuffered = true;

            ValidClick = 0; // whether the form/label click should do anything

            MainScene = new Scene(Dialogue.Dialogues[0], lblMenu);
            Credits = new Scene(Dialogue.Credits, lblDialog);
            Transition = new Scene(Dialogue.TransitionLines[0], lblCenter);

            menuTimer.Start();

        }

        private void menuTimer_Tick(object sender, EventArgs e)
        {

            MainScene.DisplayDialogue(MainScene.CurrentDialog[0], menuTimer);

        }


        private void dialogueTimer_Tick(object sender, EventArgs e)
        {
            if (ValidClick == 1) //if the click is valid
            {
                MainScene.DisplayDialogue(MainScene.CurrentDialog[MainScene.LineIndex], dialogueTimer);
            }
            else if (ValidClick == 3) //credits gets a special call in order to work at the same time as main dialog
            {
                Credits.DisplayDialogue(Credits.CurrentDialog[Credits.LineIndex], dialogueTimer);
            }
        }

        private void ButtonStart_MouseClick(object sender, MouseEventArgs e)
        {
            ButtonStart.Dispose(); //removing the Buttons
            ButtonCredits.Dispose();
            ButtonOptions.Dispose();

            ValidClick = 1;  //validating mouse clicks on the form

            lblMenu.Hide();
            lblDialog.Hide();

            MainScene.CurrentDialog = Dialogue.Dialogues[MainScene.SceneNumber];
            MainScene.LineIndex = 0;

            transitionTimer.Start();

           // dialogueTimer.Start(); // starting the dialogue scene
        }


        //Transition Scenes
        private void sceneTimer_Tick(object sender, EventArgs e)
        {
            Transition.TickIndex++; //count the ticks for transition scene

            if (Transition.TickIndex < 20) //timer for fade out
            {
                Phantom.ActiveForm.Opacity -= 0.05;
            }

            else if (Transition.TickIndex == 20) //when the transition scene comes, set wallpaper to black            
            {
                lblCenter.Hide();
                this.BackgroundImage = null;
            }
            else if (Transition.TransitionSceneProgress == 1)//after the transition, swap back to the next scene's image image
            {
                this.BackgroundImage = Properties.Resources.mainMenuGrid;
                Transition.TransitionSceneProgress = 2;
            }
            else if (Transition.TickIndex < 40 && Transition.TickIndex >= 20) //timer for fade in
            {
                Phantom.ActiveForm.Opacity += 0.05;
            }
            else if (Transition.TickIndex == 40 && MainScene.TransitionSceneProgress == 2) //scene has ended, transition to next scene
            {
                transitionTimer.Stop();
                this.Close();
            }
            else if (Transition.TickIndex == 40) //
            {
                // sceneTimer.Stop();
                MainScene.LineIndex = 0;
                ValidClick = 2;
                MainScene.LineIndex = 0;
                lblCenter.Show();
                dialogueTimer.Start();
            }
            else if (Transition.TickIndex == 300)
            {
                MainScene.TransitionSceneProgress = 1;
                Transition.TickIndex = 0;
            }
        }

        //Menu Screen

        private void ButtonStart_MouseEnter(object sender, EventArgs e)
        {
            ButtonStart.ForeColor = Color.LightSeaGreen;
        }

        private void ButtonStart_MouseLeave(object sender, EventArgs e)
        {
            ButtonStart.ForeColor = Color.White;
        }

        private void ButtonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ButtonQuit_MouseLeave(object sender, EventArgs e)
        {
            ButtonQuit.ForeColor = Color.White;
        }

        private void ButtonQuit_MouseEnter(object sender, EventArgs e)
        {
            ButtonQuit.ForeColor = Color.LightSeaGreen;
        }


        private void ButtonOptions_MouseEnter(object sender, EventArgs e)
        {
            ButtonOptions.ForeColor = Color.LightSeaGreen;
        }

        private void ButtonOptions_MouseLeave(object sender, EventArgs e)
        {
            ButtonOptions.ForeColor = Color.White;
        }

        private void ButtonCredits_MouseEnter(object sender, EventArgs e)
        {
            ButtonCredits.ForeColor = Color.LightSeaGreen;
        }

        private void ButtonCredits_MouseLeave(object sender, EventArgs e)
        {
            ButtonCredits.ForeColor = Color.White;
        }

        private void ButtonCredits_Click(object sender, EventArgs e)
        {

            if (ValidClick == 3)
            {
                ValidClick = 0;
                lblDialog.Text = "";
            }
            else
            {
                ValidClick = 3;
                lblDialog.Show();
                Credits.LineIndex = 0;
                Credits.CurrentDialog = Dialogue.Credits;
                dialogueTimer.Start();
            }


            Credits.TickIndex = 0;

        }



        // Form + Label Mouse Click

        private void Phantom_MouseClick(object sender, MouseEventArgs e)
        {
            lblDialog_MouseClick(sender, e);
            Invalidate();
        }

        private void lblDialog_MouseClick(object sender, MouseEventArgs e)
        {
            if (ValidClick == 1) //if mouse click is valid
            {
                //  Scene.LetterPerTickIndex = 0;
                if (MainScene.LineIndex < MainScene.CurrentDialog.Length) //check if theres still lines in the current dialogue scene
                {
                    if (!dialogueTimer.Enabled) //if the dialogue timer is done , start it again for the next line
                    {
                        lblDialog.Text = "";
                        dialogueTimer.Start();
                    }
                    else //if timer still going and form is clicked, immediately write dialogue
                    {
                        dialogueTimer.Stop();
                        lblDialog.Text = MainScene.CurrentDialog[MainScene.LineIndex];
                        MainScene.LineIndex++; //go next line after finishing
                        MainScene.TickIndex = 0;
                    }
                }
                else //when dialog scene is finished - hide dialog box (we reuse it a lot, best not to delete)
                {
                    lblDialog.Text = "";
                    lblDialog.Hide();
                    ValidClick = 0;
                    transitionTimer.Start();
                    MainScene.TickIndex = 0;
                    MainScene.LineIndex = 0;
                }
            }
            if (ValidClick == 2)
            {
                MainScene.TickIndex = 0;
            }


            Invalidate();
        }

    }
}
