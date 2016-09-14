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
                if (item.Name != AGED_BRIE && item.Name != BACKSTAGE)
                {
                    if (item.Quality > MIN_DEFAULT_VALUE)
                    {
                        if (item.Name != SULFURAS)
                        {
                            item.Quality--;
                        }
                    }
                }
                else
                {
                    if (item.Quality < MAX_QUALITY_VALUE)
                    {
                        item.Quality++;

                        if (item.Name == BACKSTAGE)
                        {
                            if (item.SellIn < SELLIN_FIRST_DEADLINE)
                            {
                                if (item.Quality < MAX_QUALITY_VALUE)
                                {
                                    item.Quality++;
                                }
                            }

                            if (item.SellIn < SELLIN_SECOND_DEADLINE)
                            {
                                if (item.Quality < MAX_QUALITY_VALUE)
                                {
                                    item.Quality++;
                                }
                            }
                        }
                    }
                }

                if (item.Name != SULFURAS)
                {
                    item.SellIn--;
                }

                if (item.SellIn < MIN_DEFAULT_VALUE)
                {
                    if (item.Name != AGED_BRIE)
                    {
                        if (item.Name != BACKSTAGE)
                        {
                            if (item.Quality > MIN_DEFAULT_VALUE)
                            {
                                if (item.Name != SULFURAS)
                                {
                                    item.Quality--;
                                }
                            }
                        }
                        else
                        {
                            item.Quality = 0;
                        }
                    }
                    else
                    {
                        if (item.Quality < MAX_QUALITY_VALUE)
                        {
                            item.Quality++;
                        }
                    }
                }
            }
        }
    }

    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }
    }

}