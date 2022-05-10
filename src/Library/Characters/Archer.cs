namespace RoleplayGame
{
    public class Archer : ICharacter, ICurable, IAttackable
    {
        private int health = 100;

        public Bag Bag { get; }

        public Archer(string name)
        {
            Bag = new();
            this.Name = name;
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