using Engine.Renderers;
using Silk.NET.Maths;

namespace Engine.Objects {
    public class RenderableObject : BasicObject, IRenderable
    {
        private Batch? batch;
        public RenderableObject(float x, float y) {
            this.x = x;
            this.y = y;
            // set up the renderer for this object
            batch = new Batch();
        }
        public bool visible {
            get {
                return visible;
            }
            set {
                // TODO: rendering?
                visible = value;
            }
        }
        public float x { 
            get {
                return x;
            }
            set {
                // TODO: rendering?
                x = value;
            }
        }
        public float y { 
            get {
                return y;
            }
            set {
                // TODO: rendering?
                y = value;
            }
        }
        public float z { 
            get {
                return z;
            }
            set {
                // TODO: rendering?
                z = value;
            }
        }

        public Vector2D<float> scale { 
            get {
                return scale;
            }
            set {
                scale = value;
            }
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }
    }
}