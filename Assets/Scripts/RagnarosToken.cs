using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine.TextCore.Text;
using UnityEngine;

namespace Assets.Scripts
{
    
    public class RagnarosToken:AToken, IEffect
    {
        private void Start()
        {
            AssignUI();
        }
        public void Effect() { }
        public void Effect(AFighter target) { }
        public void Effect(AFighter[] targets) { }
    }
}
