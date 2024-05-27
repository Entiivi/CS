using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktinis3duomSaug
{
    internal class FileUtils
    {
        public void save(string result)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(@"C:\\Users\\User\\Desktop\\2PROG-Prak\\Praktinis3duomSaug\\result.txt"))
                {
                    writer.WriteLine(result);
                }
                MessageBox.Show("Result saved to result.txt file.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving result to file: " + ex.Message);
            }
        }

        public string ReadInputTextFromFile(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show($"File '{filePath}' does not exist.");
                    return null;
                }

                return File.ReadAllText(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading text from file: " + ex.Message);
                return null;
            }
        }
    }
}
