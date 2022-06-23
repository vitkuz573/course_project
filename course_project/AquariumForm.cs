using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace course_project
{
    public partial class AquariumForm : Form
    {
        private readonly Aquarium aquarium;
        private readonly List<Point> carpFlockData = new List<Point>();

        public AquariumForm()
        {
            InitializeComponent();

            aquarium = new Aquarium(ClientRectangle);

            aquarium_timer.Enabled = true;

            pike_speed_numericupdown.Value = 5;
        }

        private void Pike_speed_numericupdown_ValueChanged(object sender, EventArgs e)
        {
            foreach (Pike pike in aquarium.pikeFlock)
            {
                pike.speed = new Size(Convert.ToInt32(pike_speed_numericupdown.Value), Convert.ToInt32(pike_speed_numericupdown.Value));
            }
        }

        private void carp_speed_numericupdown_ValueChanged(object sender, EventArgs e)
        {
            foreach (Carp carp in aquarium.carpFlock)
            {
                carp.speed = new Size(Convert.ToInt32(pike_speed_numericupdown.Value), Convert.ToInt32(pike_speed_numericupdown.Value));
            }
        }

        private void Aquarium_timer_Tick(object sender, EventArgs e)
        {
            foreach (Pike pike in aquarium.pikeFlock)
            {
                pike.UpdateLocation(ClientRectangle);
            }

            foreach (Carp carp in aquarium.carpFlock)
            {
                carp.UpdateLocation(ClientRectangle);

                carpFlockData.Clear();
                carpFlockData.Add(carp.Data);
            }

            if (hunting_checkbox.Checked == true)
            {
                hunting_status_label.Text = "Охота: ON";

                foreach (Pike pike in aquarium.pikeFlock)
                {
                    foreach (Point point in carpFlockData)
                    {
                    }
                }
            }
            else
            {
                hunting_status_label.Text = "Охота: OFF";
            }

            Invalidate();
        }

        private void Add_carp_button_Click(object sender, EventArgs e)
        {
            aquarium.carpFlock.Add(aquarium.FishCoordinates());

            carp_count_label.Text = "Карпы: " + aquarium.carpFlock.Count;

            EnableHuntingCheckBox();
        }

        private void Add_pike_button_Click(object sender, EventArgs e)
        {
            aquarium.pikeFlock.Add(aquarium.FishCoordinates());

            pike_count_label.Text = "Щуки: " + aquarium.pikeFlock.Count;

            EnableHuntingCheckBox();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            aquarium.Init(e.Graphics);
        }

        private void EnableHuntingCheckBox()
        {
            if (aquarium.pikeFlock.Count != 0 && aquarium.carpFlock.Count != 0)
            {
                hunting_checkbox.Enabled = true;
            }
        }
    }
}