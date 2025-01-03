using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetMaman.Model.Categories
{
    public interface ICategories
    {
        public string Nom { get; set; }
        public decimal MontantDebut { get; set; }
        public decimal CurrentMontant { get; set; }

        public bool Desactiver { get; set; }


        public void ResetCurrentMontant();
    }
}
