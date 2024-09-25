using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class ACharacterCard : ACard
    {
        public CharacterSO Character;
        public void Invoke(AToken token) { }
        public void AssignUI()
        {
            GameManager.gameManager.CharacterDesign.sprite = Character.Design;
            GameManager.gameManager.CharacterMana.text = Mana.ToString();
            GameManager.gameManager.CharacterHP.text = Character.HP.ToString();
            GameManager.gameManager.CharacterAtk.text = Character.Damage.ToString();
            GameManager.gameManager.CharacterDesc.text = Character.Description;
        }
    }
}
