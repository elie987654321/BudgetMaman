using BudgetMaman.View;
using BudgetMaman.View.ClassesView;
using BudgetMaman.View.InterfaceView;
using System.ComponentModel;

namespace BudgetMaman
{
    public partial class FormPrincipal : Form
    {
        private IPresenterClass presenter;

        private int indiceColonneNom = 0;
        private int indiceColonneBudget = 1;
        private int indiceColonneMontantDepenser = 2;
        private int indiceColonneMontantRestant = 3;
        private int indiceColonneCacheIdCategorie = 4;


        public FormPrincipal(IPresenterClass presenter)
        {
            InitializeComponent();
            this.presenter = presenter;

            setLabelDebutPeriode();
            fillDgvCategories();
            sortDgvCategorie();
            mettreCellMontantRestantRouge();
        }

        public void InitLanguage()
        { 
            lblErreur = 
        }

        public void sortDgvCategorie()
        {
            DataGridViewColumn colonne = dgvCategories.Columns[indiceColonneNom];
            dgvCategories.Sort(colonne, ListSortDirection.Ascending);
        }

        public void setLabelDebutPeriode()
        {
            PeriodeView? periode = presenter.getCurrentPeriode();
            if (periode != null)
            {
                int jour = periode.Date.Day;
                string mois = periode.MoisEnumerateur.ToString();
                int annee = periode.Date.Year;

                string dateFormatee = $"Debut de la periode : {jour} {mois} {annee}";
                lblDebutPeriode.Text = dateFormatee;
            }
        }

        public void mettreCellMontantRestantRouge()
        {
            foreach (DataGridViewRow row in dgvCategories.Rows)
            {
                DataGridViewCell cell = row.Cells[indiceColonneMontantRestant];
                if (int.Parse(cell.Value.ToString()) < 0)
                {
                    cell.Style.ForeColor = Color.Red;
                }
                if (int.Parse(cell.Value.ToString()) >= 0)
                {
                    cell.Style.ForeColor = Color.Black;
                }
            }
        }


        public void fillDgvCategories()
        {
            dgvCategories.Rows.Clear();

            dgvCategories.ColumnCount = 5;

            Dictionary<int, CategorieView> dictCategories = presenter.getAllCategories();

            foreach (KeyValuePair<int, CategorieView> c in dictCategories)
            {
                addRow(c.Key, c.Value);
            }

            dgvCategories.Columns[indiceColonneCacheIdCategorie].Visible = false;
            dgvCategories.Columns[indiceColonneCacheIdCategorie].Width = 0;

            dgvCategories.Columns[indiceColonneNom].HeaderText = "Nom";
            dgvCategories.Columns[indiceColonneBudget].HeaderText = "Budget";
            dgvCategories.Columns[indiceColonneMontantDepenser].HeaderText = "Montant dépenser";
            dgvCategories.Columns[indiceColonneMontantRestant].HeaderText = "Montant restant";


            dgvCategories.Columns[indiceColonneNom].ReadOnly = true;
            dgvCategories.Columns[indiceColonneBudget].ReadOnly = true;
            dgvCategories.Columns[indiceColonneMontantDepenser].ReadOnly = true;
            dgvCategories.Columns[indiceColonneMontantRestant].ReadOnly = true;



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
            sortDgvCategorie();
        }

        private void btnAjouterCategories_Click(object sender, EventArgs e)
        {
            FormAjouterCategorie formAjouterCategorie = new FormAjouterCategorie(this, presenter);
            this.Enabled = false;
            formAjouterCategorie.Show();
        }

        private void btnNouveauMois_Click(object sender, EventArgs e)
        {
            PeriodeView mois = new PeriodeView(new List<DepenseView>(), (PeriodeView.MoisEnumView)(DateTime.Now.Month - 1), DateTime.Now);

            List<DepenseView> listDepenseView = new List<DepenseView>();

            mois.ListDepense = listDepenseView;

            presenter.addPeriode(mois);

            resetDatagridView();
            fillDgvCategories();
            setLabelDebutPeriode();
        }

        private void btnSupprimerCategorie_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count == 1)
            {
                int idCategorieASupprimer = int.Parse(dgvCategories.SelectedCells[indiceColonneCacheIdCategorie].Value.ToString());

                presenter.deleteCategorie(idCategorieASupprimer);
                dgvCategories.Rows.RemoveAt(dgvCategories.SelectedRows[0].Index);
            }
        }

        private void btnAjouterDepense_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count == 1 && txtNom.Text != "" && nUDDepense.Value > 0)
            {
                int idCategorie = int.Parse(dgvCategories.SelectedRows[0].Cells[indiceColonneCacheIdCategorie].Value.ToString());

                DepenseView depense = new DepenseView(txtNom.Text, rTxtMessage.Text, nUDDepense.Value,
                        idCategorie, DateTime.Now);

                presenter.addDepense(idCategorie, depense);


                setRowCategorieCurrentMontant(idCategorie, int.Parse(nUDDepense.Value.ToString()));
                lblErreur.Text = "";

                txtNom.Text = "";
                rTxtMessage.Text = "";
                nUDDepense.Value = 0;

                SetOnlyEditableCell(dgvCategories.SelectedRows[0].Index);
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

        private void SetOnlyEditableCell(int indiceRow)
        {
            for (int i = 0; i < dgvCategories.Rows.Count; i++)
            {
                dgvCategories.Rows[i].Cells[indiceColonneMontantDepenser].ReadOnly = true;
            }

            dgvCategories.Rows[indiceRow].Cells[indiceColonneMontantDepenser].ReadOnly = false;
        }


        private int FindRowIdCategorie(int idCategorie)
        {
            int indiceRow = -1;
            bool trouve = false;

            while (indiceRow < dgvCategories.RowCount && trouve == false)
            {

                int idCategorieRow = int.Parse(dgvCategories.Rows[indiceRow].Cells[indiceColonneCacheIdCategorie].Value.ToString());
                if (idCategorieRow == idCategorie)
                {
                }
                indiceRow++;
            }

            return indiceRow;
        }

        public void addRow(int idCategorie, CategorieView categorie)
        {

            /*TODO faire fonctionner ça avec les montants dans les variables*/

            String[] rowData =
                {
                    categorie.Nom,
                    categorie.MontantDebut.ToString(),
                    (categorie.MontantDebut - categorie.CurrentMontant).ToString(),
                    categorie.CurrentMontant.ToString(),
                    idCategorie.ToString()
                };

            dgvCategories.Rows.Add(rowData);
        }

        public void setRowCategorieCurrentMontant(int idCategorie, int montantASoustraire)
        {
            int i = 0;
            bool trouve = false;

            DataGridViewCell cellMontantBudget;
            DataGridViewCell cellMontantRestant;
            DataGridViewCell cellMontantDepense;

            while (i < dgvCategories.RowCount && !trouve)
            {
                int idCategorieRow = int.Parse(dgvCategories.Rows[i].Cells[indiceColonneCacheIdCategorie].Value.ToString());

                if (idCategorie == idCategorieRow)
                {
                    trouve = true;

                    cellMontantBudget = dgvCategories.Rows[i].Cells[indiceColonneBudget];
                    cellMontantDepense = dgvCategories.Rows[i].Cells[indiceColonneMontantDepenser];
                    cellMontantRestant = dgvCategories.Rows[i].Cells[indiceColonneMontantRestant];

                    int currentValeurMontantRestant = int.Parse(cellMontantRestant.Value.ToString()) - montantASoustraire;
                    cellMontantRestant.Value = currentValeurMontantRestant;

                    int valeurBudget = int.Parse(cellMontantBudget.Value.ToString());
                    cellMontantDepense.Value = valeurBudget - currentValeurMontantRestant;

                    if (int.Parse(cellMontantRestant.Value.ToString()) < 0)
                    {
                        cellMontantRestant.Style.ForeColor = Color.Red;
                    }
                }
                else
                {
                    i++;
                }
            };
            mettreCellMontantRestantRouge();
        }

        private void btnModifierCategorie_Click(object sender, EventArgs e)
        {
            if (dgvCategories.Rows.Count > 0)
            {
                int idCategorieAModifier = int.Parse(dgvCategories.SelectedRows[0].Cells[indiceColonneCacheIdCategorie].Value.ToString());

                Dictionary<int, CategorieView> dictCategorie = presenter.getAllCategories();

                CategorieView categorie = dictCategorie[idCategorieAModifier];


                //TODO logger l'exception du catch quand le logger sera pret
                FormModifierCategorie formModif = new FormModifierCategorie(idCategorieAModifier, categorie, this, presenter);
                this.Enabled = false;
                formModif.Show();
            }
            else
            {
                MessageBox.Show("Vous devez avoir des catégories pour modifier une categorie");
            }
        }

        public void modifierRowCategorie(CategorieView categorie)
        {
            DataGridViewRow rowAModifier = dgvCategories.SelectedRows[0];
            rowAModifier.Cells[indiceColonneNom].Value = categorie.Nom;
            rowAModifier.Cells[indiceColonneBudget].Value = categorie.MontantDebut;
            rowAModifier.Cells[indiceColonneMontantRestant].Value = categorie.CurrentMontant;

            dgvCategories.Sort(dgvCategories.Columns[indiceColonneNom], ListSortDirection.Ascending);
        }

        private void dgvCategories_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvCategories.SelectedRows[0];
            DataGridViewCell cellMontant = row.Cells[indiceColonneMontantDepenser];
            DataGridViewCell cellIdCategorie = row.Cells[indiceColonneCacheIdCategorie];

            decimal montant = decimal.Parse(cellMontant.Value.ToString());
            int idCategorie = int.Parse(cellIdCategorie.Value.ToString());

            presenter.ModifierDerniereDepense(montant, idCategorie);
            modifierRowCategorie(presenter.getAllCategories()[idCategorie]);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            presenter.DeleteDerniereDepense();
            resetDatagridView();
        }

        private void FormPrincipal_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                dgvCategories.Anchor = AnchorStyles.Right;
            }
        }
    }
}