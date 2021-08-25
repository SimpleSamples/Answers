using System;
using System.Collections.Generic;
using System.Windows.Forms;

// Generate a random string that wasn't previously generated c#
// https://docs.microsoft.com/en-us/answers/questions/527680/generate-a-random-string-that-wasn39t-previously-g.html

namespace GenerateRandom
{
    public partial class Form1 : Form
    {
        string[] validStrings = new string[] {
            "Banana",
            "Avocado",
            "Grape",
            "Apple",
            "Custard Apple",
            "Cranberry"
            };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rnd = new Random();
            List<string> unchosen = new List<string>(validStrings);
            while (unchosen.Count > 0)
                GenerateRandom(unchosen, rnd);
        }

        private void GenerateRandom(List<string> unchosen, Random rnd)
        {
            try
            {
                string result = unchosen[rnd.Next(0, unchosen.Count)];
                unchosen.Remove(result);
                listBox1.Items.Add(result);
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Error: {Ex.Message}");
            }
        }
    }
}