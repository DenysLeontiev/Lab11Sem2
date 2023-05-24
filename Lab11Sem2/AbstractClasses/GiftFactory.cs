using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Sem2.AbstractClasses
{
    abstract class GiftFactory
    {
        public abstract Gift CreateEdibleGift();
        public abstract Gift CreateInedibleGift();
    }
}
