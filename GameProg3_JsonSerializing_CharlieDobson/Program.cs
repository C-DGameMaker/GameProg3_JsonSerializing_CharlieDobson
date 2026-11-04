using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace GameProg3_JsonSerializing_CharlieDobson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myInt = 5;
            string jsonString = JsonSerializer.Serialize(myInt);

            Console.WriteLine(jsonString);

            string jsonString1 = "5";
            string jsonString2 = "2";

            var myNumber = JsonSerializer.Deserialize<int>(jsonString1);
            Console.WriteLine(myNumber);
            
        }
    }
}
