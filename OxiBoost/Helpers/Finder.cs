using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;

namespace Oxiboost.Helpers
{
    class Finder
    {
        public IEnumerable<string> Find(string rootDirectory)
        {
            IEnumerable<string> files = Enumerable.Empty<string>();
            IEnumerable<string> directories = Enumerable.Empty<string>();
            try
            {
                var permission = new FileIOPermission(FileIOPermissionAccess.PathDiscovery, rootDirectory);
                permission.Demand();

                files = Directory.GetFiles(rootDirectory);
                directories = Directory.GetDirectories(rootDirectory);
            }
            catch
            {
                rootDirectory = null;
            }

            if (rootDirectory != null)
                yield return rootDirectory;

            foreach (var file in files)
            {
                yield return file;
            }

            // Recursive call for SelectMany.
            var subdirectoryItems = directories.SelectMany(Find);
            foreach (var result in subdirectoryItems)
            {
                yield return result;
            }
        }
    }
}
