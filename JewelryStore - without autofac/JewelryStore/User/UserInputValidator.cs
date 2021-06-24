

using System.Linq;

namespace JewelryStore
{
    class UserInputValidator : IUserInputValidator
    {
        private readonly IUserModel _user;
        private readonly IStringDecryptor _stringDecryptor;
        private readonly IRepository<IUserModel> _repository;
        private readonly ILoginInfo _loginInfo;
        public UserInputValidator(IUserModel user)
        {
            _user = user;
            _repository = new XMLRepo();
            _stringDecryptor = new StringDecryptor();
            _loginInfo = new LoginInfo();
        }

        ILoginInfo IUserInputValidator.ValidateUserCredentials()
        {
            var userCollection=_repository.GetData();

            var userInfo = userCollection.FirstOrDefault(x => x.Password == _stringDecryptor.DecodeFrom64(_user.Password) && x.UserName == _stringDecryptor.DecodeFrom64(_user.UserName));

            if (userInfo != null)
            {
                _loginInfo.User = userInfo;
                _loginInfo.Message = Messages.LogInSuccessful;

            }
            else
            {
                _loginInfo.User = userInfo;
                _loginInfo.Message = Messages.LogInError;
            }

            return _loginInfo;
        }
    }
}
