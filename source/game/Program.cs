using Engine.Handlers;
using Engine.States;
using Silk.NET.Maths;

namespace Game {
    class Program {
        public static void Main(string[] args) {
            Window.GenerateWindow("Not GameMaker: Studio", 1280, 720, new State());
        }
    }
}