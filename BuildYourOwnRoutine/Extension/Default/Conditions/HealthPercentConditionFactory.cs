using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeRoutine.Routine.BuildYourOwnRoutine.Extension.Default.Conditions
{
    internal class HealthPercentConditionFactory : ExtensionConditionFactory
    {
        public HealthPercentConditionFactory(string owner)
        {
            Owner = owner;
            Name = "HealthPercentConditionFactory";
        }

        public override ExtensionCondition GetCondition()
        {
            return new HealthPercentCondition(Owner, Name);
        }

        public override List<string> GetFilterTypes()
        {
            return new List<string>() { ExtensionComponentFilterType.Player };
        }
    }
}
