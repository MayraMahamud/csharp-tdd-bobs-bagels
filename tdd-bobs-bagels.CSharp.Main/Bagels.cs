using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Bagels : Inventory 
{


        public decimal Price { get; set; }
        public string Variant { get; set; }

        public Bagels( decimal price, string variant)
        {
            
            Price = price;
            Variant = variant;
        }

       

     


    }

}
