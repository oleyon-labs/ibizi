// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string data = "шифрование_перестановкой_";
var k1 = new byte[] { 0, 1, 2, 3, 4 };
var k2 = new byte[] { 0, 1, 2, 3, 4 };
var encryptedData = Lab1.TranspositionCipher.Encrypt(data, k1, k2);
var decryptedData = Lab1.TranspositionCipher.Encrypt(encryptedData, k1, k2);
Console.WriteLine($"data: {data}");
Console.WriteLine($"encrypted data: {encryptedData}");
Console.WriteLine($"decrypted data: {decryptedData}");