using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {

            string[] itemNames = new string[] { "Aged Brie", "Backstage passes to a TAFKAL80ETC concert", "Sulfuras, Hand of Ragnaros" };
       
            for (var i = 0; i < Items.Count; i++)
            {
                CheackIfQualtiyIncreseOrDecrese(itemNames, i);
                IfItemNameNotSulfurasDecreseSellIn(itemNames, i);
                IfTheSellInIsNegative(itemNames, i);
            }
        }

        private void CheackIfQualtiyIncreseOrDecrese(string[] itemNames, int i)
        {
            if (Items[i].Name != itemNames[0] && Items[i].Name != itemNames[1])
            {
                if (Items[i].Quality > (int)QualtiyAndSellInEnum.MinQualtiy)
                {
                    CheackIfNotSulfurasAndDecreaseQualtiy(itemNames, i);
                }
            }
            else
            {
                if (Items[i].Quality < (int)QualtiyAndSellInEnum.MaxQulatiy)
                {
                    IncreseByOneQualtiy(i);

                    BackStagePassQualityIncrese(itemNames, i);
                }
            }
        }

        private void BackStagePassQualityIncrese(string[] itemNames, int i)
        {
            if (Items[i].Name == itemNames[1])
            {
                if (Items[i].SellIn < (int)QualtiyAndSellInEnum.RestElvenDays)
                {
                    CheackIfQualtiUnderFiftyAndIncreseByOneQualtiy(i);
                }

                if (Items[i].SellIn < (int)QualtiyAndSellInEnum.RestSixDays)
                {
                    CheackIfQualtiUnderFiftyAndIncreseByOneQualtiy(i);
                }
            }
        }

        private void IfItemNameNotSulfurasDecreseSellIn(string[] itemNames, int i)
        {
            if (Items[i].Name != itemNames[2])
            {
                Items[i].SellIn = Items[i].SellIn - 1;
            }
        }

        private void IfTheSellInIsNegative(string[] itemNames, int i)
        {
            if (Items[i].SellIn < (int)QualtiyAndSellInEnum.MinSellIn)
            {
                if (Items[i].Name != itemNames[0])
                {
                    if (Items[i].Name != itemNames[1])
                    {
                        if (Items[i].Quality > (int)QualtiyAndSellInEnum.MinQualtiy)
                        {
                            CheackIfNotSulfurasAndDecreaseQualtiy(itemNames, i);
                        }
                    }
                    else
                    {
                        ResetQualtiy(i);
                    }
                }
                else
                {
                    CheackIfQualtiUnderFiftyAndIncreseByOneQualtiy(i);
                }
            }
        }

        private void ResetQualtiy(int i)
        {
            Items[i].Quality = Items[i].Quality - Items[i].Quality;
        }

        private void CheackIfQualtiUnderFiftyAndIncreseByOneQualtiy(int i)
        {
            if (Items[i].Quality < (int)QualtiyAndSellInEnum.MaxQulatiy)
            {
                IncreseByOneQualtiy(i);
            }
        }

        private void IncreseByOneQualtiy(int i)
        {
            Items[i].Quality = Items[i].Quality + 1;
        }

        private void CheackIfNotSulfurasAndDecreaseQualtiy(string[] itemNames, int i)
        {
            if (Items[i].Name != itemNames[2])
            {
                Items[i].Quality = Items[i].Quality - 1;
            }
        }
    }
}
