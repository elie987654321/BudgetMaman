using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using BudgetMaman.Model;
using BudgetMaman.View.ClassesView;

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

            listPeriode = jsonManager.LoadPeriode();

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

        public List<Periode> getAllPeriodes()
        {
            return listPeriode;
        }

        public Periode? getCurrentPeriode()
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

        public void modifierDerniereDepense(decimal montant, int idCategorie)
        {
            if (listPeriode.Count > 0)
            {
                Periode lastPeriode = listPeriode.Last();
                if (lastPeriode.ListDepense.Count > 0)
                {

                    dictCategorie[idCategorie].CurrentMontant += lastPeriode.ListDepense.Last().Montant;

                    Depense lastDepense = lastPeriode.ListDepense.Last();
                    lastDepense.Montant = montant;

                    dictCategorie[idCategorie].CurrentMontant -= montant;

                    save();
                }


            }
        }

        public void DeleteDerniereDepense()
        {
            if (listPeriode.Count > 0)
            {
                

                Periode lastPeriode = listPeriode.Last();
                if (lastPeriode.ListDepense.Count > 0)
                {
                    int idCategorie = lastPeriode.ListDepense.Last().CategorieID;
                    dictCategorie[idCategorie].CurrentMontant += lastPeriode.ListDepense.Last().Montant;

                    lastPeriode.ListDepense.RemoveAt(lastPeriode.ListDepense.Count - 1);
                    save();
                }

            }
        }

        public void addPeriode(Periode periode)
        {
            listPeriode.Add(periode);
            foreach(Categorie c in dictCategorie.Values)
            {
                c.resetCurrentMontant();
            }
            save();
        }

        public void modifierCategorie(int idCategorie, Categorie categorie)
        {
            if (dictCategorie.ContainsKey(idCategorie))
            { 
                dictCategorie[idCategorie] = categorie;
                save();
            }
            else
            {
                Console.WriteLine("Erreur lors de la modification de la categorie");
            }
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
            jsonManager.SavePeriode(listPeriode);
        }

        //Pour les tests
        public void resetListRam()
        {
            dictCategorie = new Dictionary<int, Categorie>();
            listPeriode = new List<Periode>();
        }
    }
}
