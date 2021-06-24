namespace JewelryStore
{
    internal interface IStringEncryptor
    {
        string EncodeToBase64(string plainText);
    }
}