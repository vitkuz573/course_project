using System.Drawing;

namespace course_project
{
    internal class Aquarium
    {
        readonly public PikeFlock pikeFlock;
        readonly public CarpFlock carpFlock;
        readonly Color waterColor;
        readonly Bitmap bitmap;
        readonly Graphics graphics;
        readonly AquariumForm aquarium_form;

        public Aquarium(AquariumForm aquariumForm)
        {
            aquarium_form = aquariumForm;

            waterColor = Color.LightSkyBlue;
            pikeFlock = new PikeFlock();
            carpFlock = new CarpFlock();
            bitmap = new Bitmap(aquariumForm.AquariumPictureBox.Width, aquariumForm.AquariumPictureBox.Height);
            graphics = Graphics.FromImage(bitmap);
        }

        public void Init()
        {
            graphics.Clear(waterColor);

            aquarium_form.AquariumPictureBox.Image = bitmap;
            aquarium_form.Refresh();
        }

        public void Run()
        {
        }

        public void Done()
        {
        }
    }
}
