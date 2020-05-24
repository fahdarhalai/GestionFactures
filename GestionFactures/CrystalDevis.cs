using GestionFactures.DatabaseDataSetTableAdapters;
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
    public partial class CrystalDevis : Form
    {
        public static CrystalDevis cd = null;

        private CrystalDevis()
        {
            InitializeComponent();
        }

        public static CrystalDevis getInstanceCrystalReport()
        {
            if (cd == null || cd.IsDisposed)
            {
                cd = new CrystalDevis();
            }

            return cd;
        }

        public void BindReport(int devisN)
        {
            DatabaseDataSet ds = new DatabaseDataSet();
            var table1 = ds.Produit;
            var adp = new ProduitTableAdapter();
            adp.Fill(table1);
            DataView dv1 = new DataView(table1, $"DevisN={devisN}","",DataViewRowState.CurrentRows);
            var produits = dv1.ToTable();

            var table3 = ds.Devis;
            var adp3 = new DevisTableAdapter();
            adp3.Fill(table3);
            DataView dv3 = new DataView(table3, $"DevisN={devisN}", "", DataViewRowState.CurrentRows);
            var devis = dv3.ToTable();

            var table2 = ds.Client;
            var adp2 = new ClientTableAdapter();
            adp2.Fill(table2);
            DataView dv2 = new DataView(table2, $"IdClient={devis.Rows[0]["IdClient"]}", "", DataViewRowState.CurrentRows);
            var client = dv2.ToTable();

            DataSet n_ds = new DataSet();
            n_ds.Tables.Add(produits);
            n_ds.Tables.Add(devis);
            n_ds.Tables.Add(client);

            CrystalReport cr = new CrystalReport();
            cr.SetDataSource(n_ds);
            this.crystalReportViewer.ReportSource = cr;
            this.crystalReportViewer.RefreshReport();

        }
    }
}
