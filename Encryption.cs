using System;
using System.Windows.Forms;
using System.Drawing;


namespace Phantom
{
     public class Encryption
    {
        public static Label Encrypted = new Label();

        Label Alphabet = new Label();

        Label Cipher = new Label();

        Label Hint = new Label();

        public TextBox TextBox = new TextBox();

        public Button Continue = new Button();

        public Timer TransitionTimer = new Timer();

        public Timer DialogTimer = new Timer();

        public bool Done;


        public Scene EncryptMinigame;

        String A = "A: a b c d e f g h i j k l m n o p q r s t u v w x y z";
        String C = "C: z x c a s d q w e y t r h g f n b v u i o j k l m p";

        public Encryption(Timer t)
        {
            TransitionTimer = t;

            DialogTimer.Interval = 30;

            DialogTimer.Tick += new EventHandler(Decrypt_Tick);

            EncryptMinigame = new Scene(Dialogue.Encrypted, Encrypted, DialogTimer);

            Done = false;

        }

        public void CreateGame()
        {
            // main encrypt text
            Encrypted.Enabled = true;
            Encrypted.Font = new Font("Unispace", 11);
            Encrypted.Size = new System.Drawing.Size(650, 250);
            Encrypted.Location = new Point(120, 70);
            Encrypted.BackColor = Color.Transparent;
            Encrypted.ForeColor = Color.White;
            Encrypted.Text = Dialogue.Encrypted[0];
            Phantom.ActiveForm.Controls.Add(Encrypted);
            Encrypted.BringToFront();

            // cipher 1

            Alphabet.Enabled = true;
            Alphabet.Font = new Font("Unispace", 11);
            Alphabet.Size = new System.Drawing.Size(575, 30);
            Alphabet.Location = new Point(120, 330);
            Alphabet.BackColor = Color.Transparent;
            Alphabet.ForeColor = Color.White;
            Alphabet.Text = A;
            Phantom.ActiveForm.Controls.Add(Alphabet);
            Alphabet.BringToFront();

            // cipher 2

            Cipher.Enabled = true;
            Cipher.Font = new Font("Unispace", 11);
            Cipher.Size = new System.Drawing.Size(575, 30);
            Cipher.Location = new Point(120, 360);
            Cipher.BackColor = Color.Transparent;
            Cipher.ForeColor = Color.White;
            Cipher.Text = C;
            Phantom.ActiveForm.Controls.Add(Cipher);
            Cipher.BringToFront();

            //hint 

            Hint.Enabled = true;
            Hint.Font = new Font("Unispace", 11);
            Hint.Size = new System.Drawing.Size(575, 30);
            Hint.Location = new Point(400, 400);
            Hint.BackColor = Color.Transparent;
            Hint.ForeColor = Color.LightGray;
            Hint.Text = "(word to decrypt: nvfqvsuu)";
            Phantom.ActiveForm.Controls.Add(Hint);
            Hint.BringToFront();

            // text box

            TextBox.Enabled = true;
            TextBox.Font = new Font("Unispace", 11);
            TextBox.Size = new System.Drawing.Size(150, 50);
            TextBox.Location = new Point(120, 400);
            TextBox.BackColor = Color.DarkCyan;
            TextBox.ForeColor = Color.White;
            Phantom.ActiveForm.Controls.Add(TextBox);
            TextBox.BringToFront();

            // button

            Continue.Enabled = true;
            Continue.Font = new Font("Unispace", 11);
            Continue.Size = new System.Drawing.Size(50, 28);
            Continue.Location = new Point(300, 397);
            Continue.BackColor = Color.Transparent;
            Continue.ForeColor = Color.White;
            Continue.TextAlign = ContentAlignment.MiddleCenter;
            Continue.FlatAppearance.MouseOverBackColor = Color.Teal;
            Continue.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
            Continue.FlatStyle = FlatStyle.Flat;
            Continue.FlatAppearance.BorderSize = 2;
            Continue.Text = ">>";
            Phantom.ActiveForm.Controls.Add(Continue);
            Continue.Click += new EventHandler(Continue_Click);
            Continue.BringToFront();
        }


        private void Continue_Click(object sender, EventArgs e)
        {
            


            if (TextBox.Text.ToLower() == "progress") //if the keyword is correct
            {
                TextBox.Enabled = false;
                Continue.Enabled = false;
                DialogTimer.Start();
            }

            else //if you fail, consequences
            {
                Transition.sceneCount = 10;
                Transition.FAIL = true; 
                TransitionTimer.Start(); //starting the timer back up
            }
            Alphabet.Dispose();
            Cipher.Dispose();
            TextBox.Dispose();
            Continue.Dispose();
            Hint.Dispose();
        }


        private void Decrypt_Tick(object sender, EventArgs e) {

            if (!Done)
            {
                Done = EncryptMinigame.Decrypt(Dialogue.Decrypted[0], Dialogue.Encrypted[0]);
                EncryptMinigame.TickIndex++;
            }
            else
            {           
                DialogTimer.Stop();
                TransitionTimer.Start();
            }
        }

        public void DeleteLabel()
        {
            Encrypted.Dispose(); //disposing of all the buttons created for the scene

        }


    }

}

