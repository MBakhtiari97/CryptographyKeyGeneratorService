using System.Security.Cryptography;
namespace CryptographyKeyGeneratorService;
internal static class PrivateKeyGenerator
{
    public static string Generate(RSACryptoServiceProvider rsaCryptoService)
    {
        // Export the private key
        string privateKey = rsaCryptoService.ToXmlString(true);
        return privateKey;
    }
}