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

        public List<MoisView> getAllMois()
        {
            List<Mois> listMoisModel = modelMain.getAllMois();
            List<MoisView> listMoisView = new List<MoisView>();

            foreach (Mois mModel in listMoisModel)
            {

                List<DepenseView> listDepenseView = new List<DepenseView>();
                foreach (Depense dModel in mModel.ListDepense)
                {
                    DepenseView dView = depenseModelToView(dModel);
                }

                MoisView moisView = new MoisView(listDepenseView, enumMoisModelToView(mModel.MoisEnumerateur), mModel.Date); // Replace SomeOtherProperty with the actual properties of your Mois model
                listMoisView.Add(moisView);
            }

            return listMoisView;
        }

        public void addMois(MoisView moisView)
        {
            List<Depense> listDepenseModel = new List<Depense>();

            foreach (DepenseView depenseView in moisView.ListDepense)
            {
                listDepenseModel.Add(depenseViewToModel(depenseView));
            }

            Mois moisModel = new Mois(listDepenseModel, moisEnumViewToModel(moisView.MoisEnumerateur), moisView.Date);
        }

        public void deleteCategorie(int idCategorie)
        {
            modelMain.deleteCategorie(idCategorie);
            modelMain.save();
        }

        private MoisView MoisModelToView(Mois moisModel)
        {

            List<DepenseView> listDepenseView = new List<DepenseView>();

            foreach(Depense depenseModel in moisModel.ListDepense)
            {
                listDepenseView.Add(depenseModelToView(depenseModel));
            }

            MoisView moisView = new (listDepenseView, enumMoisModelToView(moisModel.MoisEnumerateur),moisModel.Date );
            return moisView;
        }

        public DepenseView depenseModelToView(Depense dModel)
        {
            DepenseView dView = new DepenseView(dModel.Nom, dModel.Message, dModel.Montant, dModel.Categorie, dModel.Date);
            return dView;
        }

        private MoisView.MoisEnumView enumMoisModelToView(Mois.MoisEnum moisEnum)
        {
            MoisView.MoisEnumView moisEnumView;

            switch (moisEnum)
            {
                case Mois.MoisEnum.Janvier:
                    moisEnumView = MoisView.MoisEnumView.Janvier;
                    break;
                case Mois.MoisEnum.Février:
                    moisEnumView = MoisView.MoisEnumView.Fevrier;
                    break;
                case Mois.MoisEnum.Mars:
                    moisEnumView = MoisView.MoisEnumView.Mars;
                    break;
                case Mois.MoisEnum.Avril:
                    moisEnumView = MoisView.MoisEnumView.Avril;
                    break;
                case Mois.MoisEnum.Mai:
                    moisEnumView = MoisView.MoisEnumView.Mai;
                    break;
                case Mois.MoisEnum.Juin:
                    moisEnumView = MoisView.MoisEnumView.Juin;
                    break;
                case Mois.MoisEnum.Juillet:
                    moisEnumView = MoisView.MoisEnumView.Juillet;
                    break;
                case Mois.MoisEnum.Août:
                    moisEnumView = MoisView.MoisEnumView.Août;
                    break;
                case Mois.MoisEnum.Septembre:
                    moisEnumView = MoisView.MoisEnumView.Septembre;
                    break;
                case Mois.MoisEnum.Octobre:
                    moisEnumView = MoisView.MoisEnumView.Octobre;
                    break;
                case Mois.MoisEnum.Novembre:
                    moisEnumView = MoisView.MoisEnumView.Novembre;
                    break;
                case Mois.MoisEnum.Décembre:
                default:
                    moisEnumView = MoisView.MoisEnumView.Décembre;
                    break;
            }

            return moisEnumView;
        }

        private Mois.MoisEnum moisEnumViewToModel(MoisView.MoisEnumView moisEnumView)
        {
            Mois.MoisEnum moisEnumModel;

            switch (moisEnumView)
            {
                case MoisView.MoisEnumView.Janvier:
                    moisEnumModel = Mois.MoisEnum.Janvier;
                    break;
                case MoisView.MoisEnumView.Fevrier:
                    moisEnumModel = Mois.MoisEnum.Février;
                    break;
                case MoisView.MoisEnumView.Mars:
                    moisEnumModel = Mois.MoisEnum.Mars;
                    break;
                case MoisView.MoisEnumView.Avril:
                    moisEnumModel = Mois.MoisEnum.Avril;
                    break;
                case MoisView.MoisEnumView.Mai:
                    moisEnumModel = Mois.MoisEnum.Mai;
                    break;
                case MoisView.MoisEnumView.Juin:
                    moisEnumModel = Mois.MoisEnum.Juin;
                    break;
                case MoisView.MoisEnumView.Juillet:
                    moisEnumModel = Mois.MoisEnum.Juillet;
                    break;
                case MoisView.MoisEnumView.Août:
                    moisEnumModel = Mois.MoisEnum.Août;
                    break;
                case MoisView.MoisEnumView.Septembre:
                    moisEnumModel = Mois.MoisEnum.Septembre;
                    break;
                case MoisView.MoisEnumView.Octobre:
                    moisEnumModel = Mois.MoisEnum.Octobre;
                    break;
                case MoisView.MoisEnumView.Novembre:
                    moisEnumModel = Mois.MoisEnum.Novembre;
                    break;
                case MoisView.MoisEnumView.Décembre:
                    moisEnumModel = Mois.MoisEnum.Décembre;
                    break;

                default:
                    moisEnumModel = Mois.MoisEnum.Décembre;
                    break;
            }

            return moisEnumModel;
        }

        public void addCategorie(CategorieView categorieView)
        {
            Categorie categorieModel = categoriesViewToModel(categorieView);
            modelMain.addCategorie(categorieModel);
        }

        public MoisView getCurrentMois()
        {
            Mois? moisModel = (modelMain.getCurrentMois());

            MoisView moisView = MoisModelToView(moisModel);
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
