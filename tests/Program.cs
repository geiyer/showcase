using NUnit.Framework;
using System;
using Showcase;


namespace Showcase.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class PhotosTest
    {
        private Photos _showcase;

        [SetUp]
        public void SetUp()
        {
            _showcase = new Photos();
        }

        [TestCase(20)]
        [TestCase(54)]
        public void IsAlbumIdNumeric_MoreThanZero(int value)
        {
            var expectedCountMoreThan =  0;
            var photos = _showcase.Get(value).Result;
            var actualCount = photos.Count;
            Assert.That(actualCount, Is.GreaterThan(expectedCountMoreThan));

        }
        [TestCase(-1)]
        public void IsAlbumIdNumeric_EqualThanZero(int value)
        {
            var expectedCount =  0;
            var photos = _showcase.Get(value).Result;
            var actualCount = photos.Count;
            Assert.AreEqual(actualCount, expectedCount);

        }

    }
    class ProgramTests{

        
        [TestCase("12")]
        public void IsAlbumIdNumeric_Valid(String value)
        {
            bool expectedVal =  true;
            bool actualVal = Showcase.Program.ValidateInput(value);
            Assert.AreEqual(actualVal, expectedVal);
        }
        [TestCase("1Ab")]
        public void IsAlbumIdAlpha_InValid(String value)
        {            
            bool expectedVal =  false;
            bool actualVal = Showcase.Program.ValidateInput(value);
            Assert.AreEqual(actualVal, expectedVal);
        }

    }
}
