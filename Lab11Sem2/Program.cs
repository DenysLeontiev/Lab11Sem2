using Lab11Sem2.Models;
using System;
using System.Collections.Generic;

namespace Lab11Sem2
{
    internal class Program
    {
        public static List<ChildGift> EdibleGifts = new List<ChildGift>
        {
            new ChildGift("Alcohol", GiftType.Good),
            new ChildGift("Drugs", GiftType.Good),
            new ChildGift("Cotton Candy(Fairy Floss)", GiftType.Good),
        };

        public static List<ChildGift> InedibleGifts = new List<ChildGift>
        {
            new ChildGift("Stick", GiftType.Bad),
            new ChildGift("Stone", GiftType.Bad),
            new ChildGift("Dirt", GiftType.Bad),
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Ho-Ho-Ho!I am old Santa Claus...");
            SantaClaus santaClaus = SantaClaus.Instance;

            Child firstChild = new Child(10, 5, "Denys");
            Child secondChild = new Child(8, 46, "Magnus");
            Child thirdChild = new Child(2, 2, "Bobby");


            santaClaus.AddChild(firstChild);
            santaClaus.AddChild(secondChild);
            santaClaus.AddChild(thirdChild);

            santaClaus.SendGifts();

            Console.WriteLine("Here what children got: \n");
            foreach (var child in santaClaus.childrenList)
            {
                foreach (var childGift in child.ChildGifts)
                {
                    Console.WriteLine($"{child.Name} has recieved {childGift}");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
