using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetMaman.Model
{
    public class Categorie
    {
        public string Nom { get ; set ; }
        public Decimal MontantDebut { get ; set ; }
        public Decimal CurrentMontant { get ; set ; }


        public Categorie(string nom, Decimal montantDebut, Decimal currentMontant)
        {
            this.Nom = nom;
            this.MontantDebut = montantDebut;
            this.CurrentMontant = currentMontant;
        }

        public void resetCurrentMontant()
        {
            this.CurrentMontant = MontantDebut;
        }
    }
}
