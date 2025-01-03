using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using BudgetMaman.Model.Categories;
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

        public List<Periode> GetAllPeriodes()
        {
            return listPeriode;
        }

        public Periode? GetCurrentPeriode()
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


        public int AddCategorie(Categorie categorie)
        {
            int idCategorie = jsonManager.GetNextIdCategorie();

            dictCategorie.Add(idCategorie, categorie);
            Save();

            return idCategorie;
        }

        public void AddDepense(Depense depense, int idCategorie)
        {
            Periode mois = listPeriode[listPeriode.Count - 1];

            mois.ListDepense.Add(depense);

            dictCategorie[idCategorie].CurrentMontant -= depense.Montant;
            Save();
        }

        public void ModifierDerniereDepense(decimal montant, int idCategorie)
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

                    Save();
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
                    Save();
                }

            }
        }

        public void AddPeriode(Periode periode)
        {
            listPeriode.Add(periode);
            foreach(Categorie c in dictCategorie.Values)
            {
                c.ResetCurrentMontant();
            }
            Save();
        }

        public void ModifierCategorie(int idCategorie, Categorie categorie)
        {
            if (dictCategorie.ContainsKey(idCategorie))
            { 
                dictCategorie[idCategorie] = categorie;
                Save();
            }
            else
            {
                Console.WriteLine("Erreur lors de la modification de la categorie");
            }
        }


        public void DeleteCategorie(int idCategorie)
        {
            dictCategorie.Remove(idCategorie);
            Save();
        }

        public void ResetMontantCategories()
        {
            foreach (Categorie c in dictCategorie.Values)
            {
                c.ResetCurrentMontant();
            }
        }

        public void Save()
        {
            jsonManager.SaveCategories(dictCategorie);
            jsonManager.SavePeriode(listPeriode);
        }

        //Pour les tests
        public void ResetListRam()
        {
            dictCategorie = new Dictionary<int, Categorie>();
            listPeriode = new List<Periode>();
        }
    }
}
