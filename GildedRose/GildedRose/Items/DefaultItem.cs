using GildedRose.Model;

namespace GildedRose.Items
{
    public class DefaultItem : ItemAbstract
    {
        public override void UpdateItem(Item item)
        {
            item.Quality--;
            item.SellIn--;
            if (item.SellIn < MIN_DEFAULT_VALUE)
            {
                if (item.Quality > MIN_DEFAULT_VALUE)
                {
                    item.Quality--;
                }
            }
        }
    }
}