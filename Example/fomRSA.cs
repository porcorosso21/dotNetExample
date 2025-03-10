using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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


        private void btnCreateKey_Click(object sender, EventArgs e)
        {
            RSA rsa = new RSA();
            tbPublicKey.Text = rsa.PublicKey;
            tbPrivateKey.Text = rsa.PrivateKey;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (tbPublicKey.Text.Trim().Length == 0 || tbPrivateKey.Text.Trim().Length == 0) { return; }

            RSA rsa = new RSA();
            tbEncrypt.Text = rsa.Encrypt("Apple", tbPublicKey.Text);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (tbPublicKey.Text.Trim().Length == 0 || tbPrivateKey.Text.Trim().Length == 0 || tbEncrypt.Text.Trim().Length == 0) { return; }

            RSA rsa = new RSA();
            tbDecrypt.Text = rsa.Decrypt(tbEncrypt.Text, tbPrivateKey.Text);
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
    }
}
