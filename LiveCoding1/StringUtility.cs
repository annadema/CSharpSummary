using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCoding1
{
    class StringUtility
    {
        public static string Summary(string sentence, int maxLength = 20)
        {
            //const int maxLength = 20;
            var summary = new List<string>();
            var words = sentence.Split(' ');
            var totalCharachers = 0;

            if (sentence.Length < maxLength)
                return sentence;

            foreach (var wd in words)
            {
                totalCharachers += wd.Length + 1;

                summary.Add(wd);
                if (totalCharachers >= maxLength)
                    break;
            }

            return String.Join(" ", summary) + " ...";
        }
    }
}
