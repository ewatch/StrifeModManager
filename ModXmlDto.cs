using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrifeModManager {
    class ModXmlDto {

        public string application { get; set; }
        public string appversion { get; set; }
        public string mmversion { get; set; }
        public string name { get; set; }
        public string version { get; set; }
        public string description { get; set; }
        public string author { get; set; }
        public string weblink { get; set; }
        public string updatecheckurl { get; set; }
        public string updatedownloadurl { get; set; }

        public object this[string propertyName] {
            get { return this.GetType().GetProperty(propertyName).GetValue(this, null); }
            set { this.GetType().GetProperty(propertyName).SetValue(this, value, null); }
        }
        
    }
}
