using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace Praktinis3duomSaug
{
    public partial class Sifravimas : Form1
    {
        internal string Enc(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Please enter plaintext!");
                return null;
            }

            // Filter only ASCII characters from 32 to 126
            text = new string(text.Where(c => c >= 32 && c <= 126).ToArray());

            // Read public key from file
            BigInteger e2, publicKeyN;
            if (!TryReadPublicKeyFromFile(out e2, out publicKeyN))
            {
                MessageBox.Show("Error reading public key from file.");
                return null;
            }

            byte[] bytes = Encoding.ASCII.GetBytes(text);
            BigInteger[] encryptedMessage = new BigInteger[bytes.Length];
            for (int i = 0; i < bytes.Length; i++)
            {
                encryptedMessage[i] = BigInteger.ModPow(bytes[i], e2, publicKeyN);
            }
            string encryptedText = Convert.ToBase64String(encryptedMessage.SelectMany(x => x.ToByteArray()).ToArray());
            return encryptedText;
        }

        private bool TryReadPublicKeyFromFile(out BigInteger e2, out BigInteger publicKeyN)
        {
            e2 = BigInteger.Zero;
            publicKeyN = BigInteger.Zero;
            try
            {
                string filePath = "keys.txt";
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("File 'keys.txt' does not exist in the application directory.");
                    return false;
                }

                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    Debug.WriteLine("Reading line: " + line);
                    if (line.StartsWith("Public Key"))
                    {
                        // Split the line by the colon ':' and extract the second part
                        string[] parts = line.Split(':');
                        if (parts.Length == 2)
                        {
                            // Split the second part by the comma ',' and extract n and e values
                            string[] keyParts = parts[1].Trim().Split(',');
                            if (keyParts.Length == 2 && BigInteger.TryParse(keyParts[0].Trim(), out publicKeyN) && BigInteger.TryParse(keyParts[1].Trim(), out e2))
                            {
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("Invalid format for public key in keys.txt file.");
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid format for public key in keys.txt file.");
                            return false;
                        }
                    }
                }
                MessageBox.Show("Public Key not found in keys.txt file.");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading keys from file: " + ex.Message);
                return false;
            }
        }

    }
}
