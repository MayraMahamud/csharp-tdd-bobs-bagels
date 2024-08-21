﻿using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {

        public List<string> _items = new List<string>();
      
        public List<string> Items { get { return _items; } }
        private int maximumCapacity = 5;

     

        public Basket()
        {
        }

        public void Add(string bagel)
        {
            if(_items.Count < maximumCapacity)
            {
              _items.Add(bagel);

            }
        }

        public string Remove(string v)
        {

            if (!_items.Contains(v)) 
            {
                return "Item does not exist";
            } 
            _items.Remove(v);
            
            return string.Empty;
            
        
        
        }


        public bool IsBasketFull()
        {
            if(_items.Count == maximumCapacity)
            {

              return true; 
            }
              return false;
        }







       

        public decimal TotalCost
        {
            get
            {
                return Quantity * Price;
            }
        }

        public int Quantity { get; private set; }
        public int Price { get; private set; }
        public int MaximumCapacity { get => maximumCapacity; set => maximumCapacity = value; }
    }
}


   

    
            
    

    

