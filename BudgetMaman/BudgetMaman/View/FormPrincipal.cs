using BudgetMaman.Model;
using BudgetMaman.View;
using BudgetMaman.View.ClassesView;
using BudgetMaman.View.InterfaceView;

namespace BudgetMaman
{
    public partial class FormPrincipal : System.Windows.Forms.Form
    {
        private IPresenterClass presenter;

        public FormPrincipal(IPresenterClass presenter)
        {
            InitializeComponent();
            this.presenter = presenter;

            FillDgvCategories();
        }

        public void FillDgvCategories()
        {
            dgvCategories.ColumnCount = 3;

            Dictionary<int, CategorieView> dictCategories = presenter.getAllCategories();

            foreach (KeyValuePair<int,CategorieView> c in dictCategories)
            {
                addRow(c.Key, c.Value);
            }

            dgvCategories.Columns[2].Visible = false;
            dgvCategories.Columns[2].Width = 0;

            dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void ResetDatagridView()
        {
            dgvCategories.Rows.Clear();

            Dictionary<int ,CategorieView> dictCategories = presenter.getAllCategories();

            foreach (KeyValuePair<int, CategorieView> c in dictCategories)
            {
                addRow(c.Key, c.Value);
            }

        }

        

        private void btnAjouterCategories_Click(object sender, EventArgs e)
        {
            FormAjouterCategorie formAjouterCategorie = new FormAjouterCategorie(presenter);
            formAjouterCategorie.Show();
        }

        private void btnNouveauMois_Click(object sender, EventArgs e)
        {
            MoisView mois = new MoisView(new List<DepenseView>(), (MoisView.MoisEnumView)(DateTime.Now.Month), DateTime.Now);

            List<DepenseView> listDepenseView = new List<DepenseView>();

            for (int i = 0; i < dgvCategories.RowCount; i++)
            {
                DataGridViewRow row = dgvCategories.Rows[i];
            }

            presenter.addMois(mois);
        }

        private void btnSupprimerCategorie_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count == 1)
            {
                int idCategorieASupprimer = int.Parse(dgvCategories.SelectedCells[2].Value.ToString());

                presenter.deleteCategorie(idCategorieASupprimer);
                dgvCategories.Rows.RemoveAt(dgvCategories.SelectedRows[0].Index);
            }
        }

        private void btnAjouterDepense_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count == 1 && txtNom.Text != "" && rTxtMessage.Text != "" && nUDDepense.Value > 0)
            {
                int idCategorie = int.Parse(dgvCategories.SelectedRows[0].Cells[2].Value.ToString());

                DepenseView depense = new DepenseView(txtNom.Text, rTxtMessage.Text, nUDDepense.Value,
                        idCategorie, DateTime.Now);

                presenter.addDepense(idCategorie, depense);

                MessageBox.Show("Depense ajouté");

                FillDgvCategories();
                ResetDatagridView();
            }
        }
        public void addRow(int idCategorie, CategorieView categorie)
        {
            String[] rowData =
                {
                    categorie.Nom,
                    categorie.CurrentMontant.ToString(),
                    idCategorie.ToString()
                };

            dgvCategories.Rows.Add(rowData);
        }
    }
}