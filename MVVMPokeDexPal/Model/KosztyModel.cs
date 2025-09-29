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
        public DateTime Data { get; set; }

        public KosztyModel(string name, float price, DateTime data)
        {
            Name = name;
            Price = price;
            Data = data;
        }
    }
}
