using System;
using System.Text;

namespace JewelryStore
{
    sealed class StringDecryptor : IStringDecryptor
    {
        private readonly UTF8Encoding _encoder;
        private readonly Decoder _utf8Decode;
        public StringDecryptor()
        {
            _encoder = new UTF8Encoding();
            _utf8Decode = _encoder.GetDecoder();
        }
        /// <summary>
        /// Decrypts a given text and returns the decrypted data
        /// as a base64 string.
        /// </summary>
        /// <param name="plainText">An decrypted string that needs
        /// to be used for manipulation.</param>
        /// <returns>A base64 encoded string that represents the encrypted
        /// binary data.
        /// </returns>
        /// <exception cref="ArgumentNullException">If <paramref name="plainText"/>
        /// is a null reference.</exception>
        public string DecodeFrom64(string encodedString)
        {
            if (encodedString == null)
            {
                throw new ArgumentNullException("No Encoded string to Decode");
            }


            byte[] todecode_byte = Convert.FromBase64String(encodedString);
            int charCount = _utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            _utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);

            return new string(decoded_char);
            
        }
    }
}
