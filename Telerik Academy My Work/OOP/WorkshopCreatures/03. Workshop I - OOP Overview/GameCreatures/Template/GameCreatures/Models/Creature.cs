using System;
using System.Collections.Generic;

namespace GameCreatures.Models
{
    public class Creature
    {
        private static readonly double[,] coefiecent =
        {
            { 1.25, 1.00, 0.75},
            { 1.00,  1.25, 0.75},
            { 0.75, 1.00, 1.25}
        };

        private string name;
        private int damage;
        private int healthPoints;

        public Creature(
            string name,
            int damage,
            int healthPoints,
            AttackType attackType,
            ArmorType armorType)
        {
            this.Name = name;
            this.Damage = damage;
            if (healthPoints <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            this.HealthPoints = healthPoints;
            this.ArmorType = armorType;
            this.AttackType = attackType;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.name = value;
            }
        }


        public int Damage
        {
            get
            {
                return this.damage;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.damage = value;
            }
        }

        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value < 0)
                {
                    this.healthPoints = 0;
                }
                else
                {
                    this.healthPoints = value;
                }
            }
        }

        public ArmorType ArmorType { get; }

        public AttackType AttackType { get; }

        public void Attack(Creature target)
        {
            int damage = this.CalculateActualDamage(target);
            target.HealthPoints -= damage;
        }

        public Creature FindBestTarget(List<Creature> targets)
        {
            if (targets == null || targets.Count == 0)
            {
                throw new ArgumentException();
            }

            Creature bestTarget = targets[0];
            int bestTargetHealthPoints = int.MaxValue;

            foreach (var target in targets)
            {
                int currentDamage = this.CalculateActualDamage(target);

                if (target.HealthPoints - currentDamage <= 0 && target.Damage >= bestTarget.Damage)
                {
                    bestTarget = target;
                    bestTargetHealthPoints = 0;
                }
                else
                {
                    if (target.HealthPoints - currentDamage < bestTargetHealthPoints)
                    {
                        bestTarget = target;
                        bestTargetHealthPoints = target.healthPoints - currentDamage;
                    }
                }
            }
            return bestTarget;
        }

        public void AutoAttack(List<Creature> targets)
        {
            this.Attack(this.FindBestTarget(targets));
        }

        public int CalculateActualDamage(Creature target)
        {
            double coeficient = coefiecent[(int)this.AttackType, (int)target.ArmorType];
            return (int)Math.Floor(this.damage * coeficient);
        }
    }
}
