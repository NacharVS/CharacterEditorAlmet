using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterEditor
{
    internal class Warrior : Character, ICharacter
    {
        public Warrior(string name, int strength, int dexterity, int intelligence, int constitution) : base(name, "Warrior", strength, dexterity, intelligence, constitution)
        {
        }

        public int Health 
        {
            get => _strength * 3 + _constitution * 10;
            set => _health = value; }
        public int Energy
        {
            get
            {
                return _intelligence * 3;
            }
            set
            {
                _energy = value;
            }
        }
        public int Strength 
        { 
            get
            {
                return _strength;
            }
            set
            {
                if(value < MinStrenght)
                {
                    _strength = MinStrenght;
                }
                else if(value > MaxStrenght)
                {
                    _strength = MaxStrenght;
                }
                else
                    _strength = value;
            }
        }
        public int Dexterity 
        {
            get
            {
                return _dexterity;
            }
            set
            {
                if (value < MinDexterity)
                {
                    _dexterity = MinDexterity;
                }
                else if (value > MaxDexterity)
                {
                    _dexterity = MaxDexterity;
                }
                else
                    _dexterity = value;
            }
        }
        public int Intelligence 
        {
            get
            {
                return _intelligence;
            }
            set
            {
                if (value < MinIntelligence)
                {
                    _intelligence = MinIntelligence;
                }
                else if (value > MaxIntelligence)
                {
                    _intelligence = MaxIntelligence;
                }
                else
                    _intelligence = value;
            }
        }
        public int Constitution 
        {
            get
            {
                return _constitution;
            }
            set
            {
                if (value < MinConstitution)
                {
                    _constitution = MinConstitution;
                }
                else if (value > MaxConstitution)
                {
                    _constitution = MaxConstitution;
                }
                else
                    _constitution = value;
            }
        }

        public override int MaxStrenght => 250;
        public override int MinStrenght => 30;
        public override int MaxDexterity => 80;
        public override int MinDexterity => 15;
        public override int MaxIntelligence => 50;
        public override int MinIntelligence => 10;
        public override int MaxConstitution => 100;
        public override int MinConstitution => 25;

        public static ICharacter CreateWarrior(string name)
        {
            return new Warrior(name, 30, 15, 10, 20);
        }

    }
}
