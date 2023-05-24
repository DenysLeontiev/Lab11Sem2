using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Sem2.Models
{
    public class Child
    {
        public int GoodDeedsCount { get; set; }
        public int BadDeedsCount { get; set; }
        public string Name { get; set; }
        public List<ChildGift> ChildGifts { get; set; } = new();

        public Child()
        {

        }

        public Child(int goodDeedsCount, int badDeedsCount, string name)
        {
            GoodDeedsCount = goodDeedsCount;
            BadDeedsCount = badDeedsCount;
            Name = name;
        }

        public override string ToString()
        {
            return $"GoodDeedsCount: {GoodDeedsCount};BadDeedsCount: {BadDeedsCount};Name:{Name}";
        }
    }
}
