using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public class AAvatar : AFighter
    {
        public EntitySO Entity;
        public APower Power;
        public int Armor;
        public void AssignUI()
        {
            GameManager.gameManager.AvatarDesign.sprite = Entity.Design;
        }
    }
}
