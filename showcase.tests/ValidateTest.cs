using System;
using NUnit.Framework;
using Showcase;

namespace Showcase.UnitTests {
    class ValidateTest {

        [TestCase ("12")]
        public void IsAlbumIdNumeric_Valid (String value) {
            bool expectedVal = true;
            Showcase.Validate v = new Validate ();
            bool actualVal = v.IsAlbumValid (value);
            Assert.AreEqual (actualVal, expectedVal);
        }

        [TestCase ("1Ab")]
        public void IsAlbumIdAlpha_InValid (String value) {
            bool expectedVal = false;
            Showcase.Validate v = new Validate ();
            bool actualVal = v.IsAlbumValid (value);
            Assert.AreEqual (actualVal, expectedVal);
        }

    }
}