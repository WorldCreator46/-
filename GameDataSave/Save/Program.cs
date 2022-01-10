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
            WriteLine("Salt(Base64) : " + Convert.ToBase64String(salt));

            //PBKDF2(Password-Based Key Derivation Function)
            //반복은 65535번
            var PBKDF2Key = new Rfc2898DeriveBytes(password, salt, 65535, HashAlgorithmName.SHA256);
            var secretKey = PBKDF2Key.GetBytes(aes.KeySize / 8);
            var iv = PBKDF2Key.GetBytes(aes.BlockSize / 8);

            WriteLine("SecretKey(Base64) : " + Convert.ToBase64String(secretKey));
            WriteLine("IV(Base64) : " + Convert.ToBase64String(iv));

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
        public byte[] AESDecrypt256(byte[] decryptData, String password)
        {
            // Salt는 비밀번호의 길이를 SHA256 해쉬값으로 한다.
            var salt = sha256Managed.ComputeHash(Encoding.UTF8.GetBytes(password.Length.ToString()));

            //PBKDF2(Password-Based Key Derivation Function)
            //반복은 65535번
            var PBKDF2Key = new Rfc2898DeriveBytes(password, salt, 65535, HashAlgorithmName.SHA256);
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
        static void Main(string[] args)
        {
            /*
            AESEncrypt aes = new AESEncrypt();
            var planeText = "a";
            var password = "a";

            WriteLine("오리지널 문장 : " + planeText);
            WriteLine("대칭키로 쓰일 키 : " + password);
            WriteLine("");

            //스트링을 byte배열로 변환
            var byteArray = Encoding.UTF8.GetBytes(planeText);

            //AES256으로 인크립트
            byte[] encryptedArray = aes.AESEncrypt256(byteArray, password);
            WriteLine("");
            WriteLine("인크립트 된 문자열 : " + Encoding.UTF8.GetString(encryptedArray));

            //디크립트(AES256)
            byte[] decryptedArray = aes.AESDecrypt256(encryptedArray, password);
            var decryptedString = Encoding.UTF8.GetString(decryptedArray);
            WriteLine("디크립트 된 문자열 : " + decryptedString);
            WriteLine("");
            */
            foreach (string Name in PropertyName)
            {
                Property[Name] = BigInteger.Zero;
            }
            // 바꾸기
            string json = JsonConvert.SerializeObject(Property, Formatting.Indented);
            WriteLine(json);
            json = json.Replace("0", "1");
            Property = JsonConvert.DeserializeObject<Dictionary<string, BigInteger>>(json);

            foreach (string Name in PropertyName)
            {
                WriteLine(Property[Name]);
            }
        }
    }
}
