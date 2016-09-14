using GildedRose.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GildedRose.Items
{
    public abstract class ItemAbstract
    {
        protected const int MIN_DEFAULT_VALUE = 0;
        protected const int MAX_QUALITY_VALUE = 50;
        public abstract void UpdateItem(Item item);
    }
}
