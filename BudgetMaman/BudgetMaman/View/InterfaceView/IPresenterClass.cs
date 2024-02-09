using BudgetMaman.View.ClassesView;

namespace BudgetMaman.View.InterfaceView
{
    public interface IPresenterClass
    {
        public int addCategorie(CategorieView categorieView);
        public void addDepense(int idCategorie, DepenseView depenseView);
        public void addMois(PeriodeView moisView);
        public Dictionary<int, CategorieView> getAllCategories();
        public List<PeriodeView> getAllMois();
        public void resetListRam();
        public void save();

        public void deleteCategorie(int idCategorie);
    }
}