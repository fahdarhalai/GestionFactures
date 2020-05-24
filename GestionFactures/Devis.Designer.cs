namespace GestionFactures
{
    partial class Devis
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Devis));
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroGrid = new MetroFramework.Controls.MetroGrid();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonImprimer = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.metroPanelFormulaire = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.statusTextErreur = new System.Windows.Forms.PictureBox();
            this.statusText = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.ClientTextErreur = new System.Windows.Forms.PictureBox();
            this.ClientText = new MetroFramework.Controls.MetroComboBox();
            this.devisNTextErreur = new System.Windows.Forms.PictureBox();
            this.closeWindowLight = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.buttonAjouterModifier = new System.Windows.Forms.Button();
            this.devisNText = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.dateText = new MetroFramework.Controls.MetroDateTime();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroPanelFormulaire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusTextErreur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientTextErreur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devisNTextErreur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeWindowLight)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAjouter.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.buttonAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouter.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAjouter.Location = new System.Drawing.Point(453, 126);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(112, 39);
            this.buttonAjouter.TabIndex = 52;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel10.Location = new System.Drawing.Point(437, 393);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(364, 15);
            this.metroLabel10.TabIndex = 51;
            this.metroLabel10.Text = "*Pour imprimer ou modifier, selectionner la ligne et cliquer sur le bouton.";
            // 
            // metroGrid
            // 
            this.metroGrid.AllowUserToAddRows = false;
            this.metroGrid.AllowUserToDeleteRows = false;
            this.metroGrid.AllowUserToResizeRows = false;
            this.metroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid.EnableHeadersVisualStyles = false;
            this.metroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid.GridColor = System.Drawing.Color.White;
            this.metroGrid.Location = new System.Drawing.Point(99, 171);
            this.metroGrid.Name = "metroGrid";
            this.metroGrid.ReadOnly = true;
            this.metroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid.RowHeadersVisible = false;
            this.metroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid.Size = new System.Drawing.Size(702, 219);
            this.metroGrid.TabIndex = 40;
            this.metroGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(903, 602);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.BackColor = System.Drawing.Color.LightGray;
            this.buttonSupprimer.Enabled = false;
            this.buttonSupprimer.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.buttonSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimer.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSupprimer.Location = new System.Drawing.Point(689, 126);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(112, 39);
            this.buttonSupprimer.TabIndex = 50;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonImprimer
            // 
            this.buttonImprimer.BackColor = System.Drawing.Color.LightGray;
            this.buttonImprimer.Enabled = false;
            this.buttonImprimer.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.buttonImprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImprimer.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImprimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonImprimer.Location = new System.Drawing.Point(99, 396);
            this.buttonImprimer.Name = "buttonImprimer";
            this.buttonImprimer.Size = new System.Drawing.Size(112, 39);
            this.buttonImprimer.TabIndex = 55;
            this.buttonImprimer.Text = "Imprimer";
            this.buttonImprimer.UseVisualStyleBackColor = false;
            this.buttonImprimer.Click += new System.EventHandler(this.buttonImprimer_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.BackColor = System.Drawing.Color.LightGray;
            this.buttonModifier.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.buttonModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifier.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonModifier.Location = new System.Drawing.Point(571, 126);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(112, 39);
            this.buttonModifier.TabIndex = 58;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = false;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // metroPanelFormulaire
            // 
            this.metroPanelFormulaire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanelFormulaire.Controls.Add(this.metroLabel2);
            this.metroPanelFormulaire.Controls.Add(this.statusTextErreur);
            this.metroPanelFormulaire.Controls.Add(this.statusText);
            this.metroPanelFormulaire.Controls.Add(this.metroLabel11);
            this.metroPanelFormulaire.Controls.Add(this.ClientTextErreur);
            this.metroPanelFormulaire.Controls.Add(this.ClientText);
            this.metroPanelFormulaire.Controls.Add(this.devisNTextErreur);
            this.metroPanelFormulaire.Controls.Add(this.closeWindowLight);
            this.metroPanelFormulaire.Controls.Add(this.metroLabel1);
            this.metroPanelFormulaire.Controls.Add(this.buttonAjouterModifier);
            this.metroPanelFormulaire.Controls.Add(this.devisNText);
            this.metroPanelFormulaire.Controls.Add(this.metroLabel6);
            this.metroPanelFormulaire.Controls.Add(this.dateText);
            this.metroPanelFormulaire.HorizontalScrollbarBarColor = true;
            this.metroPanelFormulaire.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelFormulaire.HorizontalScrollbarSize = 10;
            this.metroPanelFormulaire.Location = new System.Drawing.Point(281, 111);
            this.metroPanelFormulaire.Name = "metroPanelFormulaire";
            this.metroPanelFormulaire.Size = new System.Drawing.Size(340, 381);
            this.metroPanelFormulaire.TabIndex = 59;
            this.metroPanelFormulaire.VerticalScrollbarBarColor = true;
            this.metroPanelFormulaire.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelFormulaire.VerticalScrollbarSize = 10;
            this.metroPanelFormulaire.Visible = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(37, 170);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(42, 19);
            this.metroLabel2.TabIndex = 48;
            this.metroLabel2.Text = "Statut";
            // 
            // statusTextErreur
            // 
            this.statusTextErreur.BackColor = System.Drawing.Color.White;
            this.statusTextErreur.Image = ((System.Drawing.Image)(resources.GetObject("statusTextErreur.Image")));
            this.statusTextErreur.Location = new System.Drawing.Point(299, 168);
            this.statusTextErreur.Name = "statusTextErreur";
            this.statusTextErreur.Size = new System.Drawing.Size(22, 21);
            this.statusTextErreur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.statusTextErreur.TabIndex = 47;
            this.statusTextErreur.TabStop = false;
            this.statusTextErreur.Visible = false;
            // 
            // statusText
            // 
            this.statusText.FormattingEnabled = true;
            this.statusText.ItemHeight = 23;
            this.statusText.Items.AddRange(new object[] {
            "En attente",
            "Validé"});
            this.statusText.Location = new System.Drawing.Point(124, 165);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(169, 29);
            this.statusText.TabIndex = 46;
            this.statusText.UseSelectable = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(37, 42);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(42, 19);
            this.metroLabel11.TabIndex = 45;
            this.metroLabel11.Text = "Client";
            // 
            // ClientTextErreur
            // 
            this.ClientTextErreur.BackColor = System.Drawing.Color.White;
            this.ClientTextErreur.Image = ((System.Drawing.Image)(resources.GetObject("ClientTextErreur.Image")));
            this.ClientTextErreur.Location = new System.Drawing.Point(299, 40);
            this.ClientTextErreur.Name = "ClientTextErreur";
            this.ClientTextErreur.Size = new System.Drawing.Size(22, 21);
            this.ClientTextErreur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClientTextErreur.TabIndex = 44;
            this.ClientTextErreur.TabStop = false;
            this.ClientTextErreur.Visible = false;
            // 
            // ClientText
            // 
            this.ClientText.FormattingEnabled = true;
            this.ClientText.ItemHeight = 23;
            this.ClientText.Location = new System.Drawing.Point(124, 37);
            this.ClientText.Name = "ClientText";
            this.ClientText.Size = new System.Drawing.Size(169, 29);
            this.ClientText.TabIndex = 7;
            this.ClientText.UseSelectable = true;
            // 
            // devisNTextErreur
            // 
            this.devisNTextErreur.BackColor = System.Drawing.Color.White;
            this.devisNTextErreur.Image = ((System.Drawing.Image)(resources.GetObject("devisNTextErreur.Image")));
            this.devisNTextErreur.Location = new System.Drawing.Point(271, 82);
            this.devisNTextErreur.Name = "devisNTextErreur";
            this.devisNTextErreur.Size = new System.Drawing.Size(22, 21);
            this.devisNTextErreur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.devisNTextErreur.TabIndex = 38;
            this.devisNTextErreur.TabStop = false;
            this.devisNTextErreur.Visible = false;
            // 
            // closeWindowLight
            // 
            this.closeWindowLight.BackColor = System.Drawing.Color.White;
            this.closeWindowLight.Cursor = System.Windows.Forms.Cursors.Default;
            this.closeWindowLight.Image = ((System.Drawing.Image)(resources.GetObject("closeWindowLight.Image")));
            this.closeWindowLight.Location = new System.Drawing.Point(310, 3);
            this.closeWindowLight.Name = "closeWindowLight";
            this.closeWindowLight.Size = new System.Drawing.Size(25, 25);
            this.closeWindowLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeWindowLight.TabIndex = 37;
            this.closeWindowLight.TabStop = false;
            this.closeWindowLight.Click += new System.EventHandler(this.closeWindowLight_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(37, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(58, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Devis N°";
            // 
            // buttonAjouterModifier
            // 
            this.buttonAjouterModifier.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAjouterModifier.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.buttonAjouterModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouterModifier.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouterModifier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAjouterModifier.Location = new System.Drawing.Point(124, 309);
            this.buttonAjouterModifier.Name = "buttonAjouterModifier";
            this.buttonAjouterModifier.Size = new System.Drawing.Size(171, 39);
            this.buttonAjouterModifier.TabIndex = 26;
            this.buttonAjouterModifier.Text = "Ajouter / Modifier";
            this.buttonAjouterModifier.UseVisualStyleBackColor = false;
            this.buttonAjouterModifier.Click += new System.EventHandler(this.buttonAjouterModifier_Click);
            // 
            // devisNText
            // 
            // 
            // 
            // 
            this.devisNText.CustomButton.Image = null;
            this.devisNText.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.devisNText.CustomButton.Name = "";
            this.devisNText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.devisNText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.devisNText.CustomButton.TabIndex = 1;
            this.devisNText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.devisNText.CustomButton.UseSelectable = true;
            this.devisNText.CustomButton.Visible = false;
            this.devisNText.Lines = new string[0];
            this.devisNText.Location = new System.Drawing.Point(124, 81);
            this.devisNText.MaxLength = 32767;
            this.devisNText.Name = "devisNText";
            this.devisNText.PasswordChar = '\0';
            this.devisNText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.devisNText.SelectedText = "";
            this.devisNText.SelectionLength = 0;
            this.devisNText.SelectionStart = 0;
            this.devisNText.ShortcutsEnabled = true;
            this.devisNText.Size = new System.Drawing.Size(171, 23);
            this.devisNText.TabIndex = 8;
            this.devisNText.UseSelectable = true;
            this.devisNText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.devisNText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(37, 124);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(36, 19);
            this.metroLabel6.TabIndex = 7;
            this.metroLabel6.Text = "Date";
            // 
            // dateText
            // 
            this.dateText.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop;
            this.dateText.Location = new System.Drawing.Point(124, 120);
            this.dateText.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(169, 29);
            this.dateText.TabIndex = 13;
            // 
            // Devis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanelFormulaire);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.buttonImprimer);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroGrid);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Devis";
            this.Size = new System.Drawing.Size(903, 602);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroPanelFormulaire.ResumeLayout(false);
            this.metroPanelFormulaire.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusTextErreur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientTextErreur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devisNTextErreur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeWindowLight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAjouter;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroGrid metroGrid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonImprimer;
        private System.Windows.Forms.Button buttonModifier;
        private MetroFramework.Controls.MetroPanel metroPanelFormulaire;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.PictureBox statusTextErreur;
        private MetroFramework.Controls.MetroComboBox statusText;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.PictureBox ClientTextErreur;
        private MetroFramework.Controls.MetroComboBox ClientText;
        private System.Windows.Forms.PictureBox devisNTextErreur;
        private System.Windows.Forms.PictureBox closeWindowLight;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button buttonAjouterModifier;
        private MetroFramework.Controls.MetroTextBox devisNText;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroDateTime dateText;
    }
}
