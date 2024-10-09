using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Inventory 
    {
        public decimal Price { get; set; }
        public string Variant { get; set; }
    
        public List<Bagels> bagels;
        public List<Coffee> coffee;
        public List<Fillings> fillings;


        public Inventory()
        {
            bagels = new List<Bagels>();
            coffee = new List<Coffee>();
            fillings = new List<Fillings>();
        }
    }

    
    
}
