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
        public void Should_Not_Increase_Aged_Brie_Quality()
        {
            var item = new Item { Name = "Aged Brie", SellIn = 1, Quality = 50 };
            IList<Item> Items = new List<Item> { item };
            GildedRoseService app = new GildedRoseService(Items);
            app.UpdateQuality();

            Check.That(item.Quality).Equals(50);
        }

        [Fact]
        public void Should_Increase_Aged_Brie_Quality()
        {
            var item = new Item { Name = "Aged Brie", SellIn = 1, Quality = 40 };
            IList<Item> Items = new List<Item> { item };
            GildedRoseService app = new GildedRoseService(Items);
            app.UpdateQuality();

            Check.That(item.Quality).Equals(41);
        }

        [Fact]
        public void Should_Increase_Twice_Aged_Brie_Quality()
        {
            var item = new Item { Name = "Aged Brie", SellIn = 0, Quality = 40 };
            IList<Item> Items = new List<Item> { item };
            GildedRoseService app = new GildedRoseService(Items);
            app.UpdateQuality();

            Check.That(item.Quality).Equals(42);
        }

        [Fact]
        public void Should_Not_Increase_Bacsktage_Quality()
        {
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 1, Quality = 50 };
            IList<Item> Items = new List<Item> { item };
            GildedRoseService app = new GildedRoseService(Items);
            app.UpdateQuality();

            Check.That(item.Quality).Equals(50);
        }

        [Fact]
        public void Should_Fall_To_0_Backastage_Quality()
        {
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 50 };
            IList<Item> Items = new List<Item> { item };
            GildedRoseService app = new GildedRoseService(Items);
            app.UpdateQuality();

            Check.That(item.Quality).Equals(0);
        }

        [Fact]
        public void Should_Increase_Backstage_Quality()
        {
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 12, Quality = 40 };
            IList<Item> Items = new List<Item> { item };
            GildedRoseService app = new GildedRoseService(Items);
            app.UpdateQuality();

            Check.That(item.Quality).Equals(41);
        }

        [Fact]
        public void Should_Increase_Twice_Backstage_Quality()
        {
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 9, Quality = 40 };
            IList<Item> Items = new List<Item> { item };
            GildedRoseService app = new GildedRoseService(Items);
            app.UpdateQuality();

            Check.That(item.Quality).Equals(42);
        }

        [Fact]
        public void Should_Greatly_Increase_Backstage_Quality()
        {
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 4, Quality = 40 };
            IList<Item> Items = new List<Item> { item };
            GildedRoseService app = new GildedRoseService(Items);
            app.UpdateQuality();

            Check.That(item.Quality).Equals(43);
        }

        [Fact]
        public void Should_Not_Update_Sulfuras()
        {
            var item = new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 4, Quality = 30 };
            IList<Item> Items = new List<Item> { item };
            GildedRoseService app = new GildedRoseService(Items);
            app.UpdateQuality();

            Check.That(item.SellIn).Equals(4);
            Check.That(item.Quality).Equals(30);
        }

        [Fact]
        public void Should_Decrease_Random_Object_Quality()
        {
            var item = new Item { Name = "Mana Cake", SellIn = 4, Quality = 30 };
            IList<Item> Items = new List<Item> { item };
            GildedRoseService app = new GildedRoseService(Items);
            app.UpdateQuality();

            Check.That(item.Quality).Equals(29);
        }

        [Fact]
        public void Should_Decrease_Twice_Random_Object_Quality()
        {
            var item = new Item { Name = "Mana Cake", SellIn = 0, Quality = 30 };
            IList<Item> Items = new List<Item> { item };
            GildedRoseService app = new GildedRoseService(Items);
            app.UpdateQuality();

            Check.That(item.Quality).Equals(28);
        }
    }
}
