using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrifeModManager {
    class Patcher {
        DiffMatchPatch.diff_match_patch diffPatcher = new DiffMatchPatch.diff_match_patch();

        public void patch(string file1, string file2) {

            diffPatcher.diff_main();
        }
    }
}
