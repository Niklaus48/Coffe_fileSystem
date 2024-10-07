using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffe.Core.Authentication
{
    public static class LogedInUser
    {
        public static string userName { get; set; }
        public static string password { get; set; }
        public static string displayName { get; set; }
        public static string phoneNumber { get; set; }
    }
}
