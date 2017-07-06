using System;
using NUnit.Framework;

namespace ProjectTest
{
    [TestFixture]
    public class ProjectTest
    {
        [TestCase]
        public void TestArray()
        {

            Assert.AreEqual(ProjectDS.Array.ArraySolution.IsUnique("anubrijchandra"), false);
            Assert.AreEqual(ProjectDS.Array.ArraySolution.IsUnique("qwertyasdfghjzxcvbnm"), true);
        }
    }
}