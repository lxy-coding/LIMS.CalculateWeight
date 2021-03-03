using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.Common
{
    /// <summary>
    /// 加解密
    /// </summary>
    public sealed class Crypt
    {
        private static string key = "2011card";//密钥

        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="encryptString"></param>
        /// <returns></returns>
        public static string DesEncrypt(string encryptString)
        {
            return DesEncrypt(encryptString, key);
        }

        ///函数名称：DesEncrypt 
        ///功能说明：DES加密 
        ///输入参数：string encryptString:待加密字符串
        ///返回说明：string :加密后字符串
        ///编    写：
        ///编写日期：2019/10/11
        public static string DesEncrypt(string encryptString, string sKey)
        {
            if (sKey.Length < 8)
            {
                return "";
            }
            if (encryptString == null || encryptString == "")
            {
                return "";
            }
            try
            {
                byte[] keyBytes = Encoding.UTF8.GetBytes(sKey.Substring(0, 8));
                byte[] keyIV = keyBytes;
                byte[] inputByteArray = Encoding.UTF8.GetBytes(encryptString);
                DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
                MemoryStream mStream = new MemoryStream();
                CryptoStream cStream = new CryptoStream(mStream, provider.CreateEncryptor(keyBytes, keyIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return Convert.ToBase64String(mStream.ToArray());
            }
            catch
            {
                return "";
            }

        }

        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="decryptString"></param>
        /// <returns></returns>
        public static string DesDecrypt(string decryptString)
        {
            return DesDecrypt(decryptString, key);
        }
        ///函数名称：DesDecrypt 
        ///功能说明：DES解密 
        ///输入参数：string decryptString:待解密字符串
        ///返回说明：string :解密后字符串
        ///编    写：
        ///编写日期：2010/11/30
        public static string DesDecrypt(string decryptString, string sKey)
        {
            if (sKey.Length < 8)
            {
                return "";
            }
            if (decryptString == null || decryptString == "")
            {
                return "";
            }
            try
            {
                byte[] keyBytes = Encoding.UTF8.GetBytes(sKey.Substring(0, 8));
                byte[] keyIV = keyBytes;
                byte[] inputByteArray = Convert.FromBase64String(decryptString);
                DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
                MemoryStream mStream = new MemoryStream();
                CryptoStream cStream = new CryptoStream(mStream, provider.CreateDecryptor(keyBytes, keyIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return Encoding.UTF8.GetString(mStream.ToArray());
            }
            catch
            {
                return "";
            }
        }

        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="sKey">密钥</param>
        /// <returns></returns>
        public static string Md5(string sKey)
        {
            string sRtn = "";
            try
            {
                MD5CryptoServiceProvider hashMD5 = new MD5CryptoServiceProvider();
                byte[] byt = hashMD5.ComputeHash(Encoding.Default.GetBytes(sKey));
                StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < byt.Length; i++)
                {
                    sBuilder.Append(byt[i].ToString("x2"));
                }
                sRtn = sBuilder.ToString();
            }
            catch
            {
                sRtn = "";
            }
            return sRtn;
        }
    }
}
