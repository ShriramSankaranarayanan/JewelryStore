namespace JewelryStore
{
    internal interface IUserModel
    {
        long Id { get; set; }
        string Password { get; set; }
        string UserName { get; set; }
        Enums.UserCategory UserCategory { get; set; }
    }
}