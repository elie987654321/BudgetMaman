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
            lblErreur = new Label();
            lblDebutPeriode = new Label();
            btnAjouterDepense = new Button();
            nUDDepense = new NumericUpDown();
            txtNom = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            rTxtMessage = new RichTextBox();
            btnAnnuler = new Button();
            gbAjouterDepense = new GroupBox();
            panel1 = new Panel();
            btnSupprimerCategorie = new Button();
            btnNouveauMois = new Button();
            btnModifierCategorie = new Button();
            btnAjouterCategories = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDDepense).BeginInit();
            gbAjouterDepense.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCategories
            // 
            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.AllowUserToDeleteRows = false;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Dock = DockStyle.Right;
            dgvCategories.Location = new Point(642, 0);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.RowHeadersWidth = 51;
            dgvCategories.RowTemplate.Height = 29;
            dgvCategories.Size = new Size(622, 718);
            dgvCategories.TabIndex = 9;
            dgvCategories.CellEndEdit += dgvCategories_CellEndEdit;
            // 
            // lblErreur
            // 
            lblErreur.AutoSize = true;
            lblErreur.ForeColor = Color.Crimson;
            lblErreur.Location = new Point(370, 483);
            lblErreur.Name = "lblErreur";
            lblErreur.Size = new Size(0, 20);
            lblErreur.TabIndex = 14;
            // 
            // lblDebutPeriode
            // 
            lblDebutPeriode.AutoSize = true;
            lblDebutPeriode.Location = new Point(183, 30);
            lblDebutPeriode.Name = "lblDebutPeriode";
            lblDebutPeriode.Size = new Size(0, 20);
            lblDebutPeriode.TabIndex = 16;
            // 
            // btnAjouterDepense
            // 
            btnAjouterDepense.Location = new Point(385, 126);
            btnAjouterDepense.Name = "btnAjouterDepense";
            btnAjouterDepense.Size = new Size(190, 72);
            btnAjouterDepense.TabIndex = 8;
            btnAjouterDepense.Text = "Ajouter";
            btnAjouterDepense.UseVisualStyleBackColor = true;
            btnAjouterDepense.Click += btnAjouterDepense_Click;
            // 
            // nUDDepense
            // 
            nUDDepense.Location = new Point(203, 53);
            nUDDepense.Maximum = new decimal(new int[] { 200000, 0, 0, 0 });
            nUDDepense.Name = "nUDDepense";
            nUDDepense.Size = new Size(176, 27);
            nUDDepense.TabIndex = 5;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(18, 53);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(179, 27);
            txtNom.TabIndex = 4;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 83);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 11;
            label2.Text = "Message";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(214, 23);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 12;
            label3.Text = "Montant";
            // 
            // rTxtMessage
            // 
            rTxtMessage.Location = new Point(46, 106);
            rTxtMessage.Name = "rTxtMessage";
            rTxtMessage.Size = new Size(291, 92);
            rTxtMessage.TabIndex = 6;
            rTxtMessage.Text = "";
            // 
            // btnAnnuler
            // 
            btnAnnuler.Location = new Point(385, 29);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(190, 70);
            btnAnnuler.TabIndex = 13;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = true;
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // gbAjouterDepense
            // 
            gbAjouterDepense.Controls.Add(btnAnnuler);
            gbAjouterDepense.Controls.Add(rTxtMessage);
            gbAjouterDepense.Controls.Add(label3);
            gbAjouterDepense.Controls.Add(label2);
            gbAjouterDepense.Controls.Add(label1);
            gbAjouterDepense.Controls.Add(txtNom);
            gbAjouterDepense.Controls.Add(nUDDepense);
            gbAjouterDepense.Controls.Add(btnAjouterDepense);
            gbAjouterDepense.Location = new Point(12, 12);
            gbAjouterDepense.Name = "gbAjouterDepense";
            gbAjouterDepense.Size = new Size(595, 204);
            gbAjouterDepense.TabIndex = 6;
            gbAjouterDepense.TabStop = false;
            gbAjouterDepense.Text = "Ajouter une depense";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSupprimerCategorie);
            panel1.Controls.Add(btnNouveauMois);
            panel1.Controls.Add(btnModifierCategorie);
            panel1.Controls.Add(btnAjouterCategories);
            panel1.Location = new Point(12, 230);
            panel1.Name = "panel1";
            panel1.Size = new Size(595, 323);
            panel1.TabIndex = 17;
            // 
            // btnSupprimerCategorie
            // 
            btnSupprimerCategorie.Location = new Point(65, 13);
            btnSupprimerCategorie.Name = "btnSupprimerCategorie";
            btnSupprimerCategorie.Size = new Size(428, 69);
            btnSupprimerCategorie.TabIndex = 2;
            btnSupprimerCategorie.Text = "Supprimer une categorie";
            btnSupprimerCategorie.UseVisualStyleBackColor = true;
            btnSupprimerCategorie.Click += btnSupprimerCategorie_Click;
            // 
            // btnNouveauMois
            // 
            btnNouveauMois.Location = new Point(65, 239);
            btnNouveauMois.Name = "btnNouveauMois";
            btnNouveauMois.Size = new Size(428, 69);
            btnNouveauMois.TabIndex = 3;
            btnNouveauMois.Text = "Nouvelle periode";
            btnNouveauMois.UseVisualStyleBackColor = true;
            btnNouveauMois.Click += btnNouveauMois_Click;
            // 
            // btnModifierCategorie
            // 
            btnModifierCategorie.Location = new Point(65, 91);
            btnModifierCategorie.Name = "btnModifierCategorie";
            btnModifierCategorie.Size = new Size(428, 67);
            btnModifierCategorie.TabIndex = 15;
            btnModifierCategorie.Text = "Modifier une categorie";
            btnModifierCategorie.UseVisualStyleBackColor = true;
            btnModifierCategorie.Click += btnModifierCategorie_Click;
            // 
            // btnAjouterCategories
            // 
            btnAjouterCategories.Location = new Point(65, 164);
            btnAjouterCategories.Name = "btnAjouterCategories";
            btnAjouterCategories.Size = new Size(428, 68);
            btnAjouterCategories.TabIndex = 1;
            btnAjouterCategories.Text = "Ajouter une categorie";
            btnAjouterCategories.UseVisualStyleBackColor = true;
            btnAjouterCategories.Click += btnAjouterCategories_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 718);
            Controls.Add(gbAjouterDepense);
            Controls.Add(panel1);
            Controls.Add(lblDebutPeriode);
            Controls.Add(lblErreur);
            Controls.Add(dgvCategories);
            Name = "FormPrincipal";
            Text = "Form1";
            Resize += FormPrincipal_Resize;
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDDepense).EndInit();
            gbAjouterDepense.ResumeLayout(false);
            gbAjouterDepense.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCategories;
        private Label lblErreur;
        private Label lblDebutPeriode;
        private Button btnAjouterDepense;
        private NumericUpDown nUDDepense;
        private TextBox txtNom;
        private Label label1;
        private Label label2;
        private Label label3;
        private RichTextBox rTxtMessage;
        private Button btnAnnuler;
        private GroupBox gbAjouterDepense;
        private Panel panel1;
        private Button btnSupprimerCategorie;
        private Button btnNouveauMois;
        private Button btnModifierCategorie;
        private Button btnAjouterCategories;
    }
}