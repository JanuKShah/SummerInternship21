using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question7
{
    class Buyer
    {
        static void Main(string[] args)
        {
            var shoppingCart = new ShopCart[3]; // fill this as per your solution
            shoppingCart[0] = new Wheat5kgBag();
            shoppingCart[1] = new Wheat5kgBag();
            shoppingCart[2] = new RefinedOil5kg();
            Biller biller = new Biller();
            float totalBill = biller.CalculateTotalBill(shoppingCart);
            Console.WriteLine($"Total Bill = {totalBill}");
            Console.ReadLine();
        }
    }

    class Biller
    {
        public float CalculateTotalBill(ShopCart[] shoppingCart)
        {
            return shoppingCart.Sum(p => p.GetAmount());
        }
    }

    class ShopCart
    {
        private int wholesaleCost { get; set; }
        private int tax { get; set; }
        private int profitMargin { get; set; }
        public ShopCart(int wc, int t, int pm)
        {
            wholesaleCost = wc;
            tax = t;
            profitMargin = pm;
        }
        public int GetAmount()
        {
            return wholesaleCost + tax + profitMargin;
        }
    }

    class RefinedOil5kg : ShopCart
    {
        public RefinedOil5kg() : base(280, 10, 70) { }
        
    }

   
    class Wheat5kgBag: ShopCart
    {
        public Wheat5kgBag() : base(150, 5, 50) { }
        
    }
}
