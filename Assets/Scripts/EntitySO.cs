using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;


namespace Assets.Scripts
{
    [CreateAssetMenu(fileName = "Entity", menuName = "ScriptableObjects/Entity")]
    public class EntitySO : ScriptableObject
    {
        public string Name;
        public Sprite Design;
        public string Description;
    }
}
