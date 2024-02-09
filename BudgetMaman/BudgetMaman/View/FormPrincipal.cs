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

            fillDgvCategories();
        }

        public void fillDgvCategories()
        {
            dgvCategories.Rows.Clear();

            dgvCategories.ColumnCount = 3;

            Dictionary<int, CategorieView> dictCategories = presenter.getAllCategories();

            foreach (KeyValuePair<int, CategorieView> c in dictCategories)
            {
                addRow(c.Key, c.Value);
            }

            dgvCategories.Columns[2].Visible = false;
            dgvCategories.Columns[2].Width = 0;

            dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void resetDatagridView()
        {
            dgvCategories.Rows.Clear();

            Dictionary<int, CategorieView> dictCategories = presenter.getAllCategories();

            foreach (KeyValuePair<int, CategorieView> c in dictCategories)
            {
                addRow(c.Key, c.Value);
            }
        }

        private void btnAjouterCategories_Click(object sender, EventArgs e)
        {
            FormAjouterCategorie formAjouterCategorie = new FormAjouterCategorie(this, presenter);
            formAjouterCategorie.Show();
        }

        private void btnNouveauMois_Click(object sender, EventArgs e)
        {
            PeriodeView mois = new PeriodeView(new List<DepenseView>(), (PeriodeView.MoisEnumView)(DateTime.Now.Month), DateTime.Now);

            List<DepenseView> listDepenseView = new List<DepenseView>();

            mois.ListDepense = listDepenseView;

            presenter.addMois(mois);

            resetDatagridView();
            fillDgvCategories();
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
            if (dgvCategories.SelectedRows.Count == 1 && txtNom.Text != ""  && nUDDepense.Value > 0)
            {
                int idCategorie = int.Parse(dgvCategories.SelectedRows[0].Cells[2].Value.ToString());

                DepenseView depense = new DepenseView(txtNom.Text, rTxtMessage.Text, nUDDepense.Value,
                        idCategorie, DateTime.Now);

                presenter.addDepense(idCategorie, depense);

                MessageBox.Show("Depense ajouté");

                setRowCategorieCurrentMontant(idCategorie, int.Parse(nUDDepense.Value.ToString()));
                lblErreur.Text = "";
            }
            else if (dgvCategories.RowCount == 0)
            {
                lblErreur.Text = "Veuillez créer une categorie";
            }
            else
            {
                lblErreur.Text = "Veuillez entrer toutes les informations";
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

        public void setRowCategorieCurrentMontant(int idCategorie, int montantASoustraire)
        {
            int i = 0;
            bool trouve = false;

            DataGridViewCell cellAChanger;

            while (i < dgvCategories.RowCount && !trouve)
            {
                int idCategorieRow = int.Parse(dgvCategories.Rows[i].Cells[2].Value.ToString());

                if (idCategorie == idCategorieRow)
                {
                    trouve = true;
                    cellAChanger = dgvCategories.Rows[i].Cells[1];
                    int currentValeurCell = int.Parse(cellAChanger.Value.ToString());
                    cellAChanger.Value = currentValeurCell - montantASoustraire;
                }
                else
                {
                    i++;
                }
            };
        }
    }
}