using System.Security.Cryptography;
namespace CryptographyKeyGeneratorService;
internal static class PublicKeyGenerator
{
    public static string Generate(RSACryptoServiceProvider rsaCryptoService)
    {
        // Export the private key
        string publicKey = rsaCryptoService.ToXmlString(false);
        return publicKey;
    }
}
