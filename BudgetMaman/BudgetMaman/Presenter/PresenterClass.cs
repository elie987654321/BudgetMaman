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

        public Dictionary<int, CategorieView> getAllCategories()
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

        public List<PeriodeView> getAllMois()
        {
            List<Periode> listMoisModel = modelMain.getAllPeriodes();
            List<PeriodeView> listMoisView = new List<PeriodeView>();

            foreach (Periode mModel in listMoisModel)
            {

                List<DepenseView> listDepenseView = new List<DepenseView>();
                foreach (Depense dModel in mModel.ListDepense)
                {
                    DepenseView dView = depenseModelToView(dModel);
                }

                PeriodeView moisView = new PeriodeView(listDepenseView, enumMoisModelToView(mModel.MoisEnumerateur), mModel.Date); // Replace 
                listMoisView.Add(moisView);
            }

            return listMoisView;
        }

        public void addPeriode(PeriodeView periodeView)
        {
            List<Depense> listDepenseModel = new List<Depense>();

            foreach (DepenseView depenseView in periodeView.ListDepense)
            {
                listDepenseModel.Add(depenseViewToModel(depenseView));
            }

            Periode periodeModel = new Periode(listDepenseModel, moisEnumViewToModel(periodeView.MoisEnumerateur), periodeView.Date);
            modelMain.addPeriode(periodeModel);
        }

        public void deleteCategorie(int idCategorie)
        {
            modelMain.deleteCategorie(idCategorie);
            modelMain.save();
        }

        private PeriodeView PeriodeModelToView(Periode moisModel)
        {

            List<DepenseView> listDepenseView = new List<DepenseView>();

            foreach(Depense depenseModel in moisModel.ListDepense)
            {
                listDepenseView.Add(depenseModelToView(depenseModel));
            }

            PeriodeView moisView = new (listDepenseView, enumMoisModelToView(moisModel.MoisEnumerateur), moisModel.Date );
            return moisView;
        }

        public DepenseView depenseModelToView(Depense dModel)
        {
            DepenseView dView = new DepenseView(dModel.Nom, dModel.Message, dModel.Montant, dModel.CategorieID, dModel.Date);
            return dView;
        }

        private PeriodeView.MoisEnumView enumMoisModelToView(Periode.MoisEnum moisEnum)
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

        private Periode.MoisEnum moisEnumViewToModel(PeriodeView.MoisEnumView moisEnumView)
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

        public int addCategorie(CategorieView categorieView)
        {
            Categorie categorieModel = categoriesViewToModel(categorieView);
            return modelMain.addCategorie(categorieModel);
        }

        public void modifierCategorie(int idCategorie, CategorieView categorieView)
        {
            Categorie categorie = categoriesViewToModel(categorieView);
            modelMain.modifierCategorie(idCategorie ,categorie);
        }

        public PeriodeView getCurrentPeriode()
        {
            Periode? periodeModel = (modelMain.getCurrentPeriode());

            PeriodeView periodeView = PeriodeModelToView(periodeModel);
            return periodeView;
        }

        public void addDepense(int idCategorie,DepenseView depenseView)
        {
            Depense depenseModel = depenseViewToModel(depenseView);
            modelMain.addDepense(depenseModel, idCategorie);
        }

        private Depense depenseViewToModel(DepenseView depenseView)
        {
            Depense depenseModel = new Depense(depenseView.Nom, depenseView.Message, depenseView.Montant, depenseView.Categorie, depenseView.Date);
            return depenseModel;
        }

        private Categorie categoriesViewToModel(CategorieView categorieView)
        {
            Categorie categorieModel = new Categorie(
                categorieView.Nom,
                categorieView.MontantDebut,
                categorieView.CurrentMontant);

            return categorieModel;
        }

        private CategorieView categorieModelToView(Categorie categorieModel)
        {
            CategorieView categorieView = new CategorieView(
                    categorieModel.Nom,
                    categorieModel.CurrentMontant,
                    categorieModel.MontantDebut);

            return categorieView;
        }

        public void ModifierDerniereDepense(decimal montant, int idCategorie)
        {
            modelMain.modifierDerniereDepense(montant, idCategorie);
        }

        

        public void save()
        {
            modelMain.save();
        }

        //Pour les tests
        public void resetListRam()
        {
            modelMain.resetListRam();
        }
    }
}
