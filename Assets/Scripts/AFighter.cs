using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class AFighter : MonoBehaviour
    {
        public int Damage;
        public int HP;
        public int Team;
        public int CurrentHP;
        public int CurrentDamage;
        public void Attack(AFighter fighter) { }
    }
}
