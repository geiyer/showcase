using System;
using System.Collections.Generic;

namespace Showcase {
    public class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Enter the Album Number: ");
            string inputAlbumId;
            inputAlbumId = Console.ReadLine ();
            Showcase.Validate v = new Validate ();

            if (!v.IsAlbumValid (inputAlbumId)) { Console.WriteLine ("Enter a valid Album Number. The Album Number should be numeric."); } else {
                PrintPhotos (inputAlbumId);
            }

        }

        static void PrintPhotos (String input) {
            Photos showcase = new Photos ();
            int albumId;
            int.TryParse (input, out albumId);
            var photos = showcase.Get (albumId).Result;
            if (photos != null)
                Console.WriteLine ("Fetching all photos for Album #:  " + Convert.ToString (albumId));
            FormatOutput f = new FormatOutput ();

            foreach (var photo in photos)
                Console.WriteLine (f.Output (photo.Id, photo.Title));
        }

    }
}