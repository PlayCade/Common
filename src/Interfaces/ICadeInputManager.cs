using System.Collections.Generic;
using Cade.Common.Models;

namespace Cade.Common.Interfaces
{
    public interface ICadeInputManager
    {
        List<Input> inputs { get; }
        int MaxPlayers { get; }
    }
}