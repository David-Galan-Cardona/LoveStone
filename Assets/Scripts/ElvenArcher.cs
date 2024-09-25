using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class ElvenArcher : ACharacterCard, IOnstart
    {
        public void OnStart()
        {

        }
        private void Start()
        {
            base.AssignUI();
        }
    }
}
