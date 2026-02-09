using static GlobalFunktion.Kit.GlobalFunktionKitClass;
using Trainer;

public class GameLoop
{
    List<TrainerClass> trainers = new();
    int amountOfPlayers = 0;
    public void StartGame()
    {
        MakeNewPlayers();
        FightLoop();


        void FightLoop()
        {
            int oder = 0;
            while (trainers.Count > 1)
            {
                WhoIsGoingToFight(trainers[oder].pokemonName);
                trainers[oder].WhatToDo();
                RemoveDeadOnes();

                do
                {
                    oder++;
                    if (oder == trainers.Count)
                    {
                        oder = 0;
                    }
                }
                while (trainers[oder].pokemonHealth > 0);
            }
            return;
        }

        void MakeNewPlayers()
        {
            amountOfPlayers = TypeInt("How many gamers are there???", 1, int.MaxValue);
            for (int i = 0; i < amountOfPlayers; i++)
            {
                trainers.Add(new());
            }   
            return;
        }

        void WhoIsGoingToFight(string pokemonName)
        {
            Console.Clear();
            Console.WriteLine($"Who is {pokemonName} going to mog now?");
            Console.ReadLine();
            return;
        }
        
        void RemoveDeadOnes()
        {
            for (int i = 0; i < trainers.Count; i++)
            {
                if (trainers[i].pokemonHealth <= 0)
                {
                    trainers.Remove(trainers[i]);                
                }
            }
            return;
        }
        
    }
}