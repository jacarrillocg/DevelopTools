using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopTools
{
    public class RepoService
    {

        public static List<T> GetListFromJsonFile<T>(string jsonFile)
        {
            var response = new List<T>();
            try
            {
                if (File.Exists(jsonFile))
                {
                    using StreamReader r = new(jsonFile);

                    string json = r.ReadToEnd();

                    response = JsonConvert.DeserializeObject<List<T>>(json);
                }
            }
            catch
            {
                return response;
            }

            return response;
        }

    }
}

