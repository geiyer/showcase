using System;
using System.Collections.Generic;

namespace Showcase {
    public class FormatOutput {
        public string Output (String id, String title) {
            return String.Format ("[{0}] {1}", id, title);
        }
        public string Output (int id, String title) {
            return String.Format ("[{0}] {1}", id.ToString (), title);
        }
    }
}