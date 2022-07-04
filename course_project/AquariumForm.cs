namespace CourseProject
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// The aquarium form.
    /// </summary>
    public partial class AquariumForm : Form
    {
        /// <summary>
        /// The aquarium.
        /// </summary>
        private readonly Aquarium aquarium;

        /// <summary>
        /// Initializes a new instance of the <see cref="AquariumForm"/> class.
        /// </summary>
        public AquariumForm()
        {
            this.InitializeComponent();

            this.aquarium = new Aquarium();
        }

        /// <summary>
        /// The on paint.
        /// </summary>
        /// <param name="e">
        /// The e.
        /// </param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.aquarium.Init(e.Graphics, e.ClipRectangle);
        }

        /// <summary>
        /// The add_ carp_ button_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void Add_Carp_Button_Click(object sender, EventArgs e)
        {
            this.aquarium.CarpFlock.Add(this.aquarium.RandomPoint());

            this.UpdateFishCounters();
            this.EnableControls();
        }

        /// <summary>
        /// The add_ pike_ button_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void Add_Pike_Button_Click(object sender, EventArgs e)
        {
            this.aquarium.PikeFlock.Add(this.aquarium.RandomPoint());

            this.UpdateFishCounters();
            this.EnableControls();
        }

        /// <summary>
        /// The aquarium_ clean_ button_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void Aquarium_Clean_Button_Click(object sender, EventArgs e)
        {
            this.aquarium.CarpFlock.Clear();
            this.aquarium.PikeFlock.Clear();

            this.huntingCheckBox.Checked = false;
            this.huntingCheckBox.Enabled = false;
            this.huntingCheckBox.Visible = false;
            this.aquariumCleanButton.Enabled = false;
            this.aquariumCleanButton.Visible = false;

            this.UpdateFishCounters();
        }

        /// <summary>
        /// The aquarium_ timer_ tick.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void Aquarium_Timer_Tick(object sender, EventArgs e)
        {
            foreach (var pike in this.aquarium.PikeFlock)
            {
                pike.UpdateLocation(this.ClientRectangle);
            }

            foreach (var carp in this.aquarium.CarpFlock)
            {
                carp.UpdateLocation(this.ClientRectangle);
            }

            this.Invalidate();
        }

        /// <summary>
        /// The enable controls.
        /// </summary>
        private void EnableControls()
        {
            this.aquariumCleanButton.Enabled =
                this.aquarium.PikeFlock.IsNotEmpty || this.aquarium.CarpFlock.IsNotEmpty;

            this.aquariumCleanButton.Visible =
                this.aquarium.PikeFlock.IsNotEmpty || this.aquarium.CarpFlock.IsNotEmpty;

            this.huntingCheckBox.Enabled = this.aquarium.PikeFlock.IsNotEmpty && this.aquarium.CarpFlock.IsNotEmpty;

            this.huntingCheckBox.Visible = this.aquarium.PikeFlock.IsNotEmpty && this.aquarium.CarpFlock.IsNotEmpty;
        }

        /// <summary>
        /// The hunting_ timer_ tick.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void Hunting_Timer_Tick(object sender, EventArgs e)
        {
            if (this.huntingCheckBox.Checked)
            {
                this.huntingStatusLabel.Text = "Охота: ON";

                foreach (var pike in this.aquarium.PikeFlock)
                {
                    this.aquarium.CarpFlock.RemoveNearest(pike.Data);

                    this.UpdateFishCounters();

                    if (this.aquarium.CarpFlock.IsEmpty)
                    {
                        this.huntingCheckBox.Checked = false;
                        this.huntingCheckBox.Enabled = false;
                        this.huntingCheckBox.Visible = false;
                    }
                }
            }
            else
            {
                this.huntingStatusLabel.Text = "Охота: OFF";
            }
        }

        /// <summary>
        /// The update fish counters.
        /// </summary>
        private void UpdateFishCounters()
        {
            this.pikeCountLabel.Text = "Щуки: " + this.aquarium.PikeFlock.Count;
            this.carpCountLabel.Text = "Карпы: " + this.aquarium.CarpFlock.Count;
        }
    }
}