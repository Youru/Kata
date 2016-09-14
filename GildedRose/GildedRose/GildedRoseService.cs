using GildedRose.Items;
using GildedRose.Model;
using System.Collections.Generic;

namespace GildedRose
{
    public class GildedRoseService
    {        
        IList<Item> Items;

        private ItemAbstract itemFactory;

        public GildedRoseService(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                itemFactory = CreatorFactory.CreateItemFactory(item.Name);
                itemFactory.UpdateItem(item);
            }
        }
    }
}