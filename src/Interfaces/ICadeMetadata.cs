using System;

namespace Cade.Common.Interfaces
{
    public interface ICadeMetadata
    {
        /// <summary>
        /// Core specific Information
        /// </summary>
        string CoreName { get; }
        string CoreDescription { get; }
        string CoreDeveloper { get; }
        
        /// <summary>
        /// Platform specific information
        /// </summary>
        string PlatformName { get; }
        string PlatformDescription { get; }
        string PlatformDeveloper { get; }
        int MaxPlayers { get; }
        DateTime ReleaseDate { get; }
        
        /// <summary>
        /// Emulation specific information
        /// </summary>
        string[] SupportedFileExtensions { get; }
    }
}