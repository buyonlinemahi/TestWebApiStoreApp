using Microsoft.Extensions.Configuration;
using System.Security.Cryptography;
using System;
using System.Net.Http;
using System.Text;

namespace OnlineStoreMGTAPP.Helper
{
    public  class WebApiHelper
    {
       
        public  static HttpClient Initial()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json");
            var client = new HttpClient();            
            client.BaseAddress = new Uri(Convert.ToString(config.Build().GetSection("WebApiHosting").Value));
            client.DefaultRequestHeaders.Accept.Clear();
            return client;
        }
        public static HttpClient Url()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json");
            var client = new HttpClient();
            client.BaseAddress = new Uri(Convert.ToString(config.Build().GetSection("ReSetUrl").Value));
            client.DefaultRequestHeaders.Accept.Clear();
            return client;
        }

        string _key = "qwertyuiopasdfghjklzxcvbnm1234567890";

        public string EncryptString(string encryptString)
        {
            string concatenateEncryptString = encryptString;
            TripleDESCryptoServiceProvider objDESCrypto = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider objHashMD5 = new MD5CryptoServiceProvider();
            byte[] byteHash, byteBuff;
            string strTempKey = _key;
            byteHash = objHashMD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(strTempKey));
            objHashMD5 = null;
            objDESCrypto.Key = byteHash;
            objDESCrypto.Mode = CipherMode.ECB; //CBC, CFB
            byteBuff = ASCIIEncoding.ASCII.GetBytes(concatenateEncryptString);
            return Convert.ToBase64String(objDESCrypto.CreateEncryptor().
            TransformFinalBlock(byteBuff, 0, byteBuff.Length)).Replace("/", "!").Replace("+", "]");
        }


        public string DecryptString(string cipherText)
        {
            cipherText = cipherText.Replace("!", "/").Replace("]", "+");
            TripleDESCryptoServiceProvider objDESCrypto = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider objHashMD5 = new MD5CryptoServiceProvider();
            byte[] byteHash, byteBuff;
            string strTempKey = _key;
            byteHash = objHashMD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(strTempKey));
            objHashMD5 = null;
            objDESCrypto.Key = byteHash;
            objDESCrypto.Mode = CipherMode.ECB; //CBC, CFB
            byteBuff = Convert.FromBase64String(cipherText);
            string strDecrypted = ASCIIEncoding.ASCII.GetString
            (objDESCrypto.CreateDecryptor().TransformFinalBlock
            (byteBuff, 0, byteBuff.Length));
            objDESCrypto = null;
            return strDecrypted;

        }

        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password, 11);
        }

        public bool VerifyHashedPassword(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }

    }
}
