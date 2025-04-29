using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_7___Polymorphism.Entities
{
    internal class General : Machine
    {
        public override int LifeSpanCostPerMinute
        {
            get
            {
                return 1;
            }
        }

        public General(string name) : base(name)
        {
            
        }

        public override void Use(int numberOfMinutes)
        {
            this.Lifespan -= numberOfMinutes * this.LifeSpanCostPerMinute;
        }

        public override string ToString()
        {
            return $"{base.Name} {base.LifeSpanInfo()}";
        }
    }
}
