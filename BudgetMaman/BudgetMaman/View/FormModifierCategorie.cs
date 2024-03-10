using BudgetMaman.View.ClassesView;
using BudgetMaman.View.InterfaceView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetMaman.View
{
    public partial class FormModifierCategorie : Form
    {
        private IPresenterClass presenter;
        private FormPrincipal formPrincipal;

        private int idCategorie;
        private decimal montantDepenser;

        public FormModifierCategorie(int idCategorie, CategorieView categorieView, FormPrincipal formPrincipal, IPresenterClass presenter)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
            this.presenter = presenter;

            this.idCategorie = idCategorie;
            txtNom.Text = categorieView.Nom;
            nudBudgetCategorie.Value = categorieView.MontantDebut;
            montantDepenser = categorieView.MontantDebut  - categorieView.CurrentMontant;
        }


        private void btnModifierCategorie_Click_1(object sender, EventArgs e)
        {
            if (txtNom.Text != "" && nudBudgetCategorie.Value > 0)
            {
                CategorieView categorieView = new CategorieView(txtNom.Text, nudBudgetCategorie.Value, nudBudgetCategorie.Value - montantDepenser);
                presenter.modifierCategorie(idCategorie ,categorieView);
                presenter.save();

                formPrincipal.modifierRowCategorie(categorieView);
                formPrincipal.Enabled = true;
                this.Close();
            }
        }
    }
}
