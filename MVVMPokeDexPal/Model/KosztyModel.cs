 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMPokeDexPal.Model
{
    public class KosztyModel
    {
        public string Name { get; set; }
        public float Price {  get; set; }
        public KosztyModel(string name, float price)
        {
            Name = name;
            Price = price;
        }
    }
}
