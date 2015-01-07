using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace WpfApplication2
{

    /*
     * 
     * <modification
    application="Heroes of Newerth"        fixed
    appversion="0.3"                       game version requirement (shown is "anything starting with 0.3")
    mmversion="1.3"                        fixed, the version of the file format
    name="The Mod's Name"                  It is strongly recommended to keep this name consistent as it will identify the mod.
    version="1.0"                          The current version of the mod. Should grow with each new release.
    description="blahblahblah"             Explanatory text about the mod to be shown when selected in the Mod Manager (optional)
    author="Your Nickname"                 Will be shown below the mod's name. (optional)
    weblink="http://www.com/"              A clickable link to be shown below the description text. (optional)
    updatecheckurl="http://.../version.txt"A URL to a text file containing the newest version number. (optional)
    updatedownloadurl="http://.../m.honmod"A URL to a .honmod file that will be downloaded and replace this mod file when the text file specified above contains a higher version number than this mod currently has. (optional)
>
     * 
     * 
     */

    class StrifeMod : Mod
    {
        private string appVersion;
        private string modXmlVersion;
        private string name;
        private string modVersion;
        private string description;
        private string author;
        private string webLink;
        private string updateCheckUrl;
        private string updateDownloadUrl;

        // maybe changed to another object later on (like Image)
        private string icon;

        // to be defined
        //private IList<ZipFileEntry> modfiles;
    }
}
