using System;

namespace JewelryStore
{
    class UserInputGetter: IUserInputGetter
    {
        private readonly IUserModel _user;
        private readonly IStringEncryptor _stringEncryptor;

        public UserInputGetter()
        {
            this._user = new UserModel();
            _stringEncryptor = new StringEncryptor();
        }

        public IUserModel GetUserNameAndPassword()
        {
            GetUserName();

            GetPassword();

            return _user;
        }

        private void GetPassword()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(Messages.EnterPassword);
            Console.ForegroundColor = ConsoleColor.Yellow;
            _user.Password = _stringEncryptor.EncodeToBase64(Console.ReadLine());
        }

        private void GetUserName()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(Messages.EnterUserName);
            Console.ForegroundColor = ConsoleColor.Yellow;
            _user.UserName = _stringEncryptor.EncodeToBase64(Console.ReadLine());
        }
    }
}
