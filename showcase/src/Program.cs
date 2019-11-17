using System;
using System.Collections.Generic;


namespace Showcase
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Album Number: ");
            string inputAlbumId;
            inputAlbumId = Console.ReadLine();
            
            if(!ValidateInput(inputAlbumId))
            {Console.WriteLine("Enter a valid Album Number. The Album Number should be numeric.");}
            else{
                PrintPhotos(inputAlbumId);
            }            
            
        }
       public static bool ValidateInput(String input){
            int albumId;
            return int.TryParse(input, out albumId);

        }
        static void PrintPhotos(String input)
        {
            Photos showcase = new Photos();
            int albumId;
            int.TryParse(input, out albumId);
            var photos = showcase.Get(albumId).Result;
                if(photos != null)
                    Console.WriteLine("Fetching all photos for Album #:  " + Convert.ToString(albumId));

                foreach (var photo in photos)
                    Console.WriteLine(FormatOutput(photo));
        }
        static string FormatOutput(Photo photo){
            return String.Format("[{0}] {1}", photo.Id, photo.Title);
        }
        
        
    }
}
