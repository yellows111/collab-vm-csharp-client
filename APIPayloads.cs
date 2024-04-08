using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollabClient
{

    public class LoginPayload
    {
        public string username { get; set; }
        public string password { get; set; }
        public string captchaToken { get; set; }
    }

    public class LogoutPayload
    {
        public string token { get; set; }
    }
}
