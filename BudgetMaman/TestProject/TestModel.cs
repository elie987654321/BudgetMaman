using BudgetMaman.Model;
using BudgetMaman.Model.Categories;

namespace TestProject
{
    internal class TestModel
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
            modelManager.ResetListRam();

            Categorie categorie1 = new Categorie("categorie1", 2, 3);
            Categorie categorie2 = new Categorie("categorie2", 3, 4);

            modelManager.AddCategorie(categorie1);
            modelManager.AddCategorie(categorie2);

            Assert.That(modelManager.getAllCategories().Count == 2);
        }

        [Test]
        public void testAddCategorie()
        {
            modelManager.ResetListRam();

            Categorie categorie1 = new Categorie("categorie1", 2, 3);
            modelManager.AddCategorie(categorie1);

            Assert.That(modelManager.getAllCategories().Count == 1);
        }

        [Test]
        public void testAddMois()
        {
            modelManager.ResetListRam();

            DateTime debutMois = DateTime.Now;

            List<Depense> listDepense = new List<Depense>();

            Periode mois = new BudgetMaman.Model.Periode(listDepense, BudgetMaman.Model.Periode.MoisEnum.Août, debutMois);

            modelManager.AddPeriode(mois);

            Assert.That(modelManager.GetAllPeriodes().Count, Is.EqualTo(1));
        }

        [Test]
        public void testAddDepense()
        {
            modelManager.ResetListRam();
            modelManager.Save();
            new JsonManager().ResetIdNextCategorie();

            DateTime debutMois = DateTime.Now;

            List<Depense> listDepense = new List<Depense>();

            Periode mois = new Periode(listDepense, Periode.MoisEnum.Août, debutMois);

            modelManager.AddPeriode(mois);

            Categorie categorie = new Categorie("testCategorie", 100, 100);
            modelManager.AddCategorie(categorie);

            Depense depense = new Depense("depense", "j'ai fait une depense", 100, 2, DateTime.Now);

            modelManager.AddDepense(depense, 0);

            Assert.That(mois.ListDepense.Count, Is.EqualTo(1));
        }

        [Test]
        public void testModifierDerniereDepense()
        {
            modelManager.ResetListRam();

            Depense depense1Periode1 = new Depense("depense1periode1", "test", 200, 0, DateTime.Now);
            Depense depense1Periode2 = new Depense("depense1periode2", "test", 200, 1, DateTime.Now);
            Depense depense2Periode2 = new Depense("depense2periode2", "test", 200, 1, DateTime.Now);

            List<Depense> listDepense1 = new List<Depense>();
            List<Depense> listDepense2 = new List<Depense>();



            Categorie categorie = new Categorie("test",100, 100);

            modelManager.AddCategorie(categorie);


            listDepense1.Add(depense1Periode1);

            listDepense2.Add(depense1Periode2);
            listDepense2.Add(depense2Periode2);

            Periode periode1 = new Periode(listDepense1, Periode.MoisEnum.Janvier, DateTime.Now);
            Periode periode2 = new Periode(listDepense2, Periode.MoisEnum.Janvier, DateTime.Now);

            ModelMain modelMain = new ModelMain();

            modelMain.AddPeriode(periode1);
            modelMain.AddPeriode(periode2);

            modelMain.ModifierDerniereDepense(666, modelManager.getAllCategories().Keys.First());
            Assert.That(modelMain.GetCurrentPeriode().ListDepense.First().Montant , Is.EqualTo(200));
            Assert.That(modelMain.GetCurrentPeriode().ListDepense.Last().Montant, Is.EqualTo(666));

        }

        [Test]
        public void testGetCurrentMois()
        {
            ModelMain modelMain = new ModelMain();

            Periode mois = new Periode(new List<Depense>(), BudgetMaman.Model.Periode.MoisEnum.Janvier, new DateTime(DateTime.Now.Year, 1,1));

            modelMain.AddPeriode(mois);

            Periode? mois2 = modelMain.GetCurrentPeriode();

            Assert.That(mois.MoisEnumerateur, Is.EqualTo(mois2.MoisEnumerateur));
            Assert.That(mois.Date, Is.EqualTo(mois2.Date));
        }

        [Test]
        public void testDeleteCategorie()
        {
            ModelMain modelMain = new ModelMain();
            modelMain.ResetListRam();
            modelMain.Save();
            new JsonManager().ResetIdNextCategorie();

            Categorie categorie = new Categorie("categorie", 100, 200);
            modelMain.AddCategorie(categorie);

            Categorie categorie2 = new Categorie("categorie2", 100, 200);
            modelMain.AddCategorie(categorie2);

            Categorie categorie3 = new Categorie("categorie3", 100, 200);
            modelMain.AddCategorie(categorie3);

            modelMain.DeleteCategorie(1);

            Dictionary<int, Categorie> dictCategorie = modelMain.getAllCategories();

            Assert.That(dictCategorie.Count, Is.EqualTo(2));
        }


    }
}
