namespace JewelryStore
{
    interface ILoginInfo
    {
        string Message { get; set; }
        IUserModel User { get; set; }
    }
}