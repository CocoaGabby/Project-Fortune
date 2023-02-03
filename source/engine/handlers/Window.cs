using Engine.States;
using Silk.NET.Maths;
using Silk.NET.Windowing;

namespace Engine.Handlers {
    /// <summary>
    /// This class handles the main window of the application.
    /// </summary> 
    public static class Window {
        /* 
            The main window pointer, for when a window is generated. 
            If you ever need to generate another window, you'll have to handle that manually.
        */

        public static IWindow GenerateWindow(string windowName, int width, int height, State newState) {
            var options = WindowOptions.Default;
            options.IsVisible = false;
            options.Size = new Vector2D<int>(width, height);
            options.Title = windowName;

            Handler.window = Silk.NET.Windowing.Window.Create(options);
            // Initialize Handler
            Handler.State = newState;
            Handler.window.Load += Handler.Load;
            Handler.window.Update += Handler.Update;
            Handler.window.Render += Handler.Draw;
            //
            Handler.window.Run();
            return Handler.window;
        }
    }
}