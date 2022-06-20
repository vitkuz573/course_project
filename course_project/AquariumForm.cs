﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace course_project
{
    public partial class AquariumForm : Form
    {
        public AquariumForm()
        {
            InitializeComponent();
        }

        private void AquariumForm_Load(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(aquarium_picturebox.Width, aquarium_picturebox.Height);
            Graphics graphics = Graphics.FromImage(bitmap);

            graphics.Clear(Color.Blue);

            aquarium_picturebox.Image = bitmap;
            aquarium_picturebox.Refresh();
        }

        private void add_carp_button_Click(object sender, EventArgs e)
        {
            CarpFlock<int[]> carpFlock = new CarpFlock<int[]>();

            carpFlock.Add(setCoordinates(), this);

            foreach (var carp in carpFlock)
            {
                Console.Write(carp);
            }
        }

        private void add_pike_button_Click(object sender, EventArgs e)
        {
            PikeFlock<int[]> pikeFlock = new PikeFlock<int[]>();

            pikeFlock.Add(setCoordinates(), this);

            foreach (var pike in pikeFlock)
            {
                Console.WriteLine(pike);
            }
        }

        public PictureBox getAquarium()
        {
            return aquarium_picturebox;
        }

        public int[] setCoordinates()
        {
            Random random = new Random(DateTime.Now.Millisecond);

            int[] coordinates = {
                random.Next(0, aquarium_picturebox.Width),
                random.Next(0, aquarium_picturebox.Height)
            };

            return coordinates;
        }
    }
}
