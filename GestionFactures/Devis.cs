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
    public partial class Devis : UserControl
    {
        private bool mouseDown;
        private Point lastLocation;

        public Devis()
        {
            InitializeComponent();
            load_metroGrid();
        }

        public void reset_formulaire()
        {
            this.devisNText.Text = "";
            this.dateText.Text = "";
            this.ClientTextErreur.Visible = false;
            this.devisNTextErreur.Visible = false;
            this.buttonSupprimer.Enabled = false;
            this.buttonModifier.Enabled = false;
            this.buttonImprimer.Enabled = false;
            this.buttonModifier.BackColor = Color.LightGray;
            this.buttonSupprimer.BackColor = Color.LightGray;
            this.buttonImprimer.BackColor = Color.LightGray;
        }

        public void load_metroGrid()
        {
            this.buttonSupprimer.Enabled = false;
            this.buttonModifier.Enabled = false;
            this.buttonImprimer.Enabled = false;
            this.buttonModifier.BackColor = Color.LightGray;
            this.buttonSupprimer.BackColor = Color.LightGray;
            this.buttonImprimer.BackColor = Color.LightGray;

            DataSet ds = new DatabaseDataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Devis", Conteneur.conn);

            sda.Fill(ds, "Devis");
            this.metroGrid.DataSource = ds;
            this.metroGrid.DataMember = "Devis";
            
            this.metroGrid.ClearSelection();
            ds.Dispose();
        }

        public static SqlDataReader select(int devisN=0, string devisNumber="")
        {
            SqlCommand cmd = Conteneur.conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            if(devisN != 0)
            {
                cmd.CommandText = $"select * from Devis where DevisN={devisN}";
            }
            else
            {
                cmd.CommandText = $"select * from Devis where DevisNumber={devisNumber}";
            }
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }

        public static void insert(string RS, string date, int idClient, string devisNumber)
        {
            try
            {
                Conteneur.conn.Open();
                SqlCommand cmd = Conteneur.conn.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"insert into Devis (RS, Date, IdClient, DevisNumber, Status) values ('{RS}', '{date}', {idClient}, '{devisNumber}', 'En attente')";
                cmd.ExecuteNonQuery();
                MetroFramework.MetroMessageBox.Show(Conteneur.conteneur, "Le devis a bien été créé.", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Question);
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

        public static void update(string date, string status, int devisN = 0, string devisNumber = "", string RS="", int quantite=0, float total=0)
        {
            try
            {
                Conteneur.conn.Open();
                SqlCommand cmd = Conteneur.conn.CreateCommand();

                cmd.CommandType = CommandType.Text;
                
                if(devisN != 0)
                {
                    if(RS == "")
                    {
                        if(quantite == 0)
                        {
                            if(total == 0)
                            {
                                cmd.CommandText = $"update Devis set Date='{date}', Status='{status}' where DevisN={devisN}";
                            }
                            else
                            {
                                cmd.CommandText = $"update Devis set Total=TRY_PARSE('{total.ToString().Replace(',', '.')}' as float using 'en-US'), Date='{date}', Status='{status}' where DevisN={devisN}";
                            }
                        }else if(total == 0)
                        {
                            cmd.CommandText = $"update Devis set Quantite={quantite}, Date='{date}', Status='{status}' where DevisN={devisN}";
                        }
                        else
                        {
                            cmd.CommandText = $"update Devis set Quantite={quantite}, Total=TRY_PARSE('{total.ToString().Replace(',', '.')}' as float using 'en-US'), Date='{date}', Status='{status}' where DevisN={devisN}";
                        }
                    }else if(quantite == 0)
                    {
                        if(total == 0)
                        {
                            cmd.CommandText = $"update Devis set RS='{RS}', Date='{date}', Status='{status}' where DevisN={devisN}";
                        }
                        else
                        {
                            cmd.CommandText = $"update Devis set Total=TRY_PARSE('{total.ToString().Replace(',', '.')}' as float using 'en-US'), RS='{RS}', Date='{date}', Status='{status}' where DevisN={devisN}";
                        }
                    }else if(total == 0)
                    {
                        cmd.CommandText = $"update Devis set RS='{RS}', Quantite={quantite}, Date='{date}', Status='{status}' where DevisN={devisN}";
                    }
                    else
                    {
                        cmd.CommandText = $"update Devis set RS='{RS}', Quantite={quantite}, Total=TRY_PARSE('{total.ToString().Replace(',', '.')}' as float using 'en-US'), Date='{date}', Status='{status}' where DevisN={devisN}";
                    }
                }
                else
                {
                    if (RS == "")
                    {
                        if (quantite == 0)
                        {
                            if (total == 0)
                            {
                                cmd.CommandText = $"update Devis set Date='{date}', Status='{status}' where DevisN={devisNumber}";
                            }
                            else
                            {
                                cmd.CommandText = $"update Devis set Total=TRY_PARSE('{total.ToString().Replace(',', '.')}' as float using 'en-US'), Date='{date}', Status='{status}' where DevisN={devisNumber}";
                            }
                        }
                        else if (total == 0)
                        {
                            cmd.CommandText = $"update Devis set Quantite={quantite}, Date='{date}', Status='{status}' where DevisN={devisNumber}";
                        }
                        else
                        {
                            cmd.CommandText = $"update Devis set Quantite={quantite}, Total=TRY_PARSE('{total.ToString().Replace(',', '.')}' as float using 'en-US'), Date='{date}', Status='{status}' where DevisN={devisNumber}";
                        }
                    }
                    else if (quantite == 0)
                    {
                        if (total == 0)
                        {
                            cmd.CommandText = $"update Devis set RS='{RS}', Date='{date}', Status='{status}' where DevisN={devisNumber}";
                        }
                        else
                        {
                            cmd.CommandText = $"update Devis set Total=TRY_PARSE('{total.ToString().Replace(',', '.')}' as float using 'en-US'), RS='{RS}', Date='{date}', Status='{status}' where DevisN={devisNumber}";
                        }
                    }
                    else if (total == 0)
                    {
                        cmd.CommandText = $"update Devis set RS='{RS}', Quantite={quantite}, Date='{date}', Status='{status}' where DevisN={devisNumber}";
                    }
                    else
                    {
                        cmd.CommandText = $"update Devis set RS='{RS}', Quantite={quantite}, Total=TRY_PARSE('{total.ToString().Replace(',', '.')}' as float using 'en-US'), Date='{date}', Status='{status}' where DevisN={devisNumber}";
                    }
                }

                cmd.ExecuteNonQuery();
                MetroFramework.MetroMessageBox.Show(Conteneur.conteneur, "Le devis a bien été modifiée.", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MetroFramework.MetroMessageBox.Show(Conteneur.conteneur, "La modification à la base de données n'a pas réussi.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conteneur.conn.Close();
            }
        }

        public static void delete(int devisN)
        {
            try
            {
                Conteneur.conn.Open();
                SqlCommand cmd = Conteneur.conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"delete from Devis where DevisN={devisN}";
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

        public void load_ClientComboBox()
        {
            DataTable dt = new DataTable();
            dt.TableName = "ComboBoxClients";
            SqlDataAdapter sda = new SqlDataAdapter("select IdClient, concat(nom, ' ', prenom) as fullname FROM Client", Conteneur.conn);
            sda.Fill(dt);
            this.ClientText.DisplayMember = "fullname";
            this.ClientText.ValueMember = "IdClient";
            this.ClientText.DataSource = dt;
        }
        
        public static void calculer(int devisN)
        {
            try
            {
                Conteneur.conn.Open();
                SqlDataReader sdr = Produit.select(devisN: devisN);

                int quantite = 0;
                float total = 0;

                while (sdr.Read())
                {
                    int qteProd = Convert.ToInt32(sdr["Quantite"]);
                    quantite += qteProd;
                    total += qteProd*Convert.ToInt32(sdr["Prix"]);
                }
                Console.WriteLine(devisN);
                Console.WriteLine(quantite);
                Console.WriteLine(total);

                sdr.Close();

                SqlCommand cmd = Conteneur.conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"update Devis set Quantite={quantite}, Total=TRY_PARSE('{total.ToString().Replace(',', '.')}' as float using 'en-US') where DevisN={devisN}";
                cmd.ExecuteNonQuery();

                Devis devis = Conteneur.getInstanceDevis();

                if (devis != null)
                {
                    devis.load_metroGrid();
                }
            }
            catch(Exception e)
            {
                MetroFramework.MetroMessageBox.Show(Conteneur.conteneur, "La modification des champs Quantite et Total du devis est echouée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void metroGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.buttonSupprimer.Enabled = true;
            this.buttonModifier.Enabled = true;
            this.buttonImprimer.Enabled = true;
            this.buttonModifier.BackColor = Color.WhiteSmoke;
            this.buttonSupprimer.BackColor = Color.WhiteSmoke;
            this.buttonImprimer.BackColor = Color.WhiteSmoke;
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            this.reset_formulaire();
            this.metroPanelFormulaire.Visible = true;
            this.buttonAjouter.Enabled = false;
            this.metroGrid.Enabled = false;
            load_ClientComboBox();
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            reset_formulaire();
            load_ClientComboBox();

            int devisN = 0;
            int idclient = 0;

            try
            {
                devisN = Convert.ToInt32(this.metroGrid.CurrentRow.Cells[0].Value.ToString()) ;
                idclient = Convert.ToInt32(this.metroGrid.CurrentRow.Cells[7].Value.ToString());
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(Conteneur.conteneur, "Une erreur est survenue", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Conteneur.conn.Open();
            SqlDataReader sdr = select(devisN: devisN);

            if (sdr.Read())
            {
                this.devisNText.Text = sdr["DevisNumber"].ToString();
                this.statusText.Text = sdr["Status"].ToString();
                this.dateText.Value = Convert.ToDateTime(sdr["Date"]);

                this.metroPanelFormulaire.Visible = true;
                this.buttonAjouter.Enabled = false;
                this.metroGrid.Enabled = false;
                this.devisNText.Enabled = false;
                this.ClientText.Enabled = false;
            }

            sdr.Close();
            this.ClientText.SelectedValue = idclient;
            Conteneur.conn.Close();
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            reset_formulaire();
            int devisN = 0;
            try
            {
                devisN = Convert.ToInt32(this.metroGrid.CurrentRow.Cells[0].Value.ToString());
                delete(devisN);
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

        private void buttonAjouterModifier_Click(object sender, EventArgs e)
        {
            this.ClientTextErreur.Visible = false;
            this.devisNTextErreur.Visible = false;
            this.statusTextErreur.Visible = false;

            bool erreur = false;

            string devisNumber = devisNText.Text;
            if (devisNumber == "")
            {
                this.devisNTextErreur.Visible = true;
                erreur = true;
            }

            string status = statusText.Text;
            if(status == "")
            {
                this.statusTextErreur.Visible = true;
                erreur = true;
            }

            string date = dateText.Value.Date.ToString("yyyyMMdd");
            int idClient = Convert.ToInt32(this.ClientText.SelectedValue);
            if(idClient == 0)
            {
                this.ClientTextErreur.Visible = true;
                erreur = true;
            }

            if (!erreur)
            {
                if (this.devisNText.Enabled)
                {
                    Conteneur.conn.Open();
                    SqlDataReader sdr = Client.select(idClient);
                    if (sdr.Read())
                    {
                        string rs = sdr["RS"].ToString();
                        sdr.Close();
                        Conteneur.conn.Close();
                        insert(rs, date, idClient, devisNumber);
                    }
                    else
                    {
                        sdr.Close();
                        Conteneur.conn.Close();
                        MetroFramework.MetroMessageBox.Show(Conteneur.conteneur, "La raison sociale du client est introuvable", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    update(date, status, devisNumber: devisNumber);
                }
                
                this.metroPanelFormulaire.Visible = false;
                this.buttonAjouter.Enabled = true;
                this.metroGrid.Enabled = true;
                this.devisNText.Enabled = true;
                this.ClientText.Enabled = true;
                load_metroGrid();
            }
        }

        private void closeWindowLight_Click(object sender, EventArgs e)
        {
            this.metroPanelFormulaire.Visible = false;
            this.buttonAjouter.Enabled = true;
            this.metroGrid.Enabled = true;
            this.devisNText.Enabled = true;
            this.ClientText.Enabled = true;
            this.metroGrid.ClearSelection();
        }

        private void buttonImprimer_Click(object sender, EventArgs e)
        {
            CrystalDevis cd = CrystalDevis.getInstanceCrystalReport();
            int devisN = Convert.ToInt32(this.metroGrid.CurrentRow.Cells[0].Value.ToString());
            cd.BindReport(devisN);
            cd.Show();
        }
    }
}
