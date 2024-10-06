using Coffe.Core.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffe.Entities.Users
{
    public class User
    {
        [PrimeryKey]
        public string userName { get; set; }
        public string password { get; set; }
        public string displayName { get; set; }
        public string phoneNumber { get; set; }
    }
}
