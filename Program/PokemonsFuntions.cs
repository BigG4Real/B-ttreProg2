using static GlobalFunktion.Kit.GlobalFunktionKitClass;

namespace PokemonsFunktions
{
    public abstract class Pokemon : IDamageble
    {
        public string Name { get; protected set; }
        public float Health { get; protected set; }
        protected float Dmg;

        //Contstruktur
        public Pokemon()
        {
            Name = TypeString("What should the pokemon name be?");
            Console.Clear();
            Health = TypeInt($"What health do you want your {Name} to have?", 1, int.MaxValue);
            Console.Clear();
            Dmg = TypeInt($"What damge should your {Name} have?", 1, int.MaxValue);
            Console.Clear();
            return;
        }

        #region Interface
        public virtual void Change(float amount)
        {
            Health += amount;
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