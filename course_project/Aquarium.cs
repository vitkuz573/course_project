using System.Drawing;

namespace course_project
{
    internal class Aquarium
    {
        readonly public PikeFlock pikeFlock;
        readonly public CarpFlock carpFlock;
        readonly Color waterColor;

        public Aquarium()
        {
            waterColor = Color.LightSkyBlue;
            pikeFlock = new PikeFlock();
            carpFlock = new CarpFlock();
        }

        public void Paint(Graphics graphics)
        {
            graphics.Clear(waterColor);

            foreach (Pike pike in pikeFlock)
                pike.Draw(graphics);

            foreach (Carp carp in carpFlock)
                carp.Draw(graphics);
        }
    }
}
