using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms; 


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

        public bool music;
        public Phantom()
        {
            InitializeComponent();
            DoubleBuffered = true;

            transitionDone = false; // whether a transition is done
            sceneDone = false;
            validClick = false;
            music = true;
            
            MenuScene = new Scene(Dialogue.Menu, lblMenu, menuTimer); //
            MainScene = new Scene(Dialogue.Dialogues[0], lblDialog, dialogueTimer); //set the menu as main scene
            Credits = new Scene(Dialogue.Credits, lblDialog, creditsTimer); //set the credits dialogue
            Transition = new Transition(transitionTimer, lblCenter); //create the transition scene

            SoundPlayer player = new SoundPlayer(Properties.Resources.stealth_music_background);
            player.PlayLooping(); //mooosic
            

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
            else { 
            
              /*  if (MainScene.DialogCounter == 7  && !Transition.END_GAME || MainScene.DialogCounter == 8 && !Transition.END_GAME)
                {//if its the last dialogue before the end of the game
                    sceneDone = false;
                    dialogueTimer.Start();
                }*/
               
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

            lblDialog.TextAlign = ContentAlignment.MiddleLeft; 

            lblMenu.Dispose(); // remove label 
            menuTimer.Dispose();
            creditsTimer.Dispose(); // remove credits timer
            lblDialog.Text = "";
            lblDialog.Hide();

            transitionTimer.Start();

        }


        //Transition timer
        private void sceneTimer_Tick(object sender, EventArgs e)
        {

            if (transitionDone && MainScene.DialogCounter == 2)
            {

                transitionDone = false;
                MainScene.DialogCounter++;
                transitionTimer.Start();
            }


            if (transitionDone && Transition.sceneCount == 8)
            {

                transitionDone = false;
                MainScene.DialogCounter = 9;
                transitionTimer.Start();
            }


            else if (transitionDone)
            {
                    lblDialog.Show();
                    sceneDone = false;
                    MainScene.CurrentDialog = Dialogue.Dialogues[MainScene.DialogCounter];
                    MainScene.LineIndex = 0;
                    transitionTimer.Stop();
                    validClick = true;
                    dialogueTimer.Start();
            }
            else
            {
                lblDialog.Hide();
                Transition.TickCount++; //count the ticks for transition scene
                transitionDone = Transition.Fade(transitionDone);      //call fade every tick  
            }         

        }

        // Form + Label Mouse Click

        private void Phantom_MouseClick(object sender, MouseEventArgs e)
        {
            OnClick();
            Invalidate();
        }

        private void lblDialog_MouseClick(object sender, MouseEventArgs e)
        {
            OnClick();
            Invalidate();
        }

        public void OnClick()
        {
            if (MainScene.DialogCounter >= 6 && Choice.spawned)
            {
                validClick = Choice.clicked;
            }

            if (validClick)
            {

                if (MainScene.DialogCounter == 6)
                {
  

                    MainScene.DialogCounter = MainScene.DialogCounter + Choice.expose;
                    MainScene.CurrentDialog = Dialogue.Dialogues[MainScene.DialogCounter];
                }

                sceneDone = MainScene.DisplayDialog(MainScene.CurrentDialog[0]);

                ifDone();

            }
            


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
            ButtonMusic.ForeColor = Color.LightSeaGreen;
        }

        private void ButtonOptions_MouseLeave(object sender, EventArgs e)
        {
            ButtonMusic.ForeColor = Color.White;
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
            lblDialog.TextAlign = ContentAlignment.MiddleCenter;
            Invalidate();
        }

        public void Phantom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Space))
            {
                OnClick();
                Invalidate();
            }
            
        }

        public void ifDone()
        {
             if (sceneDone)
            {
                if (Transition.FAIL)
                {
                    MainScene.DialogCounter = 9;
                }

                transitionDone = false;
                validClick = false;
                dialogueTimer.Stop(); //stop the dialogue timer
                transitionTimer.Start(); //start the next transition
            } 
            
        }

        private void ButtonMusic_Click(object sender, EventArgs e)
        {

        }

        private void ButtonMusic_KeyDown(object sender, KeyEventArgs e)
        {
            Phantom_KeyDown(sender, e);
        }

        private void ButtonMusic_MouseClick(object sender, MouseEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.stealth_music_background);

            music = !music;

            if (music)
            {
                
                player.PlayLooping();
            }
            else
            {
                player.Stop();
            }

            Invalidate();
            
        }

        private void lblDialog_Click(object sender, EventArgs e)
        {

        }
    }
}
