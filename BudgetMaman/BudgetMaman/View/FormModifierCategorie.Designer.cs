namespace BudgetMaman.View
{
    partial class FormModifierCategorie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nudBudgetCategorie = new NumericUpDown();
            txtNom = new TextBox();
            btnAnnuler = new Button();
            btnModifierCategorie = new Button();
            lblBudget = new Label();
            lblNom = new Label();
            ((System.ComponentModel.ISupportInitialize)nudBudgetCategorie).BeginInit();
            SuspendLayout();
            // 
            // nudBudgetCategorie
            // 
            nudBudgetCategorie.Location = new Point(31, 162);
            nudBudgetCategorie.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudBudgetCategorie.Name = "nudBudgetCategorie";
            nudBudgetCategorie.Size = new Size(150, 27);
            nudBudgetCategorie.TabIndex = 11;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(31, 72);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(150, 27);
            txtNom.TabIndex = 10;
            // 
            // btnAnnuler
            // 
            btnAnnuler.Location = new Point(215, 139);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(137, 50);
            btnAnnuler.TabIndex = 9;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = true;
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // btnModifierCategorie
            // 
            btnModifierCategorie.Location = new Point(215, 60);
            btnModifierCategorie.Name = "btnModifierCategorie";
            btnModifierCategorie.Size = new Size(137, 50);
            btnModifierCategorie.TabIndex = 8;
            btnModifierCategorie.Text = "Modifier";
            btnModifierCategorie.UseVisualStyleBackColor = true;
            btnModifierCategorie.Click += btnModifierCategorie_Click_1;
            // 
            // lblBudget
            // 
            lblBudget.AutoSize = true;
            lblBudget.Location = new Point(31, 139);
            lblBudget.Name = "lblBudget";
            lblBudget.Size = new Size(57, 20);
            lblBudget.TabIndex = 7;
            lblBudget.Text = "Budget";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(31, 49);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(42, 20);
            lblNom.TabIndex = 6;
            lblNom.Text = "Nom";
            // 
            // FormModifierCategorie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 238);
            Controls.Add(nudBudgetCategorie);
            Controls.Add(txtNom);
            Controls.Add(btnAnnuler);
            Controls.Add(btnModifierCategorie);
            Controls.Add(lblBudget);
            Controls.Add(lblNom);
            Name = "FormModifierCategorie";
            Text = "FormModifierCategorie";
            FormClosing += FormModifierCategorie_FormClosing;
            ((System.ComponentModel.ISupportInitialize)nudBudgetCategorie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudBudgetCategorie;
        private TextBox txtNom;
        private Button btnAnnuler;
        private Button btnModifierCategorie;
        private Label lblBudget;
        private Label lblNom;
    }
}