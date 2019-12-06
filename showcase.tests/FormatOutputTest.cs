using System;
using NUnit.Framework;
using Showcase;

namespace Showcase.UnitTests {
    class FormatOutputTest {

        [TestCase ("1", "accusamus beatae ad facilis cum similique qui sunt")]
        public void PrintPhotoId_Title (String photoId, String title) {
            string expectedVal = "["+photoId +"] "+title;
            Showcase.FormatOutput v = new FormatOutput ();
            string actualVal = v.Output (photoId, title);
            Assert.AreEqual (actualVal, expectedVal);
        }

        [TestCase (1, "accusamus beatae ad facilis cum similique qui sunt")]
        public void IntPhotoId_Title (int photoId, String title) {
            string expectedVal = "["+photoId.ToString() +"] "+title;
            Showcase.FormatOutput v = new FormatOutput ();
            string actualVal = v.Output (photoId, title);
            Assert.AreEqual (actualVal, expectedVal);
        }

    }
}