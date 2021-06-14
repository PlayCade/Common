using System.Collections.Generic;
using Cade.Common.Models;

namespace Cade.Common.Interfaces
{
    public abstract class CadeInputManager
    { 
        public abstract List<Input> Inputs();
        public abstract void Update(List<Input> inputs);
        public abstract int MaxPlayers();
    }
}