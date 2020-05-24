namespace GestionFactures
{
    partial class Acceuil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acceuil));
            this.acceuilPanel = new System.Windows.Forms.Panel();
            this.bienvenue = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.acceuilPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bienvenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // acceuilPanel
            // 
            this.acceuilPanel.Controls.Add(this.bienvenue);
            this.acceuilPanel.Controls.Add(this.background);
            this.acceuilPanel.Location = new System.Drawing.Point(0, 0);
            this.acceuilPanel.Name = "acceuilPanel";
            this.acceuilPanel.Size = new System.Drawing.Size(900, 600);
            this.acceuilPanel.TabIndex = 0;
            // 
            // bienvenue
            // 
            this.bienvenue.BackColor = System.Drawing.Color.White;
            this.bienvenue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bienvenue.Image = ((System.Drawing.Image)(resources.GetObject("bienvenue.Image")));
            this.bienvenue.Location = new System.Drawing.Point(98, 352);
            this.bienvenue.Name = "bienvenue";
            this.bienvenue.Size = new System.Drawing.Size(294, 46);
            this.bienvenue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bienvenue.TabIndex = 8;
            this.bienvenue.TabStop = false;
            this.bienvenue.Click += new System.EventHandler(this.bienvenue_Click);
            // 
            // background
            // 
            this.background.Image = ((System.Drawing.Image)(resources.GetObject("background.Image")));
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(903, 602);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.background.TabIndex = 5;
            this.background.TabStop = false;
            this.background.MouseDown += new System.Windows.Forms.MouseEventHandler(this.background_MouseDown);
            this.background.MouseMove += new System.Windows.Forms.MouseEventHandler(this.background_MouseMove);
            this.background.MouseUp += new System.Windows.Forms.MouseEventHandler(this.background_MouseUp);
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.acceuilPanel);
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Acceuil";
            this.Size = new System.Drawing.Size(900, 600);
            this.acceuilPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bienvenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel acceuilPanel;
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox bienvenue;
    }
}
