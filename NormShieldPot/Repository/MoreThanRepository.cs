using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormShieldPot.Repository
{
    public class MoreThanRepository
    {
        string URL;
        string username;
        string password;

        public MoreThanRepository()
        {
            URL = "http://192.168.3.4:1552";
            username = "doracle";
            password = "<plaintext>seeifitworks";
        }
    }
}
