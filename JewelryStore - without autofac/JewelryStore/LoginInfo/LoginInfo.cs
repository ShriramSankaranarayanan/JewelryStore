using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryStore
{
    class LoginInfo : ILoginInfo
    {
        public IUserModel User { get; set; }
        public string Message { get; set; }
    }
}
