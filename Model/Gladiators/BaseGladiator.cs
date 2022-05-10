using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Gladiator.Model.Gladiators
{
    public abstract class BaseGladiator
    {
        public string FullName { get; }
        public string Name { get; }
        public int Level { get; private set; }
        public int BaseHP { get; }
        public int BaseSP { get; }
        public int BaseDEX { get; }
        protected abstract double HPmultiplier { get; }
        protected abstract double SPmultiplier { get; }
        protected abstract double DEXmultiplier { get; }
        public int CurrentHP { get; set; }
        public int HPmax
        {
            get { return (int)(BaseHP * HPmultiplier * Level); }
        }
        public int SPmax
        {
            get { return (int)(BaseSP * SPmultiplier * Level); }
        }
        public int DEXmax
        {
            get { return (int)(BaseDEX * DEXmultiplier * Level); }
        }
        protected BaseGladiator(string name, int level, int baseHP, int baseSP, int baseDEX)
        {
            this.Level = level;
            this.BaseDEX = baseDEX;
            this.BaseHP = baseHP;
            this.BaseSP = baseSP;
            this.Name = name;
        }
        public void LevelUp()
        {
            Level++;
        }
        public void HealUp()
        {
            CurrentHP = HPmax;
        }
        public bool IsDead()
        {
            return CurrentHP <= 0;
        }
        public void DecreaseHpBy(int hpLost)
        {
            CurrentHP -= hpLost;
        }

    }

}