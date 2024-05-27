using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Praktinis_Informacijos_saugumas
{
    public partial class Form1 : Form
    {
            public Form1()
            {
                InitializeComponent();
            }

      
            private string selectedMode = "ECB";


            private string Encrypt(string plaintext, string key)
            {
            try {
                if (key.Length != 8)
                {
                    MessageBox.Show("Raktas turi buti 8 symbliu ilgio.", "O ne kazkas blogai!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return string.Empty;
                }
                byte[] keyBytes = Encoding.ASCII.GetBytes(key);
                byte[] iv = new byte[8];

                byte[] plaintextBytes = Encoding.ASCII.GetBytes(plaintext);
                byte[] encryptedBytes;

                using (DES des = DES.Create())
                {
                    des.Mode = GetCipherMode(selectedMode);
                    des.Key = keyBytes;
                    des.IV = iv;

                    using (ICryptoTransform encryptor = des.CreateEncryptor())
                    {
                        encryptedBytes = encryptor.TransformFinalBlock(plaintextBytes, 0, plaintextBytes.Length);
                    }
                }

                return Convert.ToBase64String(encryptedBytes);
                }
            catch ( CryptographicException ex)
            {
                MessageBox.Show("Kazkas blogai ivyko sifruojant informacija: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
                
            }

            private string Decrypt(string ciphertext, string key)
            {
            try
            {
                if (key.Length != 8)
                {
                    MessageBox.Show("Raktas turi buti 8 symbliu ilgio.", "O ne kazkas blogai!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return string.Empty;
                }
                byte[] keyBytes = Encoding.ASCII.GetBytes(key);
                byte[] iv = new byte[8];

                byte[] encryptedBytes = Convert.FromBase64String(ciphertext);
                byte[] decryptedBytes;

                using (DES des = DES.Create())
                {
                    des.Mode = GetCipherMode(selectedMode);
                    des.Key = keyBytes;
                    des.IV = iv;

                    using (ICryptoTransform decryptor = des.CreateDecryptor())
                    {
                        decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
                    }
                }

                return Encoding.ASCII.GetString(decryptedBytes);
            }
            catch(CryptographicException ex)
            {
                MessageBox.Show("Kazkas blogai ivyko desifruojant informacija: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
               
            }

            private CipherMode GetCipherMode(string mode)
            {
                switch (mode)
                {
                    case "ECB":
                        return CipherMode.ECB;
                    case "CBC":
                        return CipherMode.CBC;
                    case "CFB":
                        return CipherMode.CFB;
                    default:
                        return CipherMode.ECB;
                }
            }


        private void radioButtonCBC_CheckedChanged(object sender, EventArgs e)
        {
            selectedMode = "CBC";
        }

        private void radioButtonECB_CheckedChanged(object sender, EventArgs e)
        {
            selectedMode = "ECB";
        }

        private void radioButtonCFB_CheckedChanged(object sender, EventArgs e)
        {
            selectedMode = "CFB";
        }

        private void Enc_Click(object sender, EventArgs e)
        {
            string plaintext = PraT.Text;
            string key = Key.Text;

            string encryptedText = Encrypt(plaintext, key);

            RezT.Text = encryptedText;
        }

        private void Dec_Click(object sender, EventArgs e)
        {
            string ciphertext = PraT.Text;
            string key = Key.Text;

            string decryptedText = Decrypt(ciphertext, key);

            RezT.Text = decryptedText;
        }

        private void SkaitytiIsFile(string filevieta)
        {
            try
            {
                if (!File.Exists(filevieta))
                {
                    MessageBox.Show("Nurodytoje vietoje filo nera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string text = File.ReadAllText(filevieta);
                PraT.Text = text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kazkas blogai ivyko skaitant file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void RasytiFile(string filevieta)
        {
            try
            {
                string text = RezT.Text;
                File.WriteAllText(filevieta, text);
                MessageBox.Show("Irasyta i faila.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kazkas blogai ivyko skaitant file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filevieta =@"C:\Users\s047792\Desktop\123.txt";
            SkaitytiIsFile(filevieta);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filevieta =@"C:\Users\s047792\Desktop\123.txt";
            RasytiFile(filevieta);

        }
    }
}

