using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class ModuloFirstTest
    {
        [Test]
        public void ModuloFirstSimple()
        {
            int[] input = { 4, 2, 8, 3, 9, 4, 10, 5, 11, 6 };
            int[] output = ModuloFirst.modulof(input);
            int[] expected = { 0, 2, 0, 3, 1, 0, 2, 1, 3, 2 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}
