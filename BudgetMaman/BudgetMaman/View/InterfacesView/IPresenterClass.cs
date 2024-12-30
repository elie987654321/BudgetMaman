using BudgetMaman.Model;
using BudgetMaman.View.ClassesView;

namespace BudgetMaman.View.InterfaceView
{
    public interface IPresenterClass
    {
        public int AddCategorie(CategorieView categorieView);
        public void AddDepense(int idCategorie, DepenseView depenseView);
        public void AddPeriode(PeriodeView moisView);
        public Dictionary<int, CategorieView> GetAllCategories();
        public List<PeriodeView> GetAllMois();
        public void ResetListRam();

        public void ModifierCategorie(int idCategorie, CategorieView categorieView);

        public void ModifierDerniereDepense(decimal montant, int idCategorie);

        public void DeleteDerniereDepense();

        public PeriodeView? GetCurrentPeriode();
        public void Save();

        public void DeleteCategorie(int idCategorie);
    }
}