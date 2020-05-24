namespace GestionFactures
{
    partial class Conteneur
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conteneur));
            this.minimizeWindowDark = new System.Windows.Forms.PictureBox();
            this.closeWindowDark = new System.Windows.Forms.PictureBox();
            this.minimizeWindowLight = new System.Windows.Forms.PictureBox();
            this.closeWindowLight = new System.Windows.Forms.PictureBox();
            this.metroPanelGestion = new MetroFramework.Controls.MetroPanel();
            this.returnAcceuilDark = new System.Windows.Forms.PictureBox();
            this.returnAcceuilLight = new System.Windows.Forms.PictureBox();
            this.produit = new GestionFactures.Produit();
            this.devis = new GestionFactures.Devis();
            this.facture = new GestionFactures.Facture();
            this.client = new GestionFactures.Client();
            this.metroPanelAcceuil = new MetroFramework.Controls.MetroPanel();
            this.acceuil = new GestionFactures.Acceuil();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage4 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeWindowDark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeWindowDark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeWindowLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeWindowLight)).BeginInit();
            this.metroPanelGestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnAcceuilDark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnAcceuilLight)).BeginInit();
            this.metroPanelAcceuil.SuspendLayout();
            this.metroTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // minimizeWindowDark
            // 
            this.minimizeWindowDark.BackColor = System.Drawing.Color.White;
            this.minimizeWindowDark.Cursor = System.Windows.Forms.Cursors.Default;
            this.minimizeWindowDark.Image = ((System.Drawing.Image)(resources.GetObject("minimizeWindowDark.Image")));
            this.minimizeWindowDark.Location = new System.Drawing.Point(845, 2);
            this.minimizeWindowDark.Name = "minimizeWindowDark";
            this.minimizeWindowDark.Size = new System.Drawing.Size(25, 25);
            this.minimizeWindowDark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeWindowDark.TabIndex = 11;
            this.minimizeWindowDark.TabStop = false;
            this.minimizeWindowDark.Visible = false;
            this.minimizeWindowDark.Click += new System.EventHandler(this.minimizeWindowDark_Click);
            this.minimizeWindowDark.MouseLeave += new System.EventHandler(this.minimizeWindowDark_MouseLeave);
            // 
            // closeWindowDark
            // 
            this.closeWindowDark.BackColor = System.Drawing.Color.White;
            this.closeWindowDark.Cursor = System.Windows.Forms.Cursors.Default;
            this.closeWindowDark.Image = ((System.Drawing.Image)(resources.GetObject("closeWindowDark.Image")));
            this.closeWindowDark.Location = new System.Drawing.Point(873, 2);
            this.closeWindowDark.Name = "closeWindowDark";
            this.closeWindowDark.Size = new System.Drawing.Size(25, 25);
            this.closeWindowDark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeWindowDark.TabIndex = 12;
            this.closeWindowDark.TabStop = false;
            this.closeWindowDark.Visible = false;
            this.closeWindowDark.Click += new System.EventHandler(this.closeWindowDark_Click);
            this.closeWindowDark.MouseLeave += new System.EventHandler(this.closeWindowDark_MouseLeave);
            // 
            // minimizeWindowLight
            // 
            this.minimizeWindowLight.BackColor = System.Drawing.Color.White;
            this.minimizeWindowLight.Cursor = System.Windows.Forms.Cursors.Default;
            this.minimizeWindowLight.Image = ((System.Drawing.Image)(resources.GetObject("minimizeWindowLight.Image")));
            this.minimizeWindowLight.Location = new System.Drawing.Point(845, 2);
            this.minimizeWindowLight.Name = "minimizeWindowLight";
            this.minimizeWindowLight.Size = new System.Drawing.Size(25, 25);
            this.minimizeWindowLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeWindowLight.TabIndex = 13;
            this.minimizeWindowLight.TabStop = false;
            this.minimizeWindowLight.Click += new System.EventHandler(this.minimizeWindowLight_Click);
            this.minimizeWindowLight.MouseHover += new System.EventHandler(this.minimizeWindowLight_MouseHover);
            // 
            // closeWindowLight
            // 
            this.closeWindowLight.BackColor = System.Drawing.Color.White;
            this.closeWindowLight.Cursor = System.Windows.Forms.Cursors.Default;
            this.closeWindowLight.Image = ((System.Drawing.Image)(resources.GetObject("closeWindowLight.Image")));
            this.closeWindowLight.Location = new System.Drawing.Point(873, 2);
            this.closeWindowLight.Name = "closeWindowLight";
            this.closeWindowLight.Size = new System.Drawing.Size(25, 25);
            this.closeWindowLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeWindowLight.TabIndex = 14;
            this.closeWindowLight.TabStop = false;
            this.closeWindowLight.Click += new System.EventHandler(this.closeWindowLight_Click);
            this.closeWindowLight.MouseHover += new System.EventHandler(this.closeWindowLight_MouseHover);
            // 
            // metroPanelGestion
            // 
            this.metroPanelGestion.Controls.Add(this.returnAcceuilDark);
            this.metroPanelGestion.Controls.Add(this.returnAcceuilLight);
            this.metroPanelGestion.Controls.Add(this.produit);
            this.metroPanelGestion.Controls.Add(this.devis);
            this.metroPanelGestion.Controls.Add(this.facture);
            this.metroPanelGestion.Controls.Add(this.client);
            this.metroPanelGestion.HorizontalScrollbarBarColor = true;
            this.metroPanelGestion.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelGestion.HorizontalScrollbarSize = 10;
            this.metroPanelGestion.Location = new System.Drawing.Point(0, 0);
            this.metroPanelGestion.Name = "metroPanelGestion";
            this.metroPanelGestion.Size = new System.Drawing.Size(900, 600);
            this.metroPanelGestion.TabIndex = 15;
            this.metroPanelGestion.VerticalScrollbarBarColor = true;
            this.metroPanelGestion.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelGestion.VerticalScrollbarSize = 10;
            this.metroPanelGestion.Visible = false;
            // 
            // returnAcceuilDark
            // 
            this.returnAcceuilDark.BackColor = System.Drawing.Color.White;
            this.returnAcceuilDark.Image = ((System.Drawing.Image)(resources.GetObject("returnAcceuilDark.Image")));
            this.returnAcceuilDark.Location = new System.Drawing.Point(142, 76);
            this.returnAcceuilDark.Name = "returnAcceuilDark";
            this.returnAcceuilDark.Size = new System.Drawing.Size(25, 25);
            this.returnAcceuilDark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.returnAcceuilDark.TabIndex = 4;
            this.returnAcceuilDark.TabStop = false;
            this.returnAcceuilDark.Visible = false;
            this.returnAcceuilDark.Click += new System.EventHandler(this.returnAcceuilDark_Click);
            this.returnAcceuilDark.MouseLeave += new System.EventHandler(this.returnAcceuilDark_MouseLeave);
            // 
            // returnAcceuilLight
            // 
            this.returnAcceuilLight.BackColor = System.Drawing.Color.White;
            this.returnAcceuilLight.Image = ((System.Drawing.Image)(resources.GetObject("returnAcceuilLight.Image")));
            this.returnAcceuilLight.Location = new System.Drawing.Point(142, 76);
            this.returnAcceuilLight.Name = "returnAcceuilLight";
            this.returnAcceuilLight.Size = new System.Drawing.Size(25, 25);
            this.returnAcceuilLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.returnAcceuilLight.TabIndex = 3;
            this.returnAcceuilLight.TabStop = false;
            this.returnAcceuilLight.MouseHover += new System.EventHandler(this.returnAcceuilLight_MouseHover);
            // 
            // produit
            // 
            this.produit.Location = new System.Drawing.Point(0, 0);
            this.produit.Name = "produit";
            this.produit.Size = new System.Drawing.Size(903, 602);
            this.produit.TabIndex = 8;
            // 
            // devis
            // 
            this.devis.Location = new System.Drawing.Point(0, 0);
            this.devis.Name = "devis";
            this.devis.Size = new System.Drawing.Size(903, 602);
            this.devis.TabIndex = 7;
            // 
            // facture
            // 
            this.facture.Location = new System.Drawing.Point(0, 0);
            this.facture.MaximumSize = new System.Drawing.Size(900, 600);
            this.facture.MinimumSize = new System.Drawing.Size(900, 600);
            this.facture.Name = "facture";
            this.facture.Size = new System.Drawing.Size(900, 600);
            this.facture.TabIndex = 6;
            // 
            // client
            // 
            this.client.Location = new System.Drawing.Point(0, 0);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(900, 600);
            this.client.TabIndex = 5;
            this.client.Visible = false;
            // 
            // metroPanelAcceuil
            // 
            this.metroPanelAcceuil.Controls.Add(this.acceuil);
            this.metroPanelAcceuil.HorizontalScrollbarBarColor = true;
            this.metroPanelAcceuil.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelAcceuil.HorizontalScrollbarSize = 10;
            this.metroPanelAcceuil.Location = new System.Drawing.Point(0, 0);
            this.metroPanelAcceuil.Name = "metroPanelAcceuil";
            this.metroPanelAcceuil.Size = new System.Drawing.Size(900, 600);
            this.metroPanelAcceuil.TabIndex = 2;
            this.metroPanelAcceuil.VerticalScrollbarBarColor = true;
            this.metroPanelAcceuil.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelAcceuil.VerticalScrollbarSize = 10;
            // 
            // acceuil
            // 
            this.acceuil.Location = new System.Drawing.Point(0, 0);
            this.acceuil.MaximumSize = new System.Drawing.Size(900, 600);
            this.acceuil.MinimumSize = new System.Drawing.Size(900, 600);
            this.acceuil.Name = "acceuil";
            this.acceuil.Size = new System.Drawing.Size(900, 600);
            this.acceuil.TabIndex = 0;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(590, 0);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Gestion des Factures";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(590, 0);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Gestion des Clients";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabControl
            // 
            this.metroTabControl.Controls.Add(this.metroTabPage1);
            this.metroTabControl.Controls.Add(this.metroTabPage2);
            this.metroTabControl.Controls.Add(this.metroTabPage3);
            this.metroTabControl.Controls.Add(this.metroTabPage4);
            this.metroTabControl.Location = new System.Drawing.Point(167, 63);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 0;
            this.metroTabControl.Size = new System.Drawing.Size(598, 38);
            this.metroTabControl.TabIndex = 4;
            this.metroTabControl.UseSelectable = true;
            this.metroTabControl.Visible = false;
            this.metroTabControl.SelectedIndexChanged += new System.EventHandler(this.metroTabControl_SelectedIndexChanged);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(590, 0);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Gestion des Devis";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(590, 0);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "Gestion des Produits";
            // 
            // Conteneur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.metroTabControl);
            this.Controls.Add(this.closeWindowDark);
            this.Controls.Add(this.minimizeWindowDark);
            this.Controls.Add(this.minimizeWindowLight);
            this.Controls.Add(this.closeWindowLight);
            this.Controls.Add(this.metroPanelGestion);
            this.Controls.Add(this.metroPanelAcceuil);
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Conteneur";
            ((System.ComponentModel.ISupportInitialize)(this.minimizeWindowDark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeWindowDark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeWindowLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeWindowLight)).EndInit();
            this.metroPanelGestion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.returnAcceuilDark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnAcceuilLight)).EndInit();
            this.metroPanelAcceuil.ResumeLayout(false);
            this.metroTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox minimizeWindowDark;
        private System.Windows.Forms.PictureBox closeWindowDark;
        private System.Windows.Forms.PictureBox minimizeWindowLight;
        private System.Windows.Forms.PictureBox closeWindowLight;
        private Acceuil acceuil;
        private MetroFramework.Controls.MetroPanel metroPanelGestion;
        private MetroFramework.Controls.MetroPanel metroPanelAcceuil;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private System.Windows.Forms.PictureBox returnAcceuilLight;
        private System.Windows.Forms.PictureBox returnAcceuilDark;
        private Client client;
        private Facture facture;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private Devis devis;
        private Produit produit;
        private System.Windows.Forms.TabPage metroTabPage4;
    }
}

