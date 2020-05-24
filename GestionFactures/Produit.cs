using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestionFactures
{
    public partial class Produit : UserControl
    {
        private bool mouseDown;
        private Point lastLocation;

        public Produit()
        {
            InitializeComponent();
            load_metroGrid();
        }

        public void reset_formulaire()
        {
            this.designationText.Text = "";
            this.referenceText.Text = "";
            this.quantiteText.Text = "";
            this.prixText.Text = "";
            this.dateText.Text = "";
            this.designationTextErreur.Visible = false;
            this.quantiteTextErreur.Visible = false;
            this.prixTextErreur.Visible = false;
            this.referenceTextErreur.Visible = false;
            this.buttonSupprimer.Enabled = false;
            this.buttonModifier.Enabled = false;
            this.buttonModifier.BackColor = Color.LightGray;
            this.buttonSupprimer.BackColor = Color.LightGray;
        }

        public void load_metroGrid()
        {
            this.buttonModifier.Enabled = false;
            this.buttonSupprimer.Enabled = false;
            this.buttonModifier.BackColor = Color.LightGray;
            this.buttonSupprimer.BackColor = Color.LightGray;

            DataSet ds = new DatabaseDataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Produit", Conteneur.conn);

            sda.Fill(ds, "Produit");
            this.metroGrid.DataSource = ds;
            this.metroGrid.DataMember = "Produit";

            this.metroGrid.ClearSelection();
            ds.Dispose();
        }

        private void load_DevisComboBox()
        {
            DataTable dt = new DataTable();
            dt.TableName = "ComboBoxDevis";
            SqlDataAdapter sda = new SqlDataAdapter("select DevisN, DevisNumber FROM Devis", Conteneur.conn);
            sda.Fill(dt);
            this.devisNText.DisplayMember = "DevisNumber";
            this.devisNText.ValueMember = "DevisN";
            this.devisNText.DataSource = dt;
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

        public static SqlDataReader select(int idproduit=0, int devisN=0)
        {
            SqlCommand cmd = Conteneur.conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            if(idproduit != 0)
            {
                cmd.CommandText = $"select * from Produit where IdProduit={idproduit}";
            }
            else
            {
                cmd.CommandText = $"select * from Produit where DevisN={devisN}";
            }
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }

        public static void insert(int devisN, string designation, string reference, int quantite, float prix, string date)
        {
            try
            {
                Conteneur.conn.Open();
                SqlCommand cmd = Conteneur.conn.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"insert into Produit (Designation, Reference, Quantite, Prix, Date, DevisN) values ('{designation}', '{reference}', {quantite}, TRY_PARSE('{prix.ToString().Replace(',', '.')}' as float using 'en-US'), '{date}', {devisN})";
                cmd.ExecuteNonQuery();
                MetroFramework.MetroMessageBox.Show(Conteneur.conteneur, "La facture a bien été créee.", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (Exception e)
            {
                MetroFramework.MetroMessageBox.Show(Conteneur.conteneur, "L'insertion à la base de données n'a pas réussi.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conteneur.conn.Close();
            }
        }

        public static void update(int idproduit, string designation, string reference, int quantite, float prix, string date)
        {
            try
            {
                Conteneur.conn.Open();
                SqlCommand cmd = Conteneur.conn.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"update Produit set Designation='{designation}', Reference='{reference}', Quantite={quantite}, Prix=TRY_PARSE('{prix.ToString().Replace(',', '.')}' as float using 'en-US'), Date='{date}' where IdProduit={idproduit}";
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

        public static void delete(int idproduit)
        {
            try
            {
                Conteneur.conn.Open();
                SqlCommand cmd = Conteneur.conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"delete from Produit where IdProduit={idproduit}";
                cmd.ExecuteNonQuery();
                MetroFramework.MetroMessageBox.Show(Conteneur.conteneur, "La suppression a bien été effectuée.", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (Exception e)
            {
                MetroFramework.MetroMessageBox.Show(Conteneur.conteneur, "La suppression n'a pas été effectuée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conteneur.conn.Close();
            }
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            this.reset_formulaire();
            this.metroPanelFormulaire.Visible = true;
            this.buttonAjouter.Enabled = false;
            this.buttonModifier.Enabled = false;
            this.buttonSupprimer.Enabled = false;
            this.metroGrid.Enabled = false;
            load_DevisComboBox();
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            reset_formulaire();
            load_DevisComboBox();

            int idproduit = 0;
            int devisN = 0;

            try
            {
                idproduit = Convert.ToInt32(this.metroGrid.CurrentRow.Cells[0].Value.ToString());
                devisN = Convert.ToInt32(this.metroGrid.CurrentRow.Cells[5].Value.ToString());
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(Conteneur.conteneur, "Une erreur est survenue", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Conteneur.conn.Open();
            SqlDataReader sdr = select(idproduit: idproduit);

            if (sdr.Read())
            {
                this.designationText.Text = sdr["Designation"].ToString();
                this.referenceText.Text = sdr["Reference"].ToString();
                this.quantiteText.Text = sdr["Quantite"].ToString();
                this.prixText.Text = sdr["Prix"].ToString();
                this.dateText.Value = Convert.ToDateTime(sdr["Date"]);

                this.metroPanelFormulaire.Visible = true;
                this.buttonAjouter.Enabled = false;
                this.buttonModifier.Enabled = false;
                this.buttonSupprimer.Enabled = false;
                this.metroGrid.Enabled = false;
                this.devisNText.Enabled = false;
            }

            sdr.Close();
            this.devisNText.SelectedValue = devisN;
            Conteneur.conn.Close();
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            reset_formulaire();
            try
            {
                int idproduit = Convert.ToInt32(this.metroGrid.CurrentRow.Cells[0].Value.ToString());
                int devisN = Convert.ToInt32(this.metroGrid.CurrentRow.Cells[5].Value.ToString());
                delete(idproduit);
                Devis.calculer(devisN);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MetroFramework.MetroMessageBox.Show(Conteneur.conteneur, "La suppression n'a pas été effectuée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                load_metroGrid();
            }
        }

        private void buttonAjouterModifier_Click(object sender, EventArgs e)
        {
            this.devisNTextErreur.Visible = false;
            this.designationTextErreur.Visible = false;
            this.quantiteTextErreur.Visible = false;
            this.prixTextErreur.Visible = false;
            this.referenceTextErreur.Visible = false;

            bool erreur = false;

            string designation = designationText.Text;
            if (designation == "")
            {
                this.designationTextErreur.Visible = true;
                erreur = true;
            }

            string reference = referenceText.Text;
            if (reference == "")
            {
                this.referenceTextErreur.Visible = true;
                erreur = true;
            }

            int quantite = 0;
            if (quantiteText.Text == "" || (quantite = Convert.ToInt32(quantiteText.Text)) <= 0)
            {
                this.quantiteTextErreur.Visible = true;
                erreur = true;
            }

            float prix = 0;
            if (prixText.Text == "" || (prix = Convert.ToSingle(prixText.Text.Replace('.', ','))) <= 0)
            {
                this.prixTextErreur.Visible = true;
                erreur = true;
            }

            string date = dateText.Value.Date.ToString("yyyyMMdd");
            int devisN = Convert.ToInt32(this.devisNText.SelectedValue);
            if(devisN == 0)
            {
                this.devisNTextErreur.Visible = true;
                erreur = true;
            }

            if (!erreur)
            {
                if (this.devisNText.Enabled)
                {
                    insert(devisN, designation, reference, quantite, prix, date);
                }
                else
                {
                    int idproduit = Convert.ToInt32(this.metroGrid.CurrentRow.Cells[0].Value.ToString());
                    update(idproduit, designation, reference, quantite, prix, date);
                }
                
                Devis.calculer(devisN);

                this.metroPanelFormulaire.Visible = false;
                this.buttonAjouter.Enabled = true;
                this.metroGrid.Enabled = true;
                this.devisNText.Enabled = true;
                load_metroGrid();
            }
        }

        private void closeWindowLight_Click(object sender, EventArgs e)
        {
            this.metroPanelFormulaire.Visible = false;
            this.buttonAjouter.Enabled = true;
            this.metroGrid.Enabled = true;
            this.devisNText.Enabled = true;
            this.metroGrid.ClearSelection();
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

        private void metroGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.buttonModifier.Enabled = true;
            this.buttonSupprimer.Enabled = true;
            this.buttonModifier.BackColor = Color.WhiteSmoke;
            this.buttonSupprimer.BackColor = Color.WhiteSmoke;
        }
    }
}
