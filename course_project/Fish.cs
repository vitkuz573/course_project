using System.Drawing;

namespace course_project
{
    internal class Fish
    {
        private protected Graphics graphics;
        private protected Brush brush;
        private protected AquariumForm aquarium_form;

        public Fish(Color color, AquariumForm aquariumForm)
        {
            aquarium_form = aquariumForm;

            brush = new SolidBrush(color);
            graphics = Graphics.FromImage(aquariumForm.AquariumPictureBox.Image);
        }

        protected virtual void Draw() { }

        public int[] Data { get; set; }
    }
}
