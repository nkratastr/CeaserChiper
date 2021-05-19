using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CeaserChiper;

namespace CeaserChiper
{
    public class Alphabet
    {
        public int counter = 0;
        public string TurkishAlphabet = "abcçdefgğhıijklmnoöprsştuüvyz";
        public string ChiperLetterTable = "abcçdefgğhıijklmnoöprsştuüvyzabcçdefgğhıijklmnoöprsştuüvyz";
        public string PlainText;
        public char[] PlainTextChar;
        public string PlainTextWithLetterAndSpace;
        public Dictionary<char, float> LetterFrequency = new Dictionary<char, float>() { { 'a', 11.92F }, { 'b', 2.84F }, { 'c', 0.96F }, { 'ç', 1.16F }, { 'd', 4.71F }, { 'e', 8.91F }, { 'f', 0.46F }, { 'g', 1.25F }, { 'ğ', 1.13F }, { 'h', 1.21F }, { 'ı', 5.11F }, { 'i', 8.60F }, { 'j', 0.03F }, { 'k', 4.68F }, { 'l', 5.92F }, { 'm', 3.75F }, { 'n', 4.49F }, { 'o', 2.48F }, { 'ö', 0.78F }, { 'p', 0.89F }, { 'r', 6.72F }, { 's', 3.01F }, { 'ş', 1.78F }, { 't', 3.01F }, { 'u', 3.24F }, { 'ü', 1.85F }, { 'v', 0.96F }, { 'y', 3.34F }, { 'z', 1.50F } };
        public Dictionary<char, int> LetterCount = new Dictionary<char, int>() { { 'a', 0 }, { 'b', 0 }, { 'c', 0 }, { 'ç', 0 }, { 'd', 0 }, { 'e', 0 }, { 'f', 0 }, { 'g', 0 }, { 'ğ', 0 }, { 'h', 0 }, { 'ı', 0 }, { 'i', 0 }, { 'j', 0 }, { 'k', 0 }, { 'l', 0 }, { 'm', 0 }, { 'n', 0 }, { 'o', 0 }, { 'ö', 0 }, { 'p', 0 }, { 'r', 0 }, { 's', 0 }, { 'ş', 0 }, { 't', 0 }, { 'u', 0 }, { 'ü', 0 }, { 'v', 0 }, { 'y', 0 }, { 'z', 0 } };
        public Dictionary<char, float> GivenTextFrequency = new Dictionary<char, float>();
    }
}