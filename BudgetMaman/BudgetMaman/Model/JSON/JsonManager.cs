using System;
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
        private string pathMois;
        private string pathNextIdCategorie;

        public JsonManager()
        {
            pathCategories = Directory.GetCurrentDirectory() + "/" + "categories.json";

            pathNextIdCategorie = Directory.GetCurrentDirectory() + "/" + "nextIDCategorie.txt";

            pathMois = Directory.GetCurrentDirectory() + "/" + "mois.json";
        }

        public void SaveCategories(Dictionary<int, Categorie> dictCategories)
        {
            string jsonString = JsonSerializer.Serialize(dictCategories);

            File.WriteAllText(pathCategories, jsonString);
        }

        public void SaveMois(List<Mois> listMois)
        {
            string jsonString = JsonSerializer.Serialize(listMois);

            File.WriteAllText(pathMois, jsonString);
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


        public List<Mois> LoadMois()
        {
            List<Mois> listMois = new List<Mois>();

            if (File.Exists(pathMois))
            {
                string jsonString = File.ReadAllText(pathMois);

                listMois = JsonSerializer.Deserialize<List<Mois>>(jsonString);

                if (listMois == null)
                {
                    listMois = new List<Mois>();
                }
            }
            else
            {
                listMois = new List<Mois>();
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
    }
}
