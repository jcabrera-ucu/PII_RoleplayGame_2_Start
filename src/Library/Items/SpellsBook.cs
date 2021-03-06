using System.Collections.Generic;

namespace RoleplayGame
{
    public class SpellsBook
    {
        public ISpell[] Spells { get; set; }
        
        public int AttackValue
        {
            get
            {
                int value = 0;
                foreach (ISpell spell in this.Spells)
                {
                    var attackItem = spell as IAttackItem;
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
                foreach (ISpell spell in this.Spells)
                {
                    var defenseItem = spell as IDefenseItem;
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