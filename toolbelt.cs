namespace Tools
{
    public class toolbelt
    {
        public static string GetUserInputString(string prompt)
        {
            string returnValue = "";
            bool lryFlag = true;
            while (lryFlag)
            {
                try
                {
                    Console.Write(prompt);
                    string lryUserInputStr = Console.ReadLine();
                    if (lryUserInputStr == "")
                    {
                        throw new Exception("Empty input");
                    }
                    returnValue = lryUserInputStr;
                    lryFlag = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Value is not acceptable, please try again.");
                }
            }
            return returnValue;
        }

        public static float GetUserInputFloat(string prompt)
        {
            float returnValue = 0;
            bool lryFlag = true;
            while (lryFlag)
            {
                try
                {
                    Console.Write(prompt);
                    string lryUserInputStr = Console.ReadLine();
                    returnValue = float.Parse(lryUserInputStr);
                    lryFlag = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Value is not acceptable, please try again.");
                }
            }
            return returnValue;
        }

        public static int GetUserInputInt(string prompt)
        {
            int returnValue = 0;
            bool lryFlag = true;
            while (lryFlag)
            {
                try
                {
                    Console.Write(prompt);
                    string lryUserInputStr = Console.ReadLine();
                    returnValue = int.Parse(lryUserInputStr);
                    lryFlag = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Value is not acceptable, please try again.");
                }
            }
            return returnValue;
        }
    }
}