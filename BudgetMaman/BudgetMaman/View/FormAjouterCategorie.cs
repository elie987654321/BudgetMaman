using BudgetMaman.View.ClassesView;
using BudgetMaman.View.InterfaceView;
using BudgetMaman.View.ClassesView;
using Dev;

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

        public void SetChainesFrancais()
        {
            lblNom.Text = Langue.FormAjouterCategorie.getLblNom();
            lblBudget.Text = Langue.FormAjouterCategorie.getBudget();
            btnAjouterCategorie.Text = Langue.FormAjouterCategorie.getBtnAjouter();
            btnAnnuler.Text = Langue.FormAjouterCategorie.getBtnAnnuler();
        }

        private void btnAjouterCategorie_Click(object sender, EventArgs e)
        {
            if (txtNom.Text != "" && nudBudgetCategorie.Value > 0)
            {
                CategorieView categorieView = new CategorieView(txtNom.Text, nudBudgetCategorie.Value, nudBudgetCategorie.Value);
                int idCategorie = presenter.AddCategorie(categorieView);
                presenter.Save();

                formPrincipal.addRow(idCategorie, categorieView);
            }

            //TODO retroaction si pas toutes les informations

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
