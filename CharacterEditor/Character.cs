using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterEditor
{
    internal class Character
    {
        private string _name;
        private string _characterClass;
        internal int _health;
        internal int _energy;
        internal int _strength;
        internal int _dexterity;
        internal int _intelligence;
        internal int _constitution;

        public Character(string name, string characterClass, int strength, int dexterity, int intelligence, int constitution)
        {
            _name = name;
            _characterClass = characterClass;
            _strength = strength;
            _dexterity = dexterity;
            _intelligence = intelligence;
            _constitution = constitution;
        }

        public virtual int MaxStrenght { get;}
        public virtual int MinStrenght { get; }
        public virtual int MaxDexterity { get; }
        public virtual int MinDexterity { get; }
        public virtual int MaxIntelligence { get; }
        public virtual int MinIntelligence { get; }
        public virtual int MaxConstitution { get; }
        public virtual int MinConstitution { get; }
    }
}
