using ArrayReplace;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace ArrayReplaceTest
{
    [TestClass]
    public class ArrayReplaceTest
    {
        int[] M;
        object[] expected;
        object[] actual; 
        [TestMethod]
        public void Divide3_5()
        {
            //arrange
            M = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            expected = new object[] { 1, 2, "fizz", 4, "buzz", "fizz", 7, 8, "fizz", "buzz", 11, "fizz", 13, 14, "fizz-buzz" };
            //act
            actual = Divide.ArrayReplace(M, fizz: 3, buzz: 5, s1: "fizz", s2: "buzz");
            //assert
            Assert.IsTrue(expected.SequenceEqual(actual));
        }
        [TestMethod]
        public void Divide3_5_4_7()
        {
            //arrange
            M = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 };
            expected = new object[] { 1, 2, "fizz", "muzz", "buzz", "fizz", "guzz", "muzz", "fizz", "buzz", 11, "fizz-muzz", 13, "guzz", "fizz-buzz", "fizz-buzz-muzz", "fizz-buzz-guzz", "fizz-buzz-muzz-guzz" };
            //act
            actual = Divide.ArrayReplace(M, fizz: 3, buzz: 5, muzz: 4, guzz: 7, s1: "fizz", s2: "buzz", s3: "muzz", s4: "guzz");
            //assert
            Assert.IsTrue(expected.SequenceEqual(actual));
        }
        [TestMethod]
        public void Divide3_5_4_7_goodboy()
        {
            //arrange
            M = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 };
            expected = new object[] { 1, 2, "dog", "muzz", "cat", "dog", "guzz", "muzz", "dog", "cat", 11, "fizz-muzz", 13, "guzz", "good-boy", "good-boy-muzz", "good-boy-guzz", "good-boy-muzz-guzz" };
            //act
            actual = Divide.ArrayReplaceComplex(M, fizz: 3, buzz: 5, muzz: 4, guzz: 7, s1: "fizz", s2: "buzz", s3: "muzz", s4: "guzz");
            //assert
            Assert.IsTrue(expected.SequenceEqual(actual));

        }

    }
}
