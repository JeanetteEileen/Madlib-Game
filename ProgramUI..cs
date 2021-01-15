using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    public class ProgramUI
    {
        public void Run()
        {
            Menu();            
        }

        static void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("\n\t\t\t----------------------\n" +
                "\t\t\t-------Madlibs!-------\n" +
                "\t\t\t----------------------");
                Console.WriteLine("\n\t\t\tSelect a story from the menu:\n\n" +
                   "\n\t\t\t1. Sir Conan Doyle\n" +
                   "\n\t\t\t2. Agatha Christe\n" +
                   "\n\t\t\t3. F. Scott Fitzgerald\n" +
                   "\n\t\t\t4. Exit Menu");

                var userChoice = int.Parse(TryAnswer());

                Console.WriteLine("\t\t\tPlease enter the appropriate words to create your MadLib.\n");
                switch (userChoice)
                {
                    case 1:
                        //call the SirConanDoyle Story
                        SirConanDoyle();
                        break;
                    case 2:
                        //call the AgathaChristie story
                        AgathaChristie();
                        break;
                    case 3:
                        //call the FScottFitzgerald story
                        FScottFitzgerald();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("\t\t\tThanks for playing... Bye!    Please press any key to continue");
                        keepRunning = false;
                        Console.Read();
                        break;
                    default:
                        Console.WriteLine("\t\t\tPlease enter a valid number.");
                        break;
                }
                Console.Clear();
            }
        }
        static void SirConanDoyle()
        {
            // user input
            Console.Write("\n\t\t\tPick a noun: ");
            var noun = TryAnswer();
            Console.Write("\n\t\t\tPick a adjective: ");
            var adjective = TryAnswer();
            Console.Write("\n\t\t\tPick another adjective: ");
            var adjective1 = TryAnswer();
            Console.Write("\n\t\t\tPick a being: ");
            var being = TryAnswer();
            Console.Write("\n\t\t\tPick a person: ");
            var person = TryAnswer();
            Console.Write("\n\t\t\tPick another noun: ");
            var noun1 = TryAnswer();
            Console.Write("\n\t\t\tPick another adjective: ");
            var adjective2 = TryAnswer();
            Console.Write("\n\t\t\tPick another noun: ");
            var noun2 = TryAnswer();
            Console.Write("\n\t\t\tPick another noun: ");
            var noun3 = TryAnswer();
            Console.Write("\nThey all agreed that it was a huge ");
            GetColor(noun);
            Console.Write(", ");
            GetColor(adjective);
            Console.Write(", ");
            GetColor(adjective1);
            Console.Write(", ");
            GetColor(being);
            Console.Write(".\n\nI have cross-examined these men, one of them a hard-headed ");
            GetColor(person);
            Console.Write(", one a moorland ");
            GetColor(noun1);
            Console.Write(", \n\nwho all tell the same story of this ");
            GetColor(adjective2);
            Console.Write(" ");
            GetColor(noun2);
            Console.Write(" exactly corresponding to the ");
            GetColor(noun3);
            Console.Write(" of the legend.\n\n");
            Console.WriteLine("please press any key to continue");
            Console.Read();
        }
        static void AgathaChristie()
        {
            //Get user inputs and show in another color
            Console.Clear();
            Console.Write("\n\t\t\tPick a City: ");
            Console.ForegroundColor = ConsoleColor.Green;
            var city20 = TryAnswer();
            Console.ResetColor();

            Console.Write("\n\t\t\tPick a past tense verb: ");
            var verb20 = TryAnswer();

            Console.Write("\n\t\t\tPick an noun: ");
            var noun20 = TryAnswer();

            Console.Write("\n\t\t\tPick adjective: ");
            var adjective20 = TryAnswer();

            Console.Write("\n\t\t\tPick a noun: ");
            var noun21 = TryAnswer();

            Console.Write("\n\t\t\tPick another noun: ");
            var noun23 = TryAnswer();

            Console.Write("\n\t\t\tPick a person: ");
            var person20 = TryAnswer();

            Console.Write("\n\t\t\tPick another passed tense verb: ");
            var verb21 = TryAnswer();

            Console.Write("\n\t\t\tPick a plural noun: ");
            var noun24 = TryAnswer();

            //add inputs to story and output the user input in a different color 
            Console.Write("\nThe Simplon Orient Express arrived at ");
            GetColor(city20);
            Console.Write(" at a quarter to nine that evening.\n\nIt was not due to depart again until 9:15, so Poirot ");
            GetColor(verb20);
            Console.Write(" to the ");
            GetColor(noun21);
            Console.Write(".\n\nHe did not, however, remain there long.\n\nThe cold was ");
            GetColor(adjective20);
            Console.Write(", and though the platform itself was protected, \n\nheavy ");
            GetColor(noun23);
            Console.Write(" was falling outside.\n\nHe returned to his compartment.\n\nThe ");
            GetColor(person20);
            Console.Write(", who was on the platform ");
            GetColor(verb21);
            Console.Write(" his feet and waving his ");
            GetColor(noun24);
            Console.Write(" to keep warm, spoke to him.\n\n");
            //send user back to the menu after viewing the madlib
            Console.WriteLine("please press any key to continue");
            Console.Read();
        }
        static void FScottFitzgerald()
        {
            //Get user inputs and show in another color
            Console.Clear();
            Console.Write("\n\t\t\tPick a city: ");
            var city30 = TryAnswer();

            Console.Write("\n\t\t\tPick a noun: ");
            var noun30 = TryAnswer();

            Console.Write("\n\t\t\tPick another noun: ");
            var noun31 = TryAnswer();

            Console.Write("\n\t\t\tPick a verb: ");
            var verb30 = TryAnswer();

            Console.Write("\n\t\t\tPick an adjective: ");
            var adjective30 = TryAnswer();

            Console.Write("\n\t\t\tPick another noun: ");
            var noun32 = TryAnswer();

            Console.Write("\n\t\t\tPick another noun: ");
            var noun33 = TryAnswer();

            Console.Write("\n\t\t\tPick another adjective: ");
            var adjective31 = TryAnswer();

            Console.Write("\n\t\t\tPick another verb: ");
            var verb31 = TryAnswer();

            Console.Write("\n\t\t\tPick a plural noun: ");
            var pluralNoun30 = TryAnswer();

            Console.Write("\n\t\t\tPick another adjective: ");
            var adjective32 = TryAnswer();

            //add inputs to story and output in another color 
            Console.Write("\n\nAbout half way between West Egg and ");
            GetColor(city30);
            Console.Write(" the ");
            GetColor(noun30);
            Console.Write(" hastily joins the ");
            GetColor(noun31);
            Console.Write("\n\nand runs beside it for a quarter of a mile so as to ");
            GetColor(verb30);
            Console.Write(" away from a certain ");
            GetColor(adjective30);
            Console.Write(" area of ");
            GetColor(noun32);
            Console.Write(".\n\nThis is a ");
            GetColor(noun33);
            Console.Write(" of ashes--a ");
            GetColor(adjective31);
            Console.Write(" farm where ashes ");
            GetColor(verb31);
            Console.Write(" like wheat into ");
            GetColor(pluralNoun30);
            Console.Write("\n\nand hills and ");
            GetColor(adjective31);
            Console.Write(" gardens.\n\n");
            //send user back to the menu after viewing the madlib
            Console.WriteLine("please press any key to continue");
            Console.Read();
        }
        public static string TryAnswer()
        {
            //This looks at the user input to be sure there is an answer and displays answer in anther color
            Console.ForegroundColor = ConsoleColor.Blue;
            var answer = Console.ReadLine();
            Console.ResetColor();
            while (answer == "")
            {
                Console.WriteLine("You didn't type anything");
                return Console.ReadLine();
            }
            return answer;
        }
        static void GetColor(string answer)
        {
            //this displays the user input in a different color when showing the story
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(answer);
            Console.ResetColor();
        }
    }

}

