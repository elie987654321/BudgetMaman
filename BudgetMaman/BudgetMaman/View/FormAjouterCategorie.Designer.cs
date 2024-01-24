namespace BudgetMaman.View
{
    partial class FormAjouterCategorie
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
            label1 = new Label();
            label2 = new Label();
            btnAjouterCategorie = new Button();
            btnAnnuler = new Button();
            txtNom = new TextBox();
            nudBudgetCategorie = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudBudgetCategorie).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 27);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 0;
            label1.Text = "Nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 117);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 1;
            label2.Text = "Budget";
            // 
            // btnAjouterCategorie
            // 
            btnAjouterCategorie.Location = new Point(204, 38);
            btnAjouterCategorie.Name = "btnAjouterCategorie";
            btnAjouterCategorie.Size = new Size(137, 50);
            btnAjouterCategorie.TabIndex = 2;
            btnAjouterCategorie.Text = "Ajouter";
            btnAjouterCategorie.UseVisualStyleBackColor = true;
            btnAjouterCategorie.Click += btnAjouterCategorie_Click;
            // 
            // btnAnnuler
            // 
            btnAnnuler.Location = new Point(204, 117);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(137, 50);
            btnAnnuler.TabIndex = 3;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = true;
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(20, 50);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(150, 27);
            txtNom.TabIndex = 4;
            // 
            // nudBudgetCategorie
            // 
            nudBudgetCategorie.Location = new Point(20, 140);
            nudBudgetCategorie.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudBudgetCategorie.Name = "nudBudgetCategorie";
            nudBudgetCategorie.Size = new Size(150, 27);
            nudBudgetCategorie.TabIndex = 5;
            // 
            // FormAjouterCategorie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 214);
            Controls.Add(nudBudgetCategorie);
            Controls.Add(txtNom);
            Controls.Add(btnAnnuler);
            Controls.Add(btnAjouterCategorie);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAjouterCategorie";
            Text = "FormAjouterCategorie";
            ((System.ComponentModel.ISupportInitialize)nudBudgetCategorie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnAjouterCategorie;
        private Button btnAnnuler;
        private TextBox txtNom;
        private NumericUpDown nudBudgetCategorie;
    }
}