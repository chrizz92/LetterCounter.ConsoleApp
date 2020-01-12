using System;

namespace LetterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText;
            int[] letterCount = new int[26];

            Console.WriteLine("Buchstabenzähler");
            Console.WriteLine("================");
            Console.Write("Bitte Text eingeben: ");
            inputText = Console.ReadLine().ToUpper();

            for (int i = 0; i < inputText.Length; i++)
            {
                if(inputText[i] >= 'A' && inputText[i] <= 'Z')
                {
                    letterCount[inputText[i] - 'A']++;
                }
            }

            for (int j = 0; j < letterCount.Length/2; j++)
            {
                Console.WriteLine("{0}:{1,3:D3}{2,6}:{3,3:D3}",(char)('A'+j), letterCount[j], (char)('N'+j), letterCount[j + (letterCount.Length / 2)]);
            }

        }
    }
}
