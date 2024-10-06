using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffe.Entities.Product
{
    public class MaterialsInProduct
    {
        public int id { get; set; }
        public int productId { get; set; }
        public int materialId { get; set; }
    }
}
