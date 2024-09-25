using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public class Fireball : APower, IEffect
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
