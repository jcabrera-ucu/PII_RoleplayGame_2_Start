namespace RoleplayGame
{
    public class Shield : IItem, IDefenseItem
    {
        public int DefenseValue
        {
            get
            {
                return 14;
            }
        }
    }
}