using GildedRose.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GildedRose.Items
{
    public static class CreatorFactory
    {
        private const string AGED_BRIE = "Aged Brie";
        private const string BACKSTAGE = "Backstage passes to a TAFKAL80ETC concert";
        private const string SULFURAS = "Sulfuras, Hand of Ragnaros";

        public static ItemAbstract CreateItemFactory(string name)
        {
            switch (name)
            {
                case AGED_BRIE:
                    return new AgedBrieItem();
                case BACKSTAGE:
                    return new BacstageItem();
                case SULFURAS:
                    return new SulfurasItem();
                default:
                    return new DefaultItem(); 
            }
        }
    }
}
