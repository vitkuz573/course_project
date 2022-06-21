using System;
using System.Windows.Forms;

namespace course_project
{
    public partial class AquariumForm : Form
    {
        readonly Random random;
        readonly Aquarium aquarium;

        public AquariumForm()
        {
            InitializeComponent();

            random = new Random();
            aquarium = new Aquarium(this);
        }

        private void AquariumForm_Load(object sender, EventArgs e)
        {
            aquarium.Init();

            aquarium_timer.Enabled = false;
        }

        private void Add_carp_button_Click(object sender, EventArgs e)
        {
            aquarium.carpFlock.Add(FishCoordinates, this);
        }

        private void Add_pike_button_Click(object sender, EventArgs e)
        {
            aquarium.pikeFlock.Add(FishCoordinates, this);
        }

        private void Aquarium_timer_Tick(object sender, EventArgs e)
        {
            aquarium.Init();

            /**foreach (int[] pike in aquarium.pikeFlock)
            {
                Console.WriteLine("Pike X: " + pike[0] + " Y: " + pike[1]);
            }

            foreach (int[] carp in aquarium.carpFlock)
            {
                Console.WriteLine("Carp X: " + carp[0] + " Y: " + carp[1]);
            }*/
        }

        public PictureBox AquariumPictureBox => aquarium_picturebox;
        
        private int[] FishCoordinates
        {
            get
            {
                int[] coordinates = { random.Next(0, aquarium_picturebox.Width), random.Next(0, aquarium_picturebox.Height) };
                
                return coordinates;
            }
        }
    }
}
