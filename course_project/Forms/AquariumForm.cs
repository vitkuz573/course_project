namespace CourseProject
{
    using System;
    using System.Windows.Forms;

    using CourseProject.Classes;

    /// <summary>
    /// The aquarium form.
    /// </summary>
    public partial class AquariumForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AquariumForm"/> class.
        /// </summary>
        public AquariumForm()
        {
            this.InitializeComponent();
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
            Aquarium.Init(e.Graphics, e.ClipRectangle);
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
            Aquarium.CarpFlock.Add(Aquarium.RandomPoint());

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
            Aquarium.PikeFlock.Add(Aquarium.RandomPoint());

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
            Aquarium.CarpFlock.Clear();
            Aquarium.PikeFlock.Clear();

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
            foreach (var pike in Aquarium.PikeFlock)
            {
                pike.UpdateLocation(this.ClientRectangle);
            }

            foreach (var carp in Aquarium.CarpFlock)
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
            this.aquariumCleanButton.Enabled = Aquarium.PikeFlock.IsNotEmpty || Aquarium.CarpFlock.IsNotEmpty;
            this.aquariumCleanButton.Visible = Aquarium.PikeFlock.IsNotEmpty || Aquarium.CarpFlock.IsNotEmpty;
            this.huntingCheckBox.Enabled = Aquarium.PikeFlock.IsNotEmpty && Aquarium.CarpFlock.IsNotEmpty;
            this.huntingCheckBox.Visible = Aquarium.PikeFlock.IsNotEmpty && Aquarium.CarpFlock.IsNotEmpty;
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

                foreach (var pike in Aquarium.PikeFlock)
                {
                    if (Aquarium.CarpFlock.IsNotEmpty)
                    {
                        Aquarium.CarpFlock.RemoveNearest(pike.Data);

                        this.UpdateFishCounters();
                    }
                    else
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
            this.pikeCountLabel.Text = "Щуки: " + Aquarium.PikeFlock.Count;
            this.carpCountLabel.Text = "Карпы: " + Aquarium.CarpFlock.Count;
        }
    }
}