using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DiffMatchPatch;

namespace StrifeModManager {
    class DiffPatcher {

        public static void makeChangesToFile() {
            diff_match_patch diffPatcher = new diff_match_patch();
            string fileContent1 = readFile(@"C:\ModManager\mods\game_1.interface");
            string fileContent2 = readFile(@"C:\ModManager\mods\game_2.interface");
            List<Diff> diffs = diffPatcher.diff_main(fileContent1, fileContent2);
            foreach (Diff aDiff in diffs) {
                Console.WriteLine(aDiff.text);
            }


        }

        private static string readFile(string fileName) {
             string fileContent = "";
             StreamReader sr = new StreamReader(fileName);
             fileContent = sr.ReadToEnd();
             sr.Close();
             return fileContent;
        }
    }
}
