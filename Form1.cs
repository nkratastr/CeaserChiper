using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CeaserChiper;

namespace CeaserChiper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbxPlainText.Text = "Write or copy your plain text here...";
        }

        public int _rotIndex = 0;

        public void btnChiper_Click(object sender, EventArgs e)
        {
            ChiperText chiperText = new ChiperText { };
            Alphabet alphabet = new Alphabet();
            _rotIndex = lbxCeaserRotIndex.SelectedIndex >= 0 ? lbxCeaserRotIndex.SelectedIndex + 1 : 0;

            alphabet.PlainTextChar = tbxPlainText.Text.ToLower().ToCharArray();
            alphabet = chiperText.ChiperGivenText(alphabet, _rotIndex);
            tbxChiperText.Text = alphabet.PlainTextWithLetterAndSpace;
        }

        public void btnDechiper_Click(object sender, EventArgs e)
        {
            Alphabet alphabet = new Alphabet();
            DechiperText dechiperText = new DechiperText();
            _rotIndex = lbxCeaserRotIndex.SelectedIndex >= 0 ? lbxCeaserRotIndex.SelectedIndex + 1 : 0;
            _rotIndex = 0 - _rotIndex;

            alphabet.PlainTextChar = tbxChiperText.Text.ToLower().ToCharArray();
            alphabet = dechiperText.DechiperGivenText(alphabet, _rotIndex);
            tbxPlainText.Text = alphabet.PlainTextWithLetterAndSpace;
        }

        private void btnDrawGraph_Click(object sender, EventArgs e)
        {
            Alphabet alphabet = new Alphabet();
            Frequency frequency = new Frequency();
            alphabet.PlainTextChar = tbxChiperText.Text.ToLower().ToCharArray();

            alphabet = frequency.Count(alphabet);
            alphabet = frequency.GetFrequency(alphabet);
            DrawGraphic(alphabet);
        }

        public void DrawGraphic(Alphabet alphabet)
        {
            foreach (var series in chrtCeaserChiperFreqency.Series)
            {
                series.Points.Clear();
            }
            // Clearing the graph before reuse or use.

            foreach (KeyValuePair<char, float> kvp in alphabet.LetterFrequency)
            {
                chrtCeaserChiperFreqency.Series["Turkish General"].Points.Add(kvp.Value).Label = kvp.Key.ToString();

                chrtCeaserChiperFreqency.Series["Given Text"].Points.Add(alphabet.GivenTextFrequency[kvp.Key]).Label = kvp.Key.ToString();
            }
        }
    }
}