using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Data.SqlClient;

namespace GestionFactures
{
    public partial class Client : UserControl
    {
        private bool mouseDown;
        private Point lastLocation;
        static string[][] countries = new string[][] {
            new string[]{"212", "Morocco", "Rabat", "Sale", "Kenitra", "Casablanca", "Settat", "Mohammedia", "Fes", "Meknes", "Tanger", "Oujda"},
            new string[]{"33", "France", "Paris", "Toulouse", "Bordeaux", "Marseille", "Nice", "Renne"},
            new string[]{"34", "Spain", "Madrid", "Barcelona", "Seville", "Granada", "Valencia" }
        };
        
        public Client()
        {
            InitializeComponent();
            load_form();
            
            this.filtreText.DisplayMember = "Text";
            this.filtreText.ValueMember = "Value";
            var items = new[]
            {
                new { Text = "Filtrer par ...", Value = "" },
                new { Text="Raison Sociale" , Value="RS" },
                new { Text = "Email", Value = "E" },
                new { Text = "Ville", Value = "V" },
                new { Text = "Pays", Value = "P" }
            };
            this.filtreText.DataSource = items;
            this.filtreText.SelectedIndex = 0;
        }

        public void reset_formulaire()
        {
            this.nomText.Text = "";
            this.prenomText.Text = "";
            this.emailText.Text = "";
            this.adresseText.Text = "";
            this.telText.Text = "";
            this.portableText.Text = "";
            this.paysCodeText1.Text = "";
            this.paysCodeText2.Text = "";
            this.faxText.Text = "";
            this.idClientText.Text = "";
            this.RSText.Text = "";
            this.RCText.Text = "";
            this.IFText.Text = "";
            this.typeSocText.Text = "";
            this.ICEText.Text = "";
            this.nomRespoText.Text = "";
            this.patenteText.Text = "";
            this.paysOption.Text = "";
            this.villeOption.Text = "";
            this.nomTextErreur.Visible = false;
            this.prenomTextErreur.Visible = false;
            this.emailTextErreur.Visible = false;
            this.adresseTextErreur.Visible = false;
            this.paysOptionErreur.Visible = false;
            this.villeOptionErreur.Visible = false;
            this.telTextErreur.Visible = false;
            this.portableTextErreur.Visible = false;
            this.faxTextErreur.Visible = false;
            this.idClientTextErreur.Visible = false;
            this.RSTextErreur.Visible = false;
            this.RCTextErreur.Visible = false;
            this.IFTextErreur.Visible = false;
            this.ICETextErreur.Visible = false;
            this.typeSocTextErreur.Visible = false;
            this.nomRespoTextErreur.Visible = false;
            this.patenteTextErreur.Visible = false;
        }

        public void load_metroGrid()
        {
            DataSet ds = new DatabaseDataSet();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Client", Conteneur.conn);
            sda.Fill(ds, "Client");
            this.metroGrid.DataSource = ds;
            this.metroGrid.DataMember = "Client";
            this.metroGrid.ClearSelection();
            this.buttonModifier.BackColor = Color.LightGray;
            this.buttonSupprimer.BackColor = Color.LightGray;
            ds.Dispose();
        }

        public void load_countries()
        {
            this.paysOption.Items.Clear();
            this.paysOption.Items.Add("");
            foreach (string[] country in countries)
            {
                this.paysOption.Items.Add(country[1]);
            }
            this.paysOption.Sorted = true;
        }

        public void load_cities(string country)
        {
            this.villeOption.Items.Clear();
            foreach(string[] c in countries)
            {
                if(country == c[1])
                {
                    for(int i=2; i<c.Length; i++)
                    {
                        this.villeOption.Items.Add(c[i]);
                    }
                }
            }
            this.villeOption.Sorted = true;
        }

        public void set_phonecode(string country)
        {
            this.paysCodeText1.Text = "";
            this.paysCodeText2.Text = "";
            foreach (string[] c in countries)
            {
                if(country == c[1])
                {
                    this.paysCodeText1.Text = c[0];
                    this.paysCodeText2.Text = c[0];
                }
            }
        }

        public void load_form()
        {
            load_metroGrid();
            load_countries();
        }

        public static SqlDataReader select(int idclient)
        {
            SqlCommand cmd = Conteneur.conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from Client where IdClient={idclient}";
            SqlDataReader sdr = cmd.ExecuteReader();

            return sdr;
        }

        public static void insert(int idclient, string rc, string rs, string typesoc, string nomrespo, string ifclient, string ice, string patente, string nom, string prenom, string email, string tel, string adresse, string fax, string portable, string ville, string pays)
        {
            try
            {
                Conteneur.conn.Open();
                SqlCommand cmd = Conteneur.conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"select * from Client where IFClient='{ifclient}' and ICE='{ice}' and RC='{rc}' and patente='{patente}'";
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    throw new Exception("1");
                }
                sdr.Close();
                cmd.CommandText = $"insert into Client (IdClient, RC, RS, type_societe, nom_respo, IFClient, ICE, patente, nom, prenom, email, tel, adresse, fax, portable, ville, pays) values ({idclient}, '{rc}', '{rs}', '{typesoc}', '{nomrespo}', '{ifclient}', '{ice}', '{patente}', '{nom}', '{prenom}', '{email}', '{tel}', '{adresse}', '{fax}', '{portable}', '{ville}', '{pays}')";
                cmd.ExecuteNonQuery();
                MetroFramework.MetroMessageBox.Show(Conteneur.conteneur, "Le client a bien été ajouté.", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (Exception e)
            {
                if (e.Message == "1")
                {
                    MetroFramework.MetroMessageBox.Show(Conteneur.conteneur, "Un client avec les memes identifiants(IF, ICE, Registre de Commerce, Patente) existe déjâ.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(Conteneur.conteneur, "L'insertion à la base de données n'a pas réussi.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            finally
            {
                Conteneur.conn.Close();
            }
        }

        public static void update(int idclient, string rc, string rs, string typesoc, string nomrespo, string ifclient, string ice, string patente, string nom, string prenom, string email, string tel, string adresse, string fax, string portable, string ville, string pays)
        {
            try
            {
                Conteneur.conn.Open();
                SqlCommand cmd = Conteneur.conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"update Client set RS='{rs}', type_societe='{typesoc}', nom_respo='{nomrespo}', nom='{nom}', prenom='{prenom}', email='{email}', tel='{tel}', adresse='{adresse}', fax='{fax}', portable='{portable}', ville='{ville}', pays='{pays}' where idClient={idclient}";
                cmd.ExecuteNonQuery();
                MetroFramework.MetroMessageBox.Show(Conteneur.conteneur, "Le client a bien été modifiée.", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Question);
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

        public static void delete(int idclient)
        {
            try
            {
                Conteneur.conn.Open();
                SqlCommand cmd = Conteneur.conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"delete from Client where IdClient={idclient}";
                cmd.ExecuteNonQuery();
                MetroFramework.MetroMessageBox.Show(Conteneur.conteneur, "La suppression a bien été effectuée.", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }
            catch (Exception e)
            {
                MetroFramework.MetroMessageBox.Show(Conteneur.conteneur, "La suppression n'a pas été effectuée.\nVerifier que le client n'a pas de factures.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.reset_formulaire();
            this.metroPanelFormulaire.Visible = true;
            this.buttonAjouter.Enabled = false;
            this.buttonModifier.Enabled = false;
            this.buttonSupprimer.Enabled = false;
            this.metroGrid.Enabled = false;
        }

        private void buttonAjouterModifier_Click(object sender, EventArgs e)
        {
            this.nomTextErreur.Visible = false;
            this.prenomTextErreur.Visible = false;
            this.emailTextErreur.Visible = false;
            this.adresseTextErreur.Visible = false;
            this.paysOptionErreur.Visible = false;
            this.villeOptionErreur.Visible = false;
            this.telTextErreur.Visible = false;
            this.portableTextErreur.Visible = false;
            this.faxTextErreur.Visible = false;
            this.idClientTextErreur.Visible = false;
            this.RSTextErreur.Visible = false;
            this.RCTextErreur.Visible = false;
            this.IFTextErreur.Visible = false;
            this.ICETextErreur.Visible = false;
            this.typeSocTextErreur.Visible = false;
            this.nomRespoTextErreur.Visible = false;
            this.patenteTextErreur.Visible = false;

            bool erreur = false;

            string nom = nomText.Text;
            if(nom == "")
            {
                this.nomTextErreur.Visible = true;
                erreur = true;
            }

            string prenom = prenomText.Text;
            if(prenom == "")
            {
                this.prenomTextErreur.Visible = true;
                erreur = true;
            }

            string email = emailText.Text;
            if(email == "" || !Regex.IsMatch(email, @"^[a-zA-Z_]([\.\-]?[\w])*@[a-zA-Z0-9]+(\.[a-zA-Z]{2,3}){1,2}$"))
            {
                this.emailTextErreur.Visible = true;
                erreur = true;
            }

            string adresse = adresseText.Text;
            if(adresse == "")
            {
                this.adresseTextErreur.Visible = true;
                erreur = true;
            }

            string tel = telText.Text;
            if(tel == "" || (tel.Length != 10 && tel.Length != 9))
            {
                this.telTextErreur.Visible = true;
                erreur = true;
            }
            tel = paysCodeText1.Text + " " + tel;

            string portable = portableText.Text;
            if(portable == "" || (portable.Length != 10 && portable.Length != 9))
            {
                this.portableTextErreur.Visible = true;
                erreur = true;
            }
            portable = paysCodeText2.Text + " " + portable;

            string fax = faxText.Text;
            if(fax == "")
            {
                this.faxTextErreur.Visible = true;
                erreur = true;
            }

            string pays = paysOption.Text;
            if(pays == "")
            {
                this.paysOptionErreur.Visible = true;
                erreur = true;
            }

            string ville = villeOption.Text;
            if(ville == "")
            {
                this.villeOptionErreur.Visible = true;
                erreur = true;
            }

            int idclient = 0;
            if(idClientText.Text == "" || (idclient = Convert.ToInt32(idClientText.Text)) <= 0)
            {
                this.idClientTextErreur.Visible = true;
                erreur = true;
            }

            string RS = RSText.Text;
            if(RS == "")
            {
                this.RSTextErreur.Visible = true;
                erreur = true;
            }

            string IF = IFText.Text;
            if(IF == "" || IF.Length > 8)
            {
                this.IFTextErreur.Visible = true;
                erreur = true;
            }

            string ICE = ICEText.Text;
            if(ICE == "" || ICE.Length != 15)
            {
                this.ICETextErreur.Visible = true;
                erreur = true;
            }

            string typeSoc = typeSocText.Text;
            if(typeSoc == "")
            {
                this.typeSocTextErreur.Visible = true;
                erreur = true;
            }

            string RC = RCText.Text;
            if (RC == "" || RC.Length > 5)
            {
                this.RCTextErreur.Visible = true;
                erreur = true;
            }

            string nomRespo = nomRespoText.Text;
            if(nomRespo == "")
            {
                this.nomRespoTextErreur.Visible = true;
                erreur = true;
            }

            string patente = patenteText.Text;
            if(patente == "")
            {
                this.patenteTextErreur.Visible = true;
                erreur = true;
            }

            if (!erreur)
            {
                if (this.idClientText.Enabled)
                {
                    insert(idclient, RC, RS, typeSoc, nomRespo, IF, ICE, patente, nom, prenom, email, tel, adresse, fax, portable, ville, pays);
                }
                else
                {
                    update(idclient, RC, RS, typeSoc, nomRespo, IF, ICE, patente, nom, prenom, email, tel, adresse, fax, portable, ville, pays);
                }
                this.metroPanelFormulaire.Visible = false;
                this.buttonAjouter.Enabled = true;
                this.metroGrid.Enabled = true;
                this.idClientText.Enabled = true;
                this.IFText.Enabled = true;
                this.ICEText.Enabled = true;
                this.patenteText.Enabled = true;
                this.RCText.Enabled = true;
                this.searchTextBox.Enabled = true;
                this.filtreText.Enabled = true;
                load_metroGrid();
            }
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            reset_formulaire();
            int idclient = 0;
            try
            {
                idclient = Convert.ToInt32(this.metroGrid.CurrentRow.Cells[0].Value.ToString());
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(Conteneur.conteneur, "Une erreur est survenue", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Conteneur.conn.Open();
            SqlDataReader sdr = select(idclient);

            if (sdr.Read())
            {
                this.idClientText.Text = sdr["IdClient"].ToString();
                this.RCText.Text = sdr["RC"].ToString();
                this.RSText.Text = sdr["RS"].ToString();
                this.typeSocText.Text = sdr["type_societe"].ToString();
                this.nomRespoText.Text = sdr["nom_respo"].ToString();
                this.IFText.Text = sdr["IFClient"].ToString();
                this.ICEText.Text = sdr["ICE"].ToString();
                this.patenteText.Text = sdr["patente"].ToString();
                this.nomText.Text = sdr["nom"].ToString();
                this.prenomText.Text = sdr["prenom"].ToString();
                this.emailText.Text = sdr["email"].ToString();
                this.adresseText.Text = sdr["adresse"].ToString();
                this.telText.Text = sdr["tel"].ToString().Split(' ')[1];
                this.paysCodeText1.Text = sdr["tel"].ToString().Split(' ')[0];
                this.portableText.Text = sdr["portable"].ToString().Split(' ')[1];
                this.paysCodeText2.Text = sdr["portable"].ToString().Split(' ')[0];
                this.faxText.Text = sdr["fax"].ToString();
                this.paysOption.SelectedItem = sdr["pays"].ToString();
                this.villeOption.SelectedItem = sdr["ville"].ToString();

                this.metroPanelFormulaire.Visible = true;
                this.buttonAjouter.Enabled = false;
                this.buttonModifier.Enabled = false;
                this.buttonSupprimer.Enabled = false;
                this.metroGrid.Enabled = false;
                this.IFText.Enabled = false;
                this.ICEText.Enabled = false;
                this.patenteText.Enabled = false;
                this.RCText.Enabled = false;
                this.filtreText.Enabled = false;
                this.searchTextBox.Enabled = false;
                this.idClientText.Enabled = false;
            }
            sdr.Close();
            Conteneur.conn.Close();
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            reset_formulaire();
            try
            {
                int idclient = Convert.ToInt32(metroGrid.CurrentRow.Cells[0].Value.ToString());
                delete(idclient);
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(Conteneur.conteneur, "La suppression n'a pas été effectuée.\nVerifier que le client n'a pas de factures.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                load_metroGrid();
            }
        }

        private void telText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (telText.Text.Length >= 10 && !char.IsControl(e.KeyChar)) 
            {
                e.Handled = true;
            }
        }

        private void portableText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (portableText.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void idClientText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void IFText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (IFText.Text.Length >= 8 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ICEText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (ICEText.Text.Length >= 15 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void RCText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (RCText.Text.Length >= 5 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void closeWindowLight_Click(object sender, EventArgs e)
        {
            this.metroPanelFormulaire.Visible = false;
            this.buttonAjouter.Enabled = true;
            this.metroGrid.Enabled = true;
            this.filtreText.Enabled = true;
            this.searchTextBox.Enabled = true;
            this.metroGrid.ClearSelection();
        }

        private void paysOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            string country = this.paysOption.Text;
            load_cities(country);
            set_phonecode(country);
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
            string filtre = this.filtreText.SelectedValue.ToString();
            string sqlcmd = "";
            
            switch (filtre)
            {
                case "RS":
                    sqlcmd = $"select * from Client where upper(RS) like upper('%{text}%')";
                    break;
                case "E":
                    sqlcmd = $"select * from Client where upper(email) like upper('%{text}%')";
                    break;
                case "V":
                    sqlcmd = $"select * from Client where upper(ville) like upper('%{text}%')";
                    break;
                case "P":
                    sqlcmd = $"select * from Client where upper(pays) like upper('%{text}%')";
                    break;
                default:
                    sqlcmd = $"select * from Client";
                    break;
            }

            DataTable dt = new DataTable();
            dt.TableName = "ClientSearch";
            SqlDataAdapter sda = new SqlDataAdapter(sqlcmd, Conteneur.conn);
            sda.Fill(dt);

            this.metroGrid.DataSource = dt;
            this.metroGrid.ClearSelection();
        }
    }
}
