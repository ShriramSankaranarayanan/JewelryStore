using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryStore
{
    sealed class StringEncryptor : IStringEncryptor
    {
        /// <summary>
        /// Encrypts a given text and returns the encrypted data
        /// as a base64 string.
        /// </summary>
        /// <param name="plainText">An unencrypted string that needs
        /// to be secured.</param>
        /// <returns>A base64 encoded string that represents the encrypted
        /// binary data.
        /// </returns>
        /// <exception cref="ArgumentNullException">If <paramref name="plainText"/>
        /// is a null reference.</exception>
        public string EncodeToBase64(string plainText)
        {
            if (plainText == null)
            {
                throw new ArgumentNullException("Text with no value");
            }

            //encrypt data
            byte[] encData_byte = new byte[plainText.Length];
            encData_byte = Encoding.UTF8.GetBytes(plainText);
            string encodedData = Convert.ToBase64String(encData_byte);

            return encodedData;
        }
    }
}
