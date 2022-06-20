using System.Drawing;

namespace course_project
{
    internal class Aquarium
    {
        public Fish fish = new Fish();

        readonly Color waterColor = Color.LightSkyBlue;
        readonly Bitmap bitmap;
        readonly Graphics graphics;
        readonly AquariumForm aquarium_form;

        public Aquarium(AquariumForm aquariumForm)
        {
            aquarium_form = aquariumForm;

            bitmap = new Bitmap(aquariumForm.Width, aquariumForm.Height);
            graphics = Graphics.FromImage(bitmap);
        }

        public void Init() { }

        public void Run() { }

        public void Done() { }

        public void Clear()
        {
            graphics.Clear(waterColor);

            aquarium_form.AquariumPictureBox.Image = bitmap;
            aquarium_form.Refresh();
        }
    }
}
