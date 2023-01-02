using System;
using System.Text;
using System.Security.Cryptography;


public class RSAExample {

    static void Main(string[] args){

// generates a 4096bit key...
        RSA rsa = RSA.Create(4096);

        Console.WriteLine("Signature Algorithm: " + rsa.SignatureAlgorithm);

        byte[] publicKey = rsa.ExportRSAPublicKey();
        string publicKeyString = BitConverter.ToString(publicKey);
        Console.WriteLine("=== Your Public Key ===");
        Console.WriteLine(publicKeyString);
        Console.WriteLine("=======================");
    }
}
