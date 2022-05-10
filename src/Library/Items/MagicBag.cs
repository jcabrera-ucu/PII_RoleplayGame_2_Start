using System.Collections.Generic;

namespace RoleplayGame
{
    public class MagicBag
    {
        public List<IMagicItem> Items { get; }

        public MagicBag()
        {
            this.Items = new List<IMagicItem>();
        }

        public void AddItem(IMagicItem item)
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