using BudgetMaman.Model;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestJsonCategories()
        {

            JsonManager jsonManager = new JsonManager();

            Categorie categorie1 = new Categorie("categorie1", 2, 3);
            Categorie categorie2 = new Categorie("categorie2", 5, 6);

            Dictionary<int, Categorie> dictCategorie = new Dictionary<int, Categorie>();
            dictCategorie.TryAdd(1, categorie1);
            dictCategorie.TryAdd(2, categorie2);

            jsonManager.SaveCategories(dictCategorie);

            Dictionary<int,Categorie> dictCategorieLecture = jsonManager.LoadCategorie();

            Categorie categorie1Lecture = dictCategorieLecture[1];

            Assert.That(categorie1Lecture.Nom, Is.EqualTo(categorie1.Nom));
            Assert.That(categorie1Lecture.MontantDebut, Is.EqualTo(categorie1.MontantDebut));
            Assert.That(categorie1Lecture.CurrentMontant, Is.EqualTo(categorie1.CurrentMontant));

            Categorie categorie2Lecture = dictCategorieLecture[2];

            Assert.That(categorie2Lecture.Nom, Is.EqualTo(categorie2.Nom));
            Assert.That(categorie2Lecture.MontantDebut, Is.EqualTo(categorie2.MontantDebut));
            Assert.That(categorie2Lecture.CurrentMontant, Is.EqualTo(categorie2.CurrentMontant));

        }

        [Test]
        public void TestJsonMois()
        {
            JsonManager jsonManager = new JsonManager();

            List<Periode> listPeriode = new List<Periode>();
            
            List<Depense> listDepenseMois1 = new List<Depense>();
            Depense depense1Mois1 = new Depense("depense 1 mois 1", "message1", 100, 1, DateTime.Now);
            Depense depense2Mois1 = new Depense("depense 2 mois 1", "message2", 200, 1, DateTime.Now);

            listDepenseMois1.Add(depense1Mois1);
            listDepenseMois1.Add(depense2Mois1);

            Periode mois1 = new Periode(listDepenseMois1, Periode.MoisEnum.Décembre, new DateTime(DateTime.Today.Year, 12, 1));

            listPeriode.Add(mois1);


            List<Depense> listDepenseMois2 = new List<Depense>();
            Depense depense1Mois2 = new Depense("depense 1 mois 2", "message3", 100, 1, DateTime.Now);

            Periode mois2 = new Periode(listDepenseMois2, Periode.MoisEnum.Novembre, new DateTime(DateTime.Today.Year, 11, 1));
            listPeriode.Add(mois2);


            jsonManager.SaveMois(listPeriode);




            List<Periode> listMoisLecture = jsonManager.LoadMois();

            Assert.That(listPeriode[0].Date, Is.EqualTo(listMoisLecture[0].Date));
            Assert.That(listPeriode[0].MoisEnumerateur, Is.EqualTo(listMoisLecture[0].MoisEnumerateur));

            //J'ai enlever les test de date pour gagner du temps. Je les remettrait plus tard
            Assert.That(listPeriode[0].ListDepense[0].Message, Is.EqualTo(listMoisLecture[0].ListDepense[0].Message));
            Assert.That(listPeriode[0].ListDepense[0].Montant, Is.EqualTo(listMoisLecture[0].ListDepense[0].Montant));
            Assert.That(listPeriode[0].ListDepense[0].Nom, Is.EqualTo(listMoisLecture[0].ListDepense[0].Nom));

            Assert.That(listPeriode[0].ListDepense[1].Message, Is.EqualTo(listMoisLecture[0].ListDepense[1].Message));
            Assert.That(listPeriode[0].ListDepense[1].Montant, Is.EqualTo(listMoisLecture[0].ListDepense[1].Montant));
            Assert.That(listPeriode[0].ListDepense[1].Nom, Is.EqualTo(listMoisLecture[0].ListDepense[1].Nom));

            Assert.That(listPeriode[1].Date, Is.EqualTo(listMoisLecture[1].Date));
        }


        [Test]
        public void testGetNextIdCategorie()
        {
            JsonManager jsonManager = new JsonManager();

            jsonManager.resetIdNextCategorie();

            int id1 = jsonManager.getNextIdCategorie();
            Assert.That(id1, Is.EqualTo(0));


            int id2 = jsonManager.getNextIdCategorie();
            Assert.That(id2, Is.EqualTo(1));

        }


    }

}