namespace RoleplayGame
{
    public class Armor : IItem, IDefenseItem
    {
        public int DefenseValue
        {
            get
            {
                return 25;
            }
        }
    }
}