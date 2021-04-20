//using System;
//using System.IO;
//using System.Security.Cryptography;
//using System.Text;

//public class CryptoHelper
//{
//    TripleDESCryptoServiceProvider symm;

//    #region Factory
//    public CryptoHelper()
//    {
//        this.symm = new TripleDESCryptoServiceProvider();
//        this.symm.Padding = PaddingMode.PKCS7;
//    }
//    public CryptoHelper(TripleDESCryptoServiceProvider keys)
//    {
//        this.symm = keys;
//    }

//    public CryptoHelper(byte[] key, byte[] iv)
//    {
//        this.symm = new TripleDESCryptoServiceProvider();
//        this.symm.Padding = PaddingMode.PKCS7;
//        this.symm.Key = key;
//        this.symm.IV = iv;
//    }

//    #endregion

//    #region Properties
//    public TripleDESCryptoServiceProvider Algorithm
//    {
//        get { return symm; }
//        set { symm = value; }
//    }
//    public byte[] Key
//    {
//        get { return symm.Key; }
//        set { symm.Key = value; }
//    }
//    public byte[] IV
//    {
//        get { return symm.IV; }
//        set { symm.IV = value; }
//    }

//    #endregion

//    #region Crypto

//    public byte[] Encrypt(byte[] data) { return Encrypt(data, data.Length); }
//    public byte[] Encrypt(byte[] data, int length)
//    {
//        try
//        {
//            // Create a MemoryStream.
//            var ms = new MemoryStream();

//            // Create a CryptoStream using the MemoryStream 
//            // and the passed key and initialization vector (IV).
//            var cs = new CryptoStream(ms,
//                symm.CreateEncryptor(symm.Key, symm.IV),
//                CryptoStreamMode.Write);

//            // Write the byte array to the crypto stream and flush it.
//            cs.Write(data, 0, length);
//            cs.FlushFinalBlock();

//            // Get an array of bytes from the 
//            // MemoryStream that holds the 
//            // encrypted data.
//            byte[] ret = ms.ToArray();

//            // Close the streams.
//            cs.Close();
//            ms.Close();

//            // Return the encrypted buffer.
//            return ret;
//        }
//        catch (CryptographicException ex)
//        {
//            Console.WriteLine("A cryptographic error occured: {0}", ex.Message);
//        }
//        return null;
//    }

//    public string EncryptString(string text)
//    {
//        return Convert.ToBase64String(Encrypt(Encoding.UTF8.GetBytes(text)));
//    }

//    public byte[] Decrypt(byte[] data) { return Decrypt(data, data.Length); }
//    public byte[] Decrypt(byte[] data, int length)
//    {
//        try
//        {
//            // Create a new MemoryStream using the passed 
//            // array of encrypted data.
//            MemoryStream ms = new MemoryStream(data);

//            // Create a CryptoStream using the MemoryStream 
//            // and the passed key and initialization vector (IV).
//            CryptoStream cs = new CryptoStream(ms,
//                symm.CreateDecryptor(symm.Key, symm.IV),
//                CryptoStreamMode.Read);

//            // Create buffer to hold the decrypted data.
//            byte[] result = new byte[length];

//            // Read the decrypted data out of the crypto stream
//            // and place it into the temporary buffer.
//            cs.Read(result, 0, result.Length);
//            return result;
//        }
//        catch (CryptographicException ex)
//        {
//            Console.WriteLine("A cryptographic error occured: {0}", ex.Message);
//        }
//        return null;
//    }

//    public string DecryptString(string data)
//    {
//        return Encoding.UTF8.GetString(Decrypt(Convert.FromBase64String(data))).TrimEnd('\0');
//    }

//    #endregion

//}
using System;
//using System.Configuration;
using System.IO;
//using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace PersonalAccounting.CommonLibrary.Helper
{
    public static class CryptoHelper
    {
        //// This constant is used to determine the keysize of the encryption algorithm in bits.
        //// We divide this by 8 within the code below to get the equivalent number of bytes.
        //private const int KeySize = 256;

        //// This constant determines the number of iterations for the password bytes generation function.
        //private const int DerivationIterations = 1000;

        //public static string Encrypt(string plainText, string passPhrase)
        //{
        //    // Salt and IV is randomly generated each time, but is preprended to encrypted cipher text
        //    // so that the same Salt and IV values can be used when decrypting.  
        //    var saltStringBytes = Generate256BitsOfRandomEntropy();
        //    var ivStringBytes = Generate256BitsOfRandomEntropy();
        //    var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
        //    using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
        //    {
        //        var keyBytes = password.GetBytes(KeySize / 8);
        //        using (var symmetricKey = new RijndaelManaged())
        //        {
        //            symmetricKey.BlockSize = 256;
        //            symmetricKey.Mode = CipherMode.CBC;
        //            symmetricKey.Padding = PaddingMode.PKCS7;
        //            using (var encryptor = symmetricKey.CreateEncryptor(keyBytes, ivStringBytes))
        //            {
        //                using (var memoryStream = new MemoryStream())
        //                {
        //                    using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
        //                    {
        //                        cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
        //                        cryptoStream.FlushFinalBlock();
        //                        // Create the final bytes as a concatenation of the random salt bytes, the random iv bytes and the cipher bytes.
        //                        var cipherTextBytes = saltStringBytes;
        //                        cipherTextBytes = cipherTextBytes.Concat(ivStringBytes).ToArray();
        //                        cipherTextBytes = cipherTextBytes.Concat(memoryStream.ToArray()).ToArray();
        //                        memoryStream.Close();
        //                        cryptoStream.Close();
        //                        return Convert.ToBase64String(cipherTextBytes);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

        //public static string Decrypt(string cipherText, string passPhrase)
        //{
        //    // Get the complete stream of bytes that represent:
        //    // [32 bytes of Salt] + [32 bytes of IV] + [n bytes of CipherText]
        //    var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(cipherText);
        //    // Get the saltbytes by extracting the first 32 bytes from the supplied cipherText bytes.
        //    var saltStringBytes = cipherTextBytesWithSaltAndIv.Take(KeySize / 8).ToArray();
        //    // Get the IV bytes by extracting the next 32 bytes from the supplied cipherText bytes.
        //    var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(KeySize / 8).Take(KeySize / 8).ToArray();
        //    // Get the actual cipher text bytes by removing the first 64 bytes from the cipherText string.
        //    var cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip((KeySize / 8) * 2)
        //        .Take(cipherTextBytesWithSaltAndIv.Length - ((KeySize / 8) * 2)).ToArray();

        //    using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
        //    {
        //        var keyBytes = password.GetBytes(KeySize / 8);
        //        using (var symmetricKey = new RijndaelManaged())
        //        {
        //            symmetricKey.BlockSize = 256;
        //            symmetricKey.Mode = CipherMode.CBC;
        //            symmetricKey.Padding = PaddingMode.PKCS7;
        //            using (var decryptor = symmetricKey.CreateDecryptor(keyBytes, ivStringBytes))
        //            {
        //                using (var memoryStream = new MemoryStream(cipherTextBytes))
        //                {
        //                    using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
        //                    {
        //                        var plainTextBytes = new byte[cipherTextBytes.Length];
        //                        var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
        //                        memoryStream.Close();
        //                        cryptoStream.Close();
        //                        return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

        //private static byte[] Generate256BitsOfRandomEntropy()
        //{
        //    var randomBytes = new byte[32]; // 32 Bytes will give us 256 bits.
        //    using (var rngCsp = new RNGCryptoServiceProvider())
        //    {
        //        // Fill the array with cryptographically secure random bytes.
        //        rngCsp.GetBytes(randomBytes);
        //    }

        //    return randomBytes;
        //}

        //public static string Encrypt(string clearText)
        //{
        //    var EncryptionKey = "abc123";
        //    var clearBytes = Encoding.Unicode.GetBytes(clearText);
        //    using (var encryptor = Aes.Create())
        //    {
        //        var pdb = new Rfc2898DeriveBytes(EncryptionKey,
        //            new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
        //        encryptor.Key = pdb.GetBytes(32);
        //        encryptor.IV = pdb.GetBytes(16);
        //        using (var ms = new MemoryStream())
        //        {
        //            using (var cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
        //            {
        //                cs.Write(clearBytes, 0, clearBytes.Length);
        //                cs.Close();
        //            }

        //            clearText = Convert.ToBase64String(ms.ToArray());
        //        }
        //    }

        //    return clearText;
        //}

        //public static string Decrypt(string cipherText)
        //{
        //    const string encryptionKey = "abc123";
        //    cipherText = cipherText.Replace(" ", "+");
        //    var cipherBytes = Convert.FromBase64String(cipherText);
        //    using (var encryptor = Aes.Create())
        //    {
        //        var pdb = new Rfc2898DeriveBytes(encryptionKey,
        //            new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
        //        encryptor.Key = pdb.GetBytes(32);
        //        encryptor.IV = pdb.GetBytes(16);
        //        using (var ms = new MemoryStream())
        //        {
        //            using (var cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
        //            {
        //                cs.Write(cipherBytes, 0, cipherBytes.Length);
        //                cs.Close();
        //            }

        //            cipherText = Encoding.Unicode.GetString(ms.ToArray());
        //        }
        //    }

        //    return cipherText;
        //}

        /************************************************************/
        //public static string Encrypt(string toEncrypt, bool useHashing, string key = "1231")
        //{
        //    byte[] keyArray;
        //    var toEncryptArray = Encoding.UTF8.GetBytes(toEncrypt);

        //    var settingsReader =
        //        new AppSettingsReader();
        //    // Get the key from config file

        //    //var key = (string)settingsReader.GetValue("GandomKimia",typeof(string));
        //    //System.Windows.Forms.MessageBox.Show(key);
        //    //If hashing use get hashcode regards to your key
        //    if (useHashing)
        //    {
        //        var hashmd5 = new MD5CryptoServiceProvider();
        //        keyArray = hashmd5.ComputeHash(Encoding.UTF8.GetBytes(key));
        //        //Always release the resources and flush data
        //        // of the Cryptographic service provide. Best Practice

        //        hashmd5.Clear();
        //    }
        //    else
        //        keyArray = Encoding.UTF8.GetBytes(key);

        //    var tdes = new TripleDESCryptoServiceProvider
        //    {
        //        Key = keyArray,
        //        Mode = CipherMode.ECB,
        //        Padding = PaddingMode.PKCS7
        //    };
        //    //set the secret key for the tripleDES algorithm
        //    //mode of operation. there are other 4 modes.
        //    //We choose ECB(Electronic code Book)
        //    //padding mode(if any extra byte added)


        //    var cTransform = tdes.CreateEncryptor();
        //    //transform the specified region of bytes array to resultArray
        //    var resultArray =
        //        cTransform.TransformFinalBlock(toEncryptArray, 0,
        //            toEncryptArray.Length);
        //    //Release resources held by TripleDes Encryptor
        //    tdes.Clear();
        //    //Return the encrypted data into unreadable string format
        //    return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        //}

        //public static string Decrypt(string cipherString, bool useHashing, string key = "1231")
        //{
        //    byte[] keyArray;
        //    //get the byte code of the string

        //    var toEncryptArray = Convert.FromBase64String(cipherString);

        //    var settingsReader =
        //        new AppSettingsReader();
        //    //Get your key from config file to open the lock!
        //    //var key = (string)settingsReader.GetValue("GandomKimia", typeof(string));

        //    if (useHashing)
        //    {
        //        //if hashing was used get the hash code with regards to your key
        //        var hashmd5 = new MD5CryptoServiceProvider();
        //        keyArray = hashmd5.ComputeHash(Encoding.UTF8.GetBytes(key));
        //        //release any resource held by the MD5CryptoServiceProvider

        //        hashmd5.Clear();
        //    }
        //    else
        //    {
        //        //if hashing was not implemented get the byte code of the key
        //        keyArray = Encoding.UTF8.GetBytes(key);
        //    }

        //    var tdes = new TripleDESCryptoServiceProvider
        //    {
        //        Key = keyArray,
        //        Mode = CipherMode.ECB,
        //        Padding = PaddingMode.PKCS7
        //    };
        //    //set the secret key for the tripleDES algorithm
        //    //mode of operation. there are other 4 modes. 
        //    //We choose ECB(Electronic code Book)

        //    //padding mode(if any extra byte added)

        //    var cTransform = tdes.CreateDecryptor();
        //    var resultArray = cTransform.TransformFinalBlock(
        //        toEncryptArray, 0, toEncryptArray.Length);
        //    //Release resources held by TripleDes Encryptor                
        //    tdes.Clear();
        //    //return the Clear decrypted TEXT
        //    return Encoding.UTF8.GetString(resultArray);
        //}
        /************************************************************/

        //public static string DataToMd5HashString(string input)
        //{
        //    var encoder = new UTF8Encoding();
        //    var md5Hasher = new MD5CryptoServiceProvider();
        //    var data = md5Hasher.ComputeHash(encoder.GetBytes(input));
        //    var stringBuilder = new StringBuilder();
        //    foreach (var t in data)
        //    {
        //        stringBuilder.Append(t.ToString("x2"));
        //    }

        //    var result = stringBuilder.ToString();
        //    return result;
        //}

        //public static bool VerifyMd5Hash(string input, string hash)
        //{
        //    // Hash the input.
        //    var hashOfInput = DataToMd5HashString(input);

        //    // Create a StringComparer an compare the hashes.
        //    var comparer = StringComparer.OrdinalIgnoreCase;

        //    return comparer.Compare(hashOfInput, hash) == 0;
        //}

        ///*************************************** nop commerce *******************************/
        //private static byte[] EncryptTextToMemory(string data, byte[] key, byte[] iv)
        //{
        //    using (var ms = new MemoryStream())
        //    {
        //        using (var cs = new CryptoStream(ms, new TripleDESCryptoServiceProvider().CreateEncryptor(key, iv),
        //            CryptoStreamMode.Write))
        //        {
        //            var toEncrypt = Encoding.Unicode.GetBytes(data);
        //            cs.Write(toEncrypt, 0, toEncrypt.Length);
        //            cs.FlushFinalBlock();
        //        }

        //        return ms.ToArray();
        //    }
        //}

        //private static string DecryptTextFromMemory(byte[] data, byte[] key, byte[] iv)
        //{
        //    using (var ms = new MemoryStream(data))
        //    {
        //        using (var cs = new CryptoStream(ms, new TripleDESCryptoServiceProvider().CreateDecryptor(key, iv),
        //            CryptoStreamMode.Read))
        //        {
        //            using (var sr = new StreamReader(cs, Encoding.Unicode))
        //            {
        //                return sr.ReadToEnd();
        //            }
        //        }
        //    }
        //}

        ///// <summary>
        ///// Encrypt text
        ///// </summary>
        ///// <param name="plainText">Text to encrypt</param>
        ///// <param name="encryptionPrivateKey">Encryption private key</param>
        ///// <returns>Encrypted text</returns>
        //public static string EncryptText(string plainText, string encryptionPrivateKey = "")
        //{
        //    if (string.IsNullOrEmpty(plainText))
        //        return plainText;

        //    if (string.IsNullOrEmpty(encryptionPrivateKey))
        //        encryptionPrivateKey = "1231";

        //    using (var provider = new TripleDESCryptoServiceProvider())
        //    {
        //        provider.Key = Encoding.ASCII.GetBytes(encryptionPrivateKey.Substring(0, 16));
        //        provider.IV = Encoding.ASCII.GetBytes(encryptionPrivateKey.Substring(8, 8));

        //        var encryptedBinary = EncryptTextToMemory(plainText, provider.Key, provider.IV);
        //        return Convert.ToBase64String(encryptedBinary);
        //    }
        //}

        public static string EncryptNew(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            var keyBytes = new Rfc2898DeriveBytes(DefaultConstants.PasswordHash, Encoding.ASCII.GetBytes(DefaultConstants.SaltKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };
            var encryptor = symmetricKey.CreateEncryptor(keyBytes, Encoding.ASCII.GetBytes(DefaultConstants.ViKey));

            byte[] cipherTextBytes;

            using (var memoryStream = new MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                {
                    cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                    cryptoStream.FlushFinalBlock();
                    cipherTextBytes = memoryStream.ToArray();
                    cryptoStream.Close();
                }
                memoryStream.Close();
            }
            return Convert.ToBase64String(cipherTextBytes);
        }

        public static string DecryptNew(string encryptedText)
        {
            var cipherTextBytes = Convert.FromBase64String(encryptedText);
            var keyBytes = new Rfc2898DeriveBytes(DefaultConstants.PasswordHash, Encoding.ASCII.GetBytes(DefaultConstants.SaltKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.None };

            var decryptor = symmetricKey.CreateDecryptor(keyBytes, Encoding.ASCII.GetBytes(DefaultConstants.ViKey));
            var memoryStream = new MemoryStream(cipherTextBytes);
            var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            var plainTextBytes = new byte[cipherTextBytes.Length];

            var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount).TrimEnd("\0".ToCharArray());
        }
        ///// <summary>
        ///// Decrypt text
        ///// </summary>
        ///// <param name="cipherText">Text to decrypt</param>
        ///// <param name="encryptionPrivateKey">Encryption private key</param>
        ///// <returns>Decrypted text</returns>
        //public static string DecryptText(string cipherText, string encryptionPrivateKey = "")
        //{
        //    if (string.IsNullOrEmpty(cipherText))
        //        return cipherText;

        //    if (string.IsNullOrEmpty(encryptionPrivateKey))
        //        encryptionPrivateKey = "1231";

        //    using (var provider = new TripleDESCryptoServiceProvider())
        //    {
        //        provider.Key = Encoding.ASCII.GetBytes(encryptionPrivateKey.Substring(0, 16));
        //        provider.IV = Encoding.ASCII.GetBytes(encryptionPrivateKey.Substring(8, 8));

        //        var buffer = Convert.FromBase64String(cipherText);
        //        return DecryptTextFromMemory(buffer, provider.Key, provider.IV);
        //    }
        //}



        //public static string EncryptDecrypt(string szPlainText, int szEncryptionKey)
        //{
        //    var szInputStringBuild = new StringBuilder(szPlainText);
        //    var szOutStringBuild = new StringBuilder(szPlainText.Length);
        //    for (var iCount = 0; iCount < szPlainText.Length; iCount++)
        //    {
        //        var textCh = szInputStringBuild[iCount];
        //        textCh = (char)(textCh ^ szEncryptionKey);
        //        szOutStringBuild.Append(textCh);
        //    }

        //    return szOutStringBuild.ToString();
        //}

        //public static string EncryptData(string textData, string encryptionKey)
        //{
        //    var rij = new RijndaelManaged();
        //    //set the mode for operation of the algorithm
        //    rij.Mode = CipherMode.CBC;
        //    //set the padding mode used in the algorithm.
        //    rij.Padding = PaddingMode.PKCS7;
        //    //set the size, in bits, for the secret key.
        //    rij.KeySize = 0x80;
        //    //set the block size in bits for the cryptographic operation.

        //    rij.BlockSize = 0x80;
        //    //set the symmetric key that is used for encryption & decryption.
        //    var passBytes = Encoding.UTF8.GetBytes(encryptionKey);
        //    //set the initialization vector (IV) for the symmetric algorithm
        //    var encryptionKeyBytes = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
        //    var len = passBytes.Length;

        //    if (len > encryptionKeyBytes.Length)
        //    {
        //        len = encryptionKeyBytes.Length;
        //    }
        //    Array.Copy(passBytes, encryptionKeyBytes, len);
        //    rij.Key = encryptionKeyBytes;
        //    rij.IV = encryptionKeyBytes;
        //    //Creates symmetric AES object with the current key and initialization vector IV.

        //    var objTransForm = rij.CreateEncryptor();
        //    var textDataByte = Encoding.UTF8.GetBytes(textData);
        //    //Final transform the test string.
        //    return Convert.ToBase64String(objTransForm.TransformFinalBlock(textDataByte, 0, textDataByte.Length));

        //}
        //public static string DecryptData(string encryptedText, string encryptionKey)
        //{
        //    var rij = new RijndaelManaged
        //    {
        //        Mode = CipherMode.CBC,
        //        Padding = PaddingMode.PKCS7,
        //        KeySize = 0x80,
        //        BlockSize = 0x80
        //    };
        //    var encryptedTextByte = Convert.FromBase64String(encryptedText);
        //    var passBytes = Encoding.UTF8.GetBytes(encryptionKey);
        //    var encryptionKeyBytes = new byte[0x10];
        //    var len = passBytes.Length;
        //    if (len > encryptionKeyBytes.Length)
        //    {
        //        len = encryptionKeyBytes.Length;
        //    }
        //    Array.Copy(passBytes, encryptionKeyBytes, len);
        //    rij.Key = encryptionKeyBytes;
        //    rij.IV = encryptionKeyBytes;
        //    var textByte = rij.CreateDecryptor().TransformFinalBlock(encryptedTextByte, 0, encryptedTextByte.Length);
        //    return Encoding.UTF8.GetString(textByte);  //it will return readable string
        //}
        //public static string EncryptString(string key, string plainText)
        //{
        //    var iv = new byte[16];
        //    byte[] array;
        //    using (var aes = Aes.Create())
        //    {
        //        aes.Key = Encoding.UTF8.GetBytes(key);
        //        aes.IV = iv;
        //        var encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
        //        using (var memoryStream = new MemoryStream())
        //        {
        //            using (var cryptoStream =
        //                new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
        //            {
        //                using (var streamWriter = new StreamWriter((Stream)cryptoStream))
        //                {
        //                    streamWriter.Write(plainText);
        //                }

        //                array = memoryStream.ToArray();
        //            }
        //        }
        //    }

        //    return Convert.ToBase64String(array);
        //}

        //public static string DecryptString(string key, string cipherText)
        //{
        //    var iv = new byte[16];
        //    var buffer = Convert.FromBase64String(cipherText);
        //    using (var aes = Aes.Create())
        //    {
        //        aes.Key = Encoding.UTF8.GetBytes(key);
        //        aes.IV = iv;
        //        var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
        //        using (var memoryStream = new MemoryStream(buffer))
        //        {
        //            using (var cryptoStream =
        //                new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
        //            {
        //                using (var streamReader = new StreamReader((Stream)cryptoStream))
        //                {
        //                    return streamReader.ReadToEnd();
        //                }
        //            }
        //        }
        //    }
        //}
    }
}
///// <summary>
///// Encrypts a string using the supplied key. Encoding is done using RSA encryption.
///// </summary>
///// <param name="stringToEncrypt">String that must be encrypted.</param>
///// <param name="key">Encryption key.</param>
///// <returns>A string representing a byte array separated by a minus sign.</returns>
///// <exception cref="ArgumentException">Occurs when stringToEncrypt or key is null or empty.</exception>
//public static string Encrypt(this string stringToEncrypt, string key)
//{
//    if (string.IsNullOrEmpty(stringToEncrypt))
//    {
//        throw new ArgumentException("An empty string value cannot be encrypted.");
//    }

//    if (string.IsNullOrEmpty(key))
//    {
//        throw new ArgumentException("Cannot encrypt using an empty key. Please supply an encryption key.");
//    }

//    var csp = new CspParameters { KeyContainerName = key };

//    var rsa = new RSACryptoServiceProvider(csp) { PersistKeyInCsp = true };

//    var bytes = rsa.Encrypt(Encoding.UTF8.GetBytes(stringToEncrypt), true);

//    return BitConverter.ToString(bytes);
//}

///// <summary>
///// Decrypts a string using the supplied key. Decoding is done using RSA encryption.
///// </summary>
///// <param name="stringToDecrypt">String that must be decrypted.</param>
///// <param name="key">Decryption key.</param>
///// <returns>The decrypted string or null if decryption failed.</returns>
///// <exception cref="ArgumentException">Occurs when stringToDecrypt or key is null or empty.</exception>
//public static string Decrypt(this string stringToDecrypt, string key)
//{
//    string result;

//    if (string.IsNullOrEmpty(stringToDecrypt))
//    {
//        throw new ArgumentException("An empty string value cannot be encrypted.");
//    }

//    if (string.IsNullOrEmpty(key))
//    {
//        throw new ArgumentException("Cannot decrypt using an empty key. Please supply a decryption key.");
//    }

//    try
//    {
//        var csp = new CspParameters { KeyContainerName = key };

//        var rsa = new RSACryptoServiceProvider(csp) { PersistKeyInCsp = true };

//        var decryptArray = stringToDecrypt.Split(new string[] { "-" }, StringSplitOptions.None);
//        var decryptByteArray = Array.ConvertAll<string, byte>(decryptArray,
//            (s => Convert.ToByte(byte.Parse(s, System.Globalization.NumberStyles.HexNumber))));


//        var bytes = rsa.Decrypt(decryptByteArray, true);

//        result = Encoding.UTF8.GetString(bytes);

//    }
//    finally
//    {
//        // no need for further processing
//    }

//    return result;
//}

