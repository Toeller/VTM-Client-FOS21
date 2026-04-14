using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTM_Client_FOS21
{
    internal static class Program
    {
        //HIer bitte die Attribute ergänzen
        private IModel model;
        private IView view;
        private IController controller;

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            IModel model = new IModel();
            IView view = new IView()

            IController controller = new Controller(model, view);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
