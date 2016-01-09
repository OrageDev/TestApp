namespace AppBaseDeDonnee
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_select = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_insert = new System.Windows.Forms.Button();
            this.txtbox_nom = new System.Windows.Forms.TextBox();
            this.txtbox_prenom = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.checkbox_delete = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(441, 198);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(100, 23);
            this.btn_select.TabIndex = 0;
            this.btn_select.Text = "SELECT ALL";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(351, 229);
            this.dataGridView1.TabIndex = 1;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(441, 101);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(100, 22);
            this.btn_insert.TabIndex = 2;
            this.btn_insert.Text = "INSERT";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // txtbox_nom
            // 
            this.txtbox_nom.Location = new System.Drawing.Point(441, 49);
            this.txtbox_nom.Name = "txtbox_nom";
            this.txtbox_nom.Size = new System.Drawing.Size(100, 20);
            this.txtbox_nom.TabIndex = 3;
            // 
            // txtbox_prenom
            // 
            this.txtbox_prenom.Location = new System.Drawing.Point(441, 75);
            this.txtbox_prenom.Name = "txtbox_prenom";
            this.txtbox_prenom.Size = new System.Drawing.Size(100, 20);
            this.txtbox_prenom.TabIndex = 4;
            // 
            // btn_delete
            // 
            this.btn_delete.Enabled = false;
            this.btn_delete.Location = new System.Drawing.Point(441, 127);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 24);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // checkbox_delete
            // 
            this.checkbox_delete.AutoSize = true;
            this.checkbox_delete.Location = new System.Drawing.Point(418, 157);
            this.checkbox_delete.Name = "checkbox_delete";
            this.checkbox_delete.Size = new System.Drawing.Size(114, 17);
            this.checkbox_delete.TabIndex = 6;
            this.checkbox_delete.Text = "Mode Suppression";
            this.checkbox_delete.UseVisualStyleBackColor = true;
            this.checkbox_delete.CheckedChanged += new System.EventHandler(this.checkbox_delete_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Entrer le nom et le prenom de la personne a enregistrer.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(580, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 259);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkbox_delete);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.txtbox_prenom);
            this.Controls.Add(this.txtbox_nom);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_select);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MaBaseDeDonnée_test";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.TextBox txtbox_nom;
        private System.Windows.Forms.TextBox txtbox_prenom;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.CheckBox checkbox_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

