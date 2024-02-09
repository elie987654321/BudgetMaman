using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetMaman.View.ClassesView
{
    public class DepenseView
    {

        private decimal montant;

        


        public DepenseView(string nom, string message, decimal montant, int categorie, DateTime date)
        {
            this.Nom = nom;
            this.Message = message;
            this.Montant = montant;
            this.Date = DateTime.Now;
            this.Categorie = categorie;
        }

        public string Nom { get; set; }
        public string Message { get; set; }
        public decimal Montant 
        {
            get { return montant; }
            set { montant = value; }
        }
        public DateTime Date { get; set; }
        public int Categorie { get; set; }
    }
}
