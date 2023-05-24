using Lab11Sem2.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Sem2.Models
{
    class GoodGiftFactory : GiftFactory
    {
        public override Gift CreateEdibleGift()
        {
            return new EdibleGift();
        }

        public override Gift CreateInedibleGift()
        {
            return new InedibleGift();
        }
    }
}
