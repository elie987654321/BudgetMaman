namespace BudgetMaman.View
{
    partial class FormHistoriqueSelectPeriode
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
            lblSelectionPeriode = new Label();
            listViewPeriode = new ListView();
            btnVoirDepenses = new Button();
            btnAnnuler = new Button();
            SuspendLayout();
            // 
            // lblSelectionPeriode
            // 
            lblSelectionPeriode.AutoSize = true;
            lblSelectionPeriode.Location = new Point(33, 55);
            lblSelectionPeriode.Name = "lblSelectionPeriode";
            lblSelectionPeriode.Size = new Size(228, 20);
            lblSelectionPeriode.TabIndex = 0;
            lblSelectionPeriode.Text = "Veuillez selectionner une periode";
            // 
            // listViewPeriode
            // 
            listViewPeriode.Location = new Point(33, 95);
            listViewPeriode.Name = "listViewPeriode";
            listViewPeriode.Size = new Size(441, 290);
            listViewPeriode.TabIndex = 1;
            listViewPeriode.UseCompatibleStateImageBehavior = false;
            // 
            // btnVoirDepenses
            // 
            btnVoirDepenses.Location = new Point(516, 132);
            btnVoirDepenses.Name = "btnVoirDepenses";
            btnVoirDepenses.Size = new Size(166, 74);
            btnVoirDepenses.TabIndex = 2;
            btnVoirDepenses.Text = "Voir les depenses";
            btnVoirDepenses.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            btnAnnuler.Location = new Point(516, 229);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(166, 74);
            btnAnnuler.TabIndex = 3;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // FormHistoriqueSelectPeriode
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 450);
            Controls.Add(btnAnnuler);
            Controls.Add(btnVoirDepenses);
            Controls.Add(listViewPeriode);
            Controls.Add(lblSelectionPeriode);
            Name = "FormHistoriqueSelectPeriode";
            Text = "FormHistoriqueSelectPeriode";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSelectionPeriode;
        private ListView listViewPeriode;
        private Button btnVoirDepenses;
        private Button btnAnnuler;
    }
}