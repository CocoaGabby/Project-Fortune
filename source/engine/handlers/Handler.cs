using Engine.Renderers;
using Engine.States;
using Silk.NET.Maths;
using Silk.NET.Windowing;

namespace Engine.Handlers {
    /// <summary>
    /// This class handles all of the basic information and persistent storage that the engine needs in order to function. Things like states, handlers, etc go in here.
    /// </summary> 
    public static class Handler {
        public static IWindow? window;
        public static State? State;
        public static long DeltaTime { 
            get {
                // return current delta time
                return 0;
            }
            set {
                // never set
                return;
            }
        }

        public static void Load() {
            if (window != null) {
                window.Center();
                window.IsVisible = true;
                Renderer.Initialize(window);
            } else
                return;
        }

        public static void Update(double obj) {

        }

        public static void Draw(double obj) {

        }
    }
}