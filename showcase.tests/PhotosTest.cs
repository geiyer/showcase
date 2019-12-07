using System.Threading.Tasks;
using NUnit.Framework;
using Showcase;
using System.Collections.Generic;
namespace Showcase.UnitTests {

    public class PhotosTest {
        private Photos _showcase;
        [SetUp]
        public void SetUp () {
            _showcase = new Photos ();
        }

        [TestCase (20)]
        [TestCase (54)]
        public async Task IsAlbumIdNumeric_MoreThanZero (int value) {
            var expectedCountMoreThan = 0;
            var photos = await _showcase.Get (value);
            var actualCount = photos.Count;
            Assert.That (actualCount, Is.GreaterThan (expectedCountMoreThan));
        }

        [TestCase (-1)]
        public async Task IsAlbumIdNumeric_EqualThanZero (int value) {
            var expectedCount = 0;
            var photos = await _showcase.Get (value);
            var actualCount = photos.Count;
            Assert.AreEqual (actualCount, expectedCount);
        }

        [TestCase (1, 1, "accusamus beatae ad facilis cum similique qui sunt")]
        public async Task TestPhotoID_Title (int albumId, int photoId, string title) {
            var photos = await _showcase.Get (albumId);
            var photo = photos.Find(item => item.Id == photoId);
            Assert.AreEqual (photo.Id, photoId);
            Assert.AreEqual (photo.Title, title);

        }
    }
}