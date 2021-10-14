using Assets.Scripts.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
namespace Assets.Scripts.Class.DeviceController
{
    class DesktopController : IDeviceController
    {
        public void TryAgain()
        {
            if (SimpleInput.GetButton("TryAgain"))
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }

        public void Walk(ICharacter character)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                character.Walk();
            }
            if (Input.GetKeyUp(KeyCode.Space))
            {
                character.Idle();
            }
        }
    }
}
