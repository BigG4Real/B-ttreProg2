using PokemonsFunktions;
using Trainer;
using GlobalFunktion.Kit;
Main();
void Main()
{
    GameLoop game = new();
    game.StartGame();
    Console.WriteLine($"Want to start a new game?\n[Y/N]");
    if (Console.ReadLine() == "y")
    {
        Main();
        return;
    }
}