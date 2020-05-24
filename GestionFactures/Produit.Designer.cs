namespace GestionFactures
{
    partial class Produit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produit));
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.metroGrid = new MetroFramework.Controls.MetroGrid();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroPanelFormulaire = new MetroFramework.Controls.MetroPanel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.devisNTextErreur = new System.Windows.Forms.PictureBox();
            this.devisNText = new MetroFramework.Controls.MetroComboBox();
            this.prixTextErreur = new System.Windows.Forms.PictureBox();
            this.quantiteTextErreur = new System.Windows.Forms.PictureBox();
            this.referenceTextErreur = new System.Windows.Forms.PictureBox();
            this.designationTextErreur = new System.Windows.Forms.PictureBox();
            this.closeWindowLight = new System.Windows.Forms.PictureBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.buttonAjouterModifier = new System.Windows.Forms.Button();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.designationText = new MetroFramework.Controls.MetroTextBox();
            this.referenceText = new MetroFramework.Controls.MetroTextBox();
            this.quantiteText = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.prixText = new MetroFramework.Controls.MetroTextBox();
            this.dateText = new MetroFramework.Controls.MetroDateTime();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroPanelFormulaire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devisNTextErreur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixTextErreur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantiteTextErreur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referenceTextErreur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.designationTextErreur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeWindowLight)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel18.Location = new System.Drawing.Point(431, 393);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(370, 15);
            this.metroLabel18.TabIndex = 47;
            this.metroLabel18.Text = "*Pour modifier ou supprimer, selectionner la ligne et cliquer sur le bouton.";
            // 
            // buttonModifier
            // 
            this.buttonModifier.BackColor = System.Drawing.Color.LightGray;
            this.buttonModifier.Enabled = false;
            this.buttonModifier.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.buttonModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifier.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonModifier.Location = new System.Drawing.Point(571, 126);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(112, 39);
            this.buttonModifier.TabIndex = 46;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = false;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
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
            this.buttonAjouter.TabIndex = 45;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
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
            this.buttonSupprimer.TabIndex = 44;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // metroGrid
            // 
            this.metroGrid.AllowUserToAddRows = false;
            this.metroGrid.AllowUserToDeleteRows = false;
            this.metroGrid.AllowUserToOrderColumns = true;
            this.metroGrid.AllowUserToResizeRows = false;
            this.metroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.metroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.metroGrid.EnableHeadersVisualStyles = false;
            this.metroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid.GridColor = System.Drawing.Color.White;
            this.metroGrid.Location = new System.Drawing.Point(99, 171);
            this.metroGrid.Name = "metroGrid";
            this.metroGrid.ReadOnly = true;
            this.metroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.metroGrid.RowHeadersVisible = false;
            this.metroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid.Size = new System.Drawing.Size(702, 219);
            this.metroGrid.TabIndex = 42;
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
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // metroPanelFormulaire
            // 
            this.metroPanelFormulaire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanelFormulaire.Controls.Add(this.metroLabel11);
            this.metroPanelFormulaire.Controls.Add(this.devisNTextErreur);
            this.metroPanelFormulaire.Controls.Add(this.devisNText);
            this.metroPanelFormulaire.Controls.Add(this.prixTextErreur);
            this.metroPanelFormulaire.Controls.Add(this.quantiteTextErreur);
            this.metroPanelFormulaire.Controls.Add(this.referenceTextErreur);
            this.metroPanelFormulaire.Controls.Add(this.designationTextErreur);
            this.metroPanelFormulaire.Controls.Add(this.closeWindowLight);
            this.metroPanelFormulaire.Controls.Add(this.metroLabel2);
            this.metroPanelFormulaire.Controls.Add(this.buttonAjouterModifier);
            this.metroPanelFormulaire.Controls.Add(this.metroLabel3);
            this.metroPanelFormulaire.Controls.Add(this.designationText);
            this.metroPanelFormulaire.Controls.Add(this.referenceText);
            this.metroPanelFormulaire.Controls.Add(this.quantiteText);
            this.metroPanelFormulaire.Controls.Add(this.metroLabel4);
            this.metroPanelFormulaire.Controls.Add(this.metroLabel5);
            this.metroPanelFormulaire.Controls.Add(this.metroLabel6);
            this.metroPanelFormulaire.Controls.Add(this.prixText);
            this.metroPanelFormulaire.Controls.Add(this.dateText);
            this.metroPanelFormulaire.HorizontalScrollbarBarColor = true;
            this.metroPanelFormulaire.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelFormulaire.HorizontalScrollbarSize = 10;
            this.metroPanelFormulaire.Location = new System.Drawing.Point(275, 112);
            this.metroPanelFormulaire.Name = "metroPanelFormulaire";
            this.metroPanelFormulaire.Size = new System.Drawing.Size(340, 381);
            this.metroPanelFormulaire.TabIndex = 50;
            this.metroPanelFormulaire.VerticalScrollbarBarColor = true;
            this.metroPanelFormulaire.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelFormulaire.VerticalScrollbarSize = 10;
            this.metroPanelFormulaire.Visible = false;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(37, 42);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(58, 19);
            this.metroLabel11.TabIndex = 45;
            this.metroLabel11.Text = "Devis N°";
            // 
            // devisNTextErreur
            // 
            this.devisNTextErreur.BackColor = System.Drawing.Color.White;
            this.devisNTextErreur.Image = ((System.Drawing.Image)(resources.GetObject("devisNTextErreur.Image")));
            this.devisNTextErreur.Location = new System.Drawing.Point(299, 40);
            this.devisNTextErreur.Name = "devisNTextErreur";
            this.devisNTextErreur.Size = new System.Drawing.Size(22, 21);
            this.devisNTextErreur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.devisNTextErreur.TabIndex = 44;
            this.devisNTextErreur.TabStop = false;
            this.devisNTextErreur.Visible = false;
            // 
            // devisNText
            // 
            this.devisNText.FormattingEnabled = true;
            this.devisNText.ItemHeight = 23;
            this.devisNText.Location = new System.Drawing.Point(124, 37);
            this.devisNText.Name = "devisNText";
            this.devisNText.Size = new System.Drawing.Size(169, 29);
            this.devisNText.TabIndex = 7;
            this.devisNText.UseSelectable = true;
            // 
            // prixTextErreur
            // 
            this.prixTextErreur.BackColor = System.Drawing.Color.White;
            this.prixTextErreur.Image = ((System.Drawing.Image)(resources.GetObject("prixTextErreur.Image")));
            this.prixTextErreur.Location = new System.Drawing.Point(271, 195);
            this.prixTextErreur.Name = "prixTextErreur";
            this.prixTextErreur.Size = new System.Drawing.Size(22, 21);
            this.prixTextErreur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.prixTextErreur.TabIndex = 42;
            this.prixTextErreur.TabStop = false;
            this.prixTextErreur.Visible = false;
            // 
            // quantiteTextErreur
            // 
            this.quantiteTextErreur.BackColor = System.Drawing.Color.White;
            this.quantiteTextErreur.Image = ((System.Drawing.Image)(resources.GetObject("quantiteTextErreur.Image")));
            this.quantiteTextErreur.Location = new System.Drawing.Point(271, 157);
            this.quantiteTextErreur.Name = "quantiteTextErreur";
            this.quantiteTextErreur.Size = new System.Drawing.Size(22, 21);
            this.quantiteTextErreur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.quantiteTextErreur.TabIndex = 41;
            this.quantiteTextErreur.TabStop = false;
            this.quantiteTextErreur.Visible = false;
            // 
            // referenceTextErreur
            // 
            this.referenceTextErreur.BackColor = System.Drawing.Color.White;
            this.referenceTextErreur.Image = ((System.Drawing.Image)(resources.GetObject("referenceTextErreur.Image")));
            this.referenceTextErreur.Location = new System.Drawing.Point(271, 119);
            this.referenceTextErreur.Name = "referenceTextErreur";
            this.referenceTextErreur.Size = new System.Drawing.Size(22, 21);
            this.referenceTextErreur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.referenceTextErreur.TabIndex = 40;
            this.referenceTextErreur.TabStop = false;
            this.referenceTextErreur.Visible = false;
            // 
            // designationTextErreur
            // 
            this.designationTextErreur.BackColor = System.Drawing.Color.White;
            this.designationTextErreur.Image = ((System.Drawing.Image)(resources.GetObject("designationTextErreur.Image")));
            this.designationTextErreur.Location = new System.Drawing.Point(271, 82);
            this.designationTextErreur.Name = "designationTextErreur";
            this.designationTextErreur.Size = new System.Drawing.Size(22, 21);
            this.designationTextErreur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.designationTextErreur.TabIndex = 39;
            this.designationTextErreur.TabStop = false;
            this.designationTextErreur.Visible = false;
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
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(37, 83);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(77, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Designation";
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
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(37, 120);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Reference";
            // 
            // designationText
            // 
            // 
            // 
            // 
            this.designationText.CustomButton.Image = null;
            this.designationText.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.designationText.CustomButton.Name = "";
            this.designationText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.designationText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.designationText.CustomButton.TabIndex = 1;
            this.designationText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.designationText.CustomButton.UseSelectable = true;
            this.designationText.CustomButton.Visible = false;
            this.designationText.Lines = new string[0];
            this.designationText.Location = new System.Drawing.Point(124, 81);
            this.designationText.MaxLength = 32767;
            this.designationText.Name = "designationText";
            this.designationText.PasswordChar = '\0';
            this.designationText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.designationText.SelectedText = "";
            this.designationText.SelectionLength = 0;
            this.designationText.SelectionStart = 0;
            this.designationText.ShortcutsEnabled = true;
            this.designationText.Size = new System.Drawing.Size(171, 23);
            this.designationText.TabIndex = 9;
            this.designationText.UseSelectable = true;
            this.designationText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.designationText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // referenceText
            // 
            // 
            // 
            // 
            this.referenceText.CustomButton.Image = null;
            this.referenceText.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.referenceText.CustomButton.Name = "";
            this.referenceText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.referenceText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.referenceText.CustomButton.TabIndex = 1;
            this.referenceText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.referenceText.CustomButton.UseSelectable = true;
            this.referenceText.CustomButton.Visible = false;
            this.referenceText.Lines = new string[0];
            this.referenceText.Location = new System.Drawing.Point(124, 118);
            this.referenceText.MaxLength = 32767;
            this.referenceText.Name = "referenceText";
            this.referenceText.PasswordChar = '\0';
            this.referenceText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.referenceText.SelectedText = "";
            this.referenceText.SelectionLength = 0;
            this.referenceText.SelectionStart = 0;
            this.referenceText.ShortcutsEnabled = true;
            this.referenceText.Size = new System.Drawing.Size(171, 23);
            this.referenceText.TabIndex = 10;
            this.referenceText.UseSelectable = true;
            this.referenceText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.referenceText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // quantiteText
            // 
            // 
            // 
            // 
            this.quantiteText.CustomButton.Image = null;
            this.quantiteText.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.quantiteText.CustomButton.Name = "";
            this.quantiteText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.quantiteText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.quantiteText.CustomButton.TabIndex = 1;
            this.quantiteText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.quantiteText.CustomButton.UseSelectable = true;
            this.quantiteText.CustomButton.Visible = false;
            this.quantiteText.Lines = new string[0];
            this.quantiteText.Location = new System.Drawing.Point(124, 156);
            this.quantiteText.MaxLength = 32767;
            this.quantiteText.Name = "quantiteText";
            this.quantiteText.PasswordChar = '\0';
            this.quantiteText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.quantiteText.SelectedText = "";
            this.quantiteText.SelectionLength = 0;
            this.quantiteText.SelectionStart = 0;
            this.quantiteText.ShortcutsEnabled = true;
            this.quantiteText.Size = new System.Drawing.Size(171, 23);
            this.quantiteText.TabIndex = 11;
            this.quantiteText.UseSelectable = true;
            this.quantiteText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.quantiteText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.quantiteText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantiteText_KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(37, 158);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(59, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Quantité";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(37, 195);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(31, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Prix";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(37, 236);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(36, 19);
            this.metroLabel6.TabIndex = 7;
            this.metroLabel6.Text = "Date";
            // 
            // prixText
            // 
            // 
            // 
            // 
            this.prixText.CustomButton.Image = null;
            this.prixText.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.prixText.CustomButton.Name = "";
            this.prixText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.prixText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.prixText.CustomButton.TabIndex = 1;
            this.prixText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.prixText.CustomButton.UseSelectable = true;
            this.prixText.CustomButton.Visible = false;
            this.prixText.Lines = new string[0];
            this.prixText.Location = new System.Drawing.Point(124, 194);
            this.prixText.MaxLength = 32767;
            this.prixText.Name = "prixText";
            this.prixText.PasswordChar = '\0';
            this.prixText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.prixText.SelectedText = "";
            this.prixText.SelectionLength = 0;
            this.prixText.SelectionStart = 0;
            this.prixText.ShortcutsEnabled = true;
            this.prixText.Size = new System.Drawing.Size(171, 23);
            this.prixText.TabIndex = 12;
            this.prixText.UseSelectable = true;
            this.prixText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.prixText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.prixText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prixText_KeyPress);
            // 
            // dateText
            // 
            this.dateText.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop;
            this.dateText.Location = new System.Drawing.Point(124, 232);
            this.dateText.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(171, 29);
            this.dateText.TabIndex = 13;
            // 
            // Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanelFormulaire);
            this.Controls.Add(this.metroLabel18);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.metroGrid);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Produit";
            this.Size = new System.Drawing.Size(903, 602);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroPanelFormulaire.ResumeLayout(false);
            this.metroPanelFormulaire.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devisNTextErreur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixTextErreur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantiteTextErreur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referenceTextErreur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.designationTextErreur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeWindowLight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonSupprimer;
        private MetroFramework.Controls.MetroGrid metroGrid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroPanel metroPanelFormulaire;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.PictureBox devisNTextErreur;
        private MetroFramework.Controls.MetroComboBox devisNText;
        private System.Windows.Forms.PictureBox prixTextErreur;
        private System.Windows.Forms.PictureBox quantiteTextErreur;
        private System.Windows.Forms.PictureBox referenceTextErreur;
        private System.Windows.Forms.PictureBox designationTextErreur;
        private System.Windows.Forms.PictureBox closeWindowLight;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Button buttonAjouterModifier;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox designationText;
        private MetroFramework.Controls.MetroTextBox referenceText;
        private MetroFramework.Controls.MetroTextBox quantiteText;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox prixText;
        private MetroFramework.Controls.MetroDateTime dateText;
    }
}
