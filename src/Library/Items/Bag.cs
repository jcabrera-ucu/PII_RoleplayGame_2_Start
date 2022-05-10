using System.Collections.Generic;

namespace RoleplayGame
{
    public class Bag
    {
        public List<IItem> Items { get; }

        public Bag()
        {
            this.Items = new List<IItem>();
        }

        public void AddItem(IItem item)
        {
            Items.Add(item);
        }

        public int AttackValue 
        {
            get
            {
                int value = 0;
                foreach (var item in Items)
                {
                    var attackItem = item as IAttackItem;
                    if (attackItem != null)
                    {
                        value += attackItem.AttackValue;
                    }
                }
                return value;
            } 
        }

        public int DefenseValue 
        {
            get
            {
                int value = 0;
                foreach (var item in Items)
                {
                    var defenseItem = item as IDefenseItem;
                    if (defenseItem != null)
                    {
                        value += defenseItem.DefenseValue;
                    }
                }
                return value;
            } 
        }
    }
}