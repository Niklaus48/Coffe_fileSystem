using Coffe.Core.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffe.Entities.Product
{
    public class Product
    {
        [PrimeryKey]
        public string id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public ICollection<string> materialsId { get; set; }
    }
}
