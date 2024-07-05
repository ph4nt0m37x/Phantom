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
        public int DialogTickCount;
        public int DialogCount;
        public int TransitionTickCount;
        public int SceneEnd;
        public bool Valid;

        public string[] CurrentDialog {  get; set; }


        public Phantom()
        {
            InitializeComponent();
            DoubleBuffered = true;
            lblDialog.Hide();
            DialogTickCount = 0;
            DialogCount = 0;
            CurrentDialog = Dialogue.startDialog;
            Valid = false;
            SceneEnd = 0;
            TransitionTickCount = -1;
        }

        

        public void display()
        {
           
            
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
            lblCenter.Text = "";
                dialogueTimer.Start();
        }

        private void Phantom_Load(object sender, EventArgs e)
        {

        }

        private void ButtonStart_MouseClick(object sender, MouseEventArgs e)
        {
            ButtonStart.Dispose(); //removing the Buttons
           // ButtonQuit.Dispose();
            ButtonCredits.Dispose();
            ButtonOptions.Dispose();
            Valid = true;          //validating mouse clicks on the form

          //  sceneTimer.Start();

            
            dialogueTimer.Start();        
            
            lblDialog.Show();
        }

        private void DisplayDialogue(string s, Label label) //displays dialogue letter by letter 
        {
            if (DialogTickCount < s.Length)
            {
                char c = s.ToCharArray()[DialogTickCount];
                label.Text += c;
            }
            else
            {
                DialogTickCount = 0; //resets for next dialogue line
                DialogCount++;    //moving onto next line
                dialogueTimer.Stop(); //stopping the timer indicating that the line is done
                               
            }
        }

        private void DisplayScene(string s)
        {

        }


        
        private void dialogueTimer_Tick(object sender, EventArgs e)
        {   
            if (Valid)
            {
                DisplayDialogue(CurrentDialog[DialogCount], lblDialog);
            }
            else
            {
                DisplayDialogue(CurrentDialog[DialogCount], lblCenter);
                sceneTimer.Start();
            }

            DialogTickCount++;

        }

        private void Phantom_MouseClick(object sender, MouseEventArgs e)
        {
            DialogTickCount = 0; 

            if (Valid) //if mouse click is valid
            {

                if (DialogCount < CurrentDialog.Length) //check if theres still lines in the current dialogue scene
                {
                    if (!dialogueTimer.Enabled) //if the dialogue timer is done , start it again for the next line
                    {
                        lblDialog.Text = "";
                        dialogueTimer.Start();
                    }
                    else //if timer still going and form is clicked, immediately write dialogue
                    {
                        dialogueTimer.Stop();
                        lblDialog.Text = CurrentDialog[DialogCount];
                        DialogCount++; //go next line after finishing
                    }
                }
                else //when dialog scene is finished - hide dialog box (we reuse it a lot, best not to delete)
                {
                    lblDialog.Text = "";
                    lblDialog.Hide();
                    Valid = false;
                    sceneTimer.Start();
                    DialogTickCount = 0;
                }
            }
            else if (sceneTimer.Enabled)
            {
              
                    
                


            }
            Invalidate();

        }

        //Transition scene

        private void sceneTimer_Tick(object sender, EventArgs e)
        {
            TransitionTickCount++; //count the ticks for transition scene

            if (TransitionTickCount < 20) //timer for fade out
            {
                Phantom.ActiveForm.Opacity -= 0.05;
            }

            else if (TransitionTickCount == 20) //when the transition scene comes, set wallpaper to black            
            {
                lblCenter.Hide();
                this.BackgroundImage = null;             
            }
            else  if (SceneEnd == 1)//after the transition, swap back to the next scene's image image
            {
                this.BackgroundImage = Properties.Resources.mainMenuGrid;
                SceneEnd = 2;  
            }
            if (TransitionTickCount < 40 && TransitionTickCount >= 20) //timer for fade in
            {    
                Phantom.ActiveForm.Opacity += 0.05;
            }
            else if (TransitionTickCount == 40 && SceneEnd == 2) //scene has ended, transition to next scene
            {
                sceneTimer.Stop();
                this.Close();
            }
             else if (TransitionTickCount == 40) //
            {
                sceneTimer.Stop();
                DialogTickCount = 0;
                CurrentDialog = new string[1];
                CurrentDialog[0] = "BioSynth Innovation Hub, Neo Solaris, 01:00h, 7th July 2077";
                DialogCount = 0;
                lblCenter.Show();
                dialogueTimer.Start();                
            }
            else if (TransitionTickCount == 300)
            {
                SceneEnd = 1;
                TransitionTickCount = 0;
            }
        }

        private void lblDialog_MouseClick(object sender, MouseEventArgs e)
        {
            Phantom_MouseClick(sender, e);
        }

        //Mission Assignment 







        //Arriving at the Destination

        //



        //Implement Scene 


    }
}
