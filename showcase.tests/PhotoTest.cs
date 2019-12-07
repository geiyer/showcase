using System.Threading.Tasks;
using NUnit.Framework;
using Showcase;

namespace Showcase.UnitTests {

    public class PhotoTest {
        private Photo _photo;
        [SetUp]
        public void SetUp () {
            _photo = new Photo ();
            _photo.Id = 1;
            _photo.AlbumId = 1;
            _photo.Title = "accusamus beatae ad facilis cum similique qui sunt";
            _photo.URL = "https://via.placeholder.com/600/92c952";
            _photo.ThumbnailUrl = "https://via.placeholder.com/150/92c952";
        }

        [Test]
        public void CheckAllProperties () {
            Assert.IsNotNull (_photo.Id);
            Assert.IsNotNull (_photo.AlbumId);
            Assert.IsNotEmpty (_photo.Title);
            Assert.IsNotEmpty (_photo.URL);
            Assert.IsNotEmpty (_photo.ThumbnailUrl);

        }
    }
}