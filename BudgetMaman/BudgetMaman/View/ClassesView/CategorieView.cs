using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetMaman.View.ClassesView
{
    public class CategorieView
    {
            public string Nom { get ; set; }
            public decimal MontantDebut { get ; set ; }
            public decimal CurrentMontant { get ; set ; }


            public CategorieView(string nom, Decimal montantDebut, Decimal currentMontant)
            {
                this.Nom = nom;
                this.MontantDebut = montantDebut;
                this.CurrentMontant = currentMontant;
            }

        public void resetMontant()
        {
            CurrentMontant = MontantDebut;
        }
        
    }
}
