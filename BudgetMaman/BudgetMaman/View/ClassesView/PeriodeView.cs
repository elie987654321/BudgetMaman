using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetMaman.View.ClassesView
{
    public class PeriodeView
    {
        
        public List<DepenseView> ListDepense { get ; set ; }
        public MoisEnumView MoisEnumerateur { get ; set ; }
        public DateTime Date { get ; set ; }



        public PeriodeView(List<DepenseView> listDepense, MoisEnumView moisEnumerateur, DateTime date)
        {
            this.ListDepense = listDepense;
            this.MoisEnumerateur = moisEnumerateur;
            this.Date = date;
        }

        public enum MoisEnumView
        {
            Janvier,
            Fevrier,
            Mars,
            Avril,
            Mai,
            Juin,
            Juillet,
            Août,
            Septembre,
            Octobre,
            Novembre,
            Décembre
        };
    }
}

