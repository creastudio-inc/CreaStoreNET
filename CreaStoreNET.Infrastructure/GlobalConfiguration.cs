using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreaStoreNET.Infrastructure {
    public class GlobalConfiguration {
        static GlobalConfiguration() {
            Modules = new List<ModuleInfo>();
        }

        public static IList<ModuleInfo> Modules { get; set; }
        public static string WebHostRootPath { get; set; }
        public static string ContentRootPath { get; set; }
    }
}
