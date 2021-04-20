using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace PersonalAccounting.CommonLibrary.Helper
{
    public static class Utility
    {
        //private const int TokenSizeInBytes = 16;
        private const int Pbkdf2Count = 1000;
        private const int Pbkdf2SubKeyLength = 256 / 8;
        private const int SaltSize = 128 / 8;

        //public static string GenerateSalt(int byteLength = SaltSize)
        //{
        //    var buff = new byte[byteLength];
        //    using (var prng = new RNGCryptoServiceProvider())
        //    {
        //        prng.GetBytes(buff);
        //    }

        //    return Convert.ToBase64String(buff);
        //}

        //public static string Hash(string input, string algorithm = "sha256")
        //{
        //    if (input == null)
        //    {
        //        throw new ArgumentNullException("input");
        //    }

        //    return Hash(Encoding.UTF8.GetBytes(input), algorithm);
        //}

        //public static string Hash(byte[] input, string algorithm = "sha256")
        //{
        //    if (input == null)
        //    {
        //        throw new ArgumentNullException("input");
        //    }

        //    using (var alg = HashAlgorithm.Create(algorithm))
        //    {
        //        if (alg != null)
        //        {
        //            var hashData = alg.ComputeHash(input);
        //            return BinaryToHex(hashData);
        //        }
        //        else
        //        {
        //            throw new InvalidOperationException(string.Format(
        //                CultureInfo.InvariantCulture, "not supported hash alg", algorithm));
        //        }
        //    }
        //}
        //public static string Sha1(string input)
        //{
        //    return Hash(input, "sha1");
        //}
        //public static string Sha256(string input)
        //{
        //    return Hash(input, "sha256");
        //}

        /* =======================
         * HASHED PASSWORD FORMATS
         * =======================
         * 
         * Version 0:
         * PBKDF2 with HMAC-SHA1, 128-bit salt, 256-bit subkey, 1000 iterations.
         * (See also: SDL crypto guidelines v5.1, Part III)
         * Format: { 0x00, salt, subkey }
         */

        public static string HashPassword(string password)
        {
            if (password == null)
            {
                throw new ArgumentNullException(nameof(password));
            }

            byte[] salt;
            byte[] subKey;
            using (var deriveBytes = new Rfc2898DeriveBytes(password, SaltSize, Pbkdf2Count))
            {
                salt = deriveBytes.Salt;
                subKey = deriveBytes.GetBytes(Pbkdf2SubKeyLength);
            }

            var outputBytes = new byte[1 + SaltSize + Pbkdf2SubKeyLength];
            Buffer.BlockCopy(salt, 0, outputBytes, 1, SaltSize);
            Buffer.BlockCopy(subKey, 0, outputBytes, 1 + SaltSize, Pbkdf2SubKeyLength);
            return Convert.ToBase64String(outputBytes);
        }

        // hashedPassword must be of the format of HashWithPassword (salt + Hash(salt+input)
        public static bool VerifyHashedPassword(string hashedPassword, string password)
        {
            if (hashedPassword == null)
            {
                throw new ArgumentNullException(nameof(hashedPassword));
            }
            if (password == null)
            {
                throw new ArgumentNullException(nameof(password));
            }

            var hashedPasswordBytes = Convert.FromBase64String(hashedPassword);

            // Verify a version 0 (see comment above) password hash.

            if (hashedPasswordBytes.Length != (1 + SaltSize + Pbkdf2SubKeyLength) || hashedPasswordBytes[0] != (byte)0x00)
            {
                // Wrong length or version header.
                return false;
            }

            var salt = new byte[SaltSize];
            Buffer.BlockCopy(hashedPasswordBytes, 1, salt, 0, SaltSize);
            var storedSubKey = new byte[Pbkdf2SubKeyLength];
            Buffer.BlockCopy(hashedPasswordBytes, 1 + SaltSize, storedSubKey, 0, Pbkdf2SubKeyLength);

            byte[] generatedSubKey;
            using (var deriveBytes = new Rfc2898DeriveBytes(password, salt, Pbkdf2Count))
            {
                generatedSubKey = deriveBytes.GetBytes(Pbkdf2SubKeyLength);
            }
            return ByteArraysEqual(storedSubKey, generatedSubKey);
        }

        //internal static string BinaryToHex(byte[] data)
        //{
        //    var hex = new char[data.Length * 2];

        //    for (var iter = 0; iter < data.Length; iter++)
        //    {
        //        var hexChar = ((byte)(data[iter] >> 4));
        //        hex[iter * 2] = (char)(hexChar > 9 ? hexChar + 0x37 : hexChar + 0x30);
        //        hexChar = ((byte)(data[iter] & 0xF));
        //        hex[iter * 2 + 1] = (char)(hexChar > 9 ? hexChar + 0x37 : hexChar + 0x30);
        //    }
        //    return new string(hex);
        //}

        // Compares two byte arrays for equality. The method is specifically written so that the loop is not optimized.
        [MethodImpl(MethodImplOptions.NoOptimization)]
        private static bool ByteArraysEqual(byte[] a, byte[] b)
        {
            if (object.ReferenceEquals(a, b))
            {
                return true;
            }

            if (a == null || b == null || a.Length != b.Length)
            {
                return false;
            }

            var areSame = true;
            for (var i = 0; i < a.Length; i++)
            {
                areSame &= (a[i] == b[i]);
            }
            return areSame;
        }


        /********************************************/
        public enum CompressAlgorithm
        {
            GZip = 0,
            Deflate = 1
        }
        //public static void CopyTo(Stream src, Stream dest)
        //{
        //    var bytes = new byte[4096];

        //    int cnt;

        //    while ((cnt = src.Read(bytes, 0, bytes.Length)) != 0)
        //    {
        //        dest.Write(bytes, 0, cnt);
        //    }
        //}

        //public static byte[] Zip(string str, CompressAlgorithm compressAlgorithm = CompressAlgorithm.GZip)
        //{
        //    var bytes = Encoding.UTF8.GetBytes(str);

        //    using (var msi = new MemoryStream(bytes))
        //    using (var mso = new MemoryStream())
        //    {
        //        switch (compressAlgorithm)
        //        {
        //            case CompressAlgorithm.GZip:
        //                {
        //                    using (var gs = new GZipStream(mso, CompressionMode.Compress))
        //                    {
        //                        //msi.CopyTo(gs);
        //                        CopyTo(msi, gs);
        //                    }

        //                    break;
        //                }
        //            case CompressAlgorithm.Deflate:
        //                {
        //                    using (var gs = new GZipStream(mso, CompressionMode.Compress))
        //                    {
        //                        //msi.CopyTo(gs);
        //                        CopyTo(msi, gs);
        //                    }

        //                    break;
        //                }
        //            default:
        //                using (var gs = new DeflateStream(mso, CompressionMode.Compress))
        //                {
        //                    //msi.CopyTo(gs);
        //                    CopyTo(msi, gs);
        //                }

        //                break;
        //        }

        //        return mso.ToArray();
        //    }
        //}

        //public static string Unzip(byte[] bytes, CompressAlgorithm compressAlgorithm = CompressAlgorithm.GZip)
        //{
        //    using (var msi = new MemoryStream(bytes))
        //    using (var mso = new MemoryStream())
        //    {
        //        switch (compressAlgorithm)
        //        {
        //            case CompressAlgorithm.GZip:
        //                {
        //                    using (var gs = new GZipStream(msi, CompressionMode.Decompress))
        //                    {
        //                        //gs.CopyTo(mso);
        //                        CopyTo(gs, mso);
        //                    }

        //                    break;
        //                }
        //            case CompressAlgorithm.Deflate:
        //                {
        //                    using (var gs = new DeflateStream(msi, CompressionMode.Decompress))
        //                    {
        //                        //gs.CopyTo(mso);
        //                        CopyTo(gs, mso);
        //                    }

        //                    break;
        //                }
        //            default:
        //                using (var gs = new GZipStream(msi, CompressionMode.Decompress))
        //                {
        //                    //gs.CopyTo(mso);
        //                    CopyTo(gs, mso);
        //                }

        //                break;
        //        }

        //        return Encoding.UTF8.GetString(mso.ToArray());
        //    }
        //}

        ///// <summary>
        ///// Compresses the string.
        ///// </summary>
        ///// <param name="text">The text.</param>
        ///// <param name="algorithm"></param>
        ///// <param name="encoding"></param>
        ///// <returns></returns>
        //public static async Task<string> CompressStringAsync(string text, Encoding encoding, CompressAlgorithm algorithm = CompressAlgorithm.Deflate)
        //{
        //    var encodingBuffer = encoding.GetBytes(text); //Encoding.UTF8.GetBytes(text);
        //    var memoryStream = new MemoryStream();
        //    switch (algorithm)
        //    {
        //        case CompressAlgorithm.GZip:
        //            {
        //                using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Compress, true))
        //                {
        //                    await gZipStream.WriteAsync(encodingBuffer, 0, encodingBuffer.Length);
        //                }

        //                break;
        //            }
        //        case CompressAlgorithm.Deflate:
        //            {
        //                using (var deflateStream = new DeflateStream(memoryStream, CompressionMode.Compress, true))
        //                {
        //                    await deflateStream.WriteAsync(encodingBuffer, 0, encodingBuffer.Length);
        //                }

        //                break;
        //            }
        //        default:
        //            using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Compress, true))
        //            {
        //                await gZipStream.WriteAsync(encodingBuffer, 0, encodingBuffer.Length);
        //            }

        //            break;
        //    }

        //    memoryStream.Position = 0;

        //    var compressedData = new byte[memoryStream.Length];
        //    await memoryStream.ReadAsync(compressedData, 0, compressedData.Length);

        //    var streamBuffer = new byte[compressedData.Length + 4];
        //    Buffer.BlockCopy(compressedData, 0, streamBuffer, 4, compressedData.Length);
        //    Buffer.BlockCopy(BitConverter.GetBytes(encodingBuffer.Length), 0, streamBuffer, 0, 4);
        //    return Convert.ToBase64String(streamBuffer);
        //}


        public static string CompressString(string text, Encoding encoding, CompressAlgorithm algorithm = CompressAlgorithm.Deflate)
        {
            var encodingBuffer = encoding.GetBytes(text); //Encoding.UTF8.GetBytes(text);
            var memoryStream = new MemoryStream();
            switch (algorithm)
            {
                case CompressAlgorithm.GZip:
                    {
                        using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Compress, true))
                        {
                            gZipStream.Write(encodingBuffer, 0, encodingBuffer.Length);
                        }

                        break;
                    }
                case CompressAlgorithm.Deflate:
                    {
                        using (var deflateStream = new DeflateStream(memoryStream, CompressionMode.Compress, true))
                        {
                            deflateStream.Write(encodingBuffer, 0, encodingBuffer.Length);
                        }

                        break;
                    }
                default:
                    using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Compress, true))
                    {
                        gZipStream.Write(encodingBuffer, 0, encodingBuffer.Length);
                    }

                    break;
            }

            memoryStream.Position = 0;

            var compressedData = new byte[memoryStream.Length];
            memoryStream.Read(compressedData, 0, compressedData.Length);

            var streamBuffer = new byte[compressedData.Length + 4];
            Buffer.BlockCopy(compressedData, 0, streamBuffer, 4, compressedData.Length);
            Buffer.BlockCopy(BitConverter.GetBytes(encodingBuffer.Length), 0, streamBuffer, 0, 4);
            return Convert.ToBase64String(streamBuffer);
        }

        /// <summary>
        /// Decompresses the string.
        /// </summary>
        /// <param name="compressedText">The compressed text.</param>
        /// <param name="encoding"></param>
        /// <param name="algorithm"></param>
        /// <returns></returns>
        //public static async Task<string> DecompressStringAsync(string compressedText, Encoding encoding, CompressAlgorithm algorithm = CompressAlgorithm.Deflate)
        //{
        //    var streamBuffer = Convert.FromBase64String(compressedText);
        //    using (var memoryStream = new MemoryStream())
        //    {
        //        var dataLength = BitConverter.ToInt32(streamBuffer, 0);
        //        await memoryStream.WriteAsync(streamBuffer, 4, streamBuffer.Length - 4);

        //        var buffer = new byte[dataLength];

        //        memoryStream.Position = 0;
        //        switch (algorithm)
        //        {
        //            case CompressAlgorithm.GZip:
        //                {
        //                    using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
        //                    {
        //                        await gZipStream.ReadAsync(buffer, 0, buffer.Length);
        //                    }

        //                    break;
        //                }
        //            case CompressAlgorithm.Deflate:
        //                {
        //                    using (var deflateStream = new DeflateStream(memoryStream, CompressionMode.Decompress))
        //                    {
        //                        await deflateStream.ReadAsync(buffer, 0, buffer.Length);
        //                    }

        //                    break;
        //                }
        //            default:
        //                using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
        //                {
        //                    await gZipStream.ReadAsync(buffer, 0, buffer.Length);
        //                }

        //                break;
        //        }

        //        return encoding.GetString(buffer);  //Encoding.UTF8.GetString(buffer);
        //    }
        //}
        public static string DecompressString(string compressedText, Encoding encoding, CompressAlgorithm algorithm = CompressAlgorithm.Deflate)
        {
            var streamBuffer = Convert.FromBase64String(compressedText);
            using (var memoryStream = new MemoryStream())
            {
                var dataLength = BitConverter.ToInt32(streamBuffer, 0);
                memoryStream.WriteAsync(streamBuffer, 4, streamBuffer.Length - 4);

                var buffer = new byte[dataLength];

                memoryStream.Position = 0;
                switch (algorithm)
                {
                    case CompressAlgorithm.GZip:
                        {
                            using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
                            {
                                gZipStream.Read(buffer, 0, buffer.Length);
                            }

                            break;
                        }
                    case CompressAlgorithm.Deflate:
                        {
                            using (var deflateStream = new DeflateStream(memoryStream, CompressionMode.Decompress))
                            {
                                deflateStream.Read(buffer, 0, buffer.Length);
                            }

                            break;
                        }
                    default:
                        using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
                        {
                            gZipStream.Read(buffer, 0, buffer.Length);
                        }

                        break;
                }

                return encoding.GetString(buffer);  //Encoding.UTF8.GetString(buffer);
            }
        }

        //public static string GetUniqueKey(int maxSize)
        //{
        //    var chars = "123456789".ToCharArray();
        //    var data = new byte[1];
        //    var crypto = new RNGCryptoServiceProvider();
        //    crypto.GetNonZeroBytes(data);
        //    data = new byte[maxSize];
        //    crypto.GetNonZeroBytes(data);
        //    var result = new StringBuilder(maxSize);
        //    foreach (var b in data)
        //    {
        //        result.Append(chars[b % (chars.Length)]);
        //    }
        //    return result.ToString();
        //}

        //public static byte[] ConvertToAsciiCode(string code)
        //{
        //    var ascii = Encoding.ASCII;
        //    var encodedBytes = ascii.GetBytes(code);
        //    return encodedBytes;

        //}
        //public static string ConvertToHexCode(string code)
        //{
        //    var hex = "";
        //    foreach (var t in code)
        //    {
        //        hex += Microsoft.VisualBasic.Conversion.Hex(t);
        //    }
        //    return hex;
        //}
        //public static bool IsAllDigits(string inputBox)
        //{
        //    return inputBox.All(char.IsDigit);
        //}

        //public static bool IsPositive(int number)
        //{
        //    return number > 0;
        //}

        //public static bool IsNegative(int number)
        //{
        //    return number < 0;
        //}
        //public static bool IsZero(int number)
        //{
        //    return number == 0;
        //}
        //public const string EmailPattern =
        //    @"^([0-9a-zA-Z]" + //Start with a digit or alphabate
        //    @"([\+\-_\.][0-9a-zA-Z]+)*" + // No continues or ending +-_. chars in email
        //    @")+" + @"@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,17})$";

        //public const String PatternA = @"^([a-zA-Z]\d";

        //public static bool GetInvalidInput(string inputBox, string expressionPattern, string message, string messageTitleBar)
        //{
        //    var valid = Regex.Match(inputBox, expressionPattern).Success;
        //    if (!valid)
        //    {
        //        MessageBox.Show(message, messageTitleBar, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    }
        //    return valid;
        //}

        //public static T Clone<T>(this T controlToClone)
        //    where T : Control
        //{
        //    PropertyInfo[] controlProperties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

        //    T instance = Activator.CreateInstance<T>();

        //    foreach (PropertyInfo propInfo in controlProperties)
        //    {
        //        if (propInfo.CanWrite)
        //        {
        //            if (propInfo.Name != "WindowTarget")
        //                propInfo.SetValue(instance, propInfo.GetValue(controlToClone, null), null);
        //        }
        //    }

        //    return instance;
        //}

        public static string GetBinFolderPath()
        {
            var path = Path.GetDirectoryName(
                System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)?.Replace("file:\\", "");
            return path;
        }

        //public static void CopyAllTo<T>(this T source, T target)
        //{
        //    var type = typeof(T);
        //    foreach (var sourceProperty in type.GetProperties())
        //    {
        //        var targetProperty = type.GetProperty(sourceProperty.Name);
        //        targetProperty?.SetValue(target, sourceProperty.GetValue(source, null), null);
        //    }
        //    foreach (var sourceField in type.GetFields())
        //    {
        //        var targetField = type.GetField(sourceField.Name);
        //        targetField.SetValue(target, sourceField.GetValue(source));
        //    }
        //}

        //public static void InitFont(Control control)
        //{
        //    var pfc = new PrivateFontCollection();
        //    var fontLength = Properties.Resources.TTahoma.Length;
        //    var fontData = Properties.Resources.TTahoma;
        //    var data = Marshal.AllocCoTaskMem(fontLength);
        //    Marshal.Copy(fontData, 0, data, fontLength);
        //    pfc.AddMemoryFont(data, fontLength);
        //    Marshal.FreeCoTaskMem(data);
        //    control.Font = new Font(pfc.Families[0], control.Font.Size);
        //}
    }
}