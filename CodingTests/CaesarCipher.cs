using CaesarCipher;
using NUnit.Framework;

namespace CodingTests
{
    public class CaesarCipher
    {
        [Test]
        public void CaesarCipher_RetunsEncryptedString()
        {
            Caesar caesar = new Caesar();
            string result = caesar.Encrypt("xyz", 2);
            Assert.That(result, Is.EqualTo("zab"));
        }
    }
}
