namespace EasyQuestions.CaesarCipher
{
    public class Caesar
    {
        /// <summary>
        /// Encrypt a string given a key.
        /// Eg
        /// xyz becomes zab
        /// O(n) time | O(n) space
        /// </summary>
        /// <param name="word">string to encrypt</param>
        /// <param name="key">key to shift the chars</param>
        /// <returns>Newly encrypted string.</returns>
        public string Encrypt(string word, int key)
        {
            int newKey = key % 26;//wrap the key if the value is greater than the alphabet
            char[] encryptedString = new char[word.Length];
            for (int i = 0; i <= word.Length - 1; i++)
            {
                encryptedString[i] = EncryptChar(word[i], newKey);
            }
            return new string(encryptedString);
        }

        private char EncryptChar(char character, int newKey)
        {
            int newChar = character + newKey;
            return newChar <= 122 ? (char)newChar : (char)(96 + (newChar % 122));
        }
    }
}
