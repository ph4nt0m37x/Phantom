using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phantom
{
    public class Scene
    {
        public string[] CurrentDialog {  get; set; }
        public int CurrentLine { get; set; }
        public int LetterPerTick { get; set; }

        public int TransitionSceneProgress { get; set; }
        public int TransitionTicks {  get; set; }

        public Scene()
        {
            LetterPerTick = 0;
            CurrentLine = 0;
            TransitionSceneProgress = 0;
            TransitionTicks = 0;

        }

        public string NextCharacter(string s)
        {
            if (LetterPerTick < s.Length)
            {
                char c = s.ToCharArray()[LetterPerTick];  
                return String.Format("{0}", c);
            }
            else
            {
                LetterPerTick = 0; //resets for next dialogue line
                CurrentLine++;    //moving onto next line
                return "";
            }
        }
    }
}
