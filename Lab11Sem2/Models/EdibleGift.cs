using Lab11Sem2.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Sem2.Models
{
    class EdibleGift : Gift
    {
        public override void Deliver(Child child)
        {
            var randomEdibleGift = Program.EdibleGifts[new Random().Next(0, Program.EdibleGifts.Count)];
            child.ChildGifts.Add(randomEdibleGift);
            Console.WriteLine("EdibleGift delivered");
        }
    }
}
