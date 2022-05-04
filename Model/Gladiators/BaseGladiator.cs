using System;
using System.Collections.Generic;
using System.IO;

namespace Gladiator.Model.Gladiators
{
    public class BaseGladiator
    {
        public List<BaseGladiator> Names = new List<BaseGladiator>();
        public void AddGladiatorsNames(BaseGladiator baseGladiator)
        {
            Names.Add(baseGladiator);
        }
        public string[] readNamesArray()
        {
            return File.ReadAllLines("Names.txt");
        }
    }
}