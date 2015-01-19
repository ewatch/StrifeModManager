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
            string fileContent1 = readFile(@"C:\ModManager\mods\mod1.xml");
            string fileContent2 = readFile(@"C:\ModManager\mods\mod2.xml");
            List<Diff> diffs = diffPatcher.diff_main(fileContent1, fileContent2);
            foreach (Diff aDiff in diffs) {
                Console.WriteLine(aDiff.operation + " " + aDiff.text);
            }

            List<Patch> patches = diffPatcher.patch_make(fileContent1, diffs);
            object[] applied = diffPatcher.patch_apply(patches, fileContent1);

            writeFile(@"C:\ModManager\mods\mod3.xml", (string)applied[0]);

        }

        private static string readFile(string fileName) {
             string fileContent = "";
             StreamReader sr = new StreamReader(fileName);
             fileContent = sr.ReadToEnd();
             sr.Close();
             return fileContent;
        }

        private static void writeFile(string filename, string content) {
            StreamWriter writer = new StreamWriter(filename);
            writer.Write(content);
            writer.Close();

        }
    }
}
