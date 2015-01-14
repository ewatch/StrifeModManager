using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Xml;
using System.Xml.XPath;
using StrifeModManager;
using System.Drawing;

namespace WpfApplication2 {
    class FileToStrifeModConverter {
        private const string modXmlFileName = "mod.xml";
        private const string modPngFileName = "icon.png";

        public Mod createModification(string modificationFileName) {
            if (modificationFileName.EndsWith(".strifemod")) {
                openZipFile(modificationFileName);
            }
            return null;
        }


        private bool hasFileCorrectStructure() {
            return true;
        }

        private StrifeMod openZipFile(string modificationFileName) {
            ZipArchive archive = ZipFile.OpenRead(modificationFileName);
            StrifeMod strifeMod = new StrifeMod();
            strifeMod.ModFilePath = modificationFileName;
            System.Console.Out.WriteLine("mod file path: " + modificationFileName);
            foreach (ZipArchiveEntry archiveEntry in archive.Entries) {
                System.Console.Out.WriteLine(archiveEntry.FullName);
                if (archiveEntry.Name.Equals(modXmlFileName)) {
                    strifeMod.modXml = parseModXml(archiveEntry);
                }
                else if (archiveEntry.Name.Equals(modPngFileName)) {
                    strifeMod.icon = Image.FromStream(archiveEntry.Open());
                }
               }
            return strifeMod;
        }

        private ModXmlDto parseModXml(ZipArchiveEntry archiveEntry) {
            string modXmlAsString = "";
            using (StreamReader reader = new StreamReader(archiveEntry.Open())) {
                modXmlAsString = reader.ReadToEnd();
            }

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(modXmlAsString);
            XPathNavigator xpath = xmlDoc.CreateNavigator();


            ModXmlDto modDto = new ModXmlDto();
            XmlNodeList nodeList = xmlDoc.GetElementsByTagName("modification");
            XmlNode node = nodeList.Item(0);
            foreach (XmlAttribute anAttribute in node.Attributes) {
                string name = anAttribute.Name;
                string value = anAttribute.Value;
                modDto[name] = value;
                System.Console.Out.WriteLine(name + "=" + value);
            }
            System.Console.Out.WriteLine("modDto: " + modDto.appversion);

            return modDto;
        }
    }
}
