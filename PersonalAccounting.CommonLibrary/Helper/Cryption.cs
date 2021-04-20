//using System;
//using System.IO;
//using System.Security.Cryptography;
//using System.Text;

//namespace PersonalAccounting.CommonLibrary.Helper
//{
//    public sealed class Cryption
//    {
//        //members of the Cryption 
//        //algorithm type in my case it’s RijndaelManaged
//        private RijndaelManaged _algorithm;
//        //memory stream
//        private MemoryStream _memStream;
//        //ICryptoTransform interface
//        private ICryptoTransform _encryptorDecryptor;
//        //CryptoStream
//        private CryptoStream _crStream;
//        //Stream writer and Stream reader
//        private StreamWriter _strWriter;
//        private StreamReader _strReader;
//        //internal members
//        private string _mKey;
//        private string _mIv;
//        //the Key and the Inicialization Vector
//        private byte[] _key;
//        private byte[] _iv;
//        //password view
//        private string _pwdStr;
//        private byte[] _pwdByte;
//        //Constructor
//        public Cryption(string keyVal, string ivVal)
//        {
//            _key = new byte[32];
//            _iv = new byte[32];

//            int i;
//            _mKey = keyVal;
//            _mIv = ivVal;
//            //key calculation, depends on first constructor parameter
//            for (i = 0; i < _mKey.Length; i++)
//            {
//                _key[i] = Convert.ToByte(_mKey[i]);
//            }
//            //IV calculation, depends on second constructor parameter
//            for (i = 0; i < _mIv.Length; i++)
//            {
//                _iv[i] = Convert.ToByte(_mIv[i]);
//            }

//        }
//        //Encrypt method implementation
//        public string Encrypt(string s)
//        {
//            //new instance of algorithm creation
//            _algorithm = new RijndaelManaged();

//            //setting algorithm bit size
//            _algorithm.BlockSize = 256;
//            _algorithm.KeySize = 256;

//            //creating new instance of Memory stream
//            _memStream = new MemoryStream();

//            //creating new instance of the Encryptor
//            _encryptorDecryptor = _algorithm.CreateEncryptor(_key, _iv);

//            //creating new instance of CryptoStream
//            _crStream = new CryptoStream(_memStream, _encryptorDecryptor,
//            CryptoStreamMode.Write);

//            //creating new instance of Stream Writer
//            _strWriter = new StreamWriter(_crStream);

//            //cipher input string
//            _strWriter.Write(s);

//            //clearing buffer for currnet writer and writing any 
//            //buffered data to //the underlying device
//            _strWriter.Flush();
//            _crStream.FlushFinalBlock();

//            //storing cipher string as byte array 
//            _pwdByte = new byte[_memStream.Length];
//            _memStream.Position = 0;
//            _memStream.Read(_pwdByte, 0, (int)_pwdByte.Length);

//            //storing cipher string as Unicode string
//            _pwdStr = new UnicodeEncoding().GetString(_pwdByte);

//            return _pwdStr;
//        }

//        //Decrypt method implementation 
//        public string Decrypt(string s)
//        {
//            //new instance of algorithm creation
//            _algorithm = new RijndaelManaged();

//            //setting algorithm bit size
//            _algorithm.BlockSize = 256;
//            _algorithm.KeySize = 256;

//            //creating new Memory stream as stream for input string      
//            MemoryStream memStream = new MemoryStream(
//               new UnicodeEncoding().GetBytes(s));

//            //Decryptor creating 
//            ICryptoTransform encryptorDecryptor =
//                _algorithm.CreateDecryptor(_key, _iv);

//            //setting memory stream position
//            memStream.Position = 0;

//            //creating new instance of Crupto stream
//            CryptoStream crStream = new CryptoStream(
//                memStream, encryptorDecryptor, CryptoStreamMode.Read);

//            //reading stream
//            _strReader = new StreamReader(crStream);

//            //returnig decrypted string
//            return _strReader.ReadToEnd();
//        }
//    }
//}
