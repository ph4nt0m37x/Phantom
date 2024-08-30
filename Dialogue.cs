using System;
using System.Collections.Generic;

namespace Phantom
{
    public class Dialogue
    {

        public static List<String[]> Dialogues = new List<string[]>
        {

            new string[] // 0 - starting dialogue
            {
            "r0gu3: Hello, Nix. Pleasure to be working with you again.",
            "Nix: What's the mission?",
            "r0gu3: NeuroSync is on the brink of a breakthrough with their latest cybernetic implant.",
            "r0gu3: Rumor has it, it's game changing.",
            "r0gu3: I only need the blueprints to recreate it.",
            "r0gu3: Problem is their developmental facilities are heavily guarded.",
            "r0gu3: However, they have a weak spot: the NeuroSync Innovation Hub — low interest, low security.",
            "r0gu3: My contact has informed me they’ve stashed a copy at a safe location.",
            "r0gu3: I need someone who can slip in and out unnoticed. That's where you come in.",
            "r0gu3: No trace.",
            "r0gu3: Just the blueprints.",
            "r0gu3: You’ll be joined by Apoc.",
            "Nix: I work better alone.",
            "r0gu3: Your reputation for discretion precedes you, yet we're not naive enough to trust blindly in your compliance.",
            "r0gu3: He’ll be your eyes and ears when you’re inside, and he’ll also make sure you stay on track.",
            "r0gu3: Play it smart, and you both walk away clean.",
            "Nix: ...",
            "r0gu3: The location’s coordinates and Apoc's contact have been sent to you.",
            "r0gu3: The rendezvous is scheduled at midnight on the 7th of July.",
            "r0gu3: Punctuality is paramount — failure is not an option."
            },

            new string[] //1 - outside the hub dialogue / pre cipher dialogue
            {
            "Nix: Status update?",
            "ap0c: All clear. No signs of activity.",
            "Nix: What’s the quickest entrance?",
            "ap0c: Emergency exit up front.",
            "Nix: Got it.",
            "ap0c: Next to the door you’ll see a lock screen. When you try to bypass it, you will need to type the correct code.",
            "ap0c: I've just received it, it is 0109.",
            "ap0c: You have 3 attempts. Make sure not to mess up more than twice.",
            "ap0c: It's a simple code. 0109.",
            "Nix: No pressure.",
            "ap0c: You don’t have much time. Do it, now."
            },
            new string[] //2 - text when the minigame is done
            {   
            ""
            },
            new string[] //3 - post cipher dialouge
            {
            "Nix: I’m in. Where do I proceed?",
            "ap0c: Nicely done.",
            "ap0c: The blueprints should be stashed in the server room on your right.",
            "ap0c: Cameras are scattered throughout.",
            "ap0c: Thanks to our contact, they've been moved ever so slightly, allowing you to pass if you stick close to the wall." ,
            "Nix: Hold up, stashed? Where?",
            "ap0c: Go in quickly before a guard comes."
            },

            new string[] //4 - server room
            {
                "Nix: Apoc there's someone's blood in here--",
                "ap0c: - The blueprints can be accessed from the terminal in front of you.",
                "Nix: Did you not hear me?",
                "ap0c: None of our concern.",
                "ap0c: We need those blueprints, or our contact's efforts would have been for nothing.",
                "ap0c: The data will be encrypted. The key is the word 'nvfqvsuu' deciphered with the polyalphabetic cipher given.",
                "ap0c: No time frame on this. Just make sure you don't fail.",
                "ap0c: If you do, the alarm will trigger and guards will storm you."

            },

            new string[] // 5 - allowing the player to choose to resume after they've read the file

            {
                "Click / Press SPACE to continue"
            },

            new string [] // 6 - post-encryption dialogue
            {
                "ap0c: Nix? You there?",
                "Nix: ...They’re experimenting on humans illegally here…",
                "Nix: Innocent people—they’re lying to them about what’s going to happen—",
                "ap0c: --Nix, we were explicitly instructed to only take the blueprints.",
                "Nix: So, you want me to just pretend like I saw nothing?",
                "ap0c: Need I remind you of what Rogue said?",
                "ap0c: There’s a time to fight, and a time to walk away. Knowing the difference is what keeps you breathing.",
                "ap0c: I don’t know if you’ve got a death wish, but I don’t.",
                "Nix: …",
                "ap0c: Nix?",
                "ap0c: Don’t do this, please.",
                "Not every truth is meant to be uncovered. Some things, you’re better off not knowing.",
                "But now - the truth is staring you in the face.",
                "The choice is in your hands."
            },
            new string[] // 7 - blank in between (dont ask we suffered)
            {

            },

            new string[] // 8 - expose
            {
                "Nix: I’m sorry, Apoc.",
                "ap0c: NIX, DON’T ---",
                "Nix: I have to prioritize what I believe in.",
                "Nix: Even if that costs me.",
                "True change demands sacrifice. The question isn’t whether you can pay the price, but whether you’re willing to."
            },

             new string[] // 9 - be selfish (live) :(
            {
                "Nix: I’ve taken the blueprints.",
                "ap0c: Good. We stick to the plan. No heroics.",
                "Nix: It just.. feels wrong.",
                "ap0c: This is bigger than us.  One data leak will not cost NeuroSync more than a few lawyers.",
                "In this world, the price of seeing everything is too high. Sometimes, you have to choose to see nothing."
            },

            new string[] //10 last, fail (case default)
            {
            "Nix: --Shit!",
            "ap0c: Nix? You there?",
            "ap0c: …",
            "ap0c: Nix?",
            "ap0c: …",
            "ap0c: The guards must've got her. Mission failed."
            }

    };

        public static List<String[]> TransitionLines = new List<string[]>
        {

            new string[]
            {
                "Sector 9, Neo Solaris, 19:28h, July 5th 2077"
            },

            new string[]
            {
                "NeuroSync Innovation Hub, Neo Solaris, 00:00h, July 7th 2077"
            },

            new string[]
            {
                "GAME OVER"
            }


        };

        public static string[] Decrypted =
        {
            "TO WHOEVER FINDS THIS: It means I’m no longer here.\r\n" +
            "If you’re reading this, you’ve either received the confidential security key from me or taken it by force. " +
            "Regardless of how you got it, you need to read carefully. " +
            "Do not turn a blind eye to what’s happening at NeuroSync.\r\n" +
            "Throughout my time here, I’ve compiled irrefutable evidence—evidence of illegal human experimentation. " +
            "Hundreds of victims, unaware of their fate, have suffered in the name of \"progress.\"\r\n" +
            "This data must be released to the public. NeuroSync will not stop—they are relentless, driven by greed and the pursuit of experimental implants that line their investors’ pockets.\r\n" +
            "I have a family. You understand my position. Do the right thing."
        };

        public static string[] Encrypted =
        {
            "IF KWFSJSV DEGAU IWEU: Ei hszgu E’h gf rfgqsv wsvs.\r\n" +
            "Ed mfo’vs vszaegq iweu, mfo’js seiwsv vscsejsa iws cfgdeasgiezr uscoveim tsm dvfh hs fv iztsg ei xm dfvcs. " +
            "Vsqzvarsuu fd wfk mfo qfi ei, mfo gssa if vsza czvsdorrm. " +
            "Af gfi iovg z xrega sms if kwzi’u wznnsgegq zi GsovfUmgc.\r\n" +
            "Iwvfoqwfoi hm iehs wsvs, E’js cfhnersa evvsdoizxrs sjeasgcs—sjeasgcs fd errsqzr wohzg slnsvehsgiziefg. " +
            "Wogavsau fd jeciehu, ogzkzvs fd iwsev dzis, wzjs uoddsvsa eg iws gzhs fd \"nvfqvsuu.\"\r\n" +
            "Iweu aziz houi xs vsrszusa if iws noxrec. GsovfUmgc kerr gfi uifn—iwsm zvs vsrsgirsuu, avejsg xm qvssa zga iws novuoei fd slnsvehsgizr ehnrzgiu iwzi regs iwsev egjsuifvu’ nfctsiu.\r\n" +
            "E wzjs z dzherm. Mfo ogasvuizga hm nfueiefg. Af iws veqwi iwegq."
        };



        public static string[] Credits =
        {

                "created by: Marija Ilievska && Nikola Janev\n" +
                "art: Screenshots from Cyberpunk 2077\n" +
                "freepik: https://www.freepik.com/author/freepik\n"+
                "music: https://pixabay.com/users/nickpanek620-38266323/"

        };

        public static string[] Menu =
        {
            "r0gu3: Nothing stays hidden forever. Not from us, anyway. We need intel. You need money. Will you accept the mission?"
    };
            
    }
}
