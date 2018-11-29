using System;

namespace RemoveDuplicatesInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Removal of duplicates in string!");
            Console.WriteLine("-------------------------------");

            Console.WriteLine("Enter the string with duplicates");
            String inputString = Console.ReadLine();
            String resultantString = GetDuplicatesRemovedString(inputString);
            Console.WriteLine();
            if (!string.IsNullOrEmpty(resultantString)){
                Console.WriteLine("---The resultant string is "+resultantString);
            }else {
                Console.WriteLine("Input string is empty!");
            }

            Console.ReadLine();
        }

        private static string GetDuplicatesRemovedString(String inputString) {
            if (string.IsNullOrEmpty(inputString)) {
                return inputString;
            }
            if (string.IsNullOrEmpty(inputString.Trim())) {
                return inputString.Trim();
            }
            char[] charArray = inputString.ToCharArray();
            Array.Sort(charArray);
            int newIndex = 0;
            for (int i = 0; i < charArray.Length; i++) {
                charArray[newIndex++] = charArray[i];
                while (i + 1 < charArray.Length && charArray[i] == charArray[i + 1]) {
                    i++;
                }
            }
            while (newIndex < charArray.Length) {
                charArray[newIndex++] = '\0';
            }
            return new string(charArray);
        }
    }
}
