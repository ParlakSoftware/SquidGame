using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Interface
{
    public interface IDeviceController
    {
        void Walk(ICharacter character);
        void TryAgain();
    }
}
