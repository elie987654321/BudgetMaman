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
            tableLayoutBoutons = new TableLayoutPanel();
            btnModifierCategorie = new Button();
            btnNouveauMois = new Button();
            btnSupprimerCategorie = new Button();
            btnAjouterCategories = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDDepense).BeginInit();
            gbAjouterDepense.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutBoutons.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCategories
            // 
            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.AllowUserToDeleteRows = false;
            dgvCategories.ColumnHeadersHeight = 29;
            dgvCategories.Dock = DockStyle.Right;
            dgvCategories.Location = new Point(1127, 0);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.RowHeadersWidth = 51;
            dgvCategories.RowTemplate.Height = 29;
            dgvCategories.Size = new Size(701, 1023);
            dgvCategories.TabIndex = 9;
            dgvCategories.CellEndEdit += dgvCategories_CellEndEdit;
            // 
            // lblErreur
            // 
            lblErreur.AutoSize = true;
            lblErreur.ForeColor = Color.Crimson;
            lblErreur.Location = new Point(361, 35);
            lblErreur.Name = "lblErreur";
            lblErreur.Size = new Size(0, 20);
            lblErreur.TabIndex = 14;
            // 
            // lblDebutPeriode
            // 
            lblDebutPeriode.Anchor = AnchorStyles.None;
            lblDebutPeriode.AutoSize = true;
            lblDebutPeriode.Location = new Point(201, 28);
            lblDebutPeriode.Name = "lblDebutPeriode";
            lblDebutPeriode.Size = new Size(0, 20);
            lblDebutPeriode.TabIndex = 16;
            // 
            // btnAjouterDepense
            // 
            btnAjouterDepense.Location = new Point(383, 291);
            btnAjouterDepense.Name = "btnAjouterDepense";
            btnAjouterDepense.Size = new Size(191, 96);
            btnAjouterDepense.TabIndex = 8;
            btnAjouterDepense.Text = "Ajouter";
            btnAjouterDepense.UseVisualStyleBackColor = true;
            btnAjouterDepense.Click += btnAjouterDepense_Click;
            // 
            // nUDDepense
            // 
            nUDDepense.Location = new Point(33, 116);
            nUDDepense.Maximum = new decimal(new int[] { 200000, 0, 0, 0 });
            nUDDepense.Name = "nUDDepense";
            nUDDepense.Size = new Size(182, 27);
            nUDDepense.TabIndex = 5;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(33, 51);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(192, 27);
            txtNom.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 26);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 10;
            label1.Text = "Nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 161);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 11;
            label2.Text = "Message";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 90);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 12;
            label3.Text = "Montant";
            // 
            // rTxtMessage
            // 
            rTxtMessage.Location = new Point(33, 201);
            rTxtMessage.Name = "rTxtMessage";
            rTxtMessage.Size = new Size(334, 186);
            rTxtMessage.TabIndex = 6;
            rTxtMessage.Text = "";
            // 
            // btnAnnuler
            // 
            btnAnnuler.Location = new Point(383, 182);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(191, 96);
            btnAnnuler.TabIndex = 13;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = true;
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // gbAjouterDepense
            // 
            gbAjouterDepense.Controls.Add(lblErreur);
            gbAjouterDepense.Controls.Add(btnAnnuler);
            gbAjouterDepense.Controls.Add(rTxtMessage);
            gbAjouterDepense.Controls.Add(label3);
            gbAjouterDepense.Controls.Add(label2);
            gbAjouterDepense.Controls.Add(label1);
            gbAjouterDepense.Controls.Add(txtNom);
            gbAjouterDepense.Controls.Add(nUDDepense);
            gbAjouterDepense.Controls.Add(btnAjouterDepense);
            gbAjouterDepense.Dock = DockStyle.Left;
            gbAjouterDepense.Location = new Point(0, 0);
            gbAjouterDepense.Name = "gbAjouterDepense";
            gbAjouterDepense.Size = new Size(621, 748);
            gbAjouterDepense.TabIndex = 6;
            gbAjouterDepense.TabStop = false;
            gbAjouterDepense.Text = "Ajouter une depense";
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutBoutons);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 748);
            panel1.Name = "panel1";
            panel1.Size = new Size(1127, 275);
            panel1.TabIndex = 17;
            // 
            // tableLayoutBoutons
            // 
            tableLayoutBoutons.ColumnCount = 3;
            tableLayoutBoutons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutBoutons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutBoutons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutBoutons.Controls.Add(btnModifierCategorie, 2, 0);
            tableLayoutBoutons.Controls.Add(btnNouveauMois, 2, 1);
            tableLayoutBoutons.Controls.Add(btnSupprimerCategorie, 1, 0);
            tableLayoutBoutons.Controls.Add(btnAjouterCategories, 1, 1);
            tableLayoutBoutons.Location = new Point(12, 48);
            tableLayoutBoutons.Name = "tableLayoutBoutons";
            tableLayoutBoutons.RowCount = 2;
            tableLayoutBoutons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutBoutons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutBoutons.Size = new Size(633, 215);
            tableLayoutBoutons.TabIndex = 15;
            // 
            // btnModifierCategorie
            // 
            btnModifierCategorie.Location = new Point(425, 3);
            btnModifierCategorie.Name = "btnModifierCategorie";
            btnModifierCategorie.Size = new Size(194, 77);
            btnModifierCategorie.TabIndex = 15;
            btnModifierCategorie.Text = "Modifier une categorie";
            btnModifierCategorie.UseVisualStyleBackColor = true;
            btnModifierCategorie.Click += btnModifierCategorie_Click;
            // 
            // btnNouveauMois
            // 
            btnNouveauMois.Location = new Point(425, 110);
            btnNouveauMois.Name = "btnNouveauMois";
            btnNouveauMois.Size = new Size(194, 77);
            btnNouveauMois.TabIndex = 3;
            btnNouveauMois.Text = "Nouvelle periode";
            btnNouveauMois.UseVisualStyleBackColor = true;
            btnNouveauMois.Click += btnNouveauMois_Click;
            // 
            // btnSupprimerCategorie
            // 
            btnSupprimerCategorie.Location = new Point(214, 3);
            btnSupprimerCategorie.Name = "btnSupprimerCategorie";
            btnSupprimerCategorie.Size = new Size(194, 77);
            btnSupprimerCategorie.TabIndex = 2;
            btnSupprimerCategorie.Text = "Supprimer une categorie";
            btnSupprimerCategorie.UseVisualStyleBackColor = true;
            btnSupprimerCategorie.Click += btnSupprimerCategorie_Click;
            // 
            // btnAjouterCategories
            // 
            btnAjouterCategories.Location = new Point(214, 110);
            btnAjouterCategories.Name = "btnAjouterCategories";
            btnAjouterCategories.Size = new Size(194, 77);
            btnAjouterCategories.TabIndex = 1;
            btnAjouterCategories.Text = "Ajouter une categorie";
            btnAjouterCategories.UseVisualStyleBackColor = true;
            btnAjouterCategories.Click += btnAjouterCategories_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1828, 1023);
            Controls.Add(gbAjouterDepense);
            Controls.Add(lblDebutPeriode);
            Controls.Add(panel1);
            Controls.Add(dgvCategories);
            Name = "FormPrincipal";
            Resize += FormPrincipal_Resize;
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDDepense).EndInit();
            gbAjouterDepense.ResumeLayout(false);
            gbAjouterDepense.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutBoutons.ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutBoutons;
    }
}