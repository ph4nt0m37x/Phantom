using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.TimeZoneInfo;


namespace Phantom
{
    public partial class Phantom : Form
    {

        public Scene MainScene;
        public Scene MenuScene;
        public Scene Credits;
        public Transition Transition;
        public bool transitionDone;
        public bool sceneDone;
        public bool validClick;
        public Phantom()
        {
            InitializeComponent();
            DoubleBuffered = true;

            transitionDone = false; // whether a transition is done
            sceneDone = false;
            validClick = false;
            
            MenuScene = new Scene(Dialogue.Menu, lblMenu, menuTimer); //
            MainScene = new Scene(Dialogue.Dialogues[0], lblDialog, dialogueTimer); //set the menu as main scene
            Credits = new Scene(Dialogue.Credits, lblDialog, creditsTimer); //set the credits dialogue
            Transition = new Transition(transitionTimer, lblCenter); //create the transition scene

            menuTimer.Start(); //start the menu timer for the dialog to write out
        }

        // Menu timers
        private void menuTimer_Tick(object sender, EventArgs e)
        {
            Display(MenuScene);
        }
        private void creditsTimer_Tick(object sender, EventArgs e)
        {
            Display(Credits);
        }

        private void Display(Scene scene) {
            scene.DisplayLine(scene.CurrentDialog[0]);
        }

        // Dialogue timer

        private void dialogueTimer_Tick(object sender, EventArgs e)
        {
            if (!sceneDone) //if the click is valid, if its on a scene
            {
                MainScene.DisplayLine(MainScene.CurrentDialog[MainScene.LineIndex]);
            }
            else
            {
                transitionDone = false;
                Transition.sceneCount++;
                dialogueTimer.Stop();
                transitionTimer.Start();
            }
        }
        
        //Start Button

        private void ButtonStart_MouseClick(object sender, MouseEventArgs e)
        {
            ButtonStart.Dispose(); //removing the Buttons
            ButtonCredits.Dispose();
            ButtonOptions.Dispose();

            lblMenu.Dispose(); // remove label 
            menuTimer.Dispose(); //remove menu timer
            creditsTimer.Dispose();
            lblDialog.Text = "";
            lblDialog.Hide();

            transitionTimer.Start();

        }


        //Transition timer
        private void sceneTimer_Tick(object sender, EventArgs e)
        {
            if (transitionDone)
            {               
                sceneDone = false;
                MainScene.CurrentDialog = Dialogue.Dialogues[MainScene.DialogCounter];
                MainScene.LineIndex = 0;
                transitionTimer.Stop();
                validClick = true;
                dialogueTimer.Start();
                
            }
            else
            {
                Transition.TickCount++; //count the ticks for transition scene
                transitionDone = Transition.Fade(transitionDone);      //call fade every tick  
            }         

        }

        // Form + Label Mouse Click

        private void Phantom_MouseClick(object sender, MouseEventArgs e)
        {
            lblDialog_MouseClick(sender, e);
            Invalidate();
        }

        private void lblDialog_MouseClick(object sender, MouseEventArgs e)
        {

            if (validClick)
            {
                sceneDone = MainScene.DisplayDialog(MainScene.CurrentDialog[0]);

                if (sceneDone)
                {
                    transitionDone = false;
                    validClick = false; 
                    dialogueTimer.Stop(); //stop the dialogue timer
                    transitionTimer.Start(); //start the next transition

                }
            }

            Invalidate();
        }

        //Menu Screen Button Colors

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
            lblDialog.Text = "";
            Credits.TickIndex = 0;
            Credits.LineIndex = 0;
            creditsTimer.Enabled = !creditsTimer.Enabled;

        }

    }
}
