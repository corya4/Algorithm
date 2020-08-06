using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MainFrame.Sources
{
    class Crypto
    {
        private byte[] key { get; set; } //EncodingとDecodingする暗号

        public Crypto()
        {
            key = ASCIIEncoding.UTF8.GetBytes("REFAFK93");
        }

        public String Result(int type, String data)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider() { Key = key, IV = key };
            //Key : メイン暗号演算値
            //IV : 最初の暗号演算値

            var property = new
            {
                form = type == 0 ? des.CreateEncryptor() : des.CreateDecryptor(),
                account = type == 0 ? Encoding.UTF8.GetBytes(data.ToCharArray()) : Convert.FromBase64String(data)
            };

            int length = property.account.Length;

            MemoryStream ms = new MemoryStream(length);

            CryptoStream cs = new CryptoStream(ms, property.form, CryptoStreamMode.Write);

            cs.Write(property.account, 0, length);
            cs.FlushFinalBlock();

            return type == 0 ? Convert.ToBase64String(ms.ToArray()) : Encoding.UTF8.GetString(ms.GetBuffer());
        }
    }
}
