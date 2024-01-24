using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetMaman.View.ClassesView
{
    public class MoisView
    {
        private List<DepenseView> listDepense;

        private MoisEnumView moisEnumerateur;

        private DateTime date;

        public List<DepenseView> ListDepense { get => listDepense; set => listDepense = value; }
        public MoisEnumView MoisEnumerateur { get => moisEnumerateur; set => moisEnumerateur = value; }
        public DateTime Date { get => date; set => date = value; }



        public MoisView(List<DepenseView> listDepense, MoisEnumView moisEnumerateur, DateTime date)
        {
            this.listDepense = listDepense;
            this.moisEnumerateur = moisEnumerateur;
            this.date = new DateTime(date.Year, date.Month, 1);
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

