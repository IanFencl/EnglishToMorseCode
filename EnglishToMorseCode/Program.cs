using System;

namespace EnglishToMorseCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var translations = new(string english, string morse)[]
            {
                ("a", ".-"),
                ("b", "-..."),
                ("c", "-.-."),
                ("d", "-.."),
                ("e", "."),
                ("f", "..-."),
                ("g", "--."),
                ("h", "...."),
                ("i", ".."),
                ("j", ".---"),
                ("k", "-.-"),
                ("l", ".-.."),
                ("m", "--"),
                ("n", "-."),
                ("o", "---"),
                ("p", ".--."),
                ("q", "--.-"),
                ("r", ".-."),
                ("s", "..."),
                ("t", "-"),
                ("u", "..-"),
                ("v", "...-"),
                ("w", ".--"),
                ("x", "-..-"),
                ("y", "-.--"),
                ("z", "--.."),
                ("0", "====="),
                ("1", ".----"),
                ("2", "..---"),
                ("3", "...--"),
                ("4", "....-"),
                ("5", "....."),
                ("6", "-...."),
                ("7", "--..."),
                ("8", "---.."),
                ("9", "----.")
            };

            //Asks for input from user
            Console.WriteLine("Enter text to translate, either Morse code OR English");

            //Grabs input and assigns to variable
            string input = Console.ReadLine().ToLower();
            int i = input.Length;
            string outputString = "";

            //Checks if input is blank and makes sure the first value is a letter or number
            if (input != "" && char.IsLetter(input[0]) || char.IsNumber(input[0]))
            {
                foreach (char c in input)
                {
                    for (int j = 0; j < translations.Length; j++)
                    {
                        if (translations[j].english == c.ToString())
                        {
                            outputString += translations[j].morse + " ";
                            break;
                        }
                    }
                }
            }

            //Gets kicked down here if morse code instead of letter or number
            else if (input != "" &&  !char.IsLetter(input[0]))
            {
                string[] morseInput = input.Split(' ');
                foreach (string morse in morseInput)
                {
                    for (int j = 0; j < translations.Length; j++)
                    {
                        if (translations[j].morse == morse)
                        {
                            outputString += translations[j].english + " ";
                            break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Output is blank or not recognized!");
            }
            Console.WriteLine("The output is: " + outputString + "\n" + "Press Enter to exit");
            Console.ReadLine();
        }
    }
}