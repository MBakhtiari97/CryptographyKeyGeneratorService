using CryptographyKeyGeneratorService;
using System.Security.Cryptography;
using (var rsaCryptoService = new RSACryptoServiceProvider(2048))
{
    // Export the private key
    string privateKey = PrivateKeyGenerator.Generate(rsaCryptoService);

    // Print the private key to the console
    Console.WriteLine("Test Private Key:");
    Console.WriteLine(privateKey);

    // Optionally, you can also export the public key
    string publicKey = PublicKeyGenerator.Generate(rsaCryptoService);
    Console.WriteLine("\nTest Public Key:");
    Console.WriteLine(publicKey);
}

Console.ReadLine();