

using NUnit.Framework;
using System;
using Leecode.Easy.MaximumNumberOfWordsFoundInSentences;

namespace StringHelperTest
{
    internal class MostWordsFoundTest
    {
        [TestCase(new String[] { "alice and bob love leetcode", "i think so too", "this is great thanks very much" }, 6)]
        [TestCase(new String[] { "please wait", "continue to fight", "continue to win" }, 3)]
        [TestCase(new String[] { "測試用", "測 試 用", "測 試" }, 3)]
        public void MostWordsFound_Foreach_ReturnExpected(string[] sentences, int expected)
        {
            var helper = new StringHelper();

            var actual = helper.MostWordsFound_Foreach(sentences);

            Assert.AreEqual(expected, actual);
        }
    }
}
