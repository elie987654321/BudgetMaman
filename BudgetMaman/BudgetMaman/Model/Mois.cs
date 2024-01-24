using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetMaman.Model
{
    public class Mois
    {
        private List<Depense> listDepense;

        private MoisEnum moisEnumerateur;

        private DateTime date;

        public List<Depense> ListDepense { get => listDepense; set => listDepense = value; }
        public MoisEnum MoisEnumerateur { get => moisEnumerateur; set => moisEnumerateur = value; }
        public DateTime Date { get => date; set => date = value; }



        public Mois(List<Depense> listDepense, MoisEnum moisEnumerateur, DateTime date)
        {
            this.listDepense = listDepense;
            this.moisEnumerateur = moisEnumerateur;
            this.date = new DateTime(date.Year, date.Month, 1);
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
