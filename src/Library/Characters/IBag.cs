namespace RoleplayGame
{
    public interface IBag
    {
        void AddItem(IItem item);

        int AttackValue { get; }

        int DefenseValue { get; }
    }
}
