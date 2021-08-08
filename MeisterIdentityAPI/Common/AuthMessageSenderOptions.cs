using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeisterIdentityAPI.Common
{
    public class AuthMessageSenderOptions
    {
        public string SendGridUser { get; set; }
        public string SendGridKey { get; set; }
    }
}
