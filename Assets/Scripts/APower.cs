using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public class APower : AInvocable
    {
        public EntitySO EntitySO;
        public void HeroPower() { }
        public void AssignUI()
        {
            GameManager.gameManager.PowerDesign.sprite = EntitySO.Design;
            GameManager.gameManager.PowerMana.text = Mana.ToString();
        }
    }
}
