using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
   public class Weapon : Item
    {
        public Weapon(int id, string name, string namePlural, int maximumDamage, int minimumDamage) : base(id, name, namePlural)
        {
            MaximumDamage = maximumDamage;
            MinimumDamage = minimumDamage;
        }

        public int MaximumDamage { get; set; }
        public int MinimumDamage { get; set; }
    }
}
