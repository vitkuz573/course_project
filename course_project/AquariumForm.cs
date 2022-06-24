using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace course_project
{
    public partial class AquariumForm : Form
    {
        private readonly Aquarium _aquarium;
        private readonly List<Point> _carpFlockData;

        public AquariumForm()
        {
            InitializeComponent();

            _aquarium = new Aquarium(ClientRectangle);

            pike_speed_numericupdown.Value = 5;

            _carpFlockData = new List<Point>();
        }

        private void Pike_Speed_NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            foreach (var pike in _aquarium.pikeFlock)
                pike.speed = new Size(Convert.ToInt32(pike_speed_numericupdown.Value),
                    Convert.ToInt32(pike_speed_numericupdown.Value));
        }

        private void Carp_Speed_NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            foreach (var carp in _aquarium.carpFlock)
                carp.speed = new Size(Convert.ToInt32(pike_speed_numericupdown.Value),
                    Convert.ToInt32(pike_speed_numericupdown.Value));
        }

        private void Aquarium_timer_Tick(object sender, EventArgs e)
        {
            foreach (var pike in _aquarium.pikeFlock) pike.UpdateLocation(ClientRectangle);

            foreach (var carp in _aquarium.carpFlock)
            {
                carp.UpdateLocation(ClientRectangle);

                _carpFlockData.Clear();
                _carpFlockData.Add(carp.Data);
            }

            hunting_status_label.Text = hunting_checkbox.Checked ? "Охота: ON" : "Охота: OFF";

            Invalidate();
        }

        private void Add_Carp_Button_Click(object sender, EventArgs e)
        {
            _aquarium.carpFlock.Add(_aquarium.RandomPoint());

            carp_count_label.Text = "Карпы: " + _aquarium.carpFlock.Count;

            EnableHuntingCheckBox();
            EnableCleanButton();
        }

        private void Add_Pike_Button_Click(object sender, EventArgs e)
        {
            _aquarium.pikeFlock.Add(_aquarium.RandomPoint());

            pike_count_label.Text = "Щуки: " + _aquarium.pikeFlock.Count;

            EnableHuntingCheckBox();
            EnableCleanButton();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            _aquarium.Init(e.Graphics);
        }

        private void EnableHuntingCheckBox()
        {
            if (!_aquarium.pikeFlock.IsEmpty && !_aquarium.carpFlock.IsEmpty) hunting_checkbox.Enabled = true;
        }

        private void EnableCleanButton()
        {
            if (!_aquarium.pikeFlock.IsEmpty || !_aquarium.carpFlock.IsEmpty) aquarium_clean_button.Enabled = true;
        }

        private void Aquarium_Clean_Button_Click(object sender, EventArgs e)
        {
            _aquarium.carpFlock.Clear();
            _aquarium.pikeFlock.Clear();

            if (hunting_checkbox.Checked) hunting_checkbox.Checked = false;

            hunting_checkbox.Enabled = false;
            aquarium_clean_button.Enabled = false;

            pike_count_label.Text = "Щуки: " + _aquarium.pikeFlock.Count;
            carp_count_label.Text = "Карпы: " + _aquarium.carpFlock.Count;
        }
    }
}