using System.Numerics;
using Engine.Handlers;
using Engine.Objects;
using Silk.NET.Maths;
using Silk.NET.OpenGL;
using Silk.NET.Windowing;

namespace Engine.Renderers {
    /// <summary>
    /// A Singleton render instruction class that is meant to handle the OpenGL context.
    /// </summary>
    public static class Renderer {
        /*
            Fortune's renderer was designed to be GameMaker esque. 
            This means the renderer handles all of the 2D overhead to make sprites really easy to render.
            Commands are also used in batch, meaning you tell the renderer when you want to make changes, 
            like the overall camera or shader being used/applied. 
            You're still responsible for using Shaders and Cameras wisely, however.
        */
        private static bool initialized = false;
        public static GL GL = GL.GetApi(Handler.window);
        public static void Initialize(IWindow window) {
            if (!initialized) {
                GL = GL.GetApi(window);
                initialized = true;
            }
        }

        private static Camera2D? _focusedCamera = null;
        public static Shader? CurShader = null;

        /// <summary>
        /// Sets the current target camera for 2D rendering.
        /// </summary>
        public static void SetCamera2D(Camera2D newCamera) {
            _focusedCamera = newCamera;
        }

        /*
            Render Functions
        */

        public static void DrawSprite2D(Texture2D texture, int textureIndex, int x, int y) {
            
        }
        public unsafe static void DrawSprite2D(Texture2D texture, int textureIndex, int x, int y, 
            int scaleX, int scaleY, float rotation, Vector2D<float> origin, float alpha) {
            
        }
    }
}