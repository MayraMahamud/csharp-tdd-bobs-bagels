using System.Reflection.Emit;
using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests;

public class Tests
{


    [Test]
    public void AddBagelTest()

    {

        //arrange
        Basket basket = new Basket();




        //act
        basket.Add("plain");

        // assert

        Assert.That(basket.Items.Count, Is.EqualTo(1));

    }

    [Test]
    public void RemoveBagelTest()

    {
        Basket basket = new Basket();

        basket.Add("plain");

        basket.Remove("plain");


        Assert.That(basket.Items.Count, Is.EqualTo(0));
    }


    [Test]
    public void IsBasketFullTest()
    {
      
        Basket basket = new Basket();


        //act
        basket.Add("Bagel1");
        basket.Add("Bagel2");
        basket.Add("Bagel3");
        basket.Add("Bagel4");
        basket.Add("Bagel5");

        Assert.That(basket.Items.Count, Is.EqualTo(basket.MaximumCapacity));

        Assert.That(basket.IsBasketFull(),Is.True);
    }











    [Test]
    public void RemoveNonExistingTest()

    {
        //arrange
        Basket basket = new Basket();

        basket.Add("bagel1");
        basket.Add("bagel2");

       




        //act
        string results = basket.Remove("bagel3");
       


        //assert
        Assert.That(results.Length> 0);




    }

    [Test]
    public void ChangeCapacityTest()
    {
        int firstCapacity = 2;
        Basket basket = new Basket();
        basket.MaximumCapacity = firstCapacity;

        Assert.That(basket.MaximumCapacity, Is.EqualTo(firstCapacity));
       



    }
    [Test]

    public void ExceedCapacityTest()
    {
       
        Basket basket = new Basket();
     

      
        basket.Add("bagel1");
        basket.Add("bagel2");
        basket.Add("bagel3");
        basket.Add("bagel4");
        basket.Add("bagel5");
        basket.Add("bagel6");

       

        

        //  Assert.That(basket.,Is.EqualTo(newCapacity));
        Assert.That(basket.Items.Count, Is.EqualTo(5));
    }


    [Test]
    public void DefaultCapacity()
    {
    
    Basket basket = new Basket();
    

        Assert.That(basket.MaximumCapacity, Is.EqualTo(5));
    }




    //[Test]
    //public void GetTotalCostTest()
    //{
    //    Basket basket = new Basket();

    //    basket.Add("bagel");
        
    //    decimal totalCost = basket.GetTotalCost();


    //    //  Assert.That(basket.EqualTo totalCost);
    //    Assert.That(basket.items.Count, Is.EqualTo(0));

    //}
}