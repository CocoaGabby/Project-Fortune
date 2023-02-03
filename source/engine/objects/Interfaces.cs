using Silk.NET.Maths;

namespace Engine.Objects {
    ///<summary>
    /// An interface class for basic objects, do not use this, use the BasicObject class
    ///</summary>
    public interface IBasic : IDisposable {
        public int ID{get; set;}
        public bool active{get; set;}
        public void Create();
        public void Update();
    }

    ///<summary>
    /// An interface class for renderable objects, do not use this, use the RenderableObject class
    ///</summary>
    public interface IRenderable {
        public bool visible{get; set;}
        public float x{get; set;}
        public float y{get; set;}
        public float z{get; set;}
        public Vector2D<float> scale{get; set;}
        public void Draw();
    }
}