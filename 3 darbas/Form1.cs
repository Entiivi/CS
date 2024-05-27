using System.Numerics;

namespace Praktinis3duomSaug
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void En_Click(object sender, EventArgs e)
        {
            string text;
            FileUtils fileUtils = new FileUtils();
            Sifravimas sifravimas = new Sifravimas();
            if (CheckIFfile.Checked)
            {
                // Read input text from file
                text = fileUtils.ReadInputTextFromFile(@"C:\\Users\\User\\Desktop\\2PROG-Prak\\Praktinis3duomSaug\\Plain_Text.txt");
                if (text == null)
                {
                    MessageBox.Show("Error reading input text from file.");
                    return;
                }
            }
            else
            {
                // Use text from the textbox
                text = prad.Text;
            }
            string result = sifravimas.Enc(text);
            isve.Text = result;
            fileUtils.save(result);
        }

        private void De_Click(object sender, EventArgs e)
        {
            Desifravimas desifravimas = new Desifravimas();
            string text = prad.Text;
            string result = desifravimas.Des(text);
            isve.Text = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!BigInteger.TryParse(p.Text, out BigInteger pValue) || !BigInteger.TryParse(q.Text, out BigInteger qValue))
            {
                MessageBox.Show("Invalid values for p and/or q.");
                return;
            }

            Raktai raktai = new Raktai();
            raktai.GenerateRaktai(pValue, qValue);
        }

    }
}
