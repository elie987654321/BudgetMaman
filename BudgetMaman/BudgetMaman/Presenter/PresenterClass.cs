using BudgetMaman.Model;
using BudgetMaman.View.ClassesView;
using BudgetMaman.View.InterfaceView;

namespace BudgetMaman.Presenter
{
    internal class PresenterClass : IPresenterClass
    {
        ModelMain modelMain;

        public PresenterClass()
        {
            modelMain = new ModelMain();
        }

        public Dictionary<int, CategorieView> GetAllCategories()
        {
            Dictionary<int,Categorie> dictCategorieModel = modelMain.getAllCategories();
            Dictionary<int, CategorieView> dictCategorieView = new Dictionary<int, CategorieView>();

            foreach (KeyValuePair<int, Categorie> cModel in dictCategorieModel)
            {
                CategorieView categorieView = new CategorieView(cModel.Value.Nom, cModel.Value.MontantDebut, cModel.Value.CurrentMontant);
                dictCategorieView.Add(cModel.Key ,categorieView);
            }

            return dictCategorieView;
        }

        public List<PeriodeView> GetAllMois()
        {
            List<Periode> listMoisModel = modelMain.GetAllPeriodes();
            List<PeriodeView> listMoisView = new List<PeriodeView>();

            foreach (Periode mModel in listMoisModel)
            {

                List<DepenseView> listDepenseView = new List<DepenseView>();
                foreach (Depense dModel in mModel.ListDepense)
                {
                    DepenseView dView = DepenseModelToView(dModel);
                }

                PeriodeView moisView = new PeriodeView(listDepenseView, EnumMoisModelToView(mModel.MoisEnumerateur), mModel.Date); // Replace 
                listMoisView.Add(moisView);
            }

            return listMoisView;
        }

        public void AddPeriode(PeriodeView periodeView)
        {
            List<Depense> listDepenseModel = new List<Depense>();

            foreach (DepenseView depenseView in periodeView.ListDepense)
            {
                listDepenseModel.Add(DepenseViewToModel(depenseView));
            }

            Periode periodeModel = new Periode(listDepenseModel, MoisEnumViewToModel(periodeView.MoisEnumerateur), periodeView.Date);
            modelMain.AddPeriode(periodeModel);
        }

        public void DeleteCategorie(int idCategorie)
        {
            modelMain.DeleteCategorie(idCategorie);
            modelMain.Save();
        }

        private PeriodeView PeriodeModelToView(Periode moisModel)
        {

            List<DepenseView> listDepenseView = new List<DepenseView>();

            foreach(Depense depenseModel in moisModel.ListDepense)
            {
                listDepenseView.Add(DepenseModelToView(depenseModel));
            }

            PeriodeView moisView = new (listDepenseView, EnumMoisModelToView(moisModel.MoisEnumerateur), moisModel.Date );
            return moisView;
        }

        public DepenseView DepenseModelToView(Depense dModel)
        {
            DepenseView dView = new DepenseView(dModel.Nom, dModel.Message, dModel.Montant, dModel.CategorieID, dModel.Date);
            return dView;
        }

        private PeriodeView.MoisEnumView EnumMoisModelToView(Periode.MoisEnum moisEnum)
        {
            PeriodeView.MoisEnumView moisEnumView;

            switch (moisEnum)
            {
                case Periode.MoisEnum.Janvier:
                    moisEnumView = PeriodeView.MoisEnumView.Janvier;
                    break;
                case Periode.MoisEnum.Février:
                    moisEnumView = PeriodeView.MoisEnumView.Fevrier;
                    break;
                case Periode.MoisEnum.Mars:
                    moisEnumView = PeriodeView.MoisEnumView.Mars;
                    break;
                case Periode.MoisEnum.Avril:
                    moisEnumView = PeriodeView.MoisEnumView.Avril;
                    break;
                case Periode.MoisEnum.Mai:
                    moisEnumView = PeriodeView.MoisEnumView.Mai;
                    break;
                case Periode.MoisEnum.Juin:
                    moisEnumView = PeriodeView.MoisEnumView.Juin;
                    break;
                case Periode.MoisEnum.Juillet:
                    moisEnumView = PeriodeView.MoisEnumView.Juillet;
                    break;
                case Periode.MoisEnum.Août:
                    moisEnumView = PeriodeView.MoisEnumView.Août;
                    break;
                case Periode.MoisEnum.Septembre:
                    moisEnumView = PeriodeView.MoisEnumView.Septembre;
                    break;
                case Periode.MoisEnum.Octobre:
                    moisEnumView = PeriodeView.MoisEnumView.Octobre;
                    break;
                case Periode.MoisEnum.Novembre:
                    moisEnumView = PeriodeView.MoisEnumView.Novembre;
                    break;
                case Periode.MoisEnum.Décembre:
                default:
                    moisEnumView = PeriodeView.MoisEnumView.Décembre;
                    break;
            }

            return moisEnumView;
        }

        private Periode.MoisEnum MoisEnumViewToModel(PeriodeView.MoisEnumView moisEnumView)
        {
            Periode.MoisEnum moisEnumModel;

            switch (moisEnumView)
            {
                case PeriodeView.MoisEnumView.Janvier:
                    moisEnumModel = Periode.MoisEnum.Janvier;
                    break;
                case PeriodeView.MoisEnumView.Fevrier:
                    moisEnumModel = Periode.MoisEnum.Février;
                    break;
                case PeriodeView.MoisEnumView.Mars:
                    moisEnumModel = Periode.MoisEnum.Mars;
                    break;
                case PeriodeView.MoisEnumView.Avril:
                    moisEnumModel = Periode.MoisEnum.Avril;
                    break;
                case PeriodeView.MoisEnumView.Mai:
                    moisEnumModel = Periode.MoisEnum.Mai;
                    break;
                case PeriodeView.MoisEnumView.Juin:
                    moisEnumModel = Periode.MoisEnum.Juin;
                    break;
                case PeriodeView.MoisEnumView.Juillet:
                    moisEnumModel = Periode.MoisEnum.Juillet;
                    break;
                case PeriodeView.MoisEnumView.Août:
                    moisEnumModel = Periode.MoisEnum.Août;
                    break;
                case PeriodeView.MoisEnumView.Septembre:
                    moisEnumModel = Periode.MoisEnum.Septembre;
                    break;
                case PeriodeView.MoisEnumView.Octobre:
                    moisEnumModel = Periode.MoisEnum.Octobre;
                    break;
                case PeriodeView.MoisEnumView.Novembre:
                    moisEnumModel = Periode.MoisEnum.Novembre;
                    break;
                case PeriodeView.MoisEnumView.Décembre:
                    moisEnumModel = Periode.MoisEnum.Décembre;
                    break;

                default:
                    moisEnumModel = Periode.MoisEnum.Décembre;
                    break;
            }

            return moisEnumModel;
        }

        public int AddCategorie(CategorieView categorieView)
        {
            Categorie categorieModel = CategoriesViewToModel(categorieView);
            return modelMain.AddCategorie(categorieModel);
        }

        public void ModifierCategorie(int idCategorie, CategorieView categorieView)
        {
            Categorie categorie = CategoriesViewToModel(categorieView);
            modelMain.ModifierCategorie(idCategorie ,categorie);
        }

        public PeriodeView GetCurrentPeriode()
        {
            Periode? periodeModel = (modelMain.GetCurrentPeriode());

            PeriodeView periodeView = PeriodeModelToView(periodeModel);
            return periodeView;
        }

        public void AddDepense(int idCategorie,DepenseView depenseView)
        {
            Depense depenseModel = DepenseViewToModel(depenseView);
            modelMain.AddDepense(depenseModel, idCategorie);
        }

        private Depense DepenseViewToModel(DepenseView depenseView)
        {
            Depense depenseModel = new Depense(depenseView.Nom, depenseView.Message, depenseView.Montant, depenseView.Categorie, depenseView.Date);
            return depenseModel;
        }

        private Categorie CategoriesViewToModel(CategorieView categorieView)
        {
            Categorie categorieModel = new Categorie(
                categorieView.Nom,
                categorieView.MontantDebut,
                categorieView.CurrentMontant);

            return categorieModel;
        }

        private CategorieView CategorieModelToView(Categorie categorieModel)
        {
            CategorieView categorieView = new CategorieView(
                    categorieModel.Nom,
                    categorieModel.CurrentMontant,
                    categorieModel.MontantDebut);

            return categorieView;
        }

        public void ModifierDerniereDepense(decimal montant, int idCategorie)
        {
            modelMain.ModifierDerniereDepense(montant, idCategorie);
        }

        public void DeleteDerniereDepense()
        {
            modelMain.DeleteDerniereDepense();
        }

        public void Save()
        {
            modelMain.Save();
        }

        //Pour les tests
        public void ResetListRam()
        {
            modelMain.ResetListRam();
        }
    }
}
