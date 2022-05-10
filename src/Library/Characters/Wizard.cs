namespace RoleplayGame
{
    public class Wizard : ICharacter, ICurable, IAttackable
    {
        private int health = 100;

        public Wizard(string name)
        {
            this.Name = name;
            this.Bag = new();
            this.MagicBag = new();
        }

        public string Name { get; set; }

        public Bag Bag { get; }

        public MagicBag MagicBag { get; }

        public SpellsBook SpellsBook { get; set; }

        public int AttackValue
        {
            get
            {
                return SpellsBook.AttackValue + Bag.AttackValue + MagicBag.AttackValue;
            }
        }

        public int DefenseValue
        {
            get
            {
                return SpellsBook.DefenseValue + Bag.DefenseValue + MagicBag.DefenseValue;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }

        public void Cure()
        {
            this.Health = 100;
        }
    }
}