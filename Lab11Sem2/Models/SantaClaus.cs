using Lab11Sem2.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Sem2.Models
{
    class SantaClaus
    {
        private static SantaClaus instance;
        private GiftFactory goodGiftFactory;
        private GiftFactory badGiftFactory;
        public List<Child> children;

        private SantaClaus()
        {
            goodGiftFactory = new GoodGiftFactory();
            badGiftFactory = new BadGiftFactory();
            children = new List<Child>();
        }

        public static SantaClaus Instance
        {
            get
            {
                if (instance == null)
                    instance = new SantaClaus();
                return instance;
            }
        }

        public void AddChild(Child child)
        {
            children.Add(child);
        }

        public void SendGifts()
        {
            foreach (Child child in children)
            {
                int goodDeeds = child.GoodDeedsCount;
                int badDeeds = child.BadDeedsCount;

                Console.WriteLine("Good Deeds count: " + goodDeeds);
                Console.WriteLine("Bad Deeds count: " + badDeeds);

                GiftFactory factory;
                Gift edibleGift;
                Gift inedibleGift;

                if (goodDeeds > badDeeds)
                {
                    factory = goodGiftFactory;
                    edibleGift = factory.CreateEdibleGift();

                    Console.WriteLine($"Child: {child}");
                    edibleGift?.Deliver(child);
                }
                else
                {
                    factory = badGiftFactory;
                    inedibleGift = factory.CreateInedibleGift();

                    Console.WriteLine($"Child: {child}");
                    inedibleGift?.Deliver(child);
                }

                Console.WriteLine();
            }
        }

        private int GetGoodDeedsCount(Child child)
        {
            var currentChild = children.FirstOrDefault(x => x.Name == child.Name);
            if(currentChild == null)
            {
                return 0;
            }

            return currentChild.GoodDeedsCount;
        }

        private int GetBadDeedsCount(Child child)
        {
            var currentChild = children.FirstOrDefault(x => x.Name == child.Name);
            if (currentChild == null)
            {
                return 0;
            }

            return currentChild.BadDeedsCount;
        }
    }
}
