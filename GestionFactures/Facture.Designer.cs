namespace GestionFactures
{
    partial class Facture
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facture));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroGrid = new MetroFramework.Controls.MetroGrid();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.totalTTC = new MetroFramework.Controls.MetroTextBox();
            this.TVAText = new MetroFramework.Controls.MetroTextBox();
            this.totalHT = new MetroFramework.Controls.MetroTextBox();
            this.metroRadioButton7 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton20 = new MetroFramework.Controls.MetroRadioButton();
            this.buttonCalculer = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.searchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.databaseDataSet = new GestionFactures.DatabaseDataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new GestionFactures.DatabaseDataSetTableAdapters.ClientTableAdapter();
            this.dateText = new MetroFramework.Controls.MetroDateTime();
            this.prixText = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.quantiteText = new MetroFramework.Controls.MetroTextBox();
            this.referenceText = new MetroFramework.Controls.MetroTextBox();
            this.designationText = new MetroFramework.Controls.MetroTextBox();
            this.factureNText = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.buttonAjouterModifier = new System.Windows.Forms.Button();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.closeWindowLight = new System.Windows.Forms.PictureBox();
            this.factureNTextErreur = new System.Windows.Forms.PictureBox();
            this.designationTextErreur = new System.Windows.Forms.PictureBox();
            this.referenceTextErreur = new System.Windows.Forms.PictureBox();
            this.quantiteTextErreur = new System.Windows.Forms.PictureBox();
            this.prixTextErreur = new System.Windows.Forms.PictureBox();
            this.ClientText = new MetroFramework.Controls.MetroComboBox();
            this.ClientTextErreur = new System.Windows.Forms.PictureBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroPanelFormulaire = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeWindowLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factureNTextErreur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.designationTextErreur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referenceTextErreur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantiteTextErreur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixTextErreur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientTextErreur)).BeginInit();
            this.metroPanelFormulaire.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(903, 602);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
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
            this.metroGrid.TabIndex = 1;
            this.metroGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid_CellClick);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(234, 399);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(84, 19);
            this.metroLabel7.TabIndex = 14;
            this.metroLabel7.Text = "Total HT (Dh)";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(234, 428);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(60, 19);
            this.metroLabel8.TabIndex = 15;
            this.metroLabel8.Text = "TVA (Dh)";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(234, 457);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(90, 19);
            this.metroLabel9.TabIndex = 16;
            this.metroLabel9.Text = "Total TTC (Dh)";
            // 
            // totalTTC
            // 
            // 
            // 
            // 
            this.totalTTC.CustomButton.Image = null;
            this.totalTTC.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.totalTTC.CustomButton.Name = "";
            this.totalTTC.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.totalTTC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.totalTTC.CustomButton.TabIndex = 1;
            this.totalTTC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.totalTTC.CustomButton.UseSelectable = true;
            this.totalTTC.CustomButton.Visible = false;
            this.totalTTC.Enabled = false;
            this.totalTTC.Lines = new string[0];
            this.totalTTC.Location = new System.Drawing.Point(340, 455);
            this.totalTTC.MaxLength = 32767;
            this.totalTTC.Name = "totalTTC";
            this.totalTTC.PasswordChar = '\0';
            this.totalTTC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.totalTTC.SelectedText = "";
            this.totalTTC.SelectionLength = 0;
            this.totalTTC.SelectionStart = 0;
            this.totalTTC.ShortcutsEnabled = true;
            this.totalTTC.Size = new System.Drawing.Size(113, 23);
            this.totalTTC.TabIndex = 17;
            this.totalTTC.UseSelectable = true;
            this.totalTTC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.totalTTC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TVAText
            // 
            // 
            // 
            // 
            this.TVAText.CustomButton.Image = null;
            this.TVAText.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.TVAText.CustomButton.Name = "";
            this.TVAText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TVAText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TVAText.CustomButton.TabIndex = 1;
            this.TVAText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TVAText.CustomButton.UseSelectable = true;
            this.TVAText.CustomButton.Visible = false;
            this.TVAText.Enabled = false;
            this.TVAText.Lines = new string[0];
            this.TVAText.Location = new System.Drawing.Point(341, 426);
            this.TVAText.MaxLength = 32767;
            this.TVAText.Name = "TVAText";
            this.TVAText.PasswordChar = '\0';
            this.TVAText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TVAText.SelectedText = "";
            this.TVAText.SelectionLength = 0;
            this.TVAText.SelectionStart = 0;
            this.TVAText.ShortcutsEnabled = true;
            this.TVAText.Size = new System.Drawing.Size(113, 23);
            this.TVAText.TabIndex = 18;
            this.TVAText.UseSelectable = true;
            this.TVAText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TVAText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // totalHT
            // 
            // 
            // 
            // 
            this.totalHT.CustomButton.Image = null;
            this.totalHT.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.totalHT.CustomButton.Name = "";
            this.totalHT.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.totalHT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.totalHT.CustomButton.TabIndex = 1;
            this.totalHT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.totalHT.CustomButton.UseSelectable = true;
            this.totalHT.CustomButton.Visible = false;
            this.totalHT.Enabled = false;
            this.totalHT.Lines = new string[0];
            this.totalHT.Location = new System.Drawing.Point(341, 397);
            this.totalHT.MaxLength = 32767;
            this.totalHT.Name = "totalHT";
            this.totalHT.PasswordChar = '\0';
            this.totalHT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.totalHT.SelectedText = "";
            this.totalHT.SelectionLength = 0;
            this.totalHT.SelectionStart = 0;
            this.totalHT.ShortcutsEnabled = true;
            this.totalHT.Size = new System.Drawing.Size(113, 23);
            this.totalHT.TabIndex = 19;
            this.totalHT.UseSelectable = true;
            this.totalHT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.totalHT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroRadioButton7
            // 
            this.metroRadioButton7.AutoSize = true;
            this.metroRadioButton7.Checked = true;
            this.metroRadioButton7.Location = new System.Drawing.Point(99, 442);
            this.metroRadioButton7.Name = "metroRadioButton7";
            this.metroRadioButton7.Size = new System.Drawing.Size(39, 15);
            this.metroRadioButton7.TabIndex = 21;
            this.metroRadioButton7.TabStop = true;
            this.metroRadioButton7.Text = "7%";
            this.metroRadioButton7.UseSelectable = true;
            // 
            // metroRadioButton20
            // 
            this.metroRadioButton20.AutoSize = true;
            this.metroRadioButton20.Location = new System.Drawing.Point(166, 442);
            this.metroRadioButton20.Name = "metroRadioButton20";
            this.metroRadioButton20.Size = new System.Drawing.Size(45, 15);
            this.metroRadioButton20.TabIndex = 22;
            this.metroRadioButton20.Text = "20%";
            this.metroRadioButton20.UseSelectable = true;
            // 
            // buttonCalculer
            // 
            this.buttonCalculer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCalculer.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.buttonCalculer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculer.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCalculer.Location = new System.Drawing.Point(99, 397);
            this.buttonCalculer.Name = "buttonCalculer";
            this.buttonCalculer.Size = new System.Drawing.Size(112, 39);
            this.buttonCalculer.TabIndex = 28;
            this.buttonCalculer.Text = "Calculer";
            this.buttonCalculer.UseVisualStyleBackColor = false;
            this.buttonCalculer.Click += new System.EventHandler(this.buttonCalculer_Click);
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
            this.buttonSupprimer.TabIndex = 29;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel10.Location = new System.Drawing.Point(431, 393);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(370, 15);
            this.metroLabel10.TabIndex = 30;
            this.metroLabel10.Text = "*Pour modifier ou supprimer, selectionner la ligne et cliquer sur le bouton.";
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
            this.buttonAjouter.TabIndex = 33;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
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
            this.buttonModifier.TabIndex = 34;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = false;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // searchTextBox
            // 
            // 
            // 
            // 
            this.searchTextBox.CustomButton.Image = null;
            this.searchTextBox.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.searchTextBox.CustomButton.Name = "";
            this.searchTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.searchTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchTextBox.CustomButton.TabIndex = 1;
            this.searchTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchTextBox.CustomButton.UseSelectable = true;
            this.searchTextBox.CustomButton.Visible = false;
            this.searchTextBox.Lines = new string[0];
            this.searchTextBox.Location = new System.Drawing.Point(182, 142);
            this.searchTextBox.MaxLength = 32767;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.SelectionLength = 0;
            this.searchTextBox.SelectionStart = 0;
            this.searchTextBox.ShortcutsEnabled = true;
            this.searchTextBox.Size = new System.Drawing.Size(136, 23);
            this.searchTextBox.TabIndex = 37;
            this.searchTextBox.UseSelectable = true;
            this.searchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(98, 144);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(76, 19);
            this.metroLabel12.TabIndex = 38;
            this.metroLabel12.Text = "Nom Client";
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.databaseDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // dateText
            // 
            this.dateText.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop;
            this.dateText.Location = new System.Drawing.Point(124, 271);
            this.dateText.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(171, 29);
            this.dateText.TabIndex = 13;
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
            this.prixText.Location = new System.Drawing.Point(124, 234);
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
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(37, 275);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(36, 19);
            this.metroLabel6.TabIndex = 7;
            this.metroLabel6.Text = "Date";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(37, 235);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(31, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Prix";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(37, 198);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(59, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Quantité";
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
            this.quantiteText.Location = new System.Drawing.Point(124, 196);
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
            this.referenceText.Location = new System.Drawing.Point(124, 157);
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
            this.designationText.Location = new System.Drawing.Point(124, 118);
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
            // factureNText
            // 
            // 
            // 
            // 
            this.factureNText.CustomButton.Image = null;
            this.factureNText.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.factureNText.CustomButton.Name = "";
            this.factureNText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.factureNText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.factureNText.CustomButton.TabIndex = 1;
            this.factureNText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.factureNText.CustomButton.UseSelectable = true;
            this.factureNText.CustomButton.Visible = false;
            this.factureNText.Lines = new string[0];
            this.factureNText.Location = new System.Drawing.Point(124, 81);
            this.factureNText.MaxLength = 32767;
            this.factureNText.Name = "factureNText";
            this.factureNText.PasswordChar = '\0';
            this.factureNText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.factureNText.SelectedText = "";
            this.factureNText.SelectionLength = 0;
            this.factureNText.SelectionStart = 0;
            this.factureNText.ShortcutsEnabled = true;
            this.factureNText.Size = new System.Drawing.Size(171, 23);
            this.factureNText.TabIndex = 8;
            this.factureNText.UseSelectable = true;
            this.factureNText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.factureNText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.factureNText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.factureNText_KeyPress);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(37, 159);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Reference";
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
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(37, 120);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(77, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Designation";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(37, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(61, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "FactureN";
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
            // factureNTextErreur
            // 
            this.factureNTextErreur.BackColor = System.Drawing.Color.White;
            this.factureNTextErreur.Image = ((System.Drawing.Image)(resources.GetObject("factureNTextErreur.Image")));
            this.factureNTextErreur.Location = new System.Drawing.Point(271, 82);
            this.factureNTextErreur.Name = "factureNTextErreur";
            this.factureNTextErreur.Size = new System.Drawing.Size(22, 21);
            this.factureNTextErreur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.factureNTextErreur.TabIndex = 38;
            this.factureNTextErreur.TabStop = false;
            this.factureNTextErreur.Visible = false;
            // 
            // designationTextErreur
            // 
            this.designationTextErreur.BackColor = System.Drawing.Color.White;
            this.designationTextErreur.Image = ((System.Drawing.Image)(resources.GetObject("designationTextErreur.Image")));
            this.designationTextErreur.Location = new System.Drawing.Point(271, 119);
            this.designationTextErreur.Name = "designationTextErreur";
            this.designationTextErreur.Size = new System.Drawing.Size(22, 21);
            this.designationTextErreur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.designationTextErreur.TabIndex = 39;
            this.designationTextErreur.TabStop = false;
            this.designationTextErreur.Visible = false;
            // 
            // referenceTextErreur
            // 
            this.referenceTextErreur.BackColor = System.Drawing.Color.White;
            this.referenceTextErreur.Image = ((System.Drawing.Image)(resources.GetObject("referenceTextErreur.Image")));
            this.referenceTextErreur.Location = new System.Drawing.Point(271, 158);
            this.referenceTextErreur.Name = "referenceTextErreur";
            this.referenceTextErreur.Size = new System.Drawing.Size(22, 21);
            this.referenceTextErreur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.referenceTextErreur.TabIndex = 40;
            this.referenceTextErreur.TabStop = false;
            this.referenceTextErreur.Visible = false;
            // 
            // quantiteTextErreur
            // 
            this.quantiteTextErreur.BackColor = System.Drawing.Color.White;
            this.quantiteTextErreur.Image = ((System.Drawing.Image)(resources.GetObject("quantiteTextErreur.Image")));
            this.quantiteTextErreur.Location = new System.Drawing.Point(271, 197);
            this.quantiteTextErreur.Name = "quantiteTextErreur";
            this.quantiteTextErreur.Size = new System.Drawing.Size(22, 21);
            this.quantiteTextErreur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.quantiteTextErreur.TabIndex = 41;
            this.quantiteTextErreur.TabStop = false;
            this.quantiteTextErreur.Visible = false;
            // 
            // prixTextErreur
            // 
            this.prixTextErreur.BackColor = System.Drawing.Color.White;
            this.prixTextErreur.Image = ((System.Drawing.Image)(resources.GetObject("prixTextErreur.Image")));
            this.prixTextErreur.Location = new System.Drawing.Point(271, 235);
            this.prixTextErreur.Name = "prixTextErreur";
            this.prixTextErreur.Size = new System.Drawing.Size(22, 21);
            this.prixTextErreur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.prixTextErreur.TabIndex = 42;
            this.prixTextErreur.TabStop = false;
            this.prixTextErreur.Visible = false;
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
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(37, 42);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(42, 19);
            this.metroLabel11.TabIndex = 45;
            this.metroLabel11.Text = "Client";
            // 
            // metroPanelFormulaire
            // 
            this.metroPanelFormulaire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanelFormulaire.Controls.Add(this.metroLabel11);
            this.metroPanelFormulaire.Controls.Add(this.ClientTextErreur);
            this.metroPanelFormulaire.Controls.Add(this.ClientText);
            this.metroPanelFormulaire.Controls.Add(this.prixTextErreur);
            this.metroPanelFormulaire.Controls.Add(this.quantiteTextErreur);
            this.metroPanelFormulaire.Controls.Add(this.referenceTextErreur);
            this.metroPanelFormulaire.Controls.Add(this.designationTextErreur);
            this.metroPanelFormulaire.Controls.Add(this.factureNTextErreur);
            this.metroPanelFormulaire.Controls.Add(this.closeWindowLight);
            this.metroPanelFormulaire.Controls.Add(this.metroLabel1);
            this.metroPanelFormulaire.Controls.Add(this.metroLabel2);
            this.metroPanelFormulaire.Controls.Add(this.buttonAjouterModifier);
            this.metroPanelFormulaire.Controls.Add(this.metroLabel3);
            this.metroPanelFormulaire.Controls.Add(this.factureNText);
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
            this.metroPanelFormulaire.TabIndex = 35;
            this.metroPanelFormulaire.VerticalScrollbarBarColor = true;
            this.metroPanelFormulaire.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelFormulaire.VerticalScrollbarSize = 10;
            this.metroPanelFormulaire.Visible = false;
            // 
            // Facture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroPanelFormulaire);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonCalculer);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroRadioButton20);
            this.Controls.Add(this.metroRadioButton7);
            this.Controls.Add(this.totalHT);
            this.Controls.Add(this.TVAText);
            this.Controls.Add(this.totalTTC);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroGrid);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Facture";
            this.Size = new System.Drawing.Size(900, 600);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeWindowLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factureNTextErreur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.designationTextErreur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referenceTextErreur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantiteTextErreur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixTextErreur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientTextErreur)).EndInit();
            this.metroPanelFormulaire.ResumeLayout(false);
            this.metroPanelFormulaire.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroGrid metroGrid;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox totalTTC;
        private MetroFramework.Controls.MetroTextBox TVAText;
        private MetroFramework.Controls.MetroTextBox totalHT;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton7;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton20;
        private System.Windows.Forms.Button buttonCalculer;
        private System.Windows.Forms.Button buttonSupprimer;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonModifier;
        private MetroFramework.Controls.MetroTextBox searchTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DatabaseDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private MetroFramework.Controls.MetroDateTime dateText;
        private MetroFramework.Controls.MetroTextBox prixText;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox quantiteText;
        private MetroFramework.Controls.MetroTextBox referenceText;
        private MetroFramework.Controls.MetroTextBox designationText;
        private MetroFramework.Controls.MetroTextBox factureNText;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Button buttonAjouterModifier;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox closeWindowLight;
        private System.Windows.Forms.PictureBox factureNTextErreur;
        private System.Windows.Forms.PictureBox designationTextErreur;
        private System.Windows.Forms.PictureBox referenceTextErreur;
        private System.Windows.Forms.PictureBox quantiteTextErreur;
        private System.Windows.Forms.PictureBox prixTextErreur;
        private MetroFramework.Controls.MetroComboBox ClientText;
        private System.Windows.Forms.PictureBox ClientTextErreur;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroPanel metroPanelFormulaire;
    }
}
