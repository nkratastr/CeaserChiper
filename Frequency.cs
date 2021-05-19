using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeaserChiper
{
    internal class Frequency
    {
        public Alphabet Count(Alphabet alphabet)
        {
            foreach (var letter in alphabet.PlainTextChar)
            {
                if (alphabet.LetterCount.ContainsKey(letter))
                {
                    alphabet.LetterCount[letter]++;
                    alphabet.counter++;
                }
            }

            return alphabet;
        }

        public Alphabet GetFrequency(Alphabet alphabet)
        {
            foreach (KeyValuePair<char, int> kvp in alphabet.LetterCount)
            {
                alphabet.GivenTextFrequency.Add(kvp.Key, Convert.ToSingle(kvp.Value) / alphabet.counter * 100);
            }

            return alphabet;
        }
    }
}