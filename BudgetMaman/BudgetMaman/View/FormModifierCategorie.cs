using BudgetMaman.View.ClassesView;
using BudgetMaman.View.InterfaceView;
using Dev;


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
            montantDepenser = categorieView.MontantDebut - categorieView.CurrentMontant;
            SetChainesFrancais();
        }

        public void SetChainesFrancais()
        {
            this.lblNom.Text = Langue.FormModifierCategorie.getLblNom();
            this.lblBudget.Text = Langue.FormModifierCategorie.getLblBudget();
            this.btnAnnuler.Text = Langue.FormModifierCategorie.getBtnAnnuler();
            this.btnModifierCategorie.Text = Langue.FormModifierCategorie.getBtnModifier();
        }


        private void btnModifierCategorie_Click_1(object sender, EventArgs e)
        {
            if (txtNom.Text != "" && nudBudgetCategorie.Value > 0)
            {
                CategorieView categorieView = new CategorieView(txtNom.Text, nudBudgetCategorie.Value, nudBudgetCategorie.Value - montantDepenser);
                presenter.ModifierCategorie(idCategorie, categorieView);
                presenter.Save();

                formPrincipal.modifierRowCategorie(categorieView);
                formPrincipal.Enabled = true;
                this.Close();
            }
        }


        private void FormModifierCategorie_FormClosing(object sender, FormClosingEventArgs e)
        {
            formPrincipal.Enabled = true;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
