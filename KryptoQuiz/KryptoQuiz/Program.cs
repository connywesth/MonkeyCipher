// Kryperingsgåta av Conny Westh 2019-03-21, info@connywesth.se
// Publicerad på Facebookgruppen Kodapor Off-Topic 2019-03-21.
// Krypteringsalgoritmen är en modifierad varianrt av det över 2000 år gamla Ceasar-kryptot.
//
// Föreslagen lösning 2019-03-21 av Peter Eklund
// https://github.com/dx-dt/monkeycipher/blob/master/cipher.ipynb?fbclid=IwAR1r_rL96eljw0fNbeMEtb5tBtlAMLuatUpvEkbLJjKYvd0xYFtd4pJuLAc

using System;

namespace Kodapor.KryptoQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kodapor Krypteringsgåta 2019-03-21!");
            string clearText = "";
            string cryptedString = "";
            int key = 143;
            const string originalText = "Katten Gustav är fetare än andra katter!";

            Console.WriteLine($"Key: {key}, Original Text: {originalText}");

            cryptedString = MonkeyCipher.EnCrypt(key: key, clearString: originalText);
            Console.WriteLine($"Key: {key}, Crypted Text: {cryptedString}");

            clearText = MonkeyCipher.DeCrypt(key: key, cryptedString: cryptedString);
            Console.WriteLine($"Key: {key}, Decrypted Text: {clearText}");
        }

    }
}
