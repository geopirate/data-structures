using System;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playing = true;
            while (playing)
            {
                Console.WriteLine("please enter the string you want to reverse");
                string theString = Console.ReadLine();
                StringReverser(theString);
                //StringReverser2(theString);
                Console.WriteLine();
                Console.Write("If you would you like to try again, please type y.   ");
                
                playing = Question();
            }
            Console.Read();
        }
        // this is my preferred, simpler implementation
        private static void StringReverser(string theString)
        {
            int length = theString.Length;
            string newString = "";
            for (int x = length - 1; x >= 0; x--)
            {
                newString += theString[x];
            }
            Console.WriteLine(newString);
        }
        //  This is an alternative implementation using a char array 
        /*
        private static void StringReverser2(string theString)
        {
            char[] charArray = theString.ToCharArray();
            int length = charArray.Length;
            string newString = "";
            for (int x = length - 1; x >= 0; x--)
            {
                newString += charArray[x];
            }
            Console.WriteLine(newString);
        }*/
        static bool Question()
        {
            string answer = Console.ReadLine();
            if (answer == "y" || answer == "Y")
            {
                Console.WriteLine();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}