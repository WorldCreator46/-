using System;
using System.Collections.Generic;
using System.Numerics;
using System.IO;
using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Text;
using static System.Console;

namespace Save
{
    class AESEncrypt
    {
        private SHA256Managed sha256Managed = new SHA256Managed();
        private RijndaelManaged aes = new RijndaelManaged();
        public AESEncrypt()
        {
            aes.KeySize = 256;
            aes.BlockSize = 128;
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;
        }
        //AES_256 암호화
        public byte[] AESEncrypt256(byte[] encryptData, String password)
        {
            // Salt는 비밀번호의 길이를 SHA256 해쉬값으로 한다.
            var salt = sha256Managed.ComputeHash(Encoding.UTF8.GetBytes(password.Length.ToString()));
            // WriteLine("Salt(Base64) : " + Convert.ToBase64String(salt));

            //PBKDF2(Password-Based Key Derivation Function)
            //반복은 65535번
            // var PBKDF2Key = new Rfc2898DeriveBytes(password, salt, 65535, HashAlgorithmName.SHA256);
            var PBKDF2Key = new Rfc2898DeriveBytes(password, salt, 65535);
            var secretKey = PBKDF2Key.GetBytes(aes.KeySize / 8);
            var iv = PBKDF2Key.GetBytes(aes.BlockSize / 8);

            // WriteLine("SecretKey(Base64) : " + Convert.ToBase64String(secretKey));
            // WriteLine("IV(Base64) : " + Convert.ToBase64String(iv));

            byte[] xBuff = null;
            using (var ms = new MemoryStream())
            {
                using (var cs = new CryptoStream(ms, aes.CreateEncryptor(secretKey, iv), CryptoStreamMode.Write))
                {
                    cs.Write(encryptData, 0, encryptData.Length);
                }
                xBuff = ms.ToArray();
            }
            return xBuff;
        }
        //AES_256 복호화
        public byte[] AESDecrypt256(byte[] decryptData, string password)
        {
            // Salt는 비밀번호의 길이를 SHA256 해쉬값으로 한다.
            var salt = sha256Managed.ComputeHash(Encoding.UTF8.GetBytes(password.Length.ToString()));

            //PBKDF2(Password-Based Key Derivation Function)
            //반복은 65535번
            // var PBKDF2Key = new Rfc2898DeriveBytes(password, salt, 65535, HashAlgorithmName.SHA256);
            var PBKDF2Key = new Rfc2898DeriveBytes(password, salt, 65535);
            WriteLine(PBKDF2Key.HashAlgorithm.Name);
            var secretKey = PBKDF2Key.GetBytes(aes.KeySize / 8);
            var iv = PBKDF2Key.GetBytes(aes.BlockSize / 8);

            byte[] xBuff = null;
            using (var ms = new MemoryStream())
            {
                using (var cs = new CryptoStream(ms, aes.CreateDecryptor(secretKey, iv), CryptoStreamMode.Write))
                {
                    cs.Write(decryptData, 0, decryptData.Length);
                }
                xBuff = ms.ToArray();
            }
            return xBuff;
        }
    }
    class Program
    {
        public static string[] PropertyName = { "Cash", "Stock", "Furniture", "Jewelry", "NobleMetals", "RealEstate", "Car", "Bitcoin", "Accessories", "Etc" };
        private static Dictionary<string, BigInteger> Property = new Dictionary<string, BigInteger>();
        static string SaveFilePath = @"C:\Data\SaveData";
        static string password = "사람";
        static void SetProperty()
        {
            foreach (string Name in PropertyName)
            {
                Property[Name] = BigInteger.Zero;
            }
        }
        static void SetProperty(string property)
        {
            Property = JsonConvert.DeserializeObject<Dictionary<string, BigInteger>>(property);
        }
        static void PrintProperty()
        {
            foreach (string Name in PropertyName)
            {
                WriteLine(Property[Name]);
            }
        }
        static void WriteFile(byte[] content)
        {
            try
            {
                File.WriteAllBytes(SaveFilePath, content);
                WriteLine(SaveFilePath + "파일 쓰기 성공");
            }
            catch
            {
                WriteLine(SaveFilePath + "파일 쓰기 실패");
            }
        }
        static void ReadFile()
        {
            try
            {
                AESEncrypt aes = new AESEncrypt();
                SetProperty(Encoding.UTF8.GetString(aes.AESDecrypt256(File.ReadAllBytes(SaveFilePath), password)));
                WriteLine(SaveFilePath + "파일 읽기 성공");
            }
            catch
            {
                WriteLine(SaveFilePath + "파일 읽기 실패");
            }
        }
        static void Main(string[] args)
        {
            AESEncrypt aes = new AESEncrypt();
            SetProperty();
            var planeText = JsonConvert.SerializeObject(Property, Formatting.Indented);


            WriteLine(aes.AESEncrypt256(Encoding.UTF8.GetBytes(planeText), password));
            WriteFile(aes.AESEncrypt256(Encoding.UTF8.GetBytes(planeText), password));

            ReadFile();

            foreach(string name in PropertyName)
            {
                Property[name] = BigInteger.Parse("52");
            }

            planeText = JsonConvert.SerializeObject(Property, Formatting.Indented);

            var s = Encoding.UTF8.GetString(aes.AESEncrypt256(Encoding.UTF8.GetBytes(planeText), password));

            WriteLine(s);
            WriteFile(aes.AESEncrypt256(Encoding.UTF8.GetBytes(planeText), password));

            ReadFile();
            

            ReadFile();
            PrintProperty();

            // 교본
            {
                /*
            //AES256으로 인크립트
            byte[] encryptedArray = aes.AESEncrypt256(Encoding.UTF8.GetBytes(planeText), password);
            //WriteLine("인크립트 된 문자열 : " + Encoding.UTF8.GetString(encryptedArray));

            //WriteLine(Encoding.UTF8.GetString(encryptedArray));

            //WriteLine(Encoding.UTF8.GetString(aes.AESDecrypt256(encryptedArray, password)));
            //WriteLine(Encoding.UTF8.GetString(aes.AESDecrypt256(temp, password)));

            //디크립트(AES256)
            var decryptedString = Encoding.UTF8.GetString(aes.AESDecrypt256(encryptedArray, password));
            */
            }
        }
    }
}
