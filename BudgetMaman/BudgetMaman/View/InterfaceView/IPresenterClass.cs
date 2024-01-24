using BudgetMaman.View.ClassesView;

namespace BudgetMaman.View.InterfaceView
{
    public interface IPresenterClass
    {
        public void addCategorie(CategorieView categorieView);
        public void addDepense(int idCategorie, DepenseView depenseView);
        public void addMois(MoisView moisView);
        public Dictionary<int, CategorieView> getAllCategories();
        public List<MoisView> getAllMois();
        public void resetListRam();
        public void save();

        public void deleteCategorie(int idCategorie);
    }
}