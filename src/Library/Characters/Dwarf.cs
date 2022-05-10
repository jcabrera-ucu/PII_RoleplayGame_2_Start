namespace RoleplayGame
{
    public class Dwarf : ICharacter, ICurable, IAttackable
    {
        private int health = 100;

        public Bag Bag { get; }

        public Dwarf(string name)
        {
            this.Name = name;
            this.Bag = new();
        }

        public string Name { get; set; }

        public int AttackValue
        {
            get
            {
                return Bag.AttackValue;
            }
        }

        public int DefenseValue
        {
            get
            {
                return Bag.DefenseValue;
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