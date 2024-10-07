
using System.Collections.Generic;

namespace Coffe.Entities.Cart
{

    [System.Serializable]
    public class Cart
    {
        public string id { get; set; }
        public string userId { get; set; }
        public ICollection<string> productIds { get; set; }
    }
}
