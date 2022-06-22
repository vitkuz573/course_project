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

            aquarium_timer.Interval = 100;
            aquarium_timer.Enabled = true;
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
            aquarium.Paint(e.Graphics);
        }
    }
}
