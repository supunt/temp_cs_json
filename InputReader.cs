using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempProject
{
    public class InputReader
    {
        public static DataModel ReadFile(string inputPath)
        {
            DataModel cache = new DataModel();
            cache.Config = ReadConfiguration(inputPath);
            return cache;
        }

        private static InputConfiguration ReadConfiguration(string configPath)
        {
            string jsonData = File.ReadAllText(configPath);
            InputConfiguration config = JsonConvert.DeserializeObject<InputConfiguration>(jsonData);
            return config;
        }
    }

    
}
