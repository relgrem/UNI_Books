using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace Uni_Books
{
    class clsCrypto
    {
        private string secretkey = "AA1351K2U3J";
        private string publickey = "J88A1s2d3f4GWPDSJ82HH2J3ME";
        private byte[] aKey;
        private byte[] aIV;
        private byte[] vBuffer;
        public enum encStringFormat
        {
            Unicode,
            Utf8,
            ASCII,
            Base64
        }


        public void Set_Keys(string Private_key_value, string public_key_value)
        {
            this.secretkey = Private_key_value ;
            this.publickey = public_key_value;
            using (Aes A = Aes.Create())
            {
                A.Key = FormatKey(this.publickey, 32);
                this.aKey = FormatKey(this.publickey, 32);
                this.aIV = FormatKey(this.secretkey, A.BlockSize / 8);
            }
        }

        public void Encrypt_to_Buffer(string Value)
        {
            // Check arguments.
            if (Value == null || Value.Length <= 0)
                throw new ArgumentNullException("Value");

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = this.aKey;
                aesAlg.IV = this.aIV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(Value);
                        }
                        this.vBuffer  = msEncrypt.ToArray();
                    }
                }
            }
        }

        public string Decrypt_From_Base64(string B64_string)
        {
            this.vBuffer = strBytes(B64_string, encStringFormat.Base64);
            return Decrypt();
        }

        public string Decrypt()
        {
            string rv = "";
            using (Aes A = Aes.Create())
            {
                A.Key = this.aKey;
                A.IV = this.aIV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = A.CreateDecryptor(this.aKey, this.aIV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(this.vBuffer))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            rv = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            return rv;
        }

        /// <summary>
        /// Returns the Base64 from the currently buffered Byte array
        /// </summary>
        /// <returns></returns>
        public string Get_Buffer_Base64()
        {
            if (this.vBuffer.Length==0) return "";
            return strString(this.vBuffer, encStringFormat.Base64);
        }

        public string DLM()
        {
            string rv = "";
            string ev = "user_name=" + this.publickey + 'ÿ';
            ev += "password=" + this.secretkey + 'ÿ';
            rv = ev;
            return rv;
        }

        public void Clear()
        {
            this.aIV = null;
            this.aKey = null;
            this.publickey = "";
            this.secretkey = "";
            this.vBuffer = null;
        }

        public string Get_Key_Base64(string FromString)
        {
            return Convert.ToBase64String(Encoding.Unicode.GetBytes(FromString));
        }

        private byte[] FormatKey(string fromString, int length)
        {
            string fl = fromString;
            if (length == 0) length = 32;
            if (fl.Length<length )
            {
                while (fl.Length<length) { fl += fromString; }
            }
            return Encoding.ASCII.GetBytes(Get_Key_Base64(fl).Substring(0, length));
        }

        public byte[] strBytes(string Value, encStringFormat Format)
        {
            if (Format==encStringFormat.ASCII)
            {
                return Encoding.ASCII.GetBytes(Value);
            }
            else if(Format==encStringFormat.Unicode)
            {
                return Encoding.Unicode.GetBytes(Value);
            }
            else if (Format == encStringFormat.Utf8)
            {
                return Encoding.UTF8.GetBytes(Value);
            }
            else
            {
                return Convert.FromBase64String(Value);
            }
        }

        public string strString(byte[] Value, encStringFormat Format)
        {
            if (Format == encStringFormat.ASCII)
            {
                return Encoding.ASCII.GetString(Value);
            }
            else if (Format == encStringFormat.Unicode)
            {
                return Encoding.Unicode.GetString(Value);
            }
            else if (Format == encStringFormat.Utf8)
            {
                return Encoding.UTF8.GetString(Value);
            }
            else
            {
                return Convert.ToBase64String(Value);
            }
        }

    }

}
