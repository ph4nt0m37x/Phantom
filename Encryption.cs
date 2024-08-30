using System;
using System.Windows.Forms;
using System.Drawing;


namespace Phantom
{
     public class Encryption
    {
        public static Label Encrypted = new Label();

        Label Cipher1 = new Label();

        Label Cipher2 = new Label();

        Label Hint = new Label();

        public TextBox TextBox = new TextBox();

        public Button Continue = new Button();

        public Timer transitionTimer = new Timer();

        public Timer dialogT = new Timer();

        public bool Done;

       


        String[] dialogEncrypted = Dialogue.Encrypted;


        public Scene encryptScene;

        String alpha = "A: a b c d e f g h i j k l m n o p q r s t u v w x y z";
        String beta = "C: z x c a s d q w e y t r h g f n b v u i o j k l m p";

        public Encryption(Timer t)
        {
            transitionTimer = t;

            dialogT.Interval = 30;

            dialogT.Tick += new EventHandler(Decrypt_Tick);

            encryptScene = new Scene(dialogEncrypted, Encrypted, dialogT);

            Done = false;

        }

        public void createGame()
        {
            // main encrypt text
            Encrypted.Enabled = true;
            Encrypted.Font = new Font("Unispace", 11);
            Encrypted.Size = new System.Drawing.Size(650, 250);
            Encrypted.Location = new Point(120, 70);
            Encrypted.BackColor = Color.Transparent;
            Encrypted.ForeColor = Color.White;
            Encrypted.Text = dialogEncrypted[0];
            Phantom.ActiveForm.Controls.Add(Encrypted);
            Encrypted.BringToFront();

            // cipher 1

            Cipher1.Enabled = true;
            Cipher1.Font = new Font("Unispace", 11);
            Cipher1.Size = new System.Drawing.Size(575, 30);
            Cipher1.Location = new Point(120, 330);
            Cipher1.BackColor = Color.Transparent;
            Cipher1.ForeColor = Color.White;
            Cipher1.Text = alpha;
            Phantom.ActiveForm.Controls.Add(Cipher1);
            Cipher1.BringToFront();

            // cipher 2

            Cipher2.Enabled = true;
            Cipher2.Font = new Font("Unispace", 11);
            Cipher2.Size = new System.Drawing.Size(575, 30);
            Cipher2.Location = new Point(120, 360);
            Cipher2.BackColor = Color.Transparent;
            Cipher2.ForeColor = Color.White;
            Cipher2.Text = beta;
            Phantom.ActiveForm.Controls.Add(Cipher2);
            Cipher2.BringToFront();

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
            Cipher1.Dispose();
            Cipher2.Dispose();
            TextBox.Dispose();
            Continue.Dispose();
            Hint.Dispose();


            if (TextBox.Text == "progress") //if the keyword is correct
            {
                TextBox.Enabled = false;
                Continue.Enabled = false;
                dialogT.Start();
            }

            else
            {
                Transition.sceneCount = 8;
                Transition.FAIL = true;
              
                transitionTimer.Start(); //starting the timer back up
            }

        }


        private void Decrypt_Tick(object sender, EventArgs e) {

            

            if (!Done)
            {
                Done = encryptScene.Decrypt(Dialogue.Decrypted[0], Dialogue.Encrypted[0]);
                encryptScene.TickIndex++;
            }
            else
            {
               
                dialogT.Stop();
                transitionTimer.Start();
            }
        }

        public void DeleteAll()
        {

            Encrypted.Dispose(); //disposing of all the buttons created for the scene

        }


    }

}

