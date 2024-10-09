using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Fillings : Inventory
{
       
        //public decimal Price { get; set; }
        //public string Variant { get; set; }

        public Fillings ( decimal price, string variant)
        {
            
            Price = price;
            Variant = variant;
        }
    }
}
