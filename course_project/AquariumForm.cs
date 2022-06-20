using System;
using System.Drawing;
using System.Windows.Forms;

namespace course_project
{
    public partial class AquariumForm : Form
    {
        readonly Random random = new Random();

        public PictureBox Aquarium => aquarium_picturebox;

        public AquariumForm()
        {
            InitializeComponent();
        }

        private void AquariumForm_Load(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(aquarium_picturebox.Width, aquarium_picturebox.Height);
            Graphics graphics = Graphics.FromImage(bitmap);

            graphics.Clear(Color.Blue);

            aquarium_picturebox.Image = bitmap;
            aquarium_picturebox.Refresh();
        }

        private void Add_carp_button_Click(object sender, EventArgs e)
        {
            _ = new CarpFlock
            {
                { FishCoordinates, this }
            };
        }

        private void Add_pike_button_Click(object sender, EventArgs e)
        {
            _ = new PikeFlock
            {
                { FishCoordinates, this }
            };
        }

        private void Aquarium_timer_Tick(object sender, EventArgs e)
        {

        }

        public int[] FishCoordinates
        {
            get
            {
                int[] coordinates = { random.Next(0, aquarium_picturebox.Width), random.Next(0, aquarium_picturebox.Height) };

                return coordinates;
            }
        }
    }
}
