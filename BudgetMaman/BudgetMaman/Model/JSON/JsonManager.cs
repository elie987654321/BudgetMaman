﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;



namespace BudgetMaman.Model
{
    public class JsonManager
    {
        private string pathCategories;
        private string pathPeriode;
        private string pathNextIdCategorie;

        public JsonManager()
        {
            pathCategories = Directory.GetCurrentDirectory() + "/" + "categories.json";

            pathNextIdCategorie = Directory.GetCurrentDirectory() + "/" + "nextIDCategorie.txt";

            pathPeriode = Directory.GetCurrentDirectory() + "/" + "periode.json";
        }

        public void DeleteAll()
        {
            File.Delete(pathCategories);
            File.Delete(pathNextIdCategorie);
            File.Delete(pathPeriode);
        }

        public void SaveCategories(Dictionary<int, Categorie> dictCategories)
        {
            string jsonString = JsonSerializer.Serialize(dictCategories);

            File.WriteAllText(pathCategories, jsonString);
        }

        public void SavePeriode(List<Periode> listPeriode)
        {
            string jsonString = JsonSerializer.Serialize(listPeriode);

            foreach (Periode mois in listPeriode)
            {
                List<Depense> listDepense = new List<Depense>();
            }

            File.WriteAllText(pathPeriode, jsonString);
        }


        public Dictionary<int, Categorie> LoadCategorie()
        {
            Dictionary<int, Categorie> dictCategories;

            if (File.Exists(pathCategories))
            {
                string jsonString = File.ReadAllText(pathCategories);

                dictCategories = JsonSerializer.Deserialize<Dictionary<int ,Categorie>>(jsonString);

                if (dictCategories == null)
                {
                    dictCategories = new Dictionary<int, Categorie>();
                }
            }
            else
            {
                dictCategories = new Dictionary<int, Categorie>();
            }

            return dictCategories;
        }


        public List<Periode> LoadPeriode()
        {
            List<Periode> listMois = new List<Periode>();

            if (File.Exists(pathPeriode))
            {
                string jsonString = File.ReadAllText(pathPeriode);

                listMois = JsonSerializer.Deserialize<List<Periode>>(jsonString);

                if (listMois == null)
                {
                    listMois = new List<Periode>();
                }
            }
            else
            {
                listMois = new List<Periode>();
            }

            return listMois;
        }


        public int getNextIdCategorie()
        {
            int id;

            if (File.Exists(pathNextIdCategorie))
            {
                string idString = File.ReadAllText(pathNextIdCategorie) ;
                id = int.Parse(idString);
            }
            else
            {
                using (File.Create(pathNextIdCategorie)) 
                id = 0;
            }

            File.WriteAllText(pathNextIdCategorie, (id + 1).ToString());
            return id;
        }

        //Pour les tests
        public void resetIdNextCategorie()
        {
            File.Delete(pathNextIdCategorie);
        }

        public void assignCategorieToDepense(Dictionary<int, Categorie> dictCategorie, List<Depense> listDepense)
        {
            foreach (Depense d in listDepense)
            {
                if (dictCategorie.ContainsKey(d.CategorieID))
                {
                    Categorie categorie = dictCategorie.GetValueOrDefault(d.CategorieID);
                    d.setCategorieByRef(ref categorie); 
                }
            }
        }
    }
}
