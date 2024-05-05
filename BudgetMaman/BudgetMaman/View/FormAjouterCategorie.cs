using BudgetMaman.Model;
using BudgetMaman.View.ClassesView;
using BudgetMaman.View.InterfaceView;

namespace BudgetMaman.View
{
    public partial class FormAjouterCategorie : Form
    {
        public FormPrincipal formPrincipal;

        public IPresenterClass presenter;

        public FormAjouterCategorie(FormPrincipal formPrincipal, IPresenterClass presenter)
        {
            InitializeComponent();
            this.presenter = presenter;

            this.formPrincipal = formPrincipal;
        }

        private void btnAjouterCategorie_Click(object sender, EventArgs e)
        {
            if (txtNom.Text != "" && nudBudgetCategorie.Value > 0)
            {
                CategorieView categorieView = new CategorieView(txtNom.Text, nudBudgetCategorie.Value, nudBudgetCategorie.Value);
                int idCategorie = presenter.addCategorie(categorieView);
                presenter.save();

                formPrincipal.addRow(idCategorie, categorieView);
            }

            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAjouterCategorie_FormClosing(object sender, FormClosingEventArgs e)
        {
            formPrincipal.Enabled = true;
        }
    }
}
