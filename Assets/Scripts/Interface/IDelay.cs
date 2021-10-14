using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Interface
{
    interface IDelay
    {
        float Timer { get; set; }
        bool Wait(float time);
    }
}
