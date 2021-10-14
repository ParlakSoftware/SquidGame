using Assets.Scripts.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
namespace Assets.Scripts.Class
{
    class Delay : IDelay
    {
        private float timer;
        public float Timer
        {
            get
            {
                return timer;
            }
            set
            {
                if (value < 0) timer = 0;
                else timer = value;
            }
        }

        bool IDelay.Wait(float time)
        {
            if (Timer < time)
            {
                Timer += Time.deltaTime;
                return false;
            }
            else
            {
                Timer = 0;
                return true;
            }
        }
    }
}
