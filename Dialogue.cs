using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Windows.Forms.VisualStyles;

namespace Phantom
{
    public class Dialogue
    {

        public static List<String[]> Dialogues = new List<string[]>
        {

            new string[] // 0 - starting dialogue
            {
            "r0gu3: NeuroSync is on the brink of a breakthrough with their latest cybernetic implant.",
            "r0gu3: Rumor has it, it's game changing.",
            "r0gu3: I only need the blueprints to recreate it.",
            "r0gu3: Problem is their developmental facilities are heavily guarded.",
            "r0gu3: However, they have a weak spot: the NeuroSync Innovation Hub — low interest, low security.",
            "r0gu3: My contact has informed me they’ve stashed a copy at a safe location.",
            "r0gu3: I need someone who can slip in and out unnoticed. That's where you come in.",
            "r0gu3: No trace.",
            "r0gu3: Just the blueprints.",
            "r0gu3: You’ll be joined by Specter.",
            "Nix: I work better alone.",
            "r0gu3: Your reputation for discretion precedes you, yet we're not naive enough to trust blindly in your compliance.",
            "r0gu3: He’ll be your eyes and ears when you’re inside, and he’ll also make sure you stay on track.",
            "r0gu3: Play it smart, and you both walk away clean.",
            "Nix: ...",
            "r0gu3: The location’s coordinates and Specter's contact have been sent to you.",
            "r0gu3: The rendezvous is scheduled at midnight on the 7th of July.",
            "r0gu3: Punctuality is paramount — failure is not an option."
            },

            new string[] //1 - outside the hub dialogue / pre cipher dialogue
            {
            "Nix: Status update?",
            "Specter: All clear. No signs of activity.",
            "Nix: What’s the quickest entrance?",
            "Specter: Emergency exit up front.",
            "Nix: Got it.",
            "Specter: Next to the door you’ll see a lock screen. When you try to access it, a cipher will appear.",
            "Specter: In order to bypass it, you’ll have to connect all the lines by pressing on each circle to rotate it in a time frame of 30 seconds.",
            "Nix: No pressure.",
            "Specter: You don’t have much time. Do it, now."
            },
            new string[] //2 - post cipher dialogue 
            {
            "Nix: I’m in. Where do I proceed?",
            "Specter: Nicely done.",
            "Specter: The blueprints should be stashed in the server room on your right.",
            "Specter: Cameras are scattered throughout.",
            "Specter: Thanks to our contact, they've been moved ever so slightly, allowing you to pass if you stick close to the wall." ,
            "Nix: Hold up, stashed? Where?",
            "Specter: Go in quickly before a guard comes."            
            },

            new string[] //3 - server room
            {
                "Nix: Specter there's someone's blood in here--",
                "Specter: - The blueprints can be accessed from the terminal in front of you.",
                "Nix: Did you not hear me?",
                "Specter: None of our concern.",
                "Specter: We need those blueprints, or our contact's efforts would have been for nothing.",
                "Specter: The data will be encrypted. The key is the word 'something' written using the polyalphabetic cipher given.",
                "Specter: No time frame on this. Just make sure you don't fail more than 3 times.",
                "Specter: If you do, the alarm will trigger and guards will storm you."

            },
            new string [] // 4 - post-encryption dialogue
            {
                ""
            },
            new string[] // 5 - expose
            {
                ""
            },

             new string[] // 6 - be selfish (live) :(
            {
                ""
            },

            new string[] // last, fail (case default)
            {
            "Nix: --Shit!",
            "Specter: Nix? You there?",
            "Specter: …",
            "Specter: Nix?",
            "Specter: …",
            "Specter: The guards must've got her. Mission failed."
            }

    };

        public static List<String[]> TransitionLines = new List<string[]>
        {
            new string[]
            {
                "",

            },
            new string[]
            {
                "NeuroSync Innovation Hub, Neo Solaris, 01:00h, 7th July 2077"
            },

            new string[] 
            {
                ""
            },
        };

        public static string[] Credits =
        {

                "created by: Marija Ilievska && Nikola Janev\n" +
                "art: Screenshots from Cyberpunk 2077,\n" +
                "FreePik: https://www.freepik.com/author/freepik"

        };

        public static string[] Menu =
        {
            "r0gu3: Nothing stays hidden forever. Not from us, anyway. We need intel. You need money. Will you accept the mission?"
    };
            
    }
}
