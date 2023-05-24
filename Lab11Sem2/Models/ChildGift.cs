using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Sem2.Models
{
    public class ChildGift
    {
        public string GiftName { get; set; }
        public GiftType GiftType { get; set; }

        public ChildGift()
        {

        }

        public ChildGift(string giftName, GiftType giftType)
        {
            GiftName = giftName;
            GiftType = giftType;
        }

        public override string ToString()
        {
            return $"(GiftName: {GiftName} | GiftType: {GiftType})";
        }
    }

    public enum GiftType
    {
        Good,
        Bad
    }
}
