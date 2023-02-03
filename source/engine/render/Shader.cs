using System.Numerics;
using Silk.NET.OpenGL;

namespace Engine.Renderers {
    /// <summary>
    /// A shader instance class, inheriting the default shaders but allowing for usage of different shaders.
    /// </summary>
    public class Shader : IDisposable {
        private uint _shaderProgram = 0;
        public Shader(string vertexPath = "", string fragmentPath = "") {
            _shaderProgram = Renderer.GL.CreateProgram();

            uint vertex = LoadShader(ShaderType.VertexShader, vertexPath);
            uint fragment = LoadShader(ShaderType.FragmentShader, fragmentPath);
            Renderer.GL.AttachShader(_shaderProgram, vertex);
            Renderer.GL.AttachShader(_shaderProgram, fragment);
            Renderer.GL.LinkProgram(_shaderProgram);
            Renderer.GL.GetProgram(_shaderProgram, GLEnum.LinkStatus, out var status);
            if (status == 0)
                throw new Exception($"Program failed to link with error: {Renderer.GL.GetProgramInfoLog(_shaderProgram)}");
            Renderer.GL.DetachShader(_shaderProgram, vertex);
            Renderer.GL.DetachShader(_shaderProgram, fragment);
            Renderer.GL.DeleteShader(vertex);
            Renderer.GL.DeleteShader(fragment);
        }

        private uint LoadShader(ShaderType type, string path) {
            string src = File.ReadAllText(path);
            uint handle = Renderer.GL.CreateShader(type);
            Renderer.GL.ShaderSource(handle, src);
            Renderer.GL.CompileShader(handle);
            string infoLog = Renderer.GL.GetShaderInfoLog(handle);
            if (!string.IsNullOrWhiteSpace(infoLog))
                throw new Exception($"Error compiling shader of type {type}, failed with error {infoLog}");
            return handle;
        }

        public void Use()
        {
            Renderer.GL.UseProgram(_shaderProgram);
        }

        public void SetUniform(string name, int value)
        {
            int location = Renderer.GL.GetUniformLocation(_shaderProgram, name);
            if (location == -1)
                throw new Exception($"{name} uniform not found on shader.");
            Renderer.GL.Uniform1(location, value);
        }

        public unsafe void SetUniform(string name, Matrix4x4 value)
        {
            //A new overload has been created for setting a uniform so we can use the transform in our shader.
            int location = Renderer.GL.GetUniformLocation(_shaderProgram, name);
            if (location == -1)
                throw new Exception($"{name} uniform not found on shader.");
            Renderer.GL.UniformMatrix4(location, 1, false, (float*) &value);
        }

        public void Dispose()
        {
            Renderer.GL.DeleteShader(_shaderProgram);
        }
    }
}