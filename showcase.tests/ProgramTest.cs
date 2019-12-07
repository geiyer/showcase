using System;
using System.Threading.Tasks;
using NUnit.Framework;
using Showcase;

namespace Showcase.UnitTests {

    public class ProgramTest {
        [Test]
        public async Task testProgram_WithNumericAlbumID () {
            Program _program = new Program ();
            var result = await _program.Run ("1");
            Assert.IsNotNull (result);
        }

        [Test]
        public async Task testProgram_WithAlfaAlbumID () {
            Program _program = new Program ();
            var result = await _program.Run ("A");
            Assert.IsNotNull (result);
        }
    }
}