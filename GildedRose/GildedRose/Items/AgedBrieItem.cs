using GildedRose.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GildedRose.Items
{
    public class AgedBrieItem : ItemAbstract
    {
        public override void UpdateItem(Item item)
        {
            item.IncreaseQuality(MAX_QUALITY_VALUE);

            item.SellIn--;

            if (item.SellIn < MIN_DEFAULT_VALUE)
            {
                item.IncreaseQuality(MAX_QUALITY_VALUE);
            }
        }
    }
}
