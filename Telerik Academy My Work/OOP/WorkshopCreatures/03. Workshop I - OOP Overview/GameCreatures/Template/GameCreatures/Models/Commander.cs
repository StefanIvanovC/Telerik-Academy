using System;
using System.Collections.Generic;

namespace GameCreatures.Models
{
    public class Commander
    {
        private readonly List<Creature> army;
        private string name;

        public Commander(string name, List<Creature> army)
        {
            this.Name = name;
            this.army = army ?? throw new ArgumentNullException();
        }

        public string Name
        {
            get 
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.name = value;
            }
        }

        public int ArmySize
        {
            get
            {
                return army.Count;
            }
        }

        public void AttackAtPosition(Commander enemy, int attackerIndex, int targetIndex)
        {
            var enemyCreature = enemy.army[targetIndex];
            var alliesCreature = this.army[attackerIndex];
            alliesCreature.Attack(enemyCreature);

            if (enemyCreature.HealthPoints <= 0)
            {
                enemy.army.Remove(enemyCreature);
            }
        }

        public void AutoAttack(Commander enemy)
        {
            if (enemy == null || enemy.ArmySize == 0 || this.ArmySize ==0)
            {
                throw new ArgumentNullException();
            }

            Creature myBestCreature = this.army[0];
            Creature bestTarget = enemy.army[0];

            int targetHppoitsLeft = int.MaxValue;
            bool willDie = false;

            foreach (var creature in this.army)
            {
                Creature currentTarget = creature.FindBestTarget(enemy.army);
                int currentDamage = creature.CalculateActualDamage(currentTarget);

                if (currentTarget.HealthPoints - currentDamage <= 0&& currentTarget.Damage >= bestTarget.Damage)
                {
                    myBestCreature = creature;
                    bestTarget = currentTarget;
                    targetHppoitsLeft = 0;
                    willDie = true;
                }
                else if (currentTarget.HealthPoints - currentDamage < targetHppoitsLeft)
                {
                    myBestCreature = creature;
                    bestTarget = currentTarget;
                    targetHppoitsLeft = currentTarget.HealthPoints - currentDamage;
                }
            }

            myBestCreature.Attack(bestTarget);
            if (willDie)
            {
                enemy.army.Remove(bestTarget);
            }
        }
    }
}
