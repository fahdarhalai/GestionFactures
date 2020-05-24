using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionFactures
{
    public partial class Conteneur : MetroFramework.Forms.MetroForm
    {
        public static Conteneur conteneur;
        public static SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\GestionFactures\GestionFactures\Database.mdf;Integrated Security=True");

        private Conteneur()
        {
            InitializeComponent();
            this.metroPanelAcceuil.Visible = true;
            this.metroPanelGestion.Visible = false;
            this.metroTabControl.Visible = false;
        }

        public static Conteneur getInstanceConteneur()
        {
            if(conteneur == null || conteneur.IsDisposed)
            {
                conteneur = new Conteneur();
            }

            return conteneur;
        }

        public static Devis getInstanceDevis()
        {
            if(conteneur != null)
            {
                return Conteneur.conteneur.devis;
            }

            return null;
        }

        private void minimizeWindowLight_MouseHover(object sender, EventArgs e)
        {
            this.minimizeWindowDark.Visible = true;
            //this.minimizeWindowLight.Visible = false;
        }

        private void minimizeWindowDark_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minimizeWindowDark_MouseLeave(object sender, EventArgs e)
        {
            this.minimizeWindowDark.Visible = false;
            //this.minimizeWindowLight.Visible = true;
        }

        private void closeWindowLight_MouseHover(object sender, EventArgs e)
        {
            this.closeWindowDark.Visible = true;
            //this.closeWindowLight.Visible = false;
        }

        private void closeWindowDark_MouseLeave(object sender, EventArgs e)
        {
            this.closeWindowDark.Visible = false;
            //this.closeWindowLight.Visible = true;
        }

        private void closeWindowDark_Click(object sender, EventArgs e)
        {
            if(conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            Environment.Exit(0);
        }

        private void closeWindowLight_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            Environment.Exit(0);
        }

        private void minimizeWindowLight_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void loadMenu()
        {
            this.acceuil.Hide();
            this.metroTabControl.Visible = true;
            this.metroPanelAcceuil.Visible = false;
            this.metroPanelGestion.Visible = true;
            this.metroTabControl.SelectTab(0);
            this.facture.Hide();
            this.devis.Hide();
            this.produit.Hide();
            this.client.Show();
        }

        private void returnAcceuilDark_Click(object sender, EventArgs e)
        {
            this.facture.Hide();
            this.client.Hide();
            this.devis.Hide();
            this.produit.Hide();
            this.metroPanelGestion.Visible = false;
            this.metroPanelAcceuil.Visible = true;
            this.metroTabControl.Visible = false;
            this.acceuil.Show();
        }

        private void returnAcceuilLight_MouseHover(object sender, EventArgs e)
        {
            this.returnAcceuilDark.Visible = true;
        }

        private void returnAcceuilDark_MouseLeave(object sender, EventArgs e)
        {
            this.returnAcceuilDark.Visible = false;
        }

        private void metroTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = this.metroTabControl.SelectedIndex;

            if(selectedIndex == 0)
            {
                this.facture.Hide();
                this.devis.Hide();
                this.produit.Hide();
                this.client.Show();
            }
            else if(selectedIndex == 1)
            {
                this.client.Hide();
                this.devis.Hide();
                this.produit.Hide();
                this.facture.Show();
            }
            else if(selectedIndex == 2)
            {
                this.client.Hide();
                this.facture.Hide();
                this.produit.Hide();
                this.devis.Show();
            }
            else if(selectedIndex == 3)
            {
                this.client.Hide();
                this.facture.Hide();
                this.devis.Hide();
                this.produit.Show();
            }
        }

    }
}
