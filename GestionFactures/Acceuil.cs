using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionFactures
{
    public partial class Acceuil : UserControl
    {
        private bool mouseDown;
        private Point lastLocation;

        public Acceuil()
        {
            InitializeComponent();
        }

        private void bienvenue_Click(object sender, EventArgs e)
        {
            Conteneur.conteneur.loadMenu();
        }

        private void background_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void background_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Conteneur.conteneur.Location = new Point(
                    (Conteneur.conteneur.Location.X - lastLocation.X) + e.X, (Conteneur.conteneur.Location.Y - lastLocation.Y) + e.Y);

                Conteneur.conteneur.Update();
            }
        }

        private void background_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
