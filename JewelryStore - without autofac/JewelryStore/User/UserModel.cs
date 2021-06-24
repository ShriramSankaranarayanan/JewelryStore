using System;

namespace JewelryStore
{
    class UserModel : IUserModel
    {
        public long Id { get; set; }

        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception(Messages.UserNameRequired);
                }
                _userName = value;
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; } 
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception(Messages.PasswordRequired);
                }
                _password = value;
            }
        }
        public Enums.UserCategory UserCategory { get; set; }

    }
}
