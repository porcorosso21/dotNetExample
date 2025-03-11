using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotNetExample.Example
{
    public partial class fomRSA: Form
    {
        public fomRSA()
        {
            InitializeComponent();
        }

        #region RSA
        private void btnRSACreateKey_Click(object sender, EventArgs e)
        {
            RSA rsa = new RSA();
            tbRSAPublicKey.Text = rsa.PublicKey;
            tbRSAPrivateKey.Text = rsa.PrivateKey;
        }

        private void btnRSAEncrypt_Click(object sender, EventArgs e)
        {
            if (tbRSAPublicKey.Text.Trim().Length == 0 || tbRSAPrivateKey.Text.Trim().Length == 0) { return; }

            RSA rsa = new RSA();
            tbRSAEncrypt.Text = rsa.Encrypt("Apple", tbRSAPublicKey.Text);
        }

        private void btnRSADecrypt_Click(object sender, EventArgs e)
        {
            if (tbRSAPublicKey.Text.Trim().Length == 0 || tbRSAPrivateKey.Text.Trim().Length == 0 || tbRSAEncrypt.Text.Trim().Length == 0) { return; }

            RSA rsa = new RSA();
            tbRSADecrypt.Text = rsa.Decrypt(tbRSAEncrypt.Text, tbRSAPrivateKey.Text);
        }

        public class RSA
        {
            public RSA()
            {
                rsa = new RSACryptoServiceProvider(2048);
            }

            private RSACryptoServiceProvider rsa;

            /// <summary>PublicKey</summary>
            public String PublicKey { get { return rsa.ToXmlString(false); } }

            /// <summary>PrivateKey</summary>
            public String PrivateKey { get { return rsa.ToXmlString(true); } }

            /// <summary>
            /// 加密
            /// </summary>
            /// <param name="text"></param>
            /// <param name="publickey"></param>
            /// <returns></returns>
            public String Encrypt(String text, String publickey)
            {
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    rsa.FromXmlString(publickey);
                    byte[] plaintextBytes = Encoding.UTF8.GetBytes(text);
                    byte[] ciphertextBytes = rsa.Encrypt(plaintextBytes, false);
                    return Convert.ToBase64String(ciphertextBytes);
                }
            }

            /// <summary>
            /// 解密
            /// </summary>
            /// <param name="text"></param>
            /// <param name="privatekey"></param>
            /// <returns></returns>
            public String Decrypt(String text, String privatekey)
            {
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    rsa.FromXmlString(privatekey);
                    byte[] ciphertextBytes = Convert.FromBase64String(text);
                    byte[] plaintextBytes = rsa.Decrypt(ciphertextBytes, false);
                    return Encoding.UTF8.GetString(plaintextBytes);
                }
            }
        }
        #endregion

        #region AES
        private void btnAESCreateKey_Click(object sender, EventArgs e)
        {
            AES aes = new AES();
            tbAESKey.Text = aes.Key;
            tbAESIV.Text = aes.IV;
        }

        private void btnAESEncrypt_Click(object sender, EventArgs e)
        {
            if (tbAESKey.Text.Trim().Length == 0 || tbAESIV.Text.Trim().Length == 0) { return; }

            AES aes = new AES();
            tbAESEncrypt.Text = aes.Encrypt("Banana", tbAESKey.Text, tbAESIV.Text);
        }

        private void btnAESDecrypt_Click(object sender, EventArgs e)
        {
            if (tbAESKey.Text.Trim().Length == 0 || tbAESIV.Text.Trim().Length == 0 || tbAESEncrypt.Text.Trim().Length == 0) { return; }

            AES aes = new AES();
            tbAESDecrypt.Text = aes.Decrypt(tbAESEncrypt.Text, tbAESKey.Text, tbAESIV.Text);
        }

        public class AES
        { 
            /// <summary>KEY</summary>
            public String Key { get { return key; } }
            private String key { get; set; }

            /// <summary>IV(初始化向量)</summary>
            public String IV { get { return iv; } }
            private String iv { get; set; }

            public AES()
            {
                using (Aes aesAlg = Aes.Create())
                {
                    this.key = Convert.ToBase64String(aesAlg.Key);
                    this.iv = Convert.ToBase64String(aesAlg.IV);
                }
            }

            /// <summary>
            /// 加密
            /// </summary>
            /// <param name="text"></param>
            /// <param name="key"></param>
            /// <param name="iv"></param>
            /// <returns></returns>
            public String Encrypt(String text, String key, String iv)
            {
                using (Aes aesAlg = Aes.Create())
                {
                    // 設定 AES 加密參數
                    aesAlg.Key = Convert.FromBase64String(key);
                    aesAlg.IV = Convert.FromBase64String(iv);

                    // 建立加密器
                    ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                    // 使用 MemoryStream 儲存加密後的資料
                    using (MemoryStream msEncrypt = new MemoryStream())
                    {
                        using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                            {
                                // 將明文寫入加密流
                                swEncrypt.Write(text);
                            }
                            return Convert.ToBase64String(msEncrypt.ToArray());
                        }
                    }
                }
            }

            /// <summary>
            /// 解密
            /// </summary>
            /// <param name="text"></param>
            /// <param name="key"></param>
            /// <param name="iv"></param>
            /// <returns></returns>
            public String Decrypt(String text, String key, String iv)
            {
                using (Aes aesAlg = Aes.Create())
                {
                    // 設定 AES 解密參數
                    aesAlg.Key = Convert.FromBase64String(key);
                    aesAlg.IV = Convert.FromBase64String(iv);

                    // 建立解密器
                    ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                    // 將密文轉換為 byte 陣列
                    byte[] cipherBytes = Convert.FromBase64String(text);

                    // 使用 MemoryStream 儲存解密後的資料
                    using (MemoryStream msDecrypt = new MemoryStream(cipherBytes))
                    {
                        using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                            {
                                // 從解密流讀取明文
                                return srDecrypt.ReadToEnd();
                            }
                        }
                    }
                }
            }
        }

        #endregion


    }
}
