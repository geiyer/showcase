using System;
using NUnit.Framework;
using Showcase;
using System.Threading.Tasks;

namespace Showcase.UnitTests {

    public class LauncherTest {
        [Test]
        public async Task testLauncher_WithNumericAlbumID () {
            Launcher launcher = new Launcher();
            bool result = await launcher.Run("1");
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task testLauncher_WithAlfaAlbumID () {
            Launcher launcher = new Launcher();
            bool result = await launcher.Run("A");
            Assert.IsFalse(result);
        }
    }
}