using Engine.Objects;

namespace Engine.States {

    public class State : IBasic
    {
        public int ID { 
            get {
                return -1; // states dont need ids dummy
            } 
            set {
                ID = -1;
            }
        }

        public bool active { 
            get { return active; } set { active = value; }
        }

        public IBasic[] ?Members = {};
        public IRenderable[] ?Renderables = {};

        public State() {
        
        }

        public void Create()
        {
            
        }

        public void Dispose()
        {
            Members = null;
            active = false;
        }

        public void Update()
        {
            // update all members
            if (Members != null) {
                for (int i = 0; i < Members.Length; i++)
                    Members[i].Update();
            }
            //
        }

        public void Draw() {
            if (Renderables != null) {
                for (int i = 0; i < Renderables.Length; i++)
                    Renderables[i].Draw();
            }
        }
    }
}