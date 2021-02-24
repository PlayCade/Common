using System.Collections.Generic;
using Cade.Common.Models;

namespace Cade.Common.Interfaces
{
    public interface ICadeInputManager
    {
        List<Input> Inputs();
        void Update(List<Input> inputs);
        int MaxPlayers();
    }
}