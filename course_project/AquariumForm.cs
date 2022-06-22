using System;
using System.Drawing;
using System.Windows.Forms;

namespace course_project
{
    public partial class AquariumForm : Form
    {
        readonly Aquarium aquarium;

        public AquariumForm()
        {
            InitializeComponent();

            aquarium = new Aquarium();

            aquarium_timer.Enabled = true;

            speed_numericupdown.Value = 5;
        }

        private void speed_numericupdown_ValueChanged(object sender, EventArgs e)
        {
            foreach (Pike pike in aquarium.pikeFlock)
            {
                pike.speed = new Size(Convert.ToInt32(speed_numericupdown.Value), Convert.ToInt32(speed_numericupdown.Value));
            }

            foreach (Carp carp in aquarium.carpFlock)
            {
                carp.speed = new Size(Convert.ToInt32(speed_numericupdown.Value), Convert.ToInt32(speed_numericupdown.Value));
            }
        }

        private void aquarium_timer_Tick(object sender, EventArgs e)
        {
            foreach (Pike pike in aquarium.pikeFlock)
            {
                pike.UpdateLocation(ClientRectangle);
            }

            foreach (Carp carp in aquarium.carpFlock)
            {
                carp.UpdateLocation(ClientRectangle);
            }

            Invalidate();
        }

        private void Add_carp_button_Click(object sender, EventArgs e)
        {
            aquarium.carpFlock.Add(new Point());
        }

        private void Add_pike_button_Click(object sender, EventArgs e)
        {
            aquarium.pikeFlock.Add(new Point());
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            aquarium.Init(e.Graphics);
        }
    }
}
