using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JsTreeviewBuilder
{
    public static class EmbeddedResources
    {

        /// <summary>
        /// The embedded resource must be in the exact same namespace as currentType.
        /// </summary>
        /// <param name="currentType">Use: this.GetType()</param>
        /// <param name="embeddedResourceName">The simple name of the resource. Example: "newsletter.htm"</param>
        public static string GetEmbeddedResource(Type currentType, string embeddedResourceName)
        {
            var allresources = GetAllResourceNamesInAssembly();
            var assembly = Assembly.GetExecutingAssembly();
            var fullEmbeddedResourceName = GetFullEmbeddedResourceName(currentType, embeddedResourceName);
            using (Stream stream = assembly.GetManifestResourceStream(fullEmbeddedResourceName))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string result = reader.ReadToEnd();
                    return result;
                }
            }
        }

        /// <summary>
        /// To check all the embedded resources in the current assembly.
        /// </summary>
        public static string[] GetAllResourceNamesInAssembly()
        {
            var assembly = Assembly.GetExecutingAssembly();
            return assembly.GetManifestResourceNames();
        }

        /// <summary>
        /// The embedded resource must be in the exact same namespace as the input class.
        /// </summary>
        /// <param name="currentType">Use: this.GetType()</param>
        /// <param name="embeddedResourceName">The simple name of the resource. Example: "newsletter.htm"</param>
        private static string GetFullEmbeddedResourceName(Type currentType, string embeddedResourceName)
        {
            var currentNamespace = currentType.Namespace;
            var fullResourceName = currentNamespace + "." + embeddedResourceName;
            return fullResourceName;
        }

    }
}
