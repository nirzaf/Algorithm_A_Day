using System;

namespace Algorithm_A_Day.RandomEasy
{
    public class GoalParserInterpretationLc1678E
    {
        public string Interpret(string command)
        {
            if (command == null || command.Length == 0) return "";

            string result = "";
            int current = 0;
            while (current <= command.Length - 1)
            {
                if (command.Substring(current, 1) == "G")
                {
                    result += "G";
                    current += 1;
                }
                else if (command.Substring(current, 2) == "()")
                {
                    result += "o";
                    current += 2;
                }
                else
                {
                    result += "al";
                    current += 4;
                }
            }

            return result;
        }

        // linq 
        public string Interpret2(string command) => command.Replace("(al)", "al").Replace("()", "o");

        // just nice 
        public string Interpret3(string command)
        {
            string result = String.Empty;
            string currentString = String.Empty;
            foreach (char c in command)
            {
                currentString = currentString + c.ToString();
                if (IsG(currentString))
                {
                    result = result + currentString;
                    currentString = String.Empty;
                }
                else if (IsO(currentString))
                {
                    result = result + "o";
                    currentString = String.Empty;
                }
                else if (IsAl(currentString))
                {
                    result = result + "al";
                    currentString = String.Empty;
                }
            }
            return result;
        }
        private bool IsG(string value)
        {
            return (value == "G");
        }

        private bool IsO(string value)
        {
            return (value == "()");
        }

        private bool IsAl(string value)
        {
            return (value == "(al)");
        }
    }
}
