using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public Text CharacterMana, CharacterAtk, CharacterHP, CharacterDesc, TokenDamage, TokenHP, PowerMana, SpellMana, SpellDesc;
    public Image CharacterDesign, AvatarDesign, TokenDesign, PowerDesign, SpellDesign;
    void Awake()
    {
        if (gameManager == null)
        {
            gameManager = this;
        }
        else if (gameManager != this)
        {
            Destroy(gameObject);
        }
    }

}
