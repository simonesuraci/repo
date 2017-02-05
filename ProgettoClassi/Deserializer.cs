using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProgettoClassi
{
    static class Deserializer
    {
        #if DEBUG
            private static string path = @".\Debug\monsters.csv";
        #else
            private static string path = @".\Release\monsters.csv";
        #endif

        public static List<Monster> deserializeMonster()
        {
            List<Monster> monsters = new List<Monster>();

            string[] data = File.ReadAllLines(path);
            int l = data.Length;
            for (int i = 1; i < l; i++)
            {
                string[] splitterData = data[i].Split(',');
                switch (splitterData[0].ToUpper())
                {
                    case "MONSTER":
                        monsters.Add(new Monster(splitterData[1], int.Parse(splitterData[2]), int.Parse(splitterData[3]), int.Parse(splitterData[4])));
                        break;
                    case "FIRE":
                        monsters.Add(new Fire_Monster(splitterData[1], int.Parse(splitterData[2]), int.Parse(splitterData[3]), int.Parse(splitterData[4])));
                        break;
                }
                Console.WriteLine(splitterData[0]);
            }

            return monsters;
        }

    }
}
