using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKLTesting.Framework.Data
{
    public class UserData
    {
        public string Name;
        public string Password;

        public UserData(string name, string password)
        {
            this.Name = name;
            this.Password = password;
        }
    }
}
