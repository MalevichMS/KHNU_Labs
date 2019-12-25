using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringsTasks_Lab3
{
    public class StringManipulator
    {
        public string Str { get; private set; }

        public int Length{ get; private set; }

        public StringManipulator(string _str)
        {
            Str = _str;
            Length = Str.Length;
            
        }

        public int CountOfLikeSecndLetterOfFrstWord()
        {
            string word = Str.Split(' ')[0];
            return Str.Where(x => x == word.ElementAt(1)).Count() - 1;
        }

        public void InsertMinusBetweenLetters()
        {
            string[] words = Str.Split(' ');
            string word1 = Regex.Replace(words[0], @"(?<=.)(?!$)", "-");
            string word2 = Regex.Replace(words[1], @"(?<=.)(?!$)", "-");
            Str = Str.Replace(words[0], word1);
            Str = Str.Replace(words[1], word2);  
        }

        public void ReplaceVowelsToUpper()
        {
            string vowels = "aeioyu";
            string[] words = Str.Split();
            string word3 = words[2];

            foreach (var x in vowels)
                word3 = word3.Replace(x.ToString(), x.ToString().ToUpper());

            Str = Str.Replace(words[2], word3);
        }

        public int ThirdWordCount()
        {
            return Str.Split()[2].Count();
        }
    }
}
