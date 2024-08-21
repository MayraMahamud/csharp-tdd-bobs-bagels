using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Bagel
{ 
        public Bagel() {

            Quantity = 0;
            Name = string.Empty;
            Price = 0;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }   

      //  public Bagel (string name, decimal price)
      //  {
      //      Name = name;
     //       Price = price;
     //   }

      public decimal TotalCost
        {
            get
            {
                return Quantity * Price;
            }
        }

     


    }

}
