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

        private List<Periode> listPeriode;

        private JsonManager jsonManager;

        public ModelMain()
        {
            jsonManager = new JsonManager();

            dictCategorie = jsonManager.LoadCategorie();

            if (dictCategorie == null)
            {
                dictCategorie = new Dictionary<int, Categorie>();
            }

            listPeriode = jsonManager.LoadMois();

            if (listPeriode == null || listPeriode.Count == 0)
            {
                listPeriode = new List<Periode>();
                listPeriode.Add(new Periode(new List<Depense>(), (Periode.MoisEnum) DateTime.Now.Month, DateTime.Now));
            }
        }

        public Dictionary<int, Categorie> getAllCategories()
        {
            return dictCategorie;
        }

        public List<Periode> getAllMois()
        {
            return listPeriode;
        }

        public Periode? getCurrentMois()
        {
            if (listPeriode.Count > 0)
            {
                return listPeriode[listPeriode.Count - 1];
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
            Periode mois = listPeriode[listPeriode.Count - 1];

            mois.ListDepense.Add(depense);

            dictCategorie[idCategorie].CurrentMontant -= depense.Montant;
            save();
        }

        public void addMois(Periode mois)
        {
            listPeriode.Add(mois);
            foreach(Categorie c in dictCategorie.Values)
            {
                c.resetCurrentMontant();
            }
            save();
        }


        public void deleteCategorie(int idCategorie)
        {
            dictCategorie.Remove(idCategorie);
            save();
        }

        public void resetMontantCategories()
        {
            foreach (Categorie c in dictCategorie.Values)
            {
                c.resetCurrentMontant();
            }
        }

        public void save()
        {
            jsonManager.SaveCategories(dictCategorie);
            jsonManager.SaveMois(listPeriode);
        }

        //Pour les tests
        public void resetListRam()
        {
            dictCategorie = new Dictionary<int, Categorie>();
            listPeriode = new List<Periode>();
        }
    }
}
