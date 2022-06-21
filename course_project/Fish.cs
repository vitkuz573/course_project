using System.Drawing;

namespace course_project
{
    internal class Fish
    {
        private protected Brush brush;
        private protected AquariumForm aquarium_form;

        protected virtual void Draw() { }

        public int[] Data { get; set; }
    }
}
