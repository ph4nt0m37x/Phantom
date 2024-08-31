using System.Text;
using System.Windows.Forms;


namespace Phantom
{
    public class Scene
    {
        public string[] CurrentDialog { get; set; }
        public int LineIndex { get; set; }
        public int TickIndex { get; set; }

        public int DialogCounter { get; set; }


        public Label CurrentLabel { get; set; }

        public Timer T { get; set; }

        public StringBuilder sb { get; set; }

        public Choice Choice;

        public Scene(string[] current, Label lbl, Timer t)
        {
            CurrentDialog = current;
            CurrentLabel = lbl;
            DialogCounter = 0;
            TickIndex = 0;
            LineIndex = 0;
            T = t;
            sb = new StringBuilder();
            Choice = new Choice("Expose NeuroSync", "Side with Specter", t);

        }

        public void DisplayLine(string s)
        {
            CurrentLabel.Show();

            if (TickIndex < s.Length) //if theres a next character in the string, add to label
            {
                char c = s.ToCharArray()[TickIndex++];
                CurrentLabel.Text += c;
            }
            else // if done writing
            {
                TickIndex = 0; //reset character position for next string
                LineIndex++; //go to next line in the script
                T.Stop(); //stop the timer for the current string
            }
        }

        public bool DisplayDialog(string s)
        {
            if (DialogCounter == 6)
            {
                DialogCounter = DialogCounter + Choice.expose;
            }


            //for the choice section
            CurrentDialog = Dialogue.Dialogues[DialogCounter];

            if (LineIndex < CurrentDialog.Length) //check if theres still lines in the current dialogue scene
            {
                if (!T.Enabled) //if the dialogue timer is done , start it again for the next line
                {
                    CurrentLabel.Text = "";
                    T.Start();
                }
                else //if timer still going and form is clicked, immediately write dialogue
                {
                    T.Stop();
                    CurrentLabel.Text = CurrentDialog[LineIndex];
                    LineIndex++; //go next line after finishing
                    TickIndex = 0; // reset character position for next string
                }
                return false;
            }

            else //when dialog scene is finished - reset dialog box (we reuse it a lot, best not to delete)
            {  

                if (DialogCounter == 6)
                {
                    Choice.SpawnChoiceButtons();
                    Choice.clicked = false;
                    CurrentLabel.Text = "";
                    TickIndex = 0;
                    LineIndex = 0;
                    return false;

                }

                else if (DialogCounter == 7 || DialogCounter == 8 || DialogCounter == 9)
                {
                    Transition.END_GAME = true;
                    return true;
                }
                else
                {    
                    DialogCounter++;
                    CurrentLabel.Text = "";
                    TickIndex = 0;
                    LineIndex = 0;
                    return true;
                }
            }
        }


        public bool Decrypt(string decrypted, string encrypted)
        { 
            if (TickIndex == 0)
            {
                sb.Append(encrypted); //we put the old string in the sb so we can change exact positions of the letters
            }      

            if (TickIndex < encrypted.Length)
            {
                char c = decrypted.ToCharArray()[TickIndex];
                sb[TickIndex] = c;

                CurrentLabel.Text = sb.ToString(); //replace the letter in the old string with the one in the new
                return false;
            }
            else // when done
            {
                return true;
            }
        }
    
    }
}
