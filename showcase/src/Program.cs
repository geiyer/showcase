using System;
using System.Threading.Tasks;

namespace Showcase {
    public class Program {
        public static async Task  Main (String[] args) {
            string inputAlbumId;
             Console.WriteLine ("Enter the Album Id to view the list of photos:");
            inputAlbumId = Console.ReadLine ();
            await (new Program ()).Run (inputAlbumId);
        }

        public async Task<bool> Run (String inputAlbumId) {
            Launcher launcher = new Launcher ();
            await launcher.Run (inputAlbumId);
            return true;
        }

    }
}