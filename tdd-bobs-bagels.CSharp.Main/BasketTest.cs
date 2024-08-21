using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class BasketTest
{
    public int Capacity { get; set; }
    public List<string> Items { get; set; }

    public BasketTest (int capacity)
    {

    Capacity = capacity; 
        Items = new List<string> ();
    }

    public bool AddItem (string item)
    {
        if (Items.Count < Capacity)
        {
            Items.Add(item);
            return true;
        }
        else
        {
            Console.WriteLine("Basket is full");
            return false;
        }

    }

    public bool IsFull()
    {
        return Items.Count >= Capacity;
    }

    public void ChangeCapacity(int newCapacity)
    {
        if (newCapacity < Items.Count)
        {
            Console.WriteLine("Capacity is changed");
            return;

        }

        Capacity = newCapacity;
        Console.WriteLine($"Basket capacity changed to{Capacity}.");
    }

}
}
