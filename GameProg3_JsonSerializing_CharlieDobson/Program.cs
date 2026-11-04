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
            // Test for Serializing and Unserializing
            //int myInt = 5;
            //string jsonString = JsonSerializer.Serialize(myInt);

            //Console.WriteLine(jsonString);

            //string jsonString1 = "5";
            //string jsonString2 = "2";

            //var myNumber = JsonSerializer.Deserialize<int>(jsonString1);
            //Console.WriteLine(myNumber);

            Stats playerStats = new Stats();
            playerStats.health = 5;
            playerStats.score = 100;

            string jsonString = JsonSerializer.Serialize(playerStats);

            Console.WriteLine("Player Stats: Serialize\n");
            Console.WriteLine(jsonString);
            Console.ReadKey(true);

            System.IO.File.WriteAllText("playerStats.json", jsonString);

            Stats newPlayerStats = JsonSerializer.Deserialize<Stats>(jsonString);

        }
    }
}
