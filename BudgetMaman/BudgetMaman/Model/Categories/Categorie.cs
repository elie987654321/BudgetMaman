using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetMaman.Model.Categories
{
    public class Categorie
    {
        public string Nom { get; set; }
        public decimal MontantDebut { get; set; }
        public decimal CurrentMontant { get; set; }

        public bool Desactiver { get; set; }

        public Categorie(string nom, decimal montantDebut, decimal currentMontant)
        {
            Nom = nom;
            MontantDebut = montantDebut;
            CurrentMontant = currentMontant;
        }

        public void ResetCurrentMontant()
        {
            CurrentMontant = MontantDebut;
        }
    }
}
