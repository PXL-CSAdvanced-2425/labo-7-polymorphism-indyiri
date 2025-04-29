using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_7___Polymorphism.Entities
{
    public abstract class Machine
    {
        #region Properties

        private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private int _lifespan;

		public int Lifespan
		{
			get { return _lifespan; }
			set { _lifespan = value; }
		}

		private float _price;

		public float Price
		{
			get { return _price; }
			set { _price = value; }
		}

		public bool OutOfUse
		{
			get { return this.Lifespan <= 0; }
		}

		public abstract int LifeSpanCostPerMinute { get; }

        #endregion

        #region Constructor

        protected Machine(string name)
        {
            this.Name = name;
        }

        #endregion

        #region Methods

        public abstract void Use(int numberOfMinutes);

		public string LifeSpanInfo()
		{
			if (this.OutOfUse)
			{
				return "OUT OF USE";
			}
			else
			{
				return $"<lifespan: {this.Lifespan} h>";
			}
		}

        public override string ToString()
        {
            return this.LifeSpanInfo();	
        }

        #endregion
    }
}
