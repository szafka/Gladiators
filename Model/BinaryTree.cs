using Gladiator.Model.Gladiators;
using System;
using System.Collections.Generic;

namespace Gladiator.Model
{
    public class BinaryTree
    {
        public static string StartTournamentTree(List<BaseGladiator> gladiators)
        {
            String tree = "--------------------------------------";
            int j = 0;
            foreach (var gladiator in gladiators)
            {
                j++;
                String.Format("| " + j + ": " + gladiator.SpeclizationName + " " + gladiator.Name + " " + gladiator.Level + "|");
                tree += "--------------------------------------";
            }

            return tree;
        }
    }
}