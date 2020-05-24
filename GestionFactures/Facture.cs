using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Globalization;
using GestionFactures.DatabaseDataSetTableAdapters;
using System.Drawing.Drawing2D;

namespace GestionFactures
{
    public partial class Facture : UserControl
    {
        private bool mouseDown;
        private Point lastLocation;

        public Facture()
        {
            InitializeComponent();
            load_metroGrid();
        }

        public void reset_Formulaire()
        {
            this.factureNText.Text = "";
            this.designationText.Text = "";
            this.referenceText.Text = "";
            this.quantiteText.Text = "";
            this.prixText.Text = "";
            this.dateText.Text = "";
            this.factureNTextErreur.Visible = false;
            this.designationTextErreur.Visible = false;
            this.quantiteTextErreur.Visible = false;
            this.prixTextErreur.Visible = false;
            this.referenceTextErreur.Visible = false;
            this.buttonModifier.BackColor = Color.LightGray;
            this.buttonSupprimer.BackColor = Color.LightGray;
            /*this.ClientText.Items.Clear();*/
        }

        public void load_metroGrid()
        {
            this.buttonModifier.Enabled = false;
            this.buttonSupprimer.Enabled = false;
            this.buttonModifier.BackColor = Color.LightGray;
            this.buttonSupprimer.BackColor = Color.LightGray;
            this.totalTTC.Text = "";
            this.totalHT.Text = "";
            this.TVAText.Text = "";

            DataSet ds = new DatabaseDataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Facture", Conteneur.conn);
            
            sda.Fill(ds, "Facture");
            this.metroGrid.DataSource = ds;
            this.metroGrid.DataMember = "Facture";

            this.metroGrid.ClearSelection();
            this.searchTextBox.Text = "";
            ds.Dispose();
        }

        private void load_ClientComboBox()
        {
            DataTable dt = new DataTable();
            dt.TableName = "ComboBoxClients";
            SqlDataAdapter sda = new SqlDataAdapter("select IdClient, concat(nom, ' ', prenom) as fullname FROM Client", Conteneur.conn);
            sda.Fill(dt);
            this.ClientText.DisplayMember = "fullname";
            this.ClientText.ValueMember = "IdClient";
            this.ClientText.DataSource = dt;
        }

        public static SqlDataReader select(int factureN)
        {
            SqlCommand cmd = Conteneur.conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from Facture where FactureN={factureN}";
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }

        public static void insert(int factureN, string designation, string reference, int quantite, float prix, string date, int idClient) 
        {
            try
            {
                Conteneur.conn.Open();
                SqlCommand cmd = Conteneur.conn.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"insert into Facture (FactureN, Designation, Reference, Quantite, Prix, Date, IdClient) values ({factureN}, '{designation}', '{reference}', {quantite}, TRY_PARSE('{prix.ToString().Replace(',', '.')}' as float using 'en-US'), '{date}', {idClient})";
                cmd.ExecuteNonQuery();
                MetroFramework.MetroMessageBox.Show(Conteneur.conteneur, "La facture a bien été créee.", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch(Exception e)
            {
                MetroFramework.MetroMessageBox.Show(Conteneur.conteneur, "L'insertion à la base de données n'a pas réussi.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conteneur.conn.Close();
            }
        }

        public static void update(int factureN, string designation, string reference, int quantite, float prix, string date)
        {
            try
            {
                Conteneur.conn.Open();
                SqlCommand cmd = Conteneur.conn.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"update Facture set Designation='{designation}', Reference='{reference}', Quantite={quantite}, Prix=TRY_PARSE('{prix.ToString().Replace(',', '.')}' as float using 'en-US'), Date='{date}' where FactureN={factureN}";
                cmd.ExecuteNonQuery();
                MetroFramework.MetroMessageBox.Show(Conteneur.conteneur, "La facture a bien été modifiée.", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (Exception e)
            {
                MetroFramework.MetroMessageBox.Show(Conteneur.conteneur, "La modification à la base de données n'a pas réussi.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conteneur.conn.Close();
            }
        }

        public static void delete(int factureN)
        {
            try
            {
                Conteneur.conn.Open();
                SqlCommand cmd = Conteneur.conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"delete from Facture where FactureN={factureN}";
                cmd.ExecuteNonQuery();
                MetroFramework.MetroMessageBox.Show(Conteneur.conteneur, "La suppression a bien été effectuée.", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch(Exception e)
            {
                MetroFramework.MetroMessageBox.Show(Conteneur.conteneur, "La suppression n'a pas été effectuée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conteneur.conn.Close();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Conteneur.conteneur.Location = new Point(
                    (Conteneur.conteneur.Location.X - lastLocation.X) + e.X, (Conteneur.conteneur.Location.Y - lastLocation.Y) + e.Y);

                Conteneur.conteneur.Update();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            this.reset_Formulaire();
            this.metroPanelFormulaire.Visible = true;
            this.buttonAjouter.Enabled = false;
            this.buttonModifier.Enabled = false;
            this.buttonSupprimer.Enabled = false;
            this.buttonCalculer.Enabled = false;
            this.metroGrid.Enabled = false;
            this.searchTextBox.Enabled = false;
            load_ClientComboBox();
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            reset_Formulaire();
            try
            {
                int factureN = Convert.ToInt32(this.metroGrid.CurrentRow.Cells[0].Value.ToString());
                delete(factureN);
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(Conteneur.conteneur, "La suppression n'a pas été effectuée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                load_metroGrid();
            }
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            reset_Formulaire();
            load_ClientComboBox();
            int factureN = 0;
            int idclient = 0;

            try
            {
                factureN = Convert.ToInt32(this.metroGrid.CurrentRow.Cells[0].Value.ToString());
                idclient = Convert.ToInt32(this.metroGrid.CurrentRow.Cells[6].Value.ToString());
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(Conteneur.conteneur, "Une erreur est survenue", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Conteneur.conn.Open();
            SqlDataReader sdr = select(factureN);

            if (sdr.Read())
            {
                this.factureNText.Text = sdr["FactureN"].ToString();
                this.designationText.Text = sdr["Designation"].ToString();
                this.referenceText.Text = sdr["Reference"].ToString();
                this.quantiteText.Text = sdr["Quantite"].ToString();
                this.prixText.Text = sdr["Prix"].ToString();
                this.dateText.Value = Convert.ToDateTime(sdr["Date"]);

                this.metroPanelFormulaire.Visible = true;
                this.buttonAjouter.Enabled = false;
                this.buttonModifier.Enabled = false;
                this.buttonSupprimer.Enabled = false;
                this.buttonCalculer.Enabled = false;
                this.metroGrid.Enabled = false;
                this.factureNText.Enabled = false;
                this.searchTextBox.Enabled = false;
                this.ClientText.Enabled = false;
            }

            sdr.Close();

            this.ClientText.SelectedValue = idclient;
            Conteneur.conn.Close();
        }

        private void buttonAjouterModifier_Click(object sender, EventArgs e)
        {
            this.ClientTextErreur.Visible = false;
            this.factureNTextErreur.Visible = false;
            this.designationTextErreur.Visible = false;
            this.quantiteTextErreur.Visible = false;
            this.prixTextErreur.Visible = false;
            this.referenceTextErreur.Visible = false;

            bool erreur = false;

            int factureN = 0;
            if (factureNText.Text == "" || (factureN = Convert.ToInt32(factureNText.Text)) <= 0)
            {
                this.factureNTextErreur.Visible = true;
                erreur = true;
            }

            string designation = designationText.Text;
            if(designation == "")
            {
                this.designationTextErreur.Visible = true;
                erreur = true;
            }

            string reference = referenceText.Text;
            if(reference == "")
            {
                this.referenceTextErreur.Visible = true;
                erreur = true;
            }

            int quantite = 0;
            if(quantiteText.Text == "" || (quantite = Convert.ToInt32(quantiteText.Text)) <= 0)
            {
                this.quantiteTextErreur.Visible = true;
                erreur = true;
            }

            float prix = 0;
            if(prixText.Text == "" || (prix = Convert.ToSingle(prixText.Text.Replace('.', ','))) <= 0)
            {
                this.prixTextErreur.Visible = true;
                erreur = true;
            }

            string date = dateText.Value.Date.ToString("yyyyMMdd");
            int idClient = Convert.ToInt32(this.ClientText.SelectedValue);
            if (idClient == 0)
            {
                this.ClientTextErreur.Visible = true;
                erreur = true;
            }

            if (!erreur)
            {
                if (this.factureNText.Enabled == true)
                {
                    insert(factureN, designation, reference, quantite, prix, date, idClient);
                }
                else
                {
                    update(factureN, designation, reference, quantite, prix, date);
                }

                this.metroPanelFormulaire.Visible = false;
                this.buttonAjouter.Enabled = true;
                this.buttonCalculer.Enabled = true;
                this.metroGrid.Enabled = true;
                this.factureNText.Enabled = true;
                this.searchTextBox.Enabled = true;
                this.ClientText.Enabled = true;
                load_metroGrid();
            }
        }

        private void factureNText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void quantiteText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void prixText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (this.prixText.Text.IndexOf(',') > -1 || this.prixText.Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void closeWindowLight_Click(object sender, EventArgs e)
        {
            this.metroPanelFormulaire.Visible = false;
            this.buttonAjouter.Enabled = true;
            this.buttonCalculer.Enabled = true;
            this.metroGrid.Enabled = true;
            this.searchTextBox.Enabled = true;
            this.ClientText.Enabled = true;
            this.metroGrid.ClearSelection();
        }

        private void buttonCalculer_Click(object sender, EventArgs e)
        {
            Decimal total = this.metroGrid.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDecimal(x.Cells["Quantite"].Value) * Convert.ToDecimal(x.Cells["Prix"].Value));
            totalHT.Text = Math.Round(total, 2).ToString();

            int t = metroRadioButton7.Checked ? 7 : 20;
            Decimal tva = (t * total) / 100;
            TVAText.Text = Math.Round(tva, 2).ToString();

            Decimal totalttc = total + tva;
            totalTTC.Text = Math.Round(totalttc, 2).ToString();
        }

        private void metroGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.buttonModifier.Enabled = true;
            this.buttonSupprimer.Enabled = true;
            this.buttonModifier.BackColor = Color.WhiteSmoke;
            this.buttonSupprimer.BackColor = Color.WhiteSmoke;
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = this.searchTextBox.Text;
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();

            dt1.TableName = "ClientSearch";
            dt2.TableName = "FactureSearch";

            SqlDataAdapter sda = new SqlDataAdapter($"Select IdClient from Client where upper(nom) like upper('%{text}%') OR upper(prenom) like upper('%{text}%') OR concat(upper(nom), ' ', upper(prenom)) like upper('%{text}%') OR concat(upper(prenom), ' ', upper(nom)) like upper('%{text}%')", Conteneur.conn);
            sda.Fill(dt1);


            string sqlcmd = "";
            if (dt1.Rows.Count > 0)
            {
                int[] ids = new int[dt1.Rows.Count];
                int i = 0;
                foreach (DataRow row in dt1.Rows)
                {
                    ids[i] = Convert.ToInt32(row["IdClient"]);
                    i++;
                }
                sqlcmd = $"select * from Facture where IdClient in ({string.Join(",", ids)})";
            }
            else
            {
                sqlcmd = "select * from Facture where IdClient=-1";
            }

            sda = new SqlDataAdapter(sqlcmd, Conteneur.conn);
            sda.Fill(dt2);
            this.metroGrid.DataSource = dt2;
            this.metroGrid.ClearSelection();

        }
    }
}
