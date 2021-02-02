using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class UserGiver : IUserGiver
    {

        public string getCurrentUser()
        {
            return Environment.UserName;
        }
    }
}
