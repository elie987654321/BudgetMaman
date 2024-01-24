using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetMaman.Model;

namespace BudgetMaman.Model
{
    public class ModelMain
    {
        private Dictionary<int, Categorie> dictCategorie;

        private List<Mois> listMois;

        private JsonManager jsonManager;

        public ModelMain()
        {
            jsonManager = new JsonManager();

            dictCategorie = jsonManager.LoadCategorie();

            if (dictCategorie == null)
            {
                dictCategorie = new Dictionary<int, Categorie>();
            }

            listMois = jsonManager.LoadMois();

            if (listMois == null)
            {
                listMois = new List<Mois>();
                listMois.Add(new Mois(new List<Depense>(), (Mois.MoisEnum) DateTime.Now.Month, DateTime.Now));
            }
        }

        public Dictionary<int, Categorie> getAllCategories()
        {
            return dictCategorie;
        }

        public List<Mois> getAllMois()
        {
            return listMois;
        }

        public Mois? getCurrentMois()
        {
            if (listMois.Count > 0)
            {
                return listMois[listMois.Count - 1];
            }
            else
            {
                return null;
            }
        }


        public int addCategorie(Categorie categorie)
        {
            int idCategorie = jsonManager.getNextIdCategorie();

            dictCategorie.Add(idCategorie, categorie);
            save();

            return idCategorie;
        }

        public void addDepense(Depense depense, int idCategorie)
        {

            if (listMois.Count > 0)
            {
                Mois mois = listMois[listMois.Count - 1];

                mois.ListDepense.Add(depense);
                
                dictCategorie[idCategorie].CurrentMontant -= depense.Montant;

                save();
            }
        }

        public void addMois(Mois mois)
        {
            listMois.Add(mois);
        }


        public void deleteCategorie(int idCategorie)
        {
            dictCategorie.Remove(idCategorie);
            save();
        }

        public void save()
        {
            jsonManager.SaveCategories(dictCategorie);
            jsonManager.SaveMois(listMois);
        }

        //Pour les tests
        public void resetListRam()
        {
            dictCategorie = new Dictionary<int, Categorie>();
            listMois = new List<Mois>();
        }
    }
}
