using System;

namespace JewelryStore
{
    class Program
    {

        internal static void Main()
        {
            try
            {
                IUserInputGetter userInfo = new UserInputGetter();
                var user =    userInfo.GetUserNameAndPassword();

                IUserInputValidator validator = new UserInputValidator(user);
                var loginInfo = validator.ValidateUserCredentials();

                Console.WriteLine(loginInfo.Message);
                Console.WriteLine();

                if (loginInfo.User != null)
                {
                    Console.WriteLine(Messages.Welcome + loginInfo.User.UserCategory.ToString() + " User");

                    EstimationProcessor.GetInstance(loginInfo.User.UserCategory).Process();
                }
                else
                {
                    Console.WriteLine(Messages.Not_A_RegisteredUser);
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
