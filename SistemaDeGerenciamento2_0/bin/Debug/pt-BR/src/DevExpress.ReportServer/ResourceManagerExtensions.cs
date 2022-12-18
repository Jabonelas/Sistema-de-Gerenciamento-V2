using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace DevExpress.ReportServer.Localization {
    public static class ResourceManagerExtensions {
        public static IDictionary<string, string> GetAllStrings(this ResourceManager resourceManager, CultureInfo cultureInfo) {
            var strings = new Dictionary<string, string>();

            var resourceSet = resourceManager.GetResourceSet(cultureInfo, true, true);
            foreach(DictionaryEntry resourceEntry in resourceSet) {
                strings.Add((string)resourceEntry.Key, (string)resourceEntry.Value);
            }

            return strings;
        }
    }
}

