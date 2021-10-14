using Assets.Scripts.Class;
using Assets.Scripts.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Manager
{
    class UserInterfaceManager:MonoBehaviour
    {
        public IUserInterface userInterface;
        public GameObject gameControllerPanel;
        public GameObject tryAgainPanel;
        void Start()
        {
            userInterface = new UserInterface();
            userInterface.TryAgainPanel = tryAgainPanel;
            userInterface.GameControllerPanel = gameControllerPanel;
        }
    }
}
