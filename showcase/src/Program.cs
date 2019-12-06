using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Showcase {
    public class Program {
        static async Task Main (string[] args) {
            Task.Delay (0).GetAwaiter ().GetResult ();
            Console.WriteLine ("Enter the Album Number: ");
            string inputAlbumId;
            inputAlbumId = Console.ReadLine ();
            Showcase.Validate v = new Validate ();

            if (!v.IsAlbumValid (inputAlbumId)) { Console.WriteLine ("Enter a valid Album Number. The Album Number should be numeric."); } else {
                await PrintPhotos (inputAlbumId);
            }
            Console.WriteLine ("Ending the program");

        }

        static async Task PrintPhotos (String input) {
            Photos showcase = new Photos ();
            int albumId;
            int.TryParse (input, out albumId);
            var photos = await showcase.Get (albumId);
            if (photos != null)
                Console.WriteLine ("Fetching all photos for Album #:  " + Convert.ToString (albumId));
            FormatOutput f = new FormatOutput ();

            foreach (var photo in photos)
                Console.WriteLine (f.Output (photo.Id, photo.Title));
        }

    }
}