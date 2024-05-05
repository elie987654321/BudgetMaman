using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BudgetMaman.Model
{
    public class Depense
    {
        


        [JsonIgnore]
        private Categorie categorie;

        public Depense(string nom, string message, decimal montant, int categorieID, DateTime date)
        {
            this.Nom = nom;
            this.Message = message;
            this.Montant = montant;
            this.Date = DateTime.Now;
            this.CategorieID = categorieID;
        }

        public string Nom { get; set; }
        public string Message { get; set; }

        public decimal Montant {get;  set;}

        public DateTime Date { get; set; }
        public int CategorieID { get; set; }

        public void setCategorieByRef(ref Categorie? categorie)
        {
            this.categorie = categorie;
        }

        public enum TypeDepense
        {
            Depense,
            ChangementManuel
        }
    }
}
