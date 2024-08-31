using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;



namespace Phantom
{
    public class Keypad
    {
        Button[] Buttons = new Button[12];

        Timer T = new Timer();

        String Answer;

        String Input = "";

        Label Code = new Label();

        int counter = 0;

     //   Font customFont;

        public string[] ButtonText = //text for the buttons
        {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "DEL",
            "0",
            ">"
        };

        public Point[] Point = //points where buttons are spawned
        {
            new Point(89, 102),
            new Point(175, 102),
            new Point(261, 102),
            new Point(89, 188),
            new Point(175, 188),
            new Point(261, 188),
            new Point(89, 274),
            new Point(175, 274),
            new Point(261, 274),
            new Point(89, 360),
            new Point(175, 360),
            new Point(261, 360)
        };
        public Keypad(Timer t, String answer) //const (give it the right timer so it can stop the game until the minigame is done)
        {
            this.Answer = answer;
            this.T = t;





        }

        public Button spawnButton(string s, Point p) //func to spawn a single button with text s at point p
        {
            Button Button = new Button();
            Button.Text = s;

            Button.Location = p;
            Button.Show();
            Button.Enabled = true;
            Button.Size = new System.Drawing.Size(80, 80);
            Button.BackColor = Color.Transparent;
            Button.ForeColor = Color.White;
            Button.FlatAppearance.BorderColor = Color.White;
            Button.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            Button.FlatStyle = FlatStyle.Flat;
            Button.FlatAppearance.BorderSize = 2;
            Button.Click += new EventHandler(Button_Click);
            Button.TabStop = false;
            PrivateFontCollection privateFonts = new PrivateFontCollection();
            string fontPath = Path.Combine("Resources", "Unispace Bd.otf");
            privateFonts.AddFontFile(fontPath);
            Font customFont;
            customFont = new Font(privateFonts.Families[0], 20);
            Button.Font = customFont;
            Phantom.ActiveForm.Controls.Add(Button);

            return Button;


        }
        public void SpawnAllButtons() //func to spawn all buttons automatically
        {
            for (int i = 0; i < 12; i++)
            {
                Buttons[i] = spawnButton(ButtonText[i], Point[i]);
                Buttons[i].BringToFront();
            }

            PrivateFontCollection privateFonts = new PrivateFontCollection();
            string fontPath = Path.Combine("Resources", "Unispace Bd.otf");
            privateFonts.AddFontFile(fontPath);
            Font customFont;
            customFont = new Font(privateFonts.Families[0], 20);
            
            Code.Enabled = true;
            Code.Font = customFont;
            Code.Size = new System.Drawing.Size(250, 50);
            Code.Location = new Point(90, 40);
            Code.BackColor = Color.Transparent;
            Code.ForeColor = Color.White;
            Code.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Code.BorderStyle = BorderStyle.FixedSingle;
            Phantom.ActiveForm.Controls.Add(Code);
        }

        public void DeleteButtons()
        {
            foreach (Button b in Buttons)
            {
                b.Dispose();
            }
            Code.Dispose();
        }

        private void Button_Click(object sender, EventArgs e) //event if button is clicked (works for all of the buttons)
        {
            Button Button = sender as Button;
            if (Button != null)
            {
                if (Button.Text == "DEL" || Button.Text == ">") //check if button pressed has special action
                {
                    if (Button.Text == "DEL" && Input.Length > 0) //if DEL pressed remove the most recent character
                    {
                        Input = Input.Remove(Input.Length - 1);
                        Code.Text = Input;
                    }
                    else
                    if (Input.Length == 4)  //if > is pressed and the input field is full check if answer is correct
                    {
                        if (Input == Answer) //if correct stop minigame (gets rid of everything and starts the timer again)
                        {

                            T.Start();
                            
                        }
                        else
                        {

                            if (counter < 2)
                            {
                                Code.Text = "";
                                Input = "";
                                counter++;

                            }
                            else
                            {
                                Transition.sceneCount = 7;
                                Transition.FAIL = true;
                                DeleteButtons();
                                T.Start();
                            }
                        }

                    } 

                }
                else // if not special input add input to input field 
                {
                    if (Input.Length < 4)
                    {
                        Input += Button.Text;
                        Code.Text = Input;
                    }
                }
            }
        }
    }
}

