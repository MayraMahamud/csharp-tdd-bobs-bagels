using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace tdd_bobs_bagels.CSharp.Main
{
   public class Coffee : Inventory
 { 
    //public decimal Price { get; set; }
    //public string Variant { get; set; }

     public Coffee ( decimal price, string variant)
    {
      
        Price = price;
        Variant = variant;
    }


    
  

    
}
}
