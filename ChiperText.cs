using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CeaserChiper;
using System.Windows.Forms;

namespace CeaserChiper
{
    internal class ChiperText
    {
        public Alphabet ChiperGivenText(Alphabet alphabet, int _rotIndex)
        {
            char LetterRotted;

            foreach (var letter in alphabet.PlainTextChar)
            {
                if (char.IsLetter(letter) || char.IsWhiteSpace(letter))
                {
                    LetterRotted = _GetRotOfText(letter, alphabet, _rotIndex);
                    alphabet.PlainTextWithLetterAndSpace += LetterRotted.ToString();
                }
                Application.DoEvents();
            }

            return alphabet;
            //TextBox _tbxPlainText = Application.OpenForms["Form1"].Controls["tbxChiperText"] as TextBox;
        }

        public char _GetRotOfText(char _letter, Alphabet alphabet, int _rotIndex)
        {
            for (int i = 0; i < 29; i++)
            {
                if (_letter == alphabet.ChiperLetterTable[i])
                {
                    _letter = alphabet.ChiperLetterTable[i + _rotIndex];
                    break;
                }
            }

            return _letter;
        }
    }
}