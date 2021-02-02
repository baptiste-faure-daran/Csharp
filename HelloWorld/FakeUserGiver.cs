using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class FakeUserGiver : IUserGiver
    {
        private string _user;

        public FakeUserGiver()
        {
        }

        public string getCurrentUser()
        {
            return _user;
        }

        public void fakeUser(string userName)
        {
            _user = userName;

        }
    }
}
