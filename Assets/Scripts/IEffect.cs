using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public interface IEffect
    {
        public void Effect() { }
        public void Effect(AFighter target) { }
        public void Effect(AFighter[] targets) { }
    }
}
