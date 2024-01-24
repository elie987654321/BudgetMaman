using BudgetMaman.Model;
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
    public partial class FormAjouterCategorie : Form
    {
        public FormPrincipal formPrincipal;

        public IPresenterClass presenter;

        public FormAjouterCategorie(FormPrincipal formPrincipal , IPresenterClass presenter)
        {
            InitializeComponent();
            this.presenter = presenter;

            this.formPrincipal = formPrincipal;
        }

        private void btnAjouterCategorie_Click(object sender, EventArgs e)
        {
            if (txtNom.Text != "" && nudBudgetCategorie.Value > 0)
            {
                CategorieView categorieView = new CategorieView( txtNom.Text, nudBudgetCategorie.Value, nudBudgetCategorie.Value);
                presenter.addCategorie(categorieView);
                presenter.save();

                formPrincipal.addRow();
            }

            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
