using System;

namespace Cade.Common.Interfaces
{
    public interface ICadeExtension
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

        /// <summary>
        /// Load method will setup any specific config before run
        /// </summary>
        void Load();
        
        /// <summary>
        /// Run method runs the extension
        /// </summary>
        /// <param name="path">path to content for running</param>
        void Run(string path);
    }
}