using System;
using System.Drawing;
using System.Windows.Forms;

namespace course_project
{
    public partial class AquariumForm : Form
    {
        readonly Random random = new Random();
        readonly Aquarium aquarium;

        public AquariumForm()
        {
            InitializeComponent();

            aquarium = new Aquarium(this);
        }

        private void AquariumForm_Load(object sender, EventArgs e)
        {
            aquarium.Clear();

            aquarium_timer.Enabled = false;
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
            aquarium.Clear();
        }

        public PictureBox AquariumPictureBox => aquarium_picturebox;

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
