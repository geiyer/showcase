using System;
using System.Collections.Generic;

namespace Showcase {
    public class Validate {
        public bool IsAlbumValid (String input) {
            int albumId;
            return int.TryParse (input, out albumId);
        }
    }
}