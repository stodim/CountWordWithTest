using System;
using System.Collections.Generic;
using System.Linq;

namespace CountWords
{
    class Program
    {
        static void Main(string[] args)
        {

           var outProcessedWords =  DoCount(args);
            if (outProcessedWords != null)
            {
                foreach (var item in outProcessedWords)
                {
                    Console.WriteLine(String.Format("{0} - {1}", item.Key, item.Value));
                }
            }
            else
            {
                Console.WriteLine("No input ...");
            }
            Console.ReadLine();
        }

        private static Dictionary<string, int>  DoCount(string[] args)
        {
            if (args == null ||  !args.Any())
            {
                return null;
            }

            var splitChar = new char[] {' ', '.', ',', ':', '—', '?', '!', '\r', '\n'};
                //{' ', '.', ',', ':', '—', '?', '!', '\r', '\n'

            string[] outWords = args[0].Split(splitChar);
            var outProcessedWords = new Dictionary<string, int>();

            foreach (var word in outWords)
            {
                var item = word.Trim().ToLower();

                if (item.Length != 0)
                {
                    if (outProcessedWords.ContainsKey(item))
                        outProcessedWords[item] += 1;
                    else
                        outProcessedWords[item] = 1;
                }
            }

            return outProcessedWords;

           
        }
    }
}
