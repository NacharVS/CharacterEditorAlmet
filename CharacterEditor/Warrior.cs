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

        public int Health { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
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
        public int Dexterity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Intelligence { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Constitution { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override int MaxStrenght => 250;
        public override int MinStrenght => 30;
        public override int MaxDexterity => 80;
        public override int MinDexterity => 15;
        public override int MaxIntelligence => 50;
        public override int MinIntelligence => 10;
        public override int MaxConstitution => 100;
        public override int MinConstitution => 25;

    }
}
