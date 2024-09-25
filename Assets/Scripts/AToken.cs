using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.TextCore.Text;

namespace Assets.Scripts
{
    public class AToken:AFighter
    {
        public int Position;
        public CharacterSO Character;
        public void AssignUI()
        {
            GameManager.gameManager.TokenDesign.sprite = Character.Design;
            GameManager.gameManager.TokenDamage.text = Character.Damage.ToString();
            GameManager.gameManager.TokenHP.text = Character.HP.ToString();
        }
    }
}
