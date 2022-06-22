using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;

namespace course_project
{
    public partial class AquariumForm : Form
    {
        readonly Aquarium aquarium;
        List<Point> carpFlockData = new List<Point>();

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

        public float Distance(Point p1, Point p2)
        {
            Vector2 vector2 = new Vector2((p1.X - p1.Y), (p2.X - p2.Y));

            return Math.Abs(vector2.Length());
        }

        private void Add_carp_button_Click(object sender, EventArgs e)
        {
            aquarium.carpFlock.Add(new Point());

            carp_count_label.Text = "Карпы: " + aquarium.carpFlock.Count;

            EnableHuntingCheckBox();
        }

        private void Add_pike_button_Click(object sender, EventArgs e)
        {
            aquarium.pikeFlock.Add(new Point());

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
