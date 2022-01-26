using csharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [DataRow("+5 Dexterity Vest", 0, 40, 38)]
        [DataRow("Elixir of the Mongoose", 0, 10, 8)]
        [DataRow("Elixir of the Mongoose", 0, 10, 8)]
        [DataTestMethod]
        public void UpdateQuality_CheckIfSellingPropperyIsOverThenTheQualityProppertDecraseByDouble_TheQualityDecreaseByDouble(string name, int sellIn, int quality, int result)
        {
            IList<Item> Items = new List<Item> { new Item { Name = name, SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.AreEqual(result, Items[0].Quality);
        }

        [DataRow("Aged Brie", 2, 10, 12)]
        [DataTestMethod]
        public void UpdateQuality_AgedBrieActuallyIncreasesInQualityTheOlderItGets_TheQualityIncreases(string name, int sellIn, int quality, int result)
        {
            IList<Item> Items = new List<Item> { new Item { Name = name, SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();
            app.UpdateQuality();

            Assert.AreEqual(result, Items[0].Quality);
        }

        [DataRow("Sulfuras, Hand of Ragnaros", 1, 50, 50)]
        [DataRow("Sulfuras, Hand of Ragnaros", 2, 10, 10)]
        [DataRow("Sulfuras, Hand of Ragnaros", 10, 10, 10)]
        [DataRow("Sulfuras, Hand of Ragnaros", 0, 10, 10)]
        [DataTestMethod]
        public void UpdateQuality_SulfurasActuallyQualityNotChange_TheQualityNotChange(string name, int sellIn, int quality, int result)
        {
            IList<Item> Items = new List<Item> { new Item { Name = name, SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.AreEqual(result, Items[0].Quality);
        }

        [DataRow("Sulfuras, Hand of Ragnaros", 1, 50, 1)]
        [DataRow("Sulfuras, Hand of Ragnaros", 2, 10, 2)]
        [DataRow("Sulfuras, Hand of Ragnaros", 10, 10, 10)]
        [DataRow("Sulfuras, Hand of Ragnaros", 0, 10, 0)]
        [DataTestMethod]
        public void UpdateQuality_SulfurasActuallySellInyNotChange_TheSellInNotChange(string name, int sellIn, int quality, int result)
        {
            IList<Item> Items = new List<Item> { new Item { Name = name, SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.AreEqual(result, Items[0].SellIn);
        }

        [DataRow("Backstage passes to a TAFKAL80ETC concert", 12, 12, 13)]
        [DataRow("Backstage passes to a TAFKAL80ETC concert", 11, 6, 7)]
        [DataTestMethod]
        public void UpdateQuality_BackstagePassesIncreasesInQualityAsItsSellInValueApproaches_TheQualtiyIncreasByOne(string name, int sellIn, int quality, int result)
        {
            IList<Item> Items = new List<Item> { new Item { Name = name, SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.AreEqual(result, Items[0].Quality);
        }

        [DataRow("Backstage passes to a TAFKAL80ETC concert", 10, 12, 14)]
        [DataRow("Backstage passes to a TAFKAL80ETC concert", 6, 6, 8)]
        [DataTestMethod]
        public void UpdateQuality_BackstagePassesIncreasesInQualityAsItsSellInValueApproaches_TheQualtiyIncreasByTwo(string name, int sellIn, int quality, int result)
        {
            IList<Item> Items = new List<Item> { new Item { Name = name, SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.AreEqual(result, Items[0].Quality);
        }

        [DataRow("Backstage passes to a TAFKAL80ETC concert", 5, 12, 15)]
        [DataRow("Backstage passes to a TAFKAL80ETC concert", 1, 6, 9)]
        [DataTestMethod]
        public void UpdateQuality_BackstagePassesIncreasesInQualityAsItsSellInValueApproaches_TheQualtiyIncreasByThree(string name, int sellIn, int quality, int result)
        {
            IList<Item> Items = new List<Item> { new Item { Name = name, SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.AreEqual(result, Items[0].Quality);
        }

        [DataRow("Backstage passes to a TAFKAL80ETC concert", 0, 12, 0)]
        [DataTestMethod]
        public void UpdateQuality_BackstagePassesResetsInQualiy_TheQualtiyResets(string name, int sellIn, int quality, int result)
        {
            IList<Item> Items = new List<Item> { new Item { Name = name, SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.AreEqual(result, Items[0].Quality);
        }

        [DataRow("Backstage passes to a TAFKAL80ETC concert", 4, 50, 50)]
        [DataRow("Aged Brie", 2, 50, 50)]
        [DataTestMethod]
        public void UpdateQuality_TheQualityOfAnItemIsNeverIncreaseThanFifty_TheQualtiyWillStayTheSame(string name, int sellIn, int quality, int result)
        {
            IList<Item> Items = new List<Item> { new Item { Name = name, SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.AreEqual(result, Items[0].Quality);
        }
    }
}
