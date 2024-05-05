namespace BudgetMaman
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvCategories = new DataGridView();
            nUDDepense = new NumericUpDown();
            btnNouveauMois = new Button();
            btnAjouterDepense = new Button();
            groupBox1 = new GroupBox();
            rTxtMessage = new RichTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtNom = new TextBox();
            lblErreur = new Label();
            btnAjouterCategories = new Button();
            btnSupprimerCategorie = new Button();
            btnModifierCategorie = new Button();
            lblDebutPeriode = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDDepense).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCategories
            // 
            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.AllowUserToDeleteRows = false;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(455, 99);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.RowHeadersWidth = 51;
            dgvCategories.RowTemplate.Height = 29;
            dgvCategories.Size = new Size(408, 331);
            dgvCategories.TabIndex = 9;
            dgvCategories.CellEndEdit += dgvCategories_CellEndEdit;
            // 
            // nUDDepense
            // 
            nUDDepense.Location = new Point(154, 53);
            nUDDepense.Maximum = new decimal(new int[] { 200000, 0, 0, 0 });
            nUDDepense.Name = "nUDDepense";
            nUDDepense.Size = new Size(91, 27);
            nUDDepense.TabIndex = 5;
            // 
            // btnNouveauMois
            // 
            btnNouveauMois.Location = new Point(91, 219);
            btnNouveauMois.Name = "btnNouveauMois";
            btnNouveauMois.Size = new Size(197, 43);
            btnNouveauMois.TabIndex = 3;
            btnNouveauMois.Text = "Nouvelle periode";
            btnNouveauMois.UseVisualStyleBackColor = true;
            btnNouveauMois.Click += btnNouveauMois_Click;
            // 
            // btnAjouterDepense
            // 
            btnAjouterDepense.Location = new Point(246, 133);
            btnAjouterDepense.Name = "btnAjouterDepense";
            btnAjouterDepense.Size = new Size(97, 40);
            btnAjouterDepense.TabIndex = 8;
            btnAjouterDepense.Text = "Ajouter";
            btnAjouterDepense.UseVisualStyleBackColor = true;
            btnAjouterDepense.Click += btnAjouterDepense_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rTxtMessage);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNom);
            groupBox1.Controls.Add(nUDDepense);
            groupBox1.Controls.Add(btnAjouterDepense);
            groupBox1.Location = new Point(11, 267);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(363, 259);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ajouter une depense";
            // 
            // rTxtMessage
            // 
            rTxtMessage.Location = new Point(18, 133);
            rTxtMessage.Name = "rTxtMessage";
            rTxtMessage.Size = new Size(206, 92);
            rTxtMessage.TabIndex = 6;
            rTxtMessage.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(154, 29);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 12;
            label3.Text = "Montant";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 99);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 11;
            label2.Text = "Message";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 29);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 10;
            label1.Text = "Nom";
            // 
            // txtNom
            // 
            txtNom.Location = new Point(18, 53);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(125, 27);
            txtNom.TabIndex = 4;
            // 
            // lblErreur
            // 
            lblErreur.AutoSize = true;
            lblErreur.ForeColor = Color.Crimson;
            lblErreur.Location = new Point(400, 439);
            lblErreur.Name = "lblErreur";
            lblErreur.Size = new Size(0, 20);
            lblErreur.TabIndex = 14;
            // 
            // btnAjouterCategories
            // 
            btnAjouterCategories.Location = new Point(91, 29);
            btnAjouterCategories.Name = "btnAjouterCategories";
            btnAjouterCategories.Size = new Size(197, 44);
            btnAjouterCategories.TabIndex = 1;
            btnAjouterCategories.Text = "Ajouter une categorie";
            btnAjouterCategories.UseVisualStyleBackColor = true;
            btnAjouterCategories.Click += btnAjouterCategories_Click;
            // 
            // btnSupprimerCategorie
            // 
            btnSupprimerCategorie.Location = new Point(91, 80);
            btnSupprimerCategorie.Name = "btnSupprimerCategorie";
            btnSupprimerCategorie.Size = new Size(197, 44);
            btnSupprimerCategorie.TabIndex = 2;
            btnSupprimerCategorie.Text = "Supprimer une categorie";
            btnSupprimerCategorie.UseVisualStyleBackColor = true;
            btnSupprimerCategorie.Click += btnSupprimerCategorie_Click;
            // 
            // btnModifierCategorie
            // 
            btnModifierCategorie.Location = new Point(91, 131);
            btnModifierCategorie.Name = "btnModifierCategorie";
            btnModifierCategorie.Size = new Size(197, 44);
            btnModifierCategorie.TabIndex = 15;
            btnModifierCategorie.Text = "Modifier une categorie";
            btnModifierCategorie.UseVisualStyleBackColor = true;
            btnModifierCategorie.Click += btnModifierCategorie_Click;
            // 
            // lblDebutPeriode
            // 
            lblDebutPeriode.AutoSize = true;
            lblDebutPeriode.Location = new Point(455, 53);
            lblDebutPeriode.Name = "lblDebutPeriode";
            lblDebutPeriode.Size = new Size(0, 20);
            lblDebutPeriode.TabIndex = 16;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 537);
            Controls.Add(lblDebutPeriode);
            Controls.Add(btnModifierCategorie);
            Controls.Add(lblErreur);
            Controls.Add(btnSupprimerCategorie);
            Controls.Add(btnAjouterCategories);
            Controls.Add(btnNouveauMois);
            Controls.Add(dgvCategories);
            Controls.Add(groupBox1);
            Name = "FormPrincipal";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDDepense).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCategories;
        private NumericUpDown nUDDepense;
        private Button btnNouveauMois;
        private Button btnAjouterDepense;
        private GroupBox groupBox1;
        private Button btnAjouterCategories;
        private Button btnSupprimerCategorie;
        private TextBox txtNom;
        private Label label2;
        private Label label1;
        private Label label3;
        private RichTextBox rTxtMessage;
        private Label lblErreur;
        private Button btnModifierCategorie;
        private Label lblDebutPeriode;
    }
}