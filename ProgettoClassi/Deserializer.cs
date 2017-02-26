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
        public static List<Monster> deserializeMonster()
        {
            List<Monster> monsters = new List<Monster>();

            string[] data = File.ReadAllLines(assets.assetsPath + "monsters.csv");
            int l = data.Length;
            for (int i = 1; i < l; i++)
            {
                string[] splittedData = data[i].Split(',');
                switch (splittedData[0].ToUpper())
                {
                    case "MONSTER":
                        monsters.Add(new Monster(splittedData[1], int.Parse(splittedData[2]), int.Parse(splittedData[3]), int.Parse(splittedData[4])));
                        break;
                    case "FIRE":
                        monsters.Add(new Fire_Monster(splittedData[1], int.Parse(splittedData[2]), int.Parse(splittedData[3]), int.Parse(splittedData[4])));
                        break;
                }
            }

            return monsters;
        }
    }
}
