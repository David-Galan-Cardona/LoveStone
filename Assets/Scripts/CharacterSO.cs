using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

namespace Assets.Scripts
{
    [CreateAssetMenu(fileName = "Character", menuName = "ScriptableObjects/Character")]
    public class CharacterSO : EntitySO
    {
        public int Damage;
        public int HP;
    }
}
