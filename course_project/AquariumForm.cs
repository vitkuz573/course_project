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

            DoubleBuffered = true;

            aquarium = new Aquarium(ClientRectangle);
            aquarium_timer.Interval = 100;
            aquarium_timer.Tick += Timer_Tick;
            aquarium_timer.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
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
            aquarium.carpFlock.Add(new Point(), this);
        }

        private void Add_pike_button_Click(object sender, EventArgs e)
        {
            aquarium.pikeFlock.Add(new Point(), this);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            aquarium.Paint(e.Graphics);
        }
    }
}
