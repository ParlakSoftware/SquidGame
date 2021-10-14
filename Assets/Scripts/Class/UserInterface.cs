using Assets.Scripts.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Class
{
    class UserInterface : IUserInterface
    {
        private GameObject tryAgainPanel;
        private GameObject gameControllerPanel;
        public GameObject TryAgainPanel
        {
            get { return this.tryAgainPanel; }
            set { this.tryAgainPanel = value; }
        }

        public GameObject GameControllerPanel
        {
            get { return this.gameControllerPanel; }
            set { this.gameControllerPanel = value; }
        }

        public void TryAgain()
        {
            GameController();
            TryAgainPanel.SetActive(true);
        }

        public void GameController()
        {
            GameControllerPanel.SetActive(true);
        }
    }
}
