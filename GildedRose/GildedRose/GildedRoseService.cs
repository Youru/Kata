using System.Collections.Generic;

namespace GildedRose
{
    public class GildedRoseService
    {
        private const string BACKSTAGE = "Backstage passes to a TAFKAL80ETC concert";
        private const string AGED_BRIE = "Aged Brie";
        private const string SULFURAS = "Sulfuras, Hand of Ragnaros";
        private const int MIN_DEFAULT_VALUE = 0;
        private const int MAX_QUALITY_VALUE = 50;
        private const int SELLIN_FIRST_DEADLINE = 11;
        private const int SELLIN_SECOND_DEADLINE = 6;
        IList<Item> Items;

        public GildedRoseService(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                if (item.Name == SULFURAS)
                    break;

                if (item.Name == AGED_BRIE)
                {
                    UpdateAgedBrieItem(item);
                }
                else if (item.Name == BACKSTAGE)
                {
                    UpdateBacstageItem(item);
                }
                else
                {
                    UpdateRandomItem(item);
                }
            }
        }

        private void UpdateAgedBrieItem(Item item)
        {
            item.Quality = GetNewQuality(item.Quality);

            item.SellIn--;

            if (item.SellIn < MIN_DEFAULT_VALUE)
            {
                item.Quality = GetNewQuality(item.Quality);
            }
        }

        private void UpdateBacstageItem(Item item)
        {
            item.Quality = GetNewQuality(item.Quality);

            if (item.Name == BACKSTAGE)
            {
                if (item.SellIn < SELLIN_FIRST_DEADLINE)
                {
                    item.Quality = GetNewQuality(item.Quality);
                }

                if (item.SellIn < SELLIN_SECOND_DEADLINE)
                {
                    item.Quality = GetNewQuality(item.Quality);
                }

            }

            item.SellIn--;

            if (item.SellIn < MIN_DEFAULT_VALUE)
            {
                item.Quality = 0;
            }
        }

        private void UpdateRandomItem(Item item)
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

        private int GetNewQuality(int quality)
        {
            if (quality <  MAX_QUALITY_VALUE)
            {
                quality++;
            }

            return quality;
        }
    }
}

public class Item
{
    public string Name { get; set; }

    public int SellIn { get; set; }

    public int Quality { get; set; }
}