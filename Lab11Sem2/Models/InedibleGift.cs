using Lab11Sem2.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Sem2.Models
{
    class InedibleGift : Gift
    {
        public override void Deliver(Child child)
        {
            var randomInedibleGift = Program.InedibleGifts[new Random().Next(0, Program.InedibleGifts.Count)];
            child.ChildGifts.Add(randomInedibleGift);
            Console.WriteLine("InedibleGift delivered");
        }
    }
}
