namespace RoleplayGame
{
    public class Bow : IItem, IAttackItem
    {
        public int AttackValue 
        {
            get
            {
                return 15;
            } 
        }
    }
}