namespace Engine.Renderers {
    public class Batch {
        private static readonly int positionSize = 2; // 2D Space, Vector2D
        private static readonly int colorSize = 4; // RGBA
        private static readonly int posOffset = 0;
        //
        private static readonly int floatBytes = sizeof(float);
        private static readonly int colorOffset = posOffset + positionSize * floatBytes;
        private static readonly int vertexSize = 6;
        private static readonly int vertexBytes = vertexSize * floatBytes;
        // Batch Information
        private float[] vertices;
        private int vao, vbo;
        private int batchLimiter = 0; // the amount of sprites being drawn

        /// <summary>
        /// Creates a batch object, for later use with batch rendering.
        /// </summary>
        public Batch() {
            // Create an individual batch (per object)
        }
    }

}