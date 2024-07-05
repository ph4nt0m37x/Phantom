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


namespace Phantom
{
    public partial class Phantom : Form
    {

        public int ValidClick;
        public Scene Scene { get; set; }

        public Phantom()
        {
            InitializeComponent();
            DoubleBuffered = true;
            lblDialog.Hide();
            Scene = new Scene();
            Scene.CurrentDialog = Dialogue.startDialog;
            ValidClick = 0;
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

            if (ValidClick== 2)
            {
                ValidClick = 0;
                lblCenter.Text = "";
            }
            else
            {
                ValidClick = 2;
                lblCenter.Show();
                Scene.CurrentLine = 0;
                Scene.CurrentDialog = Dialogue.credits;
                dialogueTimer.Start();
            }

            
            Scene.LetterPerTick = 0;
           
        }

        private void Phantom_Load(object sender, EventArgs e)
        {

        }

        private void ButtonStart_MouseClick(object sender, MouseEventArgs e)
        {
            
            ButtonStart.Dispose(); //removing the Buttons
            ButtonCredits.Dispose();
            ButtonOptions.Dispose();
            ValidClick = 1;          //validating mouse clicks on the form
            lblCenter.Hide(); //hiding credits if clicked
            //setting dialogue
            Scene.CurrentDialog = null;
            Scene.CurrentDialog = Dialogue.startDialog;
            //  sceneTimer.Start();
            Scene.LetterPerTick = 0;
            Scene.CurrentLine = 0;



            dialogueTimer.Start();        
            lblDialog.Show();
        }

        private void DisplayDialogue(string s, Label label) //displays dialogue letter by letter 
        {
            string nextChar = Scene.NextCharacter(s);

            if (nextChar == "")
                dialogueTimer.Stop();    

            else
                label.Text += nextChar;

        }
     
        private void dialogueTimer_Tick(object sender, EventArgs e)
        {   
            if (ValidClick == 1)
            {
                DisplayDialogue(Scene.CurrentDialog[Scene.CurrentLine], lblDialog);
            }
            else if (ValidClick == 2)
            {
                DisplayDialogue(Scene.CurrentDialog[Scene.CurrentLine], lblCenter);
               // sceneTimer.Start();
              // ValidClick = 0;

            }
            else
            { 
             //   sceneTimer.Start();
            }

            Scene.LetterPerTick++;

        }

        private void Phantom_MouseClick(object sender, MouseEventArgs e)
        {
            lblDialog_MouseClick(sender, e);
            Invalidate();

        }

        //Transition scene

        private void sceneTimer_Tick(object sender, EventArgs e)
        {

            Scene.TransitionTicks++; //count the ticks for transition scene

            if (Scene.TransitionTicks < 20) //timer for fade out
            {
                Phantom.ActiveForm.Opacity -= 0.05;
            }

            else if (Scene.TransitionTicks == 20) //when the transition scene comes, set wallpaper to black            
            {
                lblCenter.Hide();
                this.BackgroundImage = null;             
            }
            else  if (Scene.TransitionSceneProgress == 1)//after the transition, swap back to the next scene's image image
            {
                this.BackgroundImage = Properties.Resources.mainMenuGrid;
                Scene.TransitionSceneProgress = 2;  
            }
            else if (Scene.TransitionTicks < 40 && Scene.TransitionTicks >= 20) //timer for fade in
            {    
                Phantom.ActiveForm.Opacity += 0.05;
            }
            else if (Scene.TransitionTicks == 40 && Scene.TransitionSceneProgress == 2) //scene has ended, transition to next scene
            {
                sceneTimer.Stop();
                this.Close();
            }
             else if (Scene.TransitionTicks == 40) //
            {
               // sceneTimer.Stop();
                Scene.CurrentLine = 0;
                ValidClick = 2;

                Scene.CurrentDialog = new string[1];
                Scene.CurrentDialog[0] = "BioSynth Innovation Hub, Neo Solaris, 01:00h, 7th July 2077";
                Scene.CurrentLine = 0;
                lblCenter.Show();
                dialogueTimer.Start();                
            }
            else if (Scene.TransitionTicks == 300)
            {
                Scene.TransitionSceneProgress = 1;
                Scene.TransitionTicks = 0;
            }
        }

        private void lblDialog_MouseClick(object sender, MouseEventArgs e)
        {
            
            Scene.LetterPerTick = 0;
            

            if (ValidClick == 1) //if mouse click is valid
            {

                if (Scene.CurrentLine < Scene.CurrentDialog.Length) //check if theres still lines in the current dialogue scene
                {
                    if (!dialogueTimer.Enabled) //if the dialogue timer is done , start it again for the next line
                    {
                        lblDialog.Text = "";
                        dialogueTimer.Start();
                    }
                    else //if timer still going and form is clicked, immediately write dialogue
                    {
                        dialogueTimer.Stop();
                        lblDialog.Text = Scene.CurrentDialog[Scene.CurrentLine];
                        Scene.CurrentLine++; //go next line after finishing
                    }
                }
                else //when dialog scene is finished - hide dialog box (we reuse it a lot, best not to delete)
                {
                    lblDialog.Text = "";
                    lblDialog.Hide();
                    ValidClick = 0;
                    sceneTimer.Start();
                    Scene.LetterPerTick = 0;
                }
            }
            Invalidate();
        }

        //Mission Assignment 







        //Arriving at the Destination

        //



        //Implement Scene 


    }
}
