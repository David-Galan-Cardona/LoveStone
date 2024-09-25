using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor.Scripting;

namespace Assets.Scripts
{
    public class Frostbolt : ASpellCard, IEffect
    {

        public void Effect()
        {

        }
        public void Effect(AFighter target) {
        }
        public void Effect(AFighter[] targets) {
        }
        private void Start()
        {
            base.AssignUI();
        }
    }
}
