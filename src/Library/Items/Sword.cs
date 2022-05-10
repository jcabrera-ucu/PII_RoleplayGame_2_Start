namespace RoleplayGame
{
    public class Sword : IItem, IAttackItem
    {
        public int AttackValue 
        {
            get
            {
                return 20;
            } 
        }
    }
}