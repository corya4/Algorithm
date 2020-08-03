using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace Structure_Test
{

    enum CryptoType
    {
        ENC, DEC
    }

    class Crypto
    {
        private byte[] KEY { get; set; }

        public Crypto(String param)
        {
            KEY = ASCIIEncoding.UTF8.GetBytes(param);
        }

        public String Result(CryptoType type, String data)
        {
            DESCryptoServiceProvider desc = new DESCryptoServiceProvider() { Key = KEY, IV = KEY };

            var p = new { state = (type == CryptoType.ENC) ? desc.CreateEncryptor() : desc.CreateDecryptor(),
                          bytes = (type == CryptoType.ENC) ? Encoding.UTF8.GetBytes(data.ToCharArray()) : Convert.FromBase64String(data.ToString())};
            //Encode Type Equal KEY
            
            int length = p.bytes.Length;

            MemoryStream ms = new MemoryStream(length); // void -> '?' remove
            CryptoStream cs = new CryptoStream(ms, p.state, CryptoStreamMode.Write);

            cs.Write(p.bytes, 0, length);
            cs.FlushFinalBlock(); // close + push

            return type == CryptoType.ENC ? Convert.ToBase64String(ms.ToArray()) : Encoding.UTF8.GetString(ms.GetBuffer());
                                                                                                            //Length over -> "?"
        }


    }
}
