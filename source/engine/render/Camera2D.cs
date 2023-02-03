using System.Numerics;
using Engine.Objects;
using Silk.NET.Maths;

namespace Engine.Renderers {
    /// <summary>
    /// A basic camera class for 2D Sprites and 2D Rendering
    /// </summary>
    public class Camera2D : RenderableObject {
        private Matrix4x4 projectionMatrix, viewMatrix;
        private Vector2D<float> position;

        public Camera2D(Vector2D<float> position) : base(position.X, position.Y) {
            this.position = position;
            this.projectionMatrix = new Matrix4x4();
            this.viewMatrix = new Matrix4x4();
        }

        private void adjustProjection() {
            // float identity = projectionMatrix.Identity;
            projectionMatrix = Matrix4x4.CreateOrthographicOffCenter(0, 32 * 40, 0, 32 * 21, 0, 100);
        }

        public Matrix4x4 GetViewMatrix() {
            Vector3 cameraFront = new Vector3(0, 0, -1);
            Vector3 cameraUp = new Vector3(0, 1, 0);

            viewMatrix = Matrix4x4.CreateLookAt(new Vector3(x, y, 20), Vector3.Add(cameraFront, new Vector3(x, y, 0)), cameraUp);
            return viewMatrix;
        }

        public Matrix4x4 GetProjectionMatrix() {
            return projectionMatrix;
        }
  
    }
}