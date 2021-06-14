using Veldrid;

namespace Cade.Common.Interfaces
{
    public abstract class CadeOutputManager
    {
        protected GraphicsDevice _graphicsDevice;
        public CadeOutputManager(GraphicsDevice graphicsDevice)
        {
            _graphicsDevice = graphicsDevice;
        }
        public abstract void Setup();
        public abstract void Draw();
        public abstract void Dispose();
    }
}