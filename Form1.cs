using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace QwertyEncryption
{
    public partial class Form1 : Form
    {
        private QtoE qtoE = new QtoE();

        public Form1()
        {
            InitializeComponent();
        }

        public string EnglishText;
        public string QwertyText;
        public StringBuilder Translation = new StringBuilder();

        private void English_TextChanged(object sender, EventArgs e)
        {
            EnglishText = English.Text;
        }

        private void Qwerty_TextChanged(object sender, EventArgs e)
        {
            QwertyText = Qwerty.Text;
        }
        private async void EncryptButton_Click(object sender, EventArgs e)
        {
            Translation.Clear();
            errorLabel.Text = "";

            // Check if both fields are empty
            if (string.IsNullOrEmpty(EnglishText) && string.IsNullOrEmpty(QwertyText))
            {
                errorLabel.Text = "Both fields are empty!";
                return; // Exit early if both fields are empty
            }

            // If EnglishText is not empty, process it
            if (!string.IsNullOrEmpty(EnglishText))
            {
                try
                {
                    for (int i = 0; i < EnglishText.Length; i++)
                    {
                        char c = EnglishText[i];

                        if (qtoE.KeyValuePairs.TryGetValue(c, out char translatedChar))
                        {
                            Translation.Append(translatedChar);
                        }
                        else
                        {
                            Translation.Append('?');
                            throw new Exception("Use UPPERCASE letters only!");
                        }
                    }
                    Qwerty.Text = Translation.ToString();
                    return; // Exit after processing EnglishText
                }
                catch (Exception ex)
                {
                    errorLabel.Text = ex.Message;
                }
            }

            // If EnglishText is empty, process QwertyText
            if (!string.IsNullOrEmpty(QwertyText))
            {
                try
                {
                    for (int i = 0; i < QwertyText.Length; i++)
                    {
                        char c = QwertyText[i];

                        if (qtoE.ReversedKeyValuePairs.TryGetValue(c, out char translatedChar))
                        {
                            Translation.Append(translatedChar);
                        }
                        else
                        {
                            Translation.Append('?');
                            throw new Exception("Use UPPERCASE letters only!");
                        }
                    }
                    English.Text = Translation.ToString();
                }
                catch (Exception ex)
                {
                    errorLabel.Text = ex.Message;
                }
            }
        }



        private void HelpButton_Click(object sender, EventArgs e)
        {
            Form2 MyForm = new Form2();
            MyForm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class QtoE
    {
        public SortedDictionary<char, char> KeyValuePairs { get; private set; } 
        public SortedDictionary<char, char> ReversedKeyValuePairs { get; private set; }

        public QtoE()
        {
            KeyValuePairs = new SortedDictionary<char, char>();
            KeyValuePairs.Add('Q', '1');
            KeyValuePairs.Add('W', '2');
            KeyValuePairs.Add('E', '3');
            KeyValuePairs.Add('R', '4');
            KeyValuePairs.Add('T', '5');
            KeyValuePairs.Add('Y', '6');
            KeyValuePairs.Add('U', '7');
            KeyValuePairs.Add('I', '8');
            KeyValuePairs.Add('O', '9');
            KeyValuePairs.Add('P', '0');
            KeyValuePairs.Add('A', 'Q');
            KeyValuePairs.Add('S', 'W');
            KeyValuePairs.Add('D', 'E');
            KeyValuePairs.Add('F', 'R');
            KeyValuePairs.Add('G', 'T');
            KeyValuePairs.Add('H', 'Y');
            KeyValuePairs.Add('J', 'U');
            KeyValuePairs.Add('K', 'I');
            KeyValuePairs.Add('L', 'O');
            KeyValuePairs.Add('Z', 'A');
            KeyValuePairs.Add('X', 'S');
            KeyValuePairs.Add('C', 'D');
            KeyValuePairs.Add('V', 'F');
            KeyValuePairs.Add('B', 'G');
            KeyValuePairs.Add('N', 'H');
            KeyValuePairs.Add('M', 'J');
            KeyValuePairs.Add(' ', ' ');

            ReversedKeyValuePairs = new SortedDictionary<char, char>();
            foreach (var pair in KeyValuePairs)
            {
                ReversedKeyValuePairs.Add(pair.Value, pair.Key);
            }
        }
    }
}
