using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leecode.Easy.MaximumNumberOfWordsFoundInSentences
{
    public class StringHelper
    {
        public int MostWordsFound_Foreach(string[] sentences)
        {
            var resultArray = new List<int>();

            foreach (var item in sentences)
            {
                string[] wordArray = item.Split(' ');
                int count = wordArray.Length;

                resultArray.Add(count);
            }

            return resultArray.Max();
        }
    }
}
