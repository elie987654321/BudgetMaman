﻿using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetMaman.Model
{
    public class Depense
    {
        
        private string nom;

        private string message;

        private Decimal montant;

        private DateTime date;


        private int categorie;

        public Depense(string nom, string message, Decimal montant, int categorie, DateTime date)
        {
            this.nom = nom;
            this.message = message;
            this.montant = montant;
            this.date = DateTime.Now;
            this.categorie = categorie;
        }

        public string Nom { get; set; }
        public string Message { get; set; }
        public decimal Montant { get; set; }
        public DateTime Date { get; set; }
        public int Categorie { get; set; }
    }
}