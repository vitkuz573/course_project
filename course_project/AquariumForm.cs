using System;
using System.Windows.Forms;

namespace course_project
{
    public partial class AquariumForm : Form
    {
        private readonly Aquarium _aquarium;

        public AquariumForm()
        {
            InitializeComponent();

            _aquarium = new Aquarium(ClientRectangle);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            _aquarium.Init(e.Graphics);
        }

        private void Aquarium_Timer_Tick(object sender, EventArgs e)
        {
            foreach (var pike in _aquarium.pikeFlock) pike.UpdateLocation(ClientRectangle);
            foreach (var carp in _aquarium.carpFlock) carp.UpdateLocation(ClientRectangle);

            Invalidate();
        }

        private void Hunting_Timer_Tick(object sender, EventArgs e)
        {
            if (hunting_checkbox.Checked)
            {
                hunting_status_label.Text = "Охота: ON";

                foreach (var pike in _aquarium.pikeFlock)
                    if (_aquarium.carpFlock.IsNotEmpty)
                    {
                        _aquarium.carpFlock.RemoveNearest(pike.Data);

                        UpdateCounters();
                    }
                    else
                    {
                        hunting_checkbox.Checked = false;
                        hunting_checkbox.Enabled = false;
                    }
            }
            else
            {
                hunting_status_label.Text = "Охота: OFF";
            }
        }

        private void Add_Carp_Button_Click(object sender, EventArgs e)
        {
            _aquarium.carpFlock.Add(_aquarium.RandomPoint());

            UpdateCounters();
            EnableControls();
        }

        private void Add_Pike_Button_Click(object sender, EventArgs e)
        {
            _aquarium.pikeFlock.Add(_aquarium.RandomPoint());

            UpdateCounters();
            EnableControls();
        }

        private void Aquarium_Clean_Button_Click(object sender, EventArgs e)
        {
            _aquarium.carpFlock.Clear();
            _aquarium.pikeFlock.Clear();

            hunting_checkbox.Checked = false;
            hunting_checkbox.Enabled = false;
            aquarium_clean_button.Enabled = false;

            UpdateCounters();
        }

        private void UpdateCounters()
        {
            pike_count_label.Text = "Щуки: " + _aquarium.pikeFlock.Count;
            carp_count_label.Text = "Карпы: " + _aquarium.carpFlock.Count;
        }

        private void EnableControls()
        {
            aquarium_clean_button.Enabled = _aquarium.pikeFlock.IsNotEmpty || _aquarium.carpFlock.IsNotEmpty;
            hunting_checkbox.Enabled = _aquarium.pikeFlock.IsNotEmpty && _aquarium.carpFlock.IsNotEmpty;
        }
    }
}