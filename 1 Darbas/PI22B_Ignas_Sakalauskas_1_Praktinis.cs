using System;

class VigenereCipher
{
    static string Encrypt(string plaintext, string key)
    {
        char[] result = new char[plaintext.Length];
        for (int i = 0; i < plaintext.Length; i++)
        {
            char plainChar = plaintext[i];
            char keyChar = key[i % key.Length];

            result[i] = (char)(((plainChar + keyChar) % 256) % 128);
        }
        return new string(result);
    }

    static string Decrypt(string ciphertext, string key)
    {
        char[] result = new char[ciphertext.Length];
        for (int i = 0; i < ciphertext.Length; i++)
        {
            char cipherChar = ciphertext[i];
            char keyChar = key[i % key.Length];

            result[i] = (char)(((cipherChar - keyChar + 128) % 128) % 256);
        }
        return new string(result);
    }

    static void Main(string[] args)
    {

        Console.WriteLine("Iveskite teksta kuri norite šifruoti:");
        string plaintext = Console.ReadLine();

        Console.WriteLine("Iveskite rakta tekstui šifruoti:");
        string key = Console.ReadLine();

        string encryptedText = Encrypt(plaintext, key);
        Console.WriteLine("Šifruotas tekstas: " + encryptedText);

        string decryptedText = Decrypt(encryptedText, key);
        Console.WriteLine("Dešifruotas tekstas: " + decryptedText);

        Console.WriteLine("Iveskite teksta kuri norite dešifruoti:");
        string encryptedText2 = Console.ReadLine();

        Console.WriteLine("Iveskite rakta tekstui dešifruoti:");
        string key2 = Console.ReadLine();

        string decryptedText2 = Decrypt(encryptedText2, key2);
        Console.WriteLine("Dešifruotas tekstas: " + decryptedText2);

    }
}

