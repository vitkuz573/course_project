using System;
using System.Threading;
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

        private void Aquarium_timer_Tick(object sender, EventArgs e)
        {
            foreach (var pike in _aquarium.pikeFlock) pike.UpdateLocation(ClientRectangle);

            foreach (var carp in _aquarium.carpFlock)
            {
                var coordinates = carp.UpdateLocation(ClientRectangle);

                carp.Data = coordinates;
            }

            if (hunting_checkbox.Checked)
            {
                hunting_status_label.Text = "Охота: ON";

                Hunting();
            }
            else
            {
                hunting_status_label.Text = "Охота: OFF";
            }

            Invalidate();
        }

        private void Add_Carp_Button_Click(object sender, EventArgs e)
        {
            _aquarium.carpFlock.Add(_aquarium.RandomPoint());

            UpdateCounters();

            EnableHuntingCheckBox();
            EnableCleanButton();
        }

        private void Add_Pike_Button_Click(object sender, EventArgs e)
        {
            _aquarium.pikeFlock.Add(_aquarium.RandomPoint());

            UpdateCounters();

            EnableHuntingCheckBox();
            EnableCleanButton();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            _aquarium.Init(e.Graphics);
        }

        private void Aquarium_Clean_Button_Click(object sender, EventArgs e)
        {
            _aquarium.carpFlock.Clear();
            _aquarium.pikeFlock.Clear();

            if (hunting_checkbox.Checked) hunting_checkbox.Checked = false;

            hunting_checkbox.Enabled = false;
            aquarium_clean_button.Enabled = false;

            UpdateCounters();
        }

        private void Hunting()
        {
            foreach (var pike in _aquarium.pikeFlock)
                if (_aquarium.carpFlock.IsNotEmpty)
                {
                    _aquarium.carpFlock.RemoveNearest(pike.Data);

                    UpdateCounters();

                    Thread.Sleep(1000);
                }
                else
                {
                    hunting_checkbox.Checked = false;
                    hunting_checkbox.Enabled = false;
                }
        }

        private void EnableHuntingCheckBox()
        {
            if (_aquarium.pikeFlock.IsNotEmpty && _aquarium.carpFlock.IsNotEmpty) hunting_checkbox.Enabled = true;
        }

        private void EnableCleanButton()
        {
            if (_aquarium.pikeFlock.IsNotEmpty || _aquarium.carpFlock.IsNotEmpty) aquarium_clean_button.Enabled = true;
        }

        private void UpdateCounters()
        {
            pike_count_label.Text = "Щуки: " + _aquarium.pikeFlock.Count;
            carp_count_label.Text = "Карпы: " + _aquarium.carpFlock.Count;
        }
    }
}