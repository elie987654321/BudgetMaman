using BudgetMaman.Model;
using BudgetMaman.View.ClassesView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    internal class TestModelManager
    {
        private ModelMain modelManager;

        private JsonManager jsonManager;

        [SetUp]
        public void Setup()
        {
            modelManager = new ModelMain();
            jsonManager = new JsonManager();
        }

        [Test]
        public void testGetAllCategories()
        {
            modelManager.resetListRam();

            Categorie categorie1 = new Categorie("categorie1", 2, 3);
            Categorie categorie2 = new Categorie("categorie2", 3, 4);

            modelManager.addCategorie(categorie1);
            modelManager.addCategorie(categorie2);

            Assert.That(modelManager.getAllCategories().Count == 2);
        }

        [Test]
        public void testAddCategorie()
        {
            modelManager.resetListRam();

            Categorie categorie1 = new Categorie("categorie1", 2, 3);
            modelManager.addCategorie(categorie1);

            Assert.That(modelManager.getAllCategories().Count == 1);
        }

        [Test]
        public void testAddMois()
        {
            modelManager.resetListRam();

            DateTime debutMois = DateTime.Now;

            List<Depense> listDepense = new List<Depense>();

            BudgetMaman.Model.Periode mois = new BudgetMaman.Model.Periode(listDepense, BudgetMaman.Model.Periode.MoisEnum.Août, debutMois);

            modelManager.addPeriode(mois);

            Assert.That(modelManager.getAllPeriodes().Count, Is.EqualTo(1));
        }

        [Test]
        public void testAddDepense()
        {
            modelManager.resetListRam();
            modelManager.save();
            new JsonManager().resetIdNextCategorie();

            DateTime debutMois = DateTime.Now;

            List<Depense> listDepense = new List<Depense>();

            BudgetMaman.Model.Periode mois = new BudgetMaman.Model.Periode(listDepense, BudgetMaman.Model.Periode.MoisEnum.Août, debutMois);

            modelManager.addPeriode(mois);

            Categorie categorie = new Categorie("testCategorie", 100, 100);
            modelManager.addCategorie(categorie);

            Depense depense = new Depense("depense", "j'ai fait une depense", 100, 2, DateTime.Now);

            modelManager.addDepense(depense, 0);

            Assert.That(mois.ListDepense.Count, Is.EqualTo(1));
        }

        [Test]
        public void testGetCurrentMois()
        {
            ModelMain modelMain = new ModelMain();

            BudgetMaman.Model.Periode mois = new BudgetMaman.Model.Periode(new List<Depense>(), BudgetMaman.Model.Periode.MoisEnum.Janvier, new DateTime(DateTime.Now.Year, 1,1));

            modelMain.addPeriode(mois);

            BudgetMaman.Model.Periode? mois2 = modelMain.getCurrentPeriode();

            Assert.That(mois.MoisEnumerateur, Is.EqualTo(mois2.MoisEnumerateur));
            Assert.That(mois.Date, Is.EqualTo(mois2.Date));
        }

        [Test]
        public void testDeleteCategorie()
        {
            ModelMain modelMain = new ModelMain();
            modelMain.resetListRam();
            modelMain.save();
            new JsonManager().resetIdNextCategorie();

            Categorie categorie = new Categorie("categorie", 100, 200);
            modelMain.addCategorie(categorie);

            Categorie categorie2 = new Categorie("categorie2", 100, 200);
            modelMain.addCategorie(categorie2);

            Categorie categorie3 = new Categorie("categorie3", 100, 200);
            modelMain.addCategorie(categorie3);

            modelMain.deleteCategorie(1);

            Dictionary<int, Categorie> dictCategorie = modelMain.getAllCategories();

            Assert.That(dictCategorie.Count, Is.EqualTo(2));
        }

    }
}
