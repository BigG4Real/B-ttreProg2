using static GlobalFunktion.Kit.GlobalFunktionKitClass;

namespace PokemonsFunktions
{
    public abstract class Pokemon : IDamageble
    {
        public string pokemonName;
        public float pokemonHealth;
        protected float pokemonDmg;

        //Contstruktur
        public Pokemon()
        {
            pokemonName = TypeString("What should the pokemon name be?");
            Console.Clear();
            pokemonHealth = TypeInt($"What health do you want your {pokemonName} to have?", 1, int.MaxValue);
            Console.Clear();
            pokemonDmg = TypeInt($"What damge should your {pokemonName} have?", 1, int.MaxValue);
            Console.Clear();
            return;
        }

        #region Interface
        public virtual void Change(float amount)
        {
            pokemonHealth += amount;
            return;
        }
        public void ChangeHp(IDamageble target, float amount)
        {
            target.Change(amount);
            return;
        }
        #endregion
    }
}

public interface IDamageble
{
    void Change(float dmg);
    void ChangeHp(IDamageble target, float amount);
}