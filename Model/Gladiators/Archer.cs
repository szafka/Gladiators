namespace Gladiator.Model.Gladiators
{
    public class Archer : BaseGladiator
    {
        public Archer(string name, int level, int baseHP, int baseSP, int baseDEX) : base(name, level, baseHP, baseSP, baseDEX)
        {
        }

        protected override double HPmultiplier { get { return StatisticMultiplier.Medium.Extensions(); } }

        protected override double SPmultiplier { get { return StatisticMultiplier.Medium.Extensions(); } }

        protected override double DEXmultiplier { get { return StatisticMultiplier.High.Extensions(); } } 
    }

}