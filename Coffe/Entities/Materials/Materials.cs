﻿using Coffe.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffe.Entities.Materials
{
    public class Materials
    {
        [PrimeryKey]
        public string id { get; set; }
        public string name { get; set; }
        public int price { get; set; }

    }
}
