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
            var cart = new MenuLib.Basket();
            cart.AddItem(1);
            Assert.AreEqual(1, cart.Items.Count);

            var item = cart.Items.FirstOrDefault(x => x.ItemProduct.Id == 1);

            Assert.AreEqual(5, item.ItemProduct.Price);
            Assert.AreEqual(5, item.ItemProduct.MaxQuantity);
        }

        [TestMethod]
        public void RemoveItem()
        {
            var cart = new MenuLib.Basket();
            cart.AddItem(1);
            Assert.AreEqual(1, cart.Items.Count);

            var item = cart.Items.FirstOrDefault(x => x.ItemProduct.Id == 1);

            cart.RemoveItem(item.ItemProduct);
            Assert.AreEqual(0, cart.Items.Count);
        }
    }
}
