using System;
using System.Windows.Forms;
using System.Numerics;

namespace Praktinis3duomSaug
{
    public class Raktai : Form1
    {
        internal BigInteger p2;
        internal BigInteger q2;
        internal BigInteger n;
        internal BigInteger e2;
        internal BigInteger d;

        internal void GenerateRaktai(BigInteger pValue, BigInteger qValue)
        {
            p2 = pValue;
            q2 = qValue;
            
            // Check if p and q are prime numbers
            if (!IsPrime(p2) || !IsPrime(q2))
            {
                MessageBox.Show("p and q must be prime numbers.");
                return;
            }

            n = p2 * q2;
            BigInteger phi = (p2 - 1) * (q2 - 1);
            e2 = FindPublicKey(phi);
            d = FindPrivateKey(e2, phi);

            SaveKeysToFile();
        }

        private BigInteger FindPublicKey(BigInteger phi)
        {
            BigInteger publicKey = 65537; // Common public exponent
            while (BigInteger.GreatestCommonDivisor(publicKey, phi) != 1)
            {
                publicKey++;
            }
            return publicKey;
        }

        private BigInteger FindPrivateKey(BigInteger e2, BigInteger phi)
        {
            // Extended Euclidean Algorithm to find modular multiplicative inverse
            BigInteger d = 0;
            BigInteger x1 = 0, x2 = 1, y1 = 1, temp_phi = phi;

            while (e2 > 0)
            {
                BigInteger temp1 = temp_phi / e2;
                BigInteger temp2 = temp_phi - temp1 * e2;
                temp_phi = e2;
                e2 = temp2;

                BigInteger x = x2 - temp1 * x1;
                BigInteger y = d - temp1 * y1;

                x2 = x1;
                x1 = x;
                d = y1;
                y1 = y;
            }

            if (temp_phi == 1)
                return d + phi;
            else
                throw new ArithmeticException("No modular multiplicative inverse exists.");
        }

        // Method to check if a number is prime
        private bool IsPrime(BigInteger number)
        {
            if (number <= 1)
                return false;
            if (number == 2)
                return true;
            if (number % 2 == 0)
                return false;

            BigInteger boundary = (BigInteger)Math.Floor(Math.Sqrt((double)number));

            for (BigInteger i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        private void SaveKeysToFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("keys.txt"))
                {
                    writer.WriteLine($"Public Key (n, e): {n}, {e2}");
                    writer.WriteLine($"Private Key (n, d): {n} , {d}");
                }
                MessageBox.Show("Keys saved to keys.txt file.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving keys to file: " + ex.Message);
            }
        }
    }
}
