namespace RoleplayGame
{
    public class Axe : IItem, IAttackItem
    {
        public int AttackValue 
        {
            get
            {
                return 25;
            } 
        }
    }
}