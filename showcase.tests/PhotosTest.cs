using NUnit.Framework;
using Showcase;

namespace Showcase.UnitTests {

    public class PhotosTest {
        private Photos _showcase;
        [SetUp]
        public void SetUp () {
            _showcase = new Photos ();
        }

        [TestCase (20)]
        [TestCase (54)]
        public void IsAlbumIdNumeric_MoreThanZero (int value) {
            var expectedCountMoreThan = 0;
            var photos = _showcase.Get (value).Result;
            var actualCount = photos.Count;
            Assert.That (actualCount, Is.GreaterThan (expectedCountMoreThan));
        }

        [TestCase (-1)]
        public void IsAlbumIdNumeric_EqualThanZero (int value) {
            var expectedCount = 0;
            var photos = _showcase.Get (value).Result;
            var actualCount = photos.Count;
            Assert.AreEqual (actualCount, expectedCount);
        }
    }
}