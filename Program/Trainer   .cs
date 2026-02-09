using static GlobalFunktion.Kit.GlobalFunktionKitClass;
using PokemonsFunktions;
namespace Trainer
{
    public class TrainerClass : Pokemon
    {
        #region All triners
        public static List<TrainerClass> allTrainers = new List<TrainerClass>();
        public TrainerClass()
        {
            allTrainers.Add(this);
            return;
        }
        #endregion

        /// <summary>
        /// Ask what the user should do and executes that
        /// </summary>
        public void WhatToDo()
        {
            int option = TypeInt($"What do you want your {pokemonName} to do / yourself?\n1 = deal dmg\n2 = heal for 50 hp\n3 = dmg all for 20\n4 = heal all for 30", 1, 4);
            float healSingleAmount = 50;
            float healAllAmount = 30;
            float dmgAllAmount = 20;
            Console.Clear();
            if (option == 1)
            {
                WhoToChangeHP("hit", pokemonDmg * -1);
            }
            else if (option == 2)
            {
                WhoToChangeHP("heal", healSingleAmount);
            }
            else if (option == 3)
            {
                ChangeAllsHpBy(-dmgAllAmount);
            }
            else if (option == 4)
            {
                ChangeAllsHpBy(healAllAmount);
            }

            //Change the hp
            void WhoToChangeHP(string action, float amount)
            {
                DisplayAllPokemons();
                int option = TypeInt($"What pokemon do you want to {action}?", 1, allTrainers.Count);
                option--;
                Console.Clear();
                ChangeHp(allTrainers[option], amount);
            }

            //Change all of the pokemons hp
            static void ChangeAllsHpBy(float amount)
            {
                foreach (TrainerClass trainer in allTrainers)
                {
                    trainer.ChangeHp(trainer, amount);
                }
            }
            return;
        }
        /// <summary>
        /// Prints all the pokemons name, hp, dmg and ID
        /// </summary>
        void DisplayAllPokemons()
        {
            Console.WriteLine("Evrey pokemon:");
            for (int i = 0; i < allTrainers.Count; i++)
            {
                int id = i + 1;
                Console.WriteLine($"Pokemon {allTrainers[i].pokemonName}:\nHealth = {allTrainers[i].pokemonHealth}\nDamge = {allTrainers[i].pokemonDmg}\nID = {id}\n");
            }
            return;
        }
    }
}