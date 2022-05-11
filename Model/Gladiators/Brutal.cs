namespace Gladiator.Model.Gladiators
{
    public class Brutal : BaseGladiator
    {
        public Brutal(string specializationName, string name, int level, int baseHP, int baseSP, int baseDEX) : base(specializationName, name, level, baseHP, baseSP, baseDEX)
        {
        }

        protected override double HPmultiplier { get { return StatisticMultiplier.High.Extensions(); } }

        protected override double SPmultiplier { get { return StatisticMultiplier.High.Extensions(); } }

        protected override double DEXmultiplier { get { return StatisticMultiplier.Low.Extensions(); } }
    }
}