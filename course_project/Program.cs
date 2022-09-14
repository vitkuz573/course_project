namespace CourseProject
{
    using System;
    using System.Windows.Forms;
    using CourseProject.Forms;

    /// <summary>
    /// The program.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AquariumForm());
        }
    }
}