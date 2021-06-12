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
        ICadeInputManager? InputManager { get; }
        ICadeOutputManager? OutputManager { get; }

        /// <summary>
        /// Load method will setup any specific config before run
        /// </summary>
        /// <param name="path">path to content for running</param>
        void Load(string path);
        
        /// <summary>
        /// Run method runs the extension
        /// </summary>
        
        void Run();
    }
}