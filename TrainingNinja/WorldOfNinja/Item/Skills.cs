﻿namespace WorldOfNinja.Item
{
    using Interfaces;

    public class Skill : UsableItem, ISkill
    {
        private int attack;
        private int success;

        public Skill(PowerEnum engagedPower, string skillName, int skillPower, int skillSuccessRate)
            : base(skillName)
        {
            this.SuccessRate = skillSuccessRate;
            this.AttackPower = skillPower;
            this.AttackType = engagedPower;
        }

        public PowerEnum AttackType { get; private set; }   

        public int SuccessRate
        {
            get
            {
                return this.success;
            }

            private set
            {
                if (value < 1 || value > 100)
                {
                    throw new ImproperlyDefinedItemException("Succses must be between 1 and 100");
                }

                this.success = value;
            }
        }

        public int AttackPower
        {
            get
            {
                return this.attack;
            }

            private set
            {
                if (value < 1)
                {
                    throw new ImproperlyDefinedItemException("Attack Power must be greater than 0");
                }

                this.attack = value;
            }
        }
    }
}
