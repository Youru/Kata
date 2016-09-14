using GildedRose.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GildedRose.Items
{
    public class BacstageItem : ItemAbstract
    {
        private const int SELLIN_FIRST_DEADLINE = 11;
        private const int SELLIN_SECOND_DEADLINE = 6;

        public override void UpdateItem(Item item)
        {
            item.IncreaseQuality(MAX_QUALITY_VALUE);

            if (item.SellIn < SELLIN_FIRST_DEADLINE)
            {
                item.IncreaseQuality(MAX_QUALITY_VALUE);
            }

            if (item.SellIn < SELLIN_SECOND_DEADLINE)
            {
                item.IncreaseQuality(MAX_QUALITY_VALUE);
            }

            item.SellIn--;

            if (item.SellIn < MIN_DEFAULT_VALUE)
            {
                item.Quality = 0;
            }
        }
    }
}
