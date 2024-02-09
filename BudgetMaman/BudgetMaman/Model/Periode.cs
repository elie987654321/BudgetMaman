using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetMaman.Model
{
    public class Periode
    {
        
        public List<Depense> ListDepense { get ; set ; }
        public MoisEnum MoisEnumerateur { get ; set ; }
        public DateTime Date { get ; set ; }



        public Periode(List<Depense> listDepense, MoisEnum moisEnumerateur, DateTime date)
        {
            this.ListDepense = listDepense;
            this.MoisEnumerateur = moisEnumerateur;
            this.Date = date;
        }

        public enum MoisEnum
        {
            Janvier,
            Février,
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
