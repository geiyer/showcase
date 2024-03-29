using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Showcase {
    public class Launcher {
        public async Task<bool> Run (string inputAlbumId) {
            Showcase.Validate v = new Validate ();
            Photos showcase = new Photos ();
            if (!v.IsAlbumValid (inputAlbumId)) {
                Console.WriteLine ("The Album Number should be numeric. Exiting the program.");
                return false;
            } else {
                await PrintPhotos (showcase, inputAlbumId);
            }
            return true;
        }

        private async Task PrintPhotos (Photos showcase, string albumId) {
            int id;
            int.TryParse (albumId, out id);
            var photos = await showcase.Get (id);
            FormatOutput f = new FormatOutput ();
            foreach (var photo in photos)
                Console.WriteLine (f.Output (photo.Id, photo.Title));

        }
    }
}