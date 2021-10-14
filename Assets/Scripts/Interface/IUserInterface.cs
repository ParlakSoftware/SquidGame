using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Interface
{
    interface IUserInterface
    {
        GameObject GameControllerPanel { get; set; }
        GameObject TryAgainPanel { get; set; }
        void GameController();
        void TryAgain();
    }
}
