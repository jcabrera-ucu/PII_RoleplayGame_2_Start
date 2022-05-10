namespace RoleplayGame
{
    public class Helmet : IItem, IDefenseItem
    {
        public int DefenseValue
        {
            get
            {
                return 18;
            }
        }
    }
}