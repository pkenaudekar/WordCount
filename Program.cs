using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string _sentance,_word = null;
            int frequency = 0, i;
            char[] spearator = { ',', ' ', '!', '?', '.', ';', '*', '/'};

            Console.WriteLine("Enter a sentance:");
            _sentance = Console.ReadLine();

            Console.WriteLine("\nYou entered '{0}'", _sentance);

            //converting all words to Lower case
            _sentance = _sentance.ToLower();

            //Splits the sentance into words based on seperators and saves it in stringList array
            String[] stringList = _sentance.Split(spearator);
            List<String> wordList = new List<String>();
            
            foreach (String s in stringList)
            {                
                int count = 0;
                for (i = 0; i < stringList.Length; i++)
                {
                    // if match found increase count to record occurense of word
                    if (s.Equals(stringList[i]))
                        count++;
                }

                //Listing words from the sentence in a non repeating manner 
                Boolean foundWord = false;
                if (wordList != null)
                {
                    foreach (String w in wordList)
                    {
                        if (s.Equals(w))
                        {
                            foundWord = true;
                            break;
                        }
                    }                    
                }
                
                if(foundWord == false && s !="")
                {                    
                    wordList.Add(s);                   
                    Console.WriteLine("{0} - {1}", s, count);
                    if (count > frequency)
                    {
                        frequency = count;
                        _word = s;
                    }
                }    
            }
            Console.WriteLine("\nThe word with highest frequence of occurance is '{0}' with {1} occurance",_word,frequency);
            Console.ReadKey();
        }
    }
}
