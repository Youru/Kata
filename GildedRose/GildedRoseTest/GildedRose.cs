using GildedRose;
using System;
using System.Collections.Generic;
using Xunit;
using NFluent;
namespace GildedRoseTest
{
    public class GildedRose
    {
        [Fact]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRoseService app = new GildedRoseService(Items);
            app.UpdateQuality();
            Check.That(Items[0].Name).Equals("foo");
        }

    }
}
