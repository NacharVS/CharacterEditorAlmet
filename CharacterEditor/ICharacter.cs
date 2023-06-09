using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CharacterEditor
{
    internal interface ICharacter
    {
        public int Level { get; set; }
        public int Health { get; set; }
        public int Energy { get; set; }

        public int Weight { get;  }
        public int PhysDamage { get;  }
        public int Armor { get;  }


        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Constitution { get; set; }



        public void StrenghtIncrease(ref Label health, ref Label strengtn, ref Label weight, ref Label pDamage, ref Label armor, ref Label points);
        public void StrenghtDecrease(ref Label health, ref Label strengtn, ref Label weight, ref Label pDamage, ref Label armor, ref Label points);

    }
}
