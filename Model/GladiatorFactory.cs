using Gladiator.Model.Gladiators;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiator.Model
{
    public class GladiatorFactory
    {
        Random rnd = new Random();
        public GladiatorFactory()
        {
            string[] readNames = File.ReadAllLines(@"C:\Dokumenty\gladiator-csharp-szafka\Names.txt");
            List<String> namesList = readNames.ToList();
            List<String> shuffledNamesList = namesList.OrderBy(x => Guid.NewGuid()).ToList().GetRange(0, 16);
        }
        public BaseGladiator GenerateRandomGladiator()
        {
            int rndSpecialization = rnd.Next(0, 6);
            switch (rndSpecialization)
            {
                case 1:
                    return new Archer;
                    break;
                case 2:
                    return new Assassin;
                    break;
                case 3:
                    return new Brutal;
                    break;
                case 4:
                    return new Swordsman;
                    break;
                case 5:
                    return new Swordsman;
                    break;
            }
        }

    }


}
