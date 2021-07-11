using System;
using System.Threading;
using Veldrid;

namespace Cade.Common.Interfaces
{
    public abstract class CadeExtension
    {
        protected CadeExtension(CadeInputManager inputManager, CadeOutputManager outputManager)
        {
            InputManager = inputManager;
            OutputManager = outputManager;
        }

        /// <summary>
        /// Core specific Information
        /// </summary>
        public abstract string CoreName { get; }
        public abstract string CoreDescription { get; }
        public abstract string CoreDeveloper { get; }

        /// <summary>
        /// Platform specific information
        /// </summary>
        public abstract string PlatformName { get; }
        public abstract string PlatformDescription { get; }
        public abstract string PlatformDeveloper { get; }
        public abstract int MaxPlayers { get; }
        public abstract DateTime ReleaseDate { get; }

        /// <summary>
        /// Emulation specific information
        /// </summary>
        public abstract string[] SupportedFileExtensions { get; }

        public CadeInputManager InputManager { get; }
        public CadeOutputManager OutputManager { get; }
        
        protected bool IsRunning { get; set; }

        /// <summary>
        /// Setup method is used to setup extension specific configuration
        /// </summary>
        /// <param name="graphicsDevice">device used to output graphics to the window.</param>
        public abstract void Setup(GraphicsDevice graphicsDevice);

        /// <summary>
        /// Load method will setup any specific config before run
        /// </summary>
        /// <param name="path">path to content for running</param>
        public abstract void Load(string path);

        /// <summary>
        /// Run method runs the extension
        /// </summary>
        /// <param name="cancellationTokenSource">token used to cleanup threads</param>
        public abstract void Run(CancellationTokenSource cancellationTokenSource);

        /// <summary>
        /// Toggle the state of the current run between paused and running
        /// </summary>
        public abstract void Toggle();

        /// <summary>
        /// Close method cleans up a running extension
        /// </summary>
        public abstract void Close();
    }
}