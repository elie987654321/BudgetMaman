using BudgetMaman.Model;
using BudgetMaman.View.ClassesView;
using BudgetMaman.View.InterfaceView;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public List<View.ClassesView.PeriodeView> getAllMois()
        {
            List<Model.Periode> listMoisModel = modelMain.getAllMois();
            List<View.ClassesView.PeriodeView> listMoisView = new List<View.ClassesView.PeriodeView>();

            foreach (Model.Periode mModel in listMoisModel)
            {

                List<DepenseView> listDepenseView = new List<DepenseView>();
                foreach (Depense dModel in mModel.ListDepense)
                {
                    DepenseView dView = depenseModelToView(dModel);
                }

                View.ClassesView.PeriodeView moisView = new View.ClassesView.PeriodeView(listDepenseView, enumMoisModelToView(mModel.MoisEnumerateur), mModel.Date); // Replace SomeOtherProperty with the actual properties of your Mois model
                listMoisView.Add(moisView);
            }

            return listMoisView;
        }

        public void addMois(View.ClassesView.PeriodeView moisView)
        {
            List<Depense> listDepenseModel = new List<Depense>();

            foreach (DepenseView depenseView in moisView.ListDepense)
            {
                listDepenseModel.Add(depenseViewToModel(depenseView));
            }

            Periode moisModel = new Periode(listDepenseModel, moisEnumViewToModel(moisView.MoisEnumerateur), moisView.Date);
            modelMain.addMois(moisModel);
        }

        public void deleteCategorie(int idCategorie)
        {
            modelMain.deleteCategorie(idCategorie);
            modelMain.save();
        }

        private View.ClassesView.PeriodeView MoisModelToView(Model.Periode moisModel)
        {

            List<DepenseView> listDepenseView = new List<DepenseView>();

            foreach(Depense depenseModel in moisModel.ListDepense)
            {
                listDepenseView.Add(depenseModelToView(depenseModel));
            }

            View.ClassesView.PeriodeView moisView = new (listDepenseView, enumMoisModelToView(moisModel.MoisEnumerateur), moisModel.Date );
            return moisView;
        }

        public DepenseView depenseModelToView(Depense dModel)
        {
            DepenseView dView = new DepenseView(dModel.Nom, dModel.Message, dModel.Montant, dModel.CategorieID, dModel.Date);
            return dView;
        }

        private View.ClassesView.PeriodeView.MoisEnumView enumMoisModelToView(Model.Periode.MoisEnum moisEnum)
        {
            View.ClassesView.PeriodeView.MoisEnumView moisEnumView;

            switch (moisEnum)
            {
                case Model.Periode.MoisEnum.Janvier:
                    moisEnumView = View.ClassesView.PeriodeView.MoisEnumView.Janvier;
                    break;
                case Model.Periode.MoisEnum.Février:
                    moisEnumView = View.ClassesView.PeriodeView.MoisEnumView.Fevrier;
                    break;
                case Model.Periode.MoisEnum.Mars:
                    moisEnumView = View.ClassesView.PeriodeView.MoisEnumView.Mars;
                    break;
                case Model.Periode.MoisEnum.Avril:
                    moisEnumView = View.ClassesView.PeriodeView.MoisEnumView.Avril;
                    break;
                case Model.Periode.MoisEnum.Mai:
                    moisEnumView = View.ClassesView.PeriodeView.MoisEnumView.Mai;
                    break;
                case Model.Periode.MoisEnum.Juin:
                    moisEnumView = View.ClassesView.PeriodeView.MoisEnumView.Juin;
                    break;
                case Model.Periode.MoisEnum.Juillet:
                    moisEnumView = View.ClassesView.PeriodeView.MoisEnumView.Juillet;
                    break;
                case Model.Periode.MoisEnum.Août:
                    moisEnumView = View.ClassesView.PeriodeView.MoisEnumView.Août;
                    break;
                case Model.Periode.MoisEnum.Septembre:
                    moisEnumView = View.ClassesView.PeriodeView.MoisEnumView.Septembre;
                    break;
                case Model.Periode.MoisEnum.Octobre:
                    moisEnumView = View.ClassesView.PeriodeView.MoisEnumView.Octobre;
                    break;
                case Model.Periode.MoisEnum.Novembre:
                    moisEnumView = View.ClassesView.PeriodeView.MoisEnumView.Novembre;
                    break;
                case Model.Periode.MoisEnum.Décembre:
                default:
                    moisEnumView = View.ClassesView.PeriodeView.MoisEnumView.Décembre;
                    break;
            }

            return moisEnumView;
        }

        private Model.Periode.MoisEnum moisEnumViewToModel(View.ClassesView.PeriodeView.MoisEnumView moisEnumView)
        {
            Model.Periode.MoisEnum moisEnumModel;

            switch (moisEnumView)
            {
                case View.ClassesView.PeriodeView.MoisEnumView.Janvier:
                    moisEnumModel = Model.Periode.MoisEnum.Janvier;
                    break;
                case View.ClassesView.PeriodeView.MoisEnumView.Fevrier:
                    moisEnumModel = Model.Periode.MoisEnum.Février;
                    break;
                case View.ClassesView.PeriodeView.MoisEnumView.Mars:
                    moisEnumModel = Model.Periode.MoisEnum.Mars;
                    break;
                case View.ClassesView.PeriodeView.MoisEnumView.Avril:
                    moisEnumModel = Model.Periode.MoisEnum.Avril;
                    break;
                case View.ClassesView.PeriodeView.MoisEnumView.Mai:
                    moisEnumModel = Model.Periode.MoisEnum.Mai;
                    break;
                case View.ClassesView.PeriodeView.MoisEnumView.Juin:
                    moisEnumModel = Model.Periode.MoisEnum.Juin;
                    break;
                case View.ClassesView.PeriodeView.MoisEnumView.Juillet:
                    moisEnumModel = Model.Periode.MoisEnum.Juillet;
                    break;
                case View.ClassesView.PeriodeView.MoisEnumView.Août:
                    moisEnumModel = Model.Periode.MoisEnum.Août;
                    break;
                case View.ClassesView.PeriodeView.MoisEnumView.Septembre:
                    moisEnumModel = Model.Periode.MoisEnum.Septembre;
                    break;
                case View.ClassesView.PeriodeView.MoisEnumView.Octobre:
                    moisEnumModel = Model.Periode.MoisEnum.Octobre;
                    break;
                case View.ClassesView.PeriodeView.MoisEnumView.Novembre:
                    moisEnumModel = Model.Periode.MoisEnum.Novembre;
                    break;
                case View.ClassesView.PeriodeView.MoisEnumView.Décembre:
                    moisEnumModel = Model.Periode.MoisEnum.Décembre;
                    break;

                default:
                    moisEnumModel = Model.Periode.MoisEnum.Décembre;
                    break;
            }

            return moisEnumModel;
        }

        public int addCategorie(CategorieView categorieView)
        {
            Categorie categorieModel = categoriesViewToModel(categorieView);
            return modelMain.addCategorie(categorieModel);
        }

        public PeriodeView getCurrentMois()
        {
            Model.Periode? moisModel = (modelMain.getCurrentMois());

            View.ClassesView.PeriodeView moisView = MoisModelToView(moisModel);
            return moisView;
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
                categorieView.CurrentMontant,
                categorieView.MontantDebut);

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
