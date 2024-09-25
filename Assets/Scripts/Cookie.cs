using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public class Cookie : ACharacterCard, IEffect, IOnDead
    {
        public void Effect() { }
        public void Effect(AFighter target) { }
        public void Effect(AFighter[] targets) { }

        public void OnDead() { }
        private void Start()
        {
            base.AssignUI();
        }
    }
}
