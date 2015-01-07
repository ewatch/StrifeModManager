using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace WpfApplication2 {
    class FileToStrifeModConverter {

        private bool isModXmlExisting; 

        public Mod createModification(string modificationFileName) {
            if (modificationFileName.EndsWith(".strifemod")) {
                openZipFile(modificationFileName);
            }
            return null;
        }


        private bool hasFileCorrectStructure() {
            return true;
        }

        private void openZipFile(string modificationFileName) {
            ZipArchive archive = ZipFile.OpenRead(modificationFileName);
            foreach (ZipArchiveEntry archiveEntry in archive.Entries) {
                System.Console.Out.WriteLine(archiveEntry.FullName);

            }
        }

    }
}
