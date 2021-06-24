namespace JewelryStore
{
    interface IStringDecryptor
    {
        string DecodeFrom64(string encodedString);
    }
}