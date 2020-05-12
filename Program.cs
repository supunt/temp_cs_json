using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempProject
{
    class Program
    {
        static void Main(string[] args)
        {
            DataModel dm = InputReader.ReadFile(".\\config.json");
            var stringified = JsonConvert.SerializeObject(dm);
            Console.Write(stringified);

            Console.ReadKey();
        }        
    }
}
