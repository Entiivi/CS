using System.Diagnostics;
using System.Numerics;
using System.Text;


namespace Praktinis3duomSaug
{
    public class Desifravimas : Form1
    {
        internal string Des(string text)
        {
            // Check if the ciphertext is empty or null
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Please enter ciphertext!");
                return null;
            }

            BigInteger n, d;
            if (!TryReadPrivateKeyFromFile(out n, out d))
            {
                MessageBox.Show("Error reading private key from file.");
                return null;
            }

            try
            {
                // Convert the ciphertext from Base64 string to byte array
                byte[] encryptedBytes = Convert.FromBase64String(text);

                // Decrypt each block separately
                List<byte[]> decryptedBlocks = new List<byte[]>();
                int blockSize = (int)Math.Ceiling(BigInteger.Log(n, 256)); // Calculate byte length for BigInteger

                for (int i = 0; i < encryptedBytes.Length; i += blockSize)
                {
                    int blockLength = Math.Min(blockSize, encryptedBytes.Length - i);
                    byte[] block = new byte[blockLength];
                    Array.Copy(encryptedBytes, i, block, 0, blockLength);

                    // Decrypt the block
                    BigInteger encryptedBigInt = new BigInteger(block);
                    BigInteger decryptedBigInt = BigInteger.ModPow(encryptedBigInt, d, n);

                    // Convert decrypted BigInteger to byte array
                    byte[] decryptedBlock = decryptedBigInt.ToByteArray();

                    // Reverse padding
                    if (decryptedBlock.Length < blockSize)
                    {
                        decryptedBlock = decryptedBlock.Reverse().ToArray();
                    }

                    decryptedBlocks.Add(decryptedBlock);
                }

                // Combine decrypted blocks into a single byte array
                byte[] decryptedBytes = decryptedBlocks.SelectMany(b => b).ToArray();

                // Convert the decrypted bytes to string using ASCII encoding
                string plaintext = Encoding.ASCII.GetString(decryptedBytes);

                // Filter only ASCII characters from 32 to 126
                plaintext = new string(plaintext.Where(c => c >= 32 && c <= 126).ToArray());

                return plaintext;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during decryption: " + ex.Message);
                return null;
            }
        }

        private bool TryReadPrivateKeyFromFile(out BigInteger n, out BigInteger d)
        {
            n = BigInteger.Zero;
            d = BigInteger.Zero;
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
                    if (line.StartsWith("Private Key"))
                    {
                        // Split the line by the colon ':' and extract the second part
                        string[] parts = line.Split(':');
                        if (parts.Length == 2)
                        {
                            // Split the second part by the comma ',' and extract n and d values
                            string[] keyParts = parts[1].Trim().Split(',');
                            if (keyParts.Length == 2 && BigInteger.TryParse(keyParts[0].Trim(), out n) && BigInteger.TryParse(keyParts[1].Trim(), out d))
                            {
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("Invalid format for private key in keys.txt file.");
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid format for private key in keys.txt file.");
                            return false;
                        }
                    }
                }
                MessageBox.Show("Private Key not found in keys.txt file.");
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

