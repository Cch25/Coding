using CaesarCipher;
using NUnit.Framework;

namespace CodingTests
{
    public class CaesarCipher
    {
        [Test]
        public void CaesarCipher_RetunsEncryptedString()
        {
            //Arrange
            Caesar caesar = new Caesar();

            //Act
            string result = caesar.Encrypt("xyz", 2);

            //Assert
            Assert.That(result, Is.EqualTo("zab"));
        }
    }
}
