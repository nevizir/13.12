using System;
using System.Text.RegularExpressions;

namespace _13._12
{

    internal class Program
    {

        static void Main(string[] args)
        {
            string[] str = { "add123zbc446", "ber500hek800", "ssssere5ggg095", "BMW", "msm003ked344", "Rdmn", "hgsfv383hhd333" };
            string[] digits = { "1799", "2430", "86454", "2300", "94264" };

            // Task 1
            Console.WriteLine("Check for four-digit numbers ::");
            foreach (string s in digits)
            {
                Console.WriteLine("{0} {1} a valid digit.", s,
                IsValidNumber(s) ? "is" : "is not");
            }
            // Task 2
            Console.WriteLine("\nCheck for string example(asd123zxc456) ::");
            foreach (string s in str)
            {
                Console.WriteLine("{0} {1} a valid.", s,
                isValidString(s) ? "is" : "is not");
            }
            // Task 3
            Console.WriteLine("\nCheck for abbreviation ::");
            foreach (string s in str)
            {
                Console.WriteLine("{0} {1} a valid.", s,
                isAbbreviation(s) ? "is" : "is not");
            }
            // Task 4
            Console.WriteLine("\nCheck for date ::");
            foreach (string s in digits)
            {
                Console.WriteLine("{0} {1} a valid.", s,
                IsValidDate(s) ? "is" : "is not");
            }
        }
        // Task 4
        public static bool IsValidDate(string date)
        {
            string dateRegex = @"^(19|20)\d{2}$";

            Regex rex = new Regex(dateRegex);
            if (rex.IsMatch(date))
                return (true);
            else
                return (false);
        }
        // Task 3
        public static bool isAbbreviation(string text)
        {
            string strRegex = @"^[A-Z]{3}$";

            Regex rex = new Regex(strRegex);
            if (rex.IsMatch(text))
                return (true);
            else
                return (false);
        }
        // Task 2
        public static bool isValidString(string word)
        {
            string strRegex = @"^\w{3}\d{3}\w{3}\d{3}";

            Regex rex = new Regex(strRegex);
            if (rex.IsMatch(word))
                return (true);
            else
                return (false);
        }
        // Task 1
        public static bool IsValidNumber(string number)
        {
            string fourNummRegex = @"(^[0-9]{4}$)";

            Regex rex = new Regex(fourNummRegex);
            if (rex.IsMatch(number))
                return (true);
            else
                return (false);
        }
    }
}
