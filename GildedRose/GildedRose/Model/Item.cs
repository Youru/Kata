using GildedRose.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GildedRose.Model
{
    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }

        public void IncreaseQuality(int maxQualityValue)
        {
            if (Quality < maxQualityValue)
            {
                Quality++;
            }
        }
    }
}
