using System.Security.Cryptography;
using System.Text;

namespace CS_4_Darbas
{
    public partial class Form1 : Form
    {

        private RSACryptoServiceProvider rsa;
        private string publicKey;
        private string privateKey;
        public Form1()
        {
            InitializeComponent();
            InitializeRSAKeys();
        }

        private void InitializeRSAKeys()
        {
            rsa = new RSACryptoServiceProvider(2048);
            publicKey = rsa.ToXmlString(false); // public key
            privateKey = rsa.ToXmlString(true); // private key
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                string inputText = richTextBox1.Text;
                string signature = GenerateSignature(inputText);
                textBox3.Text = signature;
            }
            else { MessageBox.Show("Iveskite tekstą"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string inputText = richTextBox2.Text;
            string signature = textBox3.Text;
            bool isVerified = VerifySignature(inputText, signature);
            MessageBox.Show(isVerified ? "Signature Verified" : "Signature Not Verified");
        }

        private string GenerateSignature(string inputText)
        {
            byte[] data = Encoding.UTF8.GetBytes(inputText);
            byte[] hash = SHA256.Create().ComputeHash(data);
            byte[] signature = rsa.SignHash(hash, CryptoConfig.MapNameToOID("SHA256"));
            return Convert.ToBase64String(signature);
        }
        private bool VerifySignature(string inputText, string signature)
        {
            try
            {
                byte[] data = Encoding.UTF8.GetBytes(inputText);
                byte[] hash = SHA256.Create().ComputeHash(data);
                byte[] signatureBytes = Convert.FromBase64String(signature);
                return rsa.VerifyHash(hash, CryptoConfig.MapNameToOID("SHA256"), signatureBytes);
            }
            catch (Exception ex) { return false; }
        }
        /*
         Skaitmeninio parašo schemos paaiškinimas

            1. Rakto generavimas

                RSA raktai generuojami naudojant RSACryptoServiceProvider.

                PublicKey naudojamas parašui patikrinti, o PrivateKey - pasirašyti.

            2. Skaitmeninio parašo kūrimas

                Įvesties tekstas suglaudinamas naudojant SHA-256.

                Skaitmeniniam parašui sukurti hash užšifruojamas privačiuoju raktu.

                Parašas rodomas kaip Base64 koduojama eilutė.

            3. Skaitmeninio parašo tikrinimas

                Įvesties tekstas sugretinamas naudojant SHA-256.

                Parašas iššifruojamas naudojant viešąjį raktą, kad būtų gautas originalus hash.

                Jei hešai sutampa, parašas patikrinamas.
         */
    }
}
