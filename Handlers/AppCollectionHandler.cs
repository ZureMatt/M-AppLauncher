using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace M_AppLauncher
{
    public class AppCollectionHandler
    {
        List<App> AppCollection;
        string JsonPath = "";

        public List<App> GetAppCollection()
        {
            //Retrieve AppCollection from JSON
            AppCollection = JsonSerializer.Deserialize<List<App>>(JsonPath);

            return AppCollection;
        }
    }
}
