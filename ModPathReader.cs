using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    class ModPathReader {

        private IEnumerable<string> files;

        public ModPathReader(string path) {
            if (Directory.Exists(path)) {
                files = Directory.EnumerateFiles(path);
                foreach (string afile in files) {
                    new FileToStrifeModConverter().createModification(afile);
                }
            }
            
        }
    }
}
