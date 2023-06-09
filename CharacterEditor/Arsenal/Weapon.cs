using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterEditor.Arsenal
{
    internal class Weapon
    {
        public string WeaponType { get; set; }
        private int _damage;

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        private int _strength;

        public Weapon(string weaponType, int damage, int strength, int dexterity, int constitution, int strReq, int dexReq, int weightReq) : this(weaponType, damage, strength, dexterity, constitution)
        {
            StrReq = strReq;
            DexReq = dexReq;
            WeightReq = weightReq;
        }

        public int Strength
        {
            get { return _strength; }
            set { _strength = value; }
        }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }

        public int StrReq { get; set; }
        public int DexReq { get; set; }
        public int WeightReq { get; set; }


    }
}
