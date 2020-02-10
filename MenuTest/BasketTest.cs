using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;


namespace MenuTest
{
    [TestClass]
    public class BasketTest
    {
        [TestMethod]
        public void AddItem()
        {
            //var product = MenuLib.Menu.ProductMenu.FirstOrDefault(p => p.Id ==1);
            var cart = new MenuLib.Basket();
            cart.AddItem(1);

        }
    }
}
