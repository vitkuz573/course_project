using System;
using System.Drawing;
using System.Windows.Forms;

namespace course_project
{
    public partial class AquariumForm : Form
    {
        public AquariumForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(aquarium_picturebox.Width, aquarium_picturebox.Height);
            Graphics graphics = Graphics.FromImage(bitmap);

            graphics.Clear(Color.Blue);

            aquarium_picturebox.Image = bitmap;
            aquarium_picturebox.Refresh();
        }

        private void add_carp_button_Click(object sender, EventArgs e)
        {
            CarpFlock<int[]> carpFlock = new CarpFlock<int[]>();
            int[] coords = { 3, 4 };
            carpFlock.Add(coords);

            foreach (var carp in carpFlock)
            {
                Console.Write(carp);
            }
        }

        private void add_pike_button_Click(object sender, EventArgs e)
        {
            PikeFlock<int[]> pikeFlock = new PikeFlock<int[]>();
            int[] coords = { 1, 2 };
            pikeFlock.Add(coords);

            foreach (var pike in pikeFlock)
            {
                Console.WriteLine(pike);
            }
        }
    }
}
