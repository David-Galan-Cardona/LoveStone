using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public class ASpellCard : ACard
    {
        public EntitySO Entity;
        public void AssignUI()
        {
            GameManager.gameManager.SpellDesc.text = Entity.Description;
            GameManager.gameManager.SpellDesign.sprite = Entity.Design;
            GameManager.gameManager.SpellMana.text = Mana.ToString();
        }
    }
}
