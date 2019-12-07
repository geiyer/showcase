using System;
using System.Threading.Tasks;


namespace Showcase {
    public class Program {
        // private static Launcher launcher;
        // public static Launcher Launcher { get; set; }
        // public static Program () {
        //     launcher = new Launcher ();
        //     Launcher = launcher;
        // }
        // public static async Task Main (String[] args) {
        //     Launcher launcher = new Launcher();
        //     inputAlbumId = Console.ReadLine ();
        //     await launcher.Run (args);
        // }


        private static Launcher launcher = new Launcher();

        public static async Task Main(String[] args) {
            string inputAlbumId;
            inputAlbumId = Console.ReadLine ();
            await launcher.Run(inputAlbumId);
        }

        static void setLauncher(Launcher launcher) {
            Program.launcher = launcher;
        }

    }
}