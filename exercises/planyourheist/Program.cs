using System;
using System.Collections.Generic;

namespace planyourheist {
    class Program {
        private const string Value = "💰";

        static void Main (string[] args)

        // At the beginning of the program, prompt the user to enter the difficulty level of the bank.

        {

            Console.WriteLine ("Plan Your Heist!"); {

                // Console.WriteLine ("Plan Your Heist!");
                Console.Write ("What is Bank's difficulty level? ( 1- 100)");

                string bankDifficultyString = Console.ReadLine ();

                List<Dictionary<string, string>> team = new List<Dictionary<string, string>> ();

                //Store a value for the bank's difficulty level. Set this value to 100.
                int bankDifficulty = int.Parse (bankDifficultyString);

                while (true) {

                    Dictionary<string, string> teamMember = new Dictionary<string, string> ();

                    Console.Write ("Enter a team member's name - ");
                    string name = Console.ReadLine ();
                    // Console.WriteLine ("You entered '{0}'", name);

                    // stops the while loop if the name is blank
                    if (name == "") {
                        break;
                    }

                    Console.Write ("Enter a team member's skill level - ");
                    string skill = Console.ReadLine ();
                    // Console.WriteLine ("You entered '{0}'", skill);

                    Console.Write ("Enter a team member's courage factor - decimal between 0.0 and 2.0. ");
                    string courage = Console.ReadLine ();
                    // Console.WriteLine ("You entered '{0}'", courage);

                    //Display the team member's information.
                    teamMember.Add ("Name", name);
                    teamMember.Add ("Skill Level", skill);
                    teamMember.Add ("Courage Factor", courage);

                    // add TeamMember people to Team
                    team.Add (teamMember);

                    Console.Clear ();

                    // displays total team memebr count
                    Console.WriteLine ($"Team has {team.Count} members");

                    // Display a message containing the number of members of the team.
                    // Displays team mmber info - phase 3 says remove
                    // foreach (KeyValuePair<string, string> attribute in teamMember) {

                    //     Console.WriteLine ($"{attribute.Key}: {attribute.Value}");

                    // }

                }

                // SUM of team member skill sets
                // Sum the skill levels of the team. Save that number.
                // debugger at 17.55 min vid 3
                int combinedSkillLevel = 0;

                foreach (Dictionary<string, string> teamMember in team) {

                    int skillLevelInt = int.Parse (teamMember["Skill Level"]);
                    combinedSkillLevel += skillLevelInt;
                }

                // To run simulation several times
                Console.WriteLine ("How many times should we run the simulation?");
                int timesToRepeat = int.Parse (Console.ReadLine ());

                Console.Clear ();
                for (int i = 0; i < timesToRepeat; i++) {

                    // }
                    // Phase 4
                    // Create a random number between -10 and 10 for the heist's luck value.
                    // Add this number to the bank's difficulty level.
                    // Before displaying the success or failure message, display a report that shows.
                    // The team's combined skill level
                    // The bank's difficulty level

                    Random randy = new Random ();
                    int luckValue = randy.Next (-10, 11);

                    int totalBankDifficulty = bankDifficulty + luckValue;

                    Console.WriteLine ($"Combined skill level: {combinedSkillLevel}");
                    Console.WriteLine ($"Bank Difficulty level TOT: {totalBankDifficulty}");
                    // Console.WriteLine ("************************************************************");

                    // Compare the number with the bank's difficulty level. If the team's skill level is greater than 
                    // or equal to the bank's difficulty level, Display a success message, otherwise display a failure message.
                    if (combinedSkillLevel >= totalBankDifficulty) {
                        Console.WriteLine ("💰💰💰💰💰💰");
                        Console.WriteLine ("Bags of Money!");
                        Console.WriteLine ("************************************************************");
                    } else {

                        Console.WriteLine ("🚨🚨🚨🚨🚨🚨");
                        Console.WriteLine ("Go to JAIL!!!");
                        Console.WriteLine ("************************************************************");
                    }

                }

            }
        }
    }
}