using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetMaman.Model
{
    public class Categorie
    {
        private string nom;

        private Decimal montantDebut;

        private Decimal currentMontant;

        public string Nom { get => nom; set => nom = value; }
        public Decimal MontantDebut { get => montantDebut; set => montantDebut = value; }
        public Decimal CurrentMontant { get => currentMontant; set => currentMontant = value; }


        public Categorie(string nom, Decimal montantDebut, Decimal currentMontant)
        {
            this.nom = nom;
            this.montantDebut = montantDebut;
            this.currentMontant = currentMontant;
        }
    }
}
