using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _5_Darbas
{
    public partial class Pagrindinis : Form
    {
        private const string FilePath = "C:\\Users\\User\\Desktop\\Projects\\CS\\5 Darbas\\passwords.txt";
        private const string EncryptedFilePath = "C:\\Users\\User\\Desktop\\Projects\\CS\\5 Darbas\\passwords_encrypted.txt";
        private RSACryptoServiceProvider rsa;
        private AesCryptoServiceProvider aes;

        public Pagrindinis()
        {
            InitializeComponent();
            InitializeCryptoProviders();
            DecryptFile();
        }

        private void InitializeCryptoProviders()
        {
            rsa = new RSACryptoServiceProvider(2048);
            aes = new AesCryptoServiceProvider();
        }

        private void DecryptFile()
        {
            if (File.Exists(EncryptedFilePath))
            {
                using (var aes = new AesCryptoServiceProvider())
                {
                    byte[] encryptedData = File.ReadAllBytes(EncryptedFilePath);
                    byte[] decryptedData = DecryptAes(encryptedData, aes.Key, aes.IV);
                    File.WriteAllBytes(FilePath, decryptedData);
                }
            }
            else if (File.Exists(FilePath))
            {
                // File already exists and is unencrypted, no action needed
            }
            else
            {
                // Create a new file if it does not exist
                File.Create(FilePath).Dispose();
            }
        }

        private void EncryptFile()
        {
            if (File.Exists(FilePath))
            {
                byte[] data = File.ReadAllBytes(FilePath);
                byte[] encryptedData = EncryptAes(data, aes.Key, aes.IV);
                File.WriteAllBytes(EncryptedFilePath, encryptedData);
                File.Delete(FilePath);
            }
        }

        private byte[] EncryptAes(byte[] data, byte[] key, byte[] iv)
        {
            using (var aes = new AesCryptoServiceProvider())
            {
                aes.Key = key;
                aes.IV = iv;
                using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        cs.Write(data, 0, data.Length);
                    }
                    return ms.ToArray();
                }
            }
        }

        private byte[] DecryptAes(byte[] data, byte[] key, byte[] iv)
        {
            using (var aes = new AesCryptoServiceProvider())
            {
                aes.Key = key;
                aes.IV = iv;
                using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                using (var ms = new MemoryStream(data))
                using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                using (var reader = new StreamReader(cs))
                {
                    return Encoding.UTF8.GetBytes(reader.ReadToEnd());
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtUrl.Text) || string.IsNullOrWhiteSpace(txtComment.Text))
            {
                MessageBox.Show("All fields must be filled out to save a password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string title = txtTitle.Text;
            string password = txtPassword.Text;
            string url = txtUrl.Text;
            string comment = txtComment.Text;

            string encryptedPassword = EncryptPassword(password);

            using (var writer = new StreamWriter(FilePath, true))
            {
                writer.WriteLine($"{title},{encryptedPassword},{url},{comment}");
            }

            ClearFields();
        }

        private string EncryptPassword(string password)
        {
            byte[] data = Encoding.UTF8.GetBytes(password);
            byte[] encryptedData = rsa.Encrypt(data, false);
            return Convert.ToBase64String(encryptedData);
        }

        private string DecryptPassword(string encryptedPassword)
        {
            byte[] data = Convert.FromBase64String(encryptedPassword);
            byte[] decryptedData = rsa.Decrypt(data, false);
            return Encoding.UTF8.GetString(decryptedData);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchTitle.Text))
            {
                MessageBox.Show("Search title must be provided.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(FilePath))
            {
                MessageBox.Show("Password file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string searchTitle = txtSearchTitle.Text;

            using (var reader = new StreamReader(FilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(',');
                    if (parts[0] == searchTitle)
                    {
                        txtTitle.Text = parts[0];
                        txtPassword.Text = DecryptPassword(parts[1]);
                        txtUrl.Text = parts[2];
                        txtComment.Text = parts[3];
                        return;
                    }
                }
            }

            MessageBox.Show("Password not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchTitle.Text) || string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtUrl.Text) ||
                string.IsNullOrWhiteSpace(txtComment.Text))
            {
                MessageBox.Show("All fields must be filled out to update a password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(FilePath))
            {
                MessageBox.Show("Password file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string searchTitle = txtSearchTitle.Text;
            string newTitle = txtTitle.Text;
            string newPassword = txtPassword.Text;
            string newUrl = txtUrl.Text;
            string newComment = txtComment.Text;

            var lines = File.ReadAllLines(FilePath);
            using (var writer = new StreamWriter(FilePath, false))
            {
                bool found = false;
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts[0] == searchTitle)
                    {
                        string encryptedPassword = EncryptPassword(newPassword);
                        writer.WriteLine($"{newTitle},{encryptedPassword},{newUrl},{newComment}");
                        found = true;
                    }
                    else
                    {
                        writer.WriteLine(line);
                    }
                }

                if (!found)
                {
                    MessageBox.Show("Password not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchTitle.Text))
            {
                MessageBox.Show("Search title must be provided.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(FilePath))
            {
                MessageBox.Show("Password file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string searchTitle = txtSearchTitle.Text;

            var lines = File.ReadAllLines(FilePath);
            using (var writer = new StreamWriter(FilePath, false))
            {
                bool found = false;
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts[0] != searchTitle)
                    {
                        writer.WriteLine(line);
                    }
                    else
                    {
                        found = true;
                    }
                }

                if (!found)
                {
                    MessageBox.Show("Password not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            ClearFields();
        }

        private void ClearFields()
        {
            txtTitle.Clear();
            txtPassword.Clear();
            txtUrl.Clear();
            txtComment.Clear();
            txtSearchTitle.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            EncryptFile();
        }
    }
}
